//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Proyecto_Final_Avanzada.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class pelicula
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public pelicula()
        {
            this.proyeccion = new HashSet<proyeccion>();
        }
    
        public int pel_idPel { get; set; }
        public string pel_nombre { get; set; }
        public string pel_clasificacion { get; set; }
        public string pel_idioma { get; set; }
        public string pel_detalle { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<proyeccion> proyeccion { get; set; }
    }
}
