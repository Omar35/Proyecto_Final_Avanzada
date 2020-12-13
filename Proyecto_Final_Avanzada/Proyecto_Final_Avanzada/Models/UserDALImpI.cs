using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Final_Avanzada.Models;

namespace Proyecto_Final_Avanzada.Models
{
    public class UserDALImpl : IUserDAL
    {

        private cineEntities context;
        public bool eliminar(string idRole, int idUsuario)
        {
            throw new NotImplementedException();
        }

        public string[] gerRolesForUser(string userName)
        {
            string[] result;
            using (context = new cineEntities())
            {
                result = context.sp_getRolesForUser(userName).ToArray();
            }


            return result;
        }

        public Users get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Users> getAll()
        {
            throw new NotImplementedException();
        }

        public Users getUser(string userName)
        {
            try
            {
                Users resultado;
                using (cineEntities nose = new cineEntities())
                {
                    Expression<Func<Users, bool>> consulta = (u => u.UserName.Equals(userName));
                    resultado = nose.Set<Users>().Where(consulta).ToList().FirstOrDefault();
                }
                return resultado;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Users getUser(string userName, string password)
        {
            try
            {
                Users resultado;

                using (cineEntities nose = new cineEntities())
                {
                    Expression<Func<Users, bool>> consulta = (u => u.UserName.Equals(userName) && u.Password.Equals(password));
                    resultado = nose.Set<Users>().Where(consulta).ToList().FirstOrDefault();
                }



                return resultado;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Users getUser(int EmpleadoId)
        {
            throw new NotImplementedException();
        }

        public List<Users> getUsuariosRole(string roleName)
        {
            List<Users> result = new List<Users>();
            List<string> lista;
            using (context = new cineEntities())
            {
                lista = context.sp_getUsuariosRole(roleName).ToList();
                Users user;
                foreach (var item in lista)
                {
                    user = this.getUser(item);
                    result.Add(user);
                }

            }


            return result;
        }

        public bool insertar(int idRole, string login)
        {
            throw new NotImplementedException();
        }

        public bool insertar(string roleName, string login)
        {
            throw new NotImplementedException();
        }

        public bool isUserInRole(string userName, string roleName)
        {
            bool result = false;


            using (context = new cineEntities())
            {
                result = (bool)context.sp_isUserInRole(userName, roleName).First();
                //  result  = (bool)context.sp_isUserInRole(userName, roleName).FirstOrDefault();

            }

            return result;
        }

        public List<Roles> listarRoles()
        {
            throw new NotImplementedException();
        }

        public Users ObtenerPorID(int id)
        {
            throw new NotImplementedException();
        }
    }
}