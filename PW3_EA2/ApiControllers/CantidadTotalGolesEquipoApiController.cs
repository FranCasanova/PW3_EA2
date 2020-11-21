using Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Routing;

namespace PW3_EA2.ApiControllers
{
    public class CantidadTotalGolesEquipoApiController : ApiController
    {
        ServicioGoles servicioGoles;
        public CantidadTotalGolesEquipoApiController()
        {
            servicioGoles = new ServicioGoles();
        }
        public String Get()
        {
            return "hola Fran, probando api...";
        }
        public String Get(string id)
        {
            return servicioGoles.golesDelEquipo(id);
        }
    }
}
