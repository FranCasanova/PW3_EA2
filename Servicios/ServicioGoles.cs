using Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class ServicioGoles
    {
        RepositorioGoles repositorioGoles;

        public ServicioGoles()
        {
            repositorioGoles = new RepositorioGoles();
        }
        public List<GolesPorJugadorEquipo> Listar()
        {
            return repositorioGoles.Listar();
        }
        public void Alta(GolesPorJugadorEquipo golesJugador)
        {
            GolesPorJugadorEquipo exist = repositorioGoles.existeJugadorEnEquipo(golesJugador);
            if ( exist == null)
            {
                repositorioGoles.Alta(golesJugador);
            }
            else
            {
                exist.cantidadGoles = golesJugador.cantidadGoles;
                repositorioGoles.Alta(exist);
            }
        }

        public String golesDelEquipo(String equipo)
        {
            return repositorioGoles.golesDelEquipo(equipo).ToString();
        }
    }
}
