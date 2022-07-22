using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace NasaAPI.Models
{
    public class Meteorito
    {
        [Key]
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

        public override bool Equals(object obj)
        {
            return obj is Meteorito meteorito &&
                   _nombre == meteorito._nombre;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_nombre);
        }
    }
}
