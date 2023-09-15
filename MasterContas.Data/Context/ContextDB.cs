using Domain.DBObject;
using Microsoft.EntityFrameworkCore;

namespace MasterContas.Data.Context
{
    public class ContextDB : DbContext
    {

        public ContextDB() : base()
        {

        }

        public ContextDB(DbContextOptions<DbContext> options) : base(options)
        {

        }



        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // var stringConexao = "Data Source=DESKTOP-OFRCN20\\MR;Database=MasterContas;User=;Password=;TrustServerCertificate=true;MultipleActiveResultSets=true";
            var stringConexao = "Data Source=DESKTOP-OFRCN20\\MR;Database=MasterContas;Integrated Security=SSPI;TrustServerCertificate=true;MultipleActiveResultSets=true";
            options.UseSqlServer(stringConexao);
        }

        public DbSet<UserDB> Users { get; set; }
    }
}
