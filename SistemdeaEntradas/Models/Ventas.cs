using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemdeaEntradas.Models
{
    public class Ventas
    {
        public int Id { get; set; }
        public string Vendedor { get; set; }
        public string Espectaculo { get; set; }
        public string Ubicacion { get; set; }
        public DateTime FechaVenta { get; set; }
        public decimal Precio { get; set; }
    }
}
