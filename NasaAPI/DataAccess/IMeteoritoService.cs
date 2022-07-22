
using NasaAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NasaAPI.DataAccess
{
    public interface IMeteoritoService
    {

        
        List<Meteorito> Obtenertop3(int dias);

        List<Meteorito> Save3Meteoritos(int dias);
    }
}