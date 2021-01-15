using Bibliotheque_Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Asp_ModelGlobal.Entities;

namespace Asp_ModelGlobal.Services
{
    public class TypesService : ITypesRepo<Types>
    {
        public IEnumerable<Entities.Types> GetAll()
        {
            throw new NotImplementedException();
        }

        public Entities.Types GetOne(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Entities.Types t)
        {
            throw new NotImplementedException();
        }

        public void Update(Entities.Types t)
        {
            throw new NotImplementedException();
        }
    }
}

