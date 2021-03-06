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
    public partial class Jugador
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Jugador()
        {
            this.GolesPorJugadorEquipoes = new HashSet<GolesPorJugadorEquipo>();
        }
    
        public int id { get; set; }

        [Required(ErrorMessage = "El campo nombre es requerido.")]
        [StringLength(80, ErrorMessage = "El campo nombre tiene un maximo de 80 caracteres.")]
        public string nombre { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GolesPorJugadorEquipo> GolesPorJugadorEquipoes { get; set; }
    }
}
