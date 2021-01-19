using Bibliotheque_Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Asp_ModelClient.Entities;
using GUser = Asp_ModelGlobal.Entities.User;
using Asp_ModelClient.Mapper;

namespace Asp_ModelClient.Services
{
    public class UserService : IUserService<User>
    {
        private readonly IUserService<GUser> _globalrepository;

        public UserService(IUserService<GUser> GlobalRepository)
        {
            _globalrepository = GlobalRepository;
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAll()
        {
            return _globalrepository.GetAll().Select(g => g.ToClient());
        }

        public User GetOne(int id)
        {
            return _globalrepository.GetOne(id)?.ToClient();
        }

        public void Insert(User u)
        {
            _globalrepository.Insert(u.ToGlobal());
        }

        public void Update(int id, User u)
        {
            _globalrepository.Update(id, u.ToGlobal());
        }
    }
}
