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
    public class TypesService : ITypesRepo<Types>
    {
        private readonly IConnection _connection;
        public TypesService(IConnection connection)
        {
            _connection = connection;
        }
        public IEnumerable<Types> GetAll()
        {
            DBCommand command = new DBCommand("Select * from [RegChacha].[V_Types]");
            return _connection.ExecuteReader(command, (dr) => dr.ToTypes());
        }

        public Types GetOne(int id)
        {
            DBCommand command = new DBCommand("Select * from [RegChacha].[V_Types] where id=@id");
            command.AddParameter("id", id);
            return _connection.ExecuteReader(command, (dr) => dr.ToTypes()).SingleOrDefault();
        }

        public void Insert(Types t)
        {
            DBCommand command = new DBCommand("[RegChacha].[Type_Add]", true);
            command.AddParameter("Type", t.Type);
            _connection.ExecuteNonQuery(command);
        }

        public void Update(Types t)
        {
            DBCommand command = new DBCommand("[RegChacha].[Type_Update]", true);
            command.AddParameter("Id", t.Id);
            command.AddParameter("Type", t.Type);
            _connection.ExecuteNonQuery(command);
        }
    }
}

