using Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.IRepositories
{
    public interface IUserRepository
    {
        IEnumerable<UserDto> FindAll();
        void Save(UserDto obj);
        UserDto FindById(int id);
        void Update(UserDto obj);
        void Remove(UserDto obj);
    }
}
