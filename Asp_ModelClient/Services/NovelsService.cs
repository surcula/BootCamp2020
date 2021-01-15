using Global = Asp_ModelGlobal.Entities;
using Bibliotheque_Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using Asp_ModelClient.Entities;
using Asp_ModelClient.Mapper;
using System.Linq;

namespace Asp_ModelClient.Services
{
    public class NovelsService : INovelsService<Novels>
    {
        private readonly INovelsService<Global.Novels> _globalrepository;

        public NovelsService(INovelsService<Global.Novels> GlobalRepository)
        {
            _globalrepository = GlobalRepository;
        }
        public void Add(Novels n)
        {
            _globalrepository.Add(n.ToGobal());
        }

        public void Delete(int id)
        {
            _globalrepository.Delete(id);
        }

        public IEnumerable<Novels> GetAll()
        {
            return _globalrepository.GetAll().Select(N => N.ToClient());
        }

        public Novels GetOne(int id)
        {
            return _globalrepository.GetOne(id).ToClient();
        }

        public void Update(int id, Novels n)
        {
            _globalrepository.Update(id, n.ToGobal());
        }
    }
}
