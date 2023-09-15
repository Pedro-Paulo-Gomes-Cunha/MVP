using Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }

        public User() { }

        public User(int id, string name, string Password)
        {
            this.Id = id;
            this.Name = name;
            this.Password = Password;
        }

        public UserDto ToDto()
        {
            return new UserDto(this.Id, this.Name, this.Password);
        }
    }
}
