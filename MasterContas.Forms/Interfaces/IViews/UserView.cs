using Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Design;

namespace MasterContas.Presentation.Interfaces.IViews
{
    public interface UserView
    {
        int Id { get; set; }

        string Name { get; set; }

        string PassWord { get; set; }

        event EventHandler ButtonClicked;

        event TabControlEventHandler TabClicked;

        void add();
        void Display(List<UserDto> users);



    }
}
