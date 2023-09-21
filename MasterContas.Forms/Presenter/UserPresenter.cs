using Domain.Dtos;
using Domain.Interfaces.IServices;
using Domain.Services;
using MasterContas.Data.Repositories;
using MasterContas.Presentation.Interfaces.IViews;
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
            _UserService = new UserService(new RepositoryWrapper()); //Inicialize the service

            View.ButtonClicked += HandleButtonClicked;
            View.TabClicked += tabControl1_Selected;
        }

        public void Save()
        {
           
            _UserService.Save(ViewParser.Parse(View));
          
        }

        public List<UserDto> GetAll()
        { 
          return  _UserService.GetAll().ToList();
     
        }

        private void HandleButtonClicked(object sender, EventArgs e)
        {
            Save();
            View.add();
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
         
            View.Display(GetAll());

        }
    }
}
