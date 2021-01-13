using Client = Api_ModelClient.Entities;
using Bibliotheque_Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using Global = Api_ModelGobal.Entities;
using Api_ModelClient.Entities;
using System.Linq;
using Api_ModelClient.Mappers;

namespace Api_ModelClient.Services
{
    public class UserService : IUserService<Client.User>
    {
        private readonly IUserService<Global.User> _globalUser;
        public UserService(IUserService<Global.User> GlobalUser)
        {
            _globalUser = GlobalUser;
        }
        public void Delete(int id)
        {
            _globalUser.Delete(id);
        }

        public IEnumerable<User> GetAll()
        {
            return _globalUser.GetAll().Select(u => u.ToClient());
        }

        public User GetOne(int id)
        {
            return _globalUser.GetOne(id).ToClient();
        }

        public void Insert(User u)
        {
            _globalUser.Insert(u.ToGlobal());
        }

        public void Update(User u)
        {
            _globalUser.Update(u.ToGlobal());
        }
    }
}
