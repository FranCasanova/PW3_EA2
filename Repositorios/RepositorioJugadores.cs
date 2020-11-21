using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Repositorios
{
    
    public class RepositorioJugadores
    {
        PW3_EA2Entities contexto;

        public RepositorioJugadores()
        {
            contexto = new PW3_EA2Entities();
        }

        public List<Jugador> Listar()
        {
            //List<Jugador> jugadores = (from con in contexto.Jugadors select con).ToList();

            //return jugadores;

            return contexto.Jugadors.ToList();
        }
        public void Alta(Jugador jugador)
        {

            contexto.Jugadors.Add(jugador);
            contexto.SaveChanges();
        }
    }
}
