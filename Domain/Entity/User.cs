using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class User
    {
        private string Nome { get; set; }
        private string Senha { get; set; }

        public User() { }

        public User(string nome, string senha) {
            this.Nome = nome;
            this.Senha = senha;
        }
    }
}
