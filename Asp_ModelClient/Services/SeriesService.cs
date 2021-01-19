using Bibliotheque_Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Asp_ModelClient.Entities;
using Asp_ModelClient.Mapper;
using GSeries = Asp_ModelGlobal.Entities.Series;

namespace Asp_ModelClient.Services
{
    public class SeriesService : ISeriesService<Series>
    {
        private readonly ISeriesService<GSeries> _globalrepository;

        public SeriesService(ISeriesService<GSeries> GlobalRepository)
        {
            _globalrepository = GlobalRepository;
        }
        public void Add(Series s)
        {
            _globalrepository.Add(s.ToGlobal());
        }
        public IEnumerable<Series> GetAll()
        {
            return _globalrepository.GetAll().Select(s => s.ToClient() );
        }
        public Series GetOne(int id)
        {
            return _globalrepository.GetOne(id).ToClient();
        }
        public void Update(int id,Series s)
        {
            _globalrepository.Update(id, s.ToGlobal());
        }
    }
}
