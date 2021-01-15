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
    public class NovelsService : INovelsService<Client.Novels>
    {
        private readonly INovelsService<Global.Novels> _globalNovels;
        public NovelsService(INovelsService<Global.Novels> GlobalNovels)
        {
            _globalNovels = GlobalNovels;
        }

        public void Add(Novels n)
        {
            _globalNovels.Add(n.ToGobal());
        }

        public void Delete(int id)
        {
            _globalNovels.Delete(id);
        }

        public IEnumerable<Novels> GetAll()
        {
            return _globalNovels.GetAll().Select(n => n.ToClient());
        }        

        public Novels GetOne(int id)
        {
            return _globalNovels.GetOne(id).ToClient();            
        }       
        public void Update(int id,Novels n)
        {
            _globalNovels.Update(id,n.ToGobal()); 
        }
    }
}
