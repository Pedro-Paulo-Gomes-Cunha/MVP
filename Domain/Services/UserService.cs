using Domain.Dtos;
using Domain.Interfaces.IRepositories;
using Domain.Interfaces.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class UserService : IUserService
    {
        

        IRepositoryWrapper _repositoryWrapper;
        public UserService(IRepositoryWrapper repositoryWrapper) => this._repositoryWrapper = repositoryWrapper;
  

        public void Save(UserDto obj)
        {
            var userEntiy = obj.ToEntity();
            if (string.IsNullOrWhiteSpace(userEntiy.Name) || string.IsNullOrWhiteSpace(userEntiy.Password))
                return;

            _repositoryWrapper.UserRepository.Save(userEntiy.ToDto());
        }


        public IEnumerable<UserDto> GetAll()
        {
            return _repositoryWrapper.UserRepository.FindAll();
        }

        public UserDto GetById(int id)
        {
            return _repositoryWrapper.UserRepository.FindById(id);
        }

        public void Remove(UserDto obj)
        {
            _repositoryWrapper.UserRepository.Remove(obj);
        }

        public void Update(UserDto obj)
        {
            _repositoryWrapper.UserRepository.Update(obj);

        }

       
    }
}
