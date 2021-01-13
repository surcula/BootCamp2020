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
    public class SeriesService : ISeriesService<Series>
    {
        private readonly IConnection _connection;
        public SeriesService(IConnection connection)
        {
            _connection = connection;
        }

        public void Add(Series s)
        {
            DBCommand command = new DBCommand("[RegChacha].[Series_Add]", true);
            command.AddParameter("Nom", s.Nom);
            _connection.ExecuteNonQuery(command);
        }
        public IEnumerable<Series> GetAll()
        {
            DBCommand command = new DBCommand("Select * from [RegChacha].[V_Series]");
            return _connection.ExecuteReader(command, (dr) => dr.ToSeries());
        }

        public Series GetOne(int id)
        {
            DBCommand command = new DBCommand("Select * from [RegChacha].[V_Series] where id=@id");
            command.AddParameter("id", id);
            return _connection.ExecuteReader(command, (dr) => dr.ToSeries()).SingleOrDefault();
        }

        public void Update(Series s)
        {
            DBCommand command = new DBCommand("[RegChacha].[Series_Update]", true);
            command.AddParameter("Id", s.Id);
            command.AddParameter("Nom", s.Nom);
            _connection.ExecuteNonQuery(command);
        }
    }
}
