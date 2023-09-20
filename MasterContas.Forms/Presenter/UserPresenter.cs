using Domain.Dtos;
using Domain.Interfaces.IServices;
using Domain.Services;
using MasterContas.Data.Repositories;
using MasterContas.Presentation.IViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterContas.Presentation.Presenter
{
    public class UserPresenter
    { 

        UserView View;
          readonly  IUserService _UserService;
        public UserPresenter(UserView view)
        {
            View = view;
            _UserService = new UserService(new RepositoryWrapper());
        }

        public void add()
        {
           
            _UserService.Save(ViewParser.Parse(View));
            MessageBox.Show("Usuario: "+ View.Name + "  Created");
        }

        public List<UserDto> GetAll()
        { 
          return  _UserService.GetAll().ToList();
     
        }
    }
}
