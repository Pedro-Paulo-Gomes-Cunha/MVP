using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dtos
{
   public class UserDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }

        public UserDto() { }

        public UserDto(int id, string name, string Password)
        {
            this.Id = id;
            this.Name = name;
            this.Password = Password;
        }

        public User ToEntity()
        {
            return new User(this.Id, this.Name, this.Password);
        }
        
        }
}
