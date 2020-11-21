//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Repositorios
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    public partial class GolesPorJugadorEquipo
    {
        public int id { get; set; }
        [Required(ErrorMessage = "La cantidad de goles es requerida")]
        [Range(1, 1000, ErrorMessage = "Cantidad de Goles debe ser mayor a 1 y menor a 1000.")]
        public int cantidadGoles { get; set; }
        [Required(ErrorMessage = "El equipo es requerido")]
        public string equipo { get; set; }
        [Required(ErrorMessage = "El jugador es requerido")]
        public int idJugador { get; set; }
    
        public virtual Jugador Jugador { get; set; }
    }
}