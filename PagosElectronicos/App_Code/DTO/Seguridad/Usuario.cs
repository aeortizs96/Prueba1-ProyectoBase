using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Seguridad
{
    public class Usuario
    {

        public Usuario() { }
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NombreUsuario { get; set; }
        public string Contrasena { get; set; }
        public string Correo { get; set; }

        public string CI { get; set; }
        public string Sexo { get; set; }

        public int rolId { get; set; }
    }
}