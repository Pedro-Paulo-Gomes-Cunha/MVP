using Domain.Interfaces.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterContas.Data.Repositories
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
      

        IUserRepository _userRepository;

        public RepositoryWrapper()
        {
        }


        public IUserRepository UserRepository
        {
            get
            {
                if (_userRepository == null)
                {
                    _userRepository = new UserRepository();
                }
                return _userRepository;
            }
        }


    }
}
