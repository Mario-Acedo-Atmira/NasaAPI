using System;
using System.Collections.Generic;
using System.Text;

namespace NasaAPI.Models
{
    public class Meteorito
    {
        public string _nombre { get; set; }
        public float _diametro { get; set; }
        public string _velocidad { get; set; }
        public string _fecha { get; set; }
        public string _planeta { get; set; }

        public Meteorito()
        {

        }
        public Meteorito(string nombre, float diametro, string velocidad, string fecha,string planeta)
        {
            _nombre = nombre;
            _diametro = diametro;
            _velocidad = velocidad;
            _fecha = fecha;
            _planeta = planeta;
        }
    }
}
