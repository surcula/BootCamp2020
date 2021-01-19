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
    public class TypesService : ITypesService<Client.Types>
    {
        private readonly ITypesService<Global.Types> _globalTypes;
        public TypesService(ITypesService<Global.Types> GlobalTypes)
        {
            _globalTypes = GlobalTypes;
        }

        public IEnumerable<Types> GetAll()
        {
            return _globalTypes.GetAll().Select(t => t.ToClient());
        }

        public Types GetOne(int id)
        {
            return _globalTypes.GetOne(id).ToClient();
        }

        public void Insert(Types t)
        {
            _globalTypes.Insert(t.ToGlobal());
        }

        public void Update(int id,Types t)
        {
            _globalTypes.Update(id,t.ToGlobal());
        }
    }
}

