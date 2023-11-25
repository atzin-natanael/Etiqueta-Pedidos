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
    public class GlobalSettings
    {
        private static GlobalSettings instance;
        //VARIABLES
        public string Clave_articulo_id { get; set; }
        public string Descripcion { get; set; }

        public static GlobalSettings Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new GlobalSettings();
                }
                return instance;
            }
        }
        public class Articulo
        {
            public string Codigo { get; set; }
            public string Descripcion { get; set; }
        }
    }
}
