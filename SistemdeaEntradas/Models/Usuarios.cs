using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemdeaEntradas.Models
{
    
        public class Usuarios
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
            public string Contrasenia { get; set; }
            public string Rol { get; set; }
        }
}
