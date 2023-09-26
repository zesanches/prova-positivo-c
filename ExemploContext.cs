using APIExemplo.Models;
using Microsoft.EntityFrameworkCore;

namespace APIExemplo.Data
{
    public class ExemploContext: DbContext
    {
        //Construtor
        public ExemploContext(
            DbContextOptions<ExemploContext> options) : base(options) { }

        public DbSet<Veiculo> Veiculo { get; set; }
    }
}
