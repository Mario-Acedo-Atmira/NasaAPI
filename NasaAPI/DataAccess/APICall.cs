using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace NasaAPI.DataAccess
{
    public class APICall
    {
        public HttpWebRequest getDatos(string fechaactual,string fechafinal)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://www.neowsapp.com/rest/v1/feed?start_date=" + fechaactual + "&end_date=" + fechafinal + "&detailed=false&api_key=nUIaTOBMbI7BNyvjiRruwLrAWeARkE9qaOcbUBg3");
            return request;
        }
    }
}
