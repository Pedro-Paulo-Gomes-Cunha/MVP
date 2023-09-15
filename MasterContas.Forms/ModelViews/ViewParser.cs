using Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterContas.Forms.ModelViews
{
    public class ViewParser
    {
        public ViewParser()
        {
        }

     

        public static UserView Parse(UserDto user)
        {
            return new UserView(user.Id, user.Name, user.Password);
        }

    }
}
