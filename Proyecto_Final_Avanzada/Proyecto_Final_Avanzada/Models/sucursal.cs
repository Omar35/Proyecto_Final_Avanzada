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
    
    public partial class sucursal
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public sucursal()
        {
            this.sala = new HashSet<sala>();
        }
    
        public decimal suc_idSucursal { get; set; }
        public string suc_nombre { get; set; }
        public string suc_provincia { get; set; }
        public Nullable<decimal> suc_telefono { get; set; }
        public string suc_direccion { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sala> sala { get; set; }
    }
}