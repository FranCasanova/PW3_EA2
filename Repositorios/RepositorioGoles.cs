using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Repositorios
{
    
    public class RepositorioGoles
    {
        PW3_EA2Entities contexto;

        public RepositorioGoles()
        {
            contexto = new PW3_EA2Entities();
        }

        public List<GolesPorJugadorEquipo> Listar()
        {
            return contexto.GolesPorJugadorEquipoes.ToList();
        }
        public void Alta(GolesPorJugadorEquipo goles)
        {
            
            contexto.GolesPorJugadorEquipoes.AddOrUpdate(goles);
            contexto.SaveChanges();
        }

        public GolesPorJugadorEquipo existeJugadorEnEquipo(GolesPorJugadorEquipo goles)
        {
            //return  (from con in contexto.GolesPorJugadorEquipoes where
            //        (con.idJugador == goles.idJugador && con.equipo == goles.equipo) select con)
            //        .FirstOrDefault();
            return contexto.GolesPorJugadorEquipoes.Where(x => x.equipo == goles.equipo)
                                                   .Where(x => x.idJugador == goles.idJugador)
                                                   .FirstOrDefault();
        }

        public int golesDelEquipo(string equipo)
        {
            return contexto.GolesPorJugadorEquipoes.Where(x => x.equipo == equipo).Sum(x => x.cantidadGoles);
        }
    }
}
