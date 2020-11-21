using Repositorios;
using Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PW3_EA2.Controllers
{
    public class JugadoresController : Controller
    {
        ServicioJugadores servicioJugadores;
        public JugadoresController()
        {
            servicioJugadores = new ServicioJugadores();
        }
        // GET: Jugadores
        public ActionResult ListaJugadores()
        {
            List<Jugador> jugadores = servicioJugadores.Listar();

            return View(jugadores);
        }

        public ActionResult Alta()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Alta(Jugador jugador)
        {
            if (ModelState.IsValid)
            {
                servicioJugadores.Alta(jugador);
                return Redirect("/Jugadores/ListaJugadores");
            }
            return View(jugador);
        }
    }
}