using Microsoft.EntityFrameworkCore;
using Teste.Core.Domain.Entity;

namespace Teste.Core.Data.Context
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) :
         base(options)
        {

        }

        public DbSet<RegiaoDeInteresseEntity> regiaoDeInteresse { get; set; }
    }
}
