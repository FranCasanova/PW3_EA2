using Repositorios;
using Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PW3_EA2.Controllers
{
    public class GolesController : Controller
    {
        ServicioGoles servicioGoles;
        ServicioJugadores servicioJugadores;
        public GolesController()
        {
            servicioGoles = new ServicioGoles();
            servicioJugadores = new ServicioJugadores();
        }
        // GET: Goles
        public ActionResult ListaGolesJugador()
        {
            List<GolesPorJugadorEquipo> goles = servicioGoles.Listar();

            return View(goles);
        }

        public ActionResult Alta()
        {
            List<Jugador> jugadores = servicioJugadores.Listar();
            ViewBag.jugadores = jugadores;
            return View();
        }

        [HttpPost]
        public ActionResult Alta(GolesPorJugadorEquipo goles)
        {
            if (ModelState.IsValid)
            {
                servicioGoles.Alta(goles);
                return Redirect("/Goles/ListaGolesJugador");
            }
            List<Jugador> jugadores = servicioJugadores.Listar();
            ViewBag.jugadores = jugadores;
            return View(goles);
        }
    }
}