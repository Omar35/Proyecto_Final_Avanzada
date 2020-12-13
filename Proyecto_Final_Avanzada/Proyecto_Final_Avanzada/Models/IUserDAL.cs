using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_Avanzada.Models
{
    public interface IUserDAL
    {
        bool insertar(int idRole, string login);
        bool insertar(string roleName, string login);
        Users getUser(string userName);
        Users getUser(string userName, string password);
        Users getUser(int EmpleadoId);
        Users get(int id);
        List<Users> getAll();
        bool isUserInRole(string userName, string roleName);
        string[] gerRolesForUser(string userName);
        List<Users> getUsuariosRole(string roleName);
        List<Roles> listarRoles();
        bool eliminar(string idRole, int idUsuario);
        Users ObtenerPorID(int id);
    }
}