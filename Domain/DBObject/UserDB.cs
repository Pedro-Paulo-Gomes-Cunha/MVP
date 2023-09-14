using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DBObject
{
   public class UserDB
    {
        private string Nome { get; set; }
        private string Senha { get; set; }

        public UserDB() { }

        public UserDB(string nome, string senha)
        {
            this.Nome = nome;
            this.Senha = senha;
        }
    }
}
