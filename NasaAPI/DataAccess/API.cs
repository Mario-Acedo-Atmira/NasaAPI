
using NasaAPI.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace NasaAPI.DataAccess
{
    class API : IAPI
    {
        public async Task<List<Meteorito>> Obtenertop3(int dias)
        {
            string fechaactual = DateTime.Now.ToString("yyyy-MM-dd");
            var diaactual = fechaactual.Split("-");
            string fechafinal = calcularfecha(dias);
            List<List<Fecha>> todos = new List<List<Fecha>>();
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://www.neowsapp.com/rest/v1/feed?start_date="+fechaactual+"&end_date="+fechafinal+"&detailed=false&api_key=nUIaTOBMbI7BNyvjiRruwLrAWeARkE9qaOcbUBg3");
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = (Stream)response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {

                int p = int.Parse(diaactual[2]);
                string fecha = diaactual[0] + "-" + diaactual[1] + "-";
                var json = reader.ReadToEnd();
                for (int i = 0; i < dias; i++)
                {

                    var jsonreal = json.Replace(fecha + p, "fecha");
                    var ejemplo1 = JsonConvert.DeserializeObject<Todos>(jsonreal);

                    todos.Add(ejemplo1.near_earth_objects.fecha);
                    p++;
                }
                
            }
            return ordenar(clasificar(todos));
        }

        protected List<Meteorito> clasificar(List<List<Fecha>> todos)
        {
            List<Meteorito> meteoritos = new List<Meteorito>();
            for (int i = 0; i < todos.Count; i++)
            {
                for (int j = 0; j < todos[i].Count; j++)
                {
                    var nuevo = todos[i];
                    if (nuevo[j].is_potentially_hazardous_asteroid)
                    {
                        float media = (nuevo[j].estimated_diameter.kilometers.estimated_diameter_min + nuevo[j].estimated_diameter.kilometers.estimated_diameter_max) / 2;
                        Meteorito meteoro = new Meteorito(
                            nuevo[j].name,
                            media,
                            nuevo[j].close_approach_data[0].relative_velocity.kilometers_per_hour,
                            nuevo[j].close_approach_data[0].close_approach_date,
                            nuevo[j].close_approach_data[0].orbiting_body);
                        meteoritos.Add(meteoro);
                    }
                }

            }
            return meteoritos;
        }

        protected List<Meteorito> ordenar(List<Meteorito> meteoritos)
        {
            List<Meteorito> meteoritosordenados = new List<Meteorito>();
            var top3 = meteoritos.OrderByDescending(x => x._diametro).Take(3);
            foreach (Meteorito n in top3)
            {
                meteoritosordenados.Add(n);
                
            }
            return meteoritosordenados;
        }

        protected string calcularfecha(int dias)
        {
            string fechaactual = DateTime.Now.ToString("yyyy-MM-dd");
            var diaactual = fechaactual.Split("-");
            int dia = int.Parse(diaactual[2]) + dias;
            string fechafinal = "";
            if (diaactual[1] == "01" || diaactual[1] == "03" || diaactual[1] == "05" || diaactual[1] == "07" || diaactual[1] == "08" || diaactual[1] == "10")
            {
                if (dia > 31)
                {
                    fechafinal = diaactual[0] + "-" + (int.Parse(diaactual[1]) + 1).ToString() + "-" + "0" + (dia - 31).ToString();
                }
                else
                {
                    fechafinal = diaactual[0] + "-" + diaactual[1] + "-" + dia.ToString();
                }

            }
            else if (diaactual[1] == "04" || diaactual[1] == "06" || diaactual[1] == "09" || diaactual[1] == "11")
            {
                if (dia > 30)
                {
                    fechafinal = diaactual[0] + "-" + (int.Parse(diaactual[1]) + 1).ToString() + "-" + "0" + (dia - 30).ToString();
                }
                else
                {
                    fechafinal = diaactual[0] + "-" + diaactual[1] + "-" + dia.ToString();
                }
            }
            else if (diaactual[1] == "02")
            {
                if (dia > 28)
                {
                    fechafinal = diaactual[0] + "-" + (int.Parse(diaactual[1]) + 1).ToString() + "-" + "0" + (dia - 28).ToString();
                }
                else
                {
                    fechafinal = diaactual[0] + "-" + diaactual[1] + "-" + dia.ToString();
                }
            }
            else if (diaactual[1] == "12")
            {
                if (dia > 31)
                {
                    fechafinal = (int.Parse(diaactual[0]) + 1).ToString() + "-" + "01" + "-" + "0" + (dia - 31).ToString();
                }
                else
                {
                    fechafinal = diaactual[0] + "-" + diaactual[1] + "-" + dia.ToString();
                }
            }

            return fechafinal;
        }
    }
    
}
