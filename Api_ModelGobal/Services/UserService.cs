using Api_ModelGobal.Entities;
using Api_ModelGobal.Mappers;
using Bibliotheque_Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToolBox;

namespace Api_ModelGobal.Services
{
    public class UserService : IUserService<User>
    {
        private readonly IConnection _connection;
        public UserService(IConnection connection)
        {
            _connection = connection;
        }
        public void Delete(int id)
        {
            DBCommand command = new DBCommand("[RegChacha].[User_del]",true);
            command.AddParameter("id", id);
            _connection.ExecuteNonQuery(command);
        }

        public IEnumerable<User> GetAll()
        {
            DBCommand command = new DBCommand("Select * from [RegChacha].[V_Types]");
            return _connection.ExecuteReader(command, (dr) => dr.ToUser()); 
        }

        public User GetOne(int id)
        {
            DBCommand command = new DBCommand("Select * from [RegChacha].[V_Types] where id = @id");
            command.AddParameter("id", id);
            return _connection.ExecuteReader(command, (dr) => dr.ToUser()).SingleOrDefault(); 
        }

        public void Insert(User u)
        {
            DBCommand command = new DBCommand("[RegChacha].[User_add]", true);
            command.AddParameter("Email", u.Email);
            command.AddParameter("Password", u.Passwd);
            command.AddParameter("FirstName", u.FirstName);
            command.AddParameter("LastName", u.LastName);
            command.AddParameter("BirthDate", u.Birthdate);
            command.AddParameter("Address", u.Address);
            command.AddParameter("Cp", u.Cp);
            command.AddParameter("Land", u.Land);
            command.AddParameter("Phone", u.Phone);
            _connection.ExecuteNonQuery(command);
        }

        public void Update(User u)
        {
            DBCommand command = new DBCommand("[RegChacha].[User_update]", true);
            command.AddParameter("id", u.Id);
            command.AddParameter("Email", u.Email);
            command.AddParameter("Password", u.Passwd);
            command.AddParameter("FirstName", u.FirstName);
            command.AddParameter("LastName", u.LastName);
            command.AddParameter("BirthDate", u.Birthdate);
            command.AddParameter("Address", u.Address);
            command.AddParameter("Cp", u.Cp);
            command.AddParameter("Land", u.Land);
            command.AddParameter("Phone", u.Phone);
            _connection.ExecuteNonQuery(command);
        }
    }
}
