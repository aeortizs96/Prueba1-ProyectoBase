using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Seguridad;

namespace Seguridad.BLL
{
    public class RolBLL
    {
        public RolBLL() { }


        public static Dictionary<string, string> GetPermisoRol(int rolId)
        {
            if (rolId <= 0)

                throw new ArgumentException("El rolId no puede ser menor o igual que cero");

            RolDSTableAdapters.PermisoByRolTableAdapter adapter = new RolDSTableAdapters.PermisoByRolTableAdapter();
            RolDS.PermisoByRolDataTable table = adapter.GetPermisoByRolId(rolId);

            Dictionary<string, string> roles = new Dictionary<string, string>();

            foreach (var row in table)
            {
                roles.Add(row.nombre, row.descripcion);
            }
            return roles;
        }





        public static List<Rol> SelectAll()
        {
            List<Rol> listaRoles = new List<Rol>();
            RolDSTableAdapters.tblRolTableAdapter adapter = new RolDSTableAdapters.tblRolTableAdapter();
            RolDS.tblRolDataTable table = adapter.SelectAll();
            foreach (RolDS.tblRolRow row in table)
            {
                listaRoles.Add(rowToDTO(row));
            }
            return listaRoles;
        }

        public static Rol SelectById(int id)
        {
            RolDSTableAdapters.tblRolTableAdapter adapter = new RolDSTableAdapters.tblRolTableAdapter();
            RolDS.tblRolDataTable table = adapter.SelectById(id);
            if (table.Rows.Count == 0)
            {
                return null;
            }
            return rowToDTO(table[0]);
        }

        public static void Insert(string nombre, string descripcion)
        {
            RolDSTableAdapters.tblRolTableAdapter adapter = new RolDSTableAdapters.tblRolTableAdapter();
            adapter.Insert(nombre, descripcion);
        }

        public static void Update(string nombre, string descripcion, int id)
        {
            RolDSTableAdapters.tblRolTableAdapter adapter = new RolDSTableAdapters.tblRolTableAdapter();
            adapter.Update(nombre, descripcion, id);
        }
        public static void Delete(int id)
        {
            RolDSTableAdapters.tblRolTableAdapter adapter = new RolDSTableAdapters.tblRolTableAdapter();
            adapter.Delete(id);
        }

        private static Rol rowToDTO(RolDS.tblRolRow row)
        {
            Rol objRol = new Rol();
            objRol.Id = row.id;
            objRol.Nombre = row.nombre;
            objRol.Descripcion = row.descripcion;
            return objRol;

        }
    }
}