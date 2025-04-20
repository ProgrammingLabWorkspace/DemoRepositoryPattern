using LabStore.Domain.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabStore.Infraestructure.Data
{
    public class UnitOfWork(AppDbContext context) : IUnitOfWork
    {
        public async Task CommitAsync()
        {
            await context.SaveChangesAsync();
        }
    }
}
