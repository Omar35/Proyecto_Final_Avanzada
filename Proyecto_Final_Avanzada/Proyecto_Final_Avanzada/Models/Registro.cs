using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Proyecto_Final_Avanzada.Models
{
    public class Registro
    {
        [Required]
        [StringLength(10)]
        [Display(Name = "ID Cliente")]
        public decimal cl_idCliente { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Nombre")]
        public string cl_nombre { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Primer Apellido")]
        public string cl_apellido1 { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Segundo Apellido")]
        public string cl_apellido2 { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Telefono")]
        public Nullable<decimal> cl_telefono { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Contraseña")]
        public string Password { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Registro> Registros { get; set; }
    }
}