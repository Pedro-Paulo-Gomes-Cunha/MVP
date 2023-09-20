using Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterContas.Presentation.IViews
{
    public interface UserView
    {
            int Id { get; set; }

            string Name { get; set; }

            string PassWord { get; set; }

         void add();
    
           

}
}
