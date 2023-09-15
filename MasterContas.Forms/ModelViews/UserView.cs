using Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterContas.Forms.ModelViews
{
    public class UserView
    {
            public int Id { get; set; }

            public string Name { get; set; }

            public string PassWord { get; set; }

            public UserView()
            {
            }

            public UserView(int id, string name, string password)
            {
                Id = id;
                Name = name;
            }

            public UserDto ToDto()
            {
                
                return new UserDto(this.Id, this.Name, this.PassWord);
            }


        }
    }
