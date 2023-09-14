using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dtos
{
   public class UserDto
    {
        private string Nome { get; set; }
        private string Senha { get; set; }

        public UserDto() { }

        public UserDto(string nome, string senha)
        {
            this.Nome = nome;
            this.Senha = senha;
        }
    }
}
