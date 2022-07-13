
using NasaAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NasaAPI.DataAccess
{
    public interface IAPI
    {
        Task<List<Meteorito>> Obtenertop3(int dias);
    }
}