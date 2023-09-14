using Domain.DBObject;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            var stringConexao = "Data Source=USER\\SQLEXPRESS;Database=Okutanga;User=User1;Password=123456789;TrustServerCertificate=true;MultipleActiveResultSets=true";
            options.UseSqlServer(stringConexao);
        }

        public DbSet<UserDB> Users { get; set; }
    }
}
