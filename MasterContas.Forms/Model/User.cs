using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterContas.Presentation.Model
{
    public class User
    {
     public int Id { get; set; }

     public   string Name { get; set; }

        string PassWord { get; set; }


        public User(int id, string passWord, string name)
        {
            Id = id;
            Name = name;
            PassWord = passWord;

        }
    }
}
