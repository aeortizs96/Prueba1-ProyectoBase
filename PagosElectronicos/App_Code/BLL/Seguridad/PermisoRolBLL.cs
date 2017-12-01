using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Seguridad;

namespace Seguridad.BLL
{
    public class PermisoRolBLL
    {
        public PermisoRolBLL() { }

        public static List<PermisoxRol> SelectAll()
        {

            List<PermisoxRol> listaPermisoxRol = new List<PermisoxRol>();


            PermisoxRolDSTableAdapters.sp_PermisoxRolTableAdapter adapter = new PermisoxRolDSTableAdapters.sp_PermisoxRolTableAdapter();
            PermisoxRolDS.sp_PermisoxRolDataTable table = adapter.SelectAll();

            foreach (PermisoxRolDS.sp_PermisoxRolRow row in table)
            {
                listaPermisoxRol.Add(rowToDto2(row));
            }
            return listaPermisoxRol;

        }

        public static PermisoxRol SelectByIdPermisoxRol(int id)
        {
            PermisoxRolDSTableAdapters.sp_PermisoxRolTableAdapter adapter = new PermisoxRolDSTableAdapters.sp_PermisoxRolTableAdapter();

            PermisoxRolDS.sp_PermisoxRolDataTable table = adapter.SelectById(id);

            if (table.Rows.Count == 0)
            {
                return null;
            }
            return rowToDto2(table[0]);
        }



        public static void Insert(int idPermiso, int idRol)
        {
            PermisoxRolDSTableAdapters.sp_PermisoxRolTableAdapter adapter = new PermisoxRolDSTableAdapters.sp_PermisoxRolTableAdapter();

            adapter.Insert(idPermiso, idRol);

        }

        public static void Update(int idPermiso, int idRol, int id)
        {
            PermisoxRolDSTableAdapters.sp_PermisoxRolTableAdapter adapter = new PermisoxRolDSTableAdapters.sp_PermisoxRolTableAdapter();

            adapter.Update(idPermiso, idRol, id);

        }

        public static void Delete(int id)
        {
            PermisoxRolDSTableAdapters.sp_PermisoxRolTableAdapter adapter = new PermisoxRolDSTableAdapters.sp_PermisoxRolTableAdapter();
            adapter.Delete(id);
        }


        private static PermisoxRol rowToDto2(PermisoxRolDS.sp_PermisoxRolRow row)
        {
            PermisoxRol objPermisoRol = new PermisoxRol();

            objPermisoRol.Id = row.id;
            objPermisoRol.NombrePermiso = row.nombre;
            objPermisoRol.NombreRol = row.nombre1;
            return objPermisoRol;

        }




    }
}