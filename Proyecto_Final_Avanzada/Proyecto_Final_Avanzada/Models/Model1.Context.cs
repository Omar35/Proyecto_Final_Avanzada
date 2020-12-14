﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class cineEntities : DbContext
    {
        public cineEntities()
            : base("name=cineEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<cliente> cliente { get; set; }
        public virtual DbSet<funcion> funcion { get; set; }
        public virtual DbSet<pelicula> pelicula { get; set; }
        public virtual DbSet<proyeccion> proyeccion { get; set; }
        public virtual DbSet<reserva> reserva { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<sala> sala { get; set; }
        public virtual DbSet<sucursal> sucursal { get; set; }
        public virtual DbSet<Users> Users { get; set; }
    
        public virtual ObjectResult<string> sp_getRolesForUser(string userName)
        {
            var userNameParameter = userName != null ?
                new ObjectParameter("userName", userName) :
                new ObjectParameter("userName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("sp_getRolesForUser", userNameParameter);
        }
    
        public virtual ObjectResult<string> sp_getUsuariosRole(string roleName)
        {
            var roleNameParameter = roleName != null ?
                new ObjectParameter("roleName", roleName) :
                new ObjectParameter("roleName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("sp_getUsuariosRole", roleNameParameter);
        }
    
        public virtual ObjectResult<Nullable<bool>> sp_isUserInRole(string userName, string roleName)
        {
            var userNameParameter = userName != null ?
                new ObjectParameter("userName", userName) :
                new ObjectParameter("userName", typeof(string));
    
            var roleNameParameter = roleName != null ?
                new ObjectParameter("roleName", roleName) :
                new ObjectParameter("roleName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<bool>>("sp_isUserInRole", userNameParameter, roleNameParameter);
        }
    }
}
