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
    public class SeriesService : ISeriesService<Client.Series>
    {
        private readonly ISeriesService<Global.Series> _globalSerie;
        public SeriesService(ISeriesService<Global.Series> GlobalSerie)
        {
            _globalSerie = GlobalSerie;
        }
        public void Add(Series s)
        {
            _globalSerie.Add(s.ToGlobal());
        }

        public IEnumerable<Series> GetAll()
        {
            return _globalSerie.GetAll().Select(s => s.ToClient());
        }

        public Series GetOne(int id)
        {
            return _globalSerie.GetOne(id).ToClient();
        }

        public void Update(int id,Series s)
        {
            _globalSerie.Update(id,s.ToGlobal());
        }
    }
}
