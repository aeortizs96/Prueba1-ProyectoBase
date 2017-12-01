using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Seguridad.BLL
{
    public class PermisoBLL
    {
        public PermisoBLL() { }


        public static Dictionary<string, string> GetPermisosUsuario(int userId)
        {
            if (userId <= 0)
                throw new ArgumentException("El userId no puede ser menor o igual que cero");


            PermisoDSTableAdapters.PermisoByUsuarioTableAdapter adapter = new PermisoDSTableAdapters.PermisoByUsuarioTableAdapter();
            PermisoDS.PermisoByUsuarioDataTable table = adapter.GetPermisoByUsuarioId(userId);
            Dictionary<string, string> permisos = new Dictionary<string, string>();

            foreach (var row in table)
            {
                permisos.Add(row.nombre, row.descripcion);
            }

            return permisos;
        }




        public static List<Permiso> SelectAll()
        {
            List<Permiso> listaPermiso = new List<Permiso>();
            PermisoDSTableAdapters.tblPermisoTableAdapter adapter = new PermisoDSTableAdapters.tblPermisoTableAdapter();
            PermisoDS.tblPermisoDataTable table = adapter.SelectAll();
            foreach (PermisoDS.tblPermisoRow row in table)
            {
                listaPermiso.Add(rowToDTO(row));
            }
            return listaPermiso;
        }

        public static Permiso SelectById(int id)
        {
            PermisoDSTableAdapters.tblPermisoTableAdapter adapter = new PermisoDSTableAdapters.tblPermisoTableAdapter();
            PermisoDS.tblPermisoDataTable table = adapter.SelectById(id);
            if (table.Rows.Count == 0)
            {
                return null;
            }
            return rowToDTO(table[0]);
        }

        public static void Insert(string nombre, string descripcion)
        {
            PermisoDSTableAdapters.tblPermisoTableAdapter adapter = new PermisoDSTableAdapters.tblPermisoTableAdapter();
            adapter.Insert(nombre, descripcion);
        }

        public static void Update(string nombre, string descripcion, int id)
        {
            PermisoDSTableAdapters.tblPermisoTableAdapter adapter = new PermisoDSTableAdapters.tblPermisoTableAdapter();
            adapter.Update(nombre, descripcion, id);
        }

        public static void Delete(int id)
        {
            PermisoDSTableAdapters.tblPermisoTableAdapter adapter = new PermisoDSTableAdapters.tblPermisoTableAdapter();
            adapter.Delete(id);
        }
        private static Permiso rowToDTO(PermisoDS.tblPermisoRow row)
        {
            Permiso objPermiso = new Permiso();
            objPermiso.Id = row.id;
            objPermiso.Nombre = row.nombre;
            objPermiso.Descripcion = row.descripcion;
            return objPermiso;

        }
    }
}