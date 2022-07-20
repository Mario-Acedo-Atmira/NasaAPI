
using NasaAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NasaAPI.DataAccess
{
    public interface IMeteoritoService
    {
        Task<List<Meteorito>> Obtenertop3(int dias);
    }
}