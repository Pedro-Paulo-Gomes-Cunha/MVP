using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DBObject
{
   public class UserDB
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }

        public UserDB() { }

        public UserDB(int id,string name, string Password)
        {
            this.Id = id;
            this.Name = name;
            this.Password = Password;
        }
    }
}
