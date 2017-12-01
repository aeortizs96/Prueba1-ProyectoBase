using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Seguridad
{

    public class PermisoxRol
    {
        public PermisoxRol() { }

        public int Id { get; set; }
        public int IdPermiso { get; set; }
        public int IdRol { get; set; }

        public string NombrePermiso { get; set; }
        public string NombreRol { get; set; }


    }

}