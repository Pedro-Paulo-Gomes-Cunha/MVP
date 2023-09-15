using Domain.DBObject;
using Domain.Dtos;
using Domain.Interfaces.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterContas.Data.Repositories
{
    public class UserRepository: RepositoryBase<UserDB>, IUserRepository
    {

        public IEnumerable<UserDto> FindAll()
        {
            var useres = GetAll();

            return useres.Select(TransformToDto);
        }

        public UserDto FindById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(UserDto obj)
        {
            throw new NotImplementedException();
        }

        public void Save(UserDto obj)
        {
            var dbObject = TransformToDBO(obj);         
            Add(dbObject);
        }

        public void Update(UserDto obj)
        {
            throw new NotImplementedException();
        }

        private UserDto TransformToDto(UserDB user)
        {
            return new UserDto(user.Id, user.Name, user.Password);
        }

        private UserDB TransformToDBO(UserDto user)
        {
            return new UserDB(user.Id, user.Name, user.Password);
        }

       
    }
}
