﻿using Proyecto_Final_Avanzada.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Proyecto_Final_Avanzada.Models
{
    public class UserViewModel
    {
        public int UserViewModelId { get; set; }
        [Required(ErrorMessage = "Debe digitar una Nombre de Usuario.")]
        [Display(Name = "Usuario")]
        public string UserName { get; set; }
        public string nombre { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Debe digitar una Contraseña.")]
        [Display(Name = "Contraseña")]
        public string Password { get; set; }


        public string LoginErrorMessage { get; set; }

        public virtual ICollection<Roles> Roles { get; set; }

    }
}