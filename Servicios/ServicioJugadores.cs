using Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class ServicioJugadores
    {
        RepositorioJugadores repositorioJugadores;

        public ServicioJugadores()
        {
            repositorioJugadores = new RepositorioJugadores();
        }
        public List<Jugador> Listar()
        {
            return repositorioJugadores.Listar();
        }
        public void Alta(Jugador jugador)
        {
            repositorioJugadores.Alta(jugador);
        }
    }
}
