using Bibliotheque_Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Asp_ModelClient.Entities;
using GTypes = Asp_ModelGlobal.Entities.Types;
using Asp_ModelClient.Mapper;

namespace Asp_ModelClient.Services
{
    public class TypesService : ITypesService<Types>
    {
        private readonly ITypesService<GTypes> _globalrepository;

        public TypesService(ITypesService<GTypes> GlobalRepository)
        {
            _globalrepository = GlobalRepository;
        }
        public IEnumerable<Types> GetAll()
        {
            return _globalrepository.GetAll().Select(t => t.ToClient());
        }

        public Types GetOne(int id)
        {
            return _globalrepository.GetOne(id)?.ToClient();
        }

        public void Insert(Types t)
        {
            _globalrepository.Insert(t.ToGlobal());
        }

        public void Update(int id,Types t)
        {
            _globalrepository.Update(id, t.ToGlobal());
        }
    }
}

