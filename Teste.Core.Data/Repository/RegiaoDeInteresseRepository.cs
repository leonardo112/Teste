using Microsoft.EntityFrameworkCore;
using System.Linq;
using Teste.Core.Data.Context;
using Teste.Core.Domain.Entity;
using Teste.Core.Domain.Interfaces.Repository;
using Teste.Core.Domain.Model;

namespace Teste.Core.Data.Repository
{
    public class RegiaoDeInteresseRepository : IRegiaoDeInteresseRepository
    {
        protected readonly MyContext _context;
        public readonly DbSet<RegiaoDeInteresseEntity> dataset;

        public RegiaoDeInteresseRepository(MyContext context)
        {
            context.Database.EnsureCreated();
            _context = context;
            this.dataset = context.Set<RegiaoDeInteresseEntity>();
        }

        public async Task<bool> InsertAsync(List<RegiaoDeInteresseModel> input)
        {
            var regiaoDb = new List<RegiaoDeInteresseEntity>();
            foreach (var item in input)
            {
                regiaoDb.Add(new RegiaoDeInteresseEntity
                {
                    Id = new Guid(),
                    Estado = item.Estado,
                    Regiao = item.Regiao,
                    Sigla = item.Sigla,
                });
            }
            
            await dataset.AddRangeAsync(regiaoDb);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<List<RegiaoDeInteresseEntity>> GetAll()
        {
            return await dataset.ToListAsync();
        }
    }
}
