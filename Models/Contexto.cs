namespace SistemaLaboratorio.Models
{
    public class Contexto
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) 
        {

        }
        //public DbSet<Calculadora> Calculadora { get; set; }
    }
}
