using Microsoft.EntityFrameworkCore;
using NasaAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace NasaAPI.Context
{
    public interface IContextoDB
    {

        DbSet<Meteorito> meteoritos { get; set; }

        int SaveChanges();

        Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default);
    }
}
