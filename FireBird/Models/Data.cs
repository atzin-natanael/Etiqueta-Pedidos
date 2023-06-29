using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireBird.Models
{
    public class Dato
    {
        public int BaseId { get; set; }
        public string Hora { get; set; }
        public string Fecha { get; set; }
        public string Empacador { get; set; }
        public string Factura { get; set; }
        public int Bultos { get; set; }
    }
}
