using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Proyecto_Final_Avanzada.Models
{
    public class RegistroViewModel
    {
        [Key]
        [Required]
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
        [Display(Name = "Telefono")]

        public decimal cl_telefono { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Nombre de usuario")]
        public string cl_usuario { get; set; }
        [Required]
        [MaxLength(30)]
        [MinLength(4)]
        [Display(Name = "Contraseña")]
        [DataType(DataType.Password)]
        public string cl_contrasena { get; set; }
    }
}