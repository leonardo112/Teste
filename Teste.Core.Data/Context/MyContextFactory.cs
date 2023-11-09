using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Teste.Core.Data.Context
{
    public class MyContextFactory : IDesignTimeDbContextFactory<MyContext>
    {
        public MyContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<MyContext>();
            optionsBuilder.UseNpgsql("Server=localhost;Database=AplicacaoTeste;Port=5432;User Id=root;Password=123456");

            return new MyContext(optionsBuilder.Options);
        }
    }
}
