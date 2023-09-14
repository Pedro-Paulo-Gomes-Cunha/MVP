using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class User
    {
        private int Id { get; set; }
        private string Name { get; set; }
        private string Password { get; set; }

        public User() { }

        public User(int id, string name, string Password)
        {
            this.Id = id;
            this.Name = name;
            this.Password = Password;
        }
    }
}
