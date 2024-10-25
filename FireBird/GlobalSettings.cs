﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireBird
{
    public class GlobalSettings
    {
        private static GlobalSettings instance;
        public string Ip { get; set; }
        public string Puerto { get; set; }
        public string Direccion { get; set; }
        public string User { get; set; }
        public string Pw { get; set; }
        public List<string> Config { get; set; }
        public string Clave_articulo_id { get; set; }
        public string Descripcion { get; set; }


        private GlobalSettings()
        {
            Config = new List<string>();

        }
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
    }
}