using Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterContas.Presentation.Interfaces.IViews
{
    public class ViewParser
    {
        public ViewParser()
        {
        }


        public static UserDto Parse(UserView user)
        {
            return new UserDto(user.Id, user.Name, user.PassWord);
        }
    }
}
