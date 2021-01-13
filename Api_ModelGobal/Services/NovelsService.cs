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
    public class NovelsService : INovelsService<Novels>
    {
        private readonly IConnection _connection;
        public NovelsService(IConnection connection)
        {
            _connection = connection;
        }

        public void Add(Novels n)
        {
            DBCommand command = new DBCommand("[RegChacha].[Novels_add]", true);
            command.AddParameter("Title", n.Title);
            command.AddParameter("Series", n.SerieId);
            command.AddParameter("Authors", n.Authors);
            command.AddParameter("SerialNumber", n.SerialNumber);
            command.AddParameter("Price", n.Price);
            command.AddParameter("Informations", n.Informations);
            command.AddParameter("Langue", n.Langue);
            command.AddParameter("Dimension", n.Dimension);
            command.AddParameter("Published", n.Published);
            command.AddParameter("Type", n.TypeId);
            _connection.ExecuteNonQuery(command);
        }



        public void Delete(int id)
        {
            DBCommand command = new DBCommand("[RegChacha].[Novels_del]", true);
            command.AddParameter("Id", id);
            _connection.ExecuteScalar(command);
        }

        public IEnumerable<Novels> GetAll()
        {
            DBCommand command = new DBCommand("Select * from [RegChacha].[V_Novels]");
            return _connection.ExecuteReader(command, (dr) => dr.ToNovels());
        }

        public Novels GetOne(int id)
        {
            DBCommand command = new DBCommand($"Select * from [RegChacha].[V_Novels] where id = @Id");
            command.AddParameter("Id", id);
            return _connection.ExecuteReader(command, (dr) => dr.ToNovels()).SingleOrDefault();
        }

        public void Update(Novels n)
        {
            DBCommand command = new DBCommand("[RegChacha].[Novels_update]", true);
            command.AddParameter("Id", n.Id);
            command.AddParameter("Title", n.Title);
            command.AddParameter("Series", n.SerieId);
            command.AddParameter("Author", n.Authors);
            command.AddParameter("SerialNumber", n.SerialNumber);
            command.AddParameter("Price", n.Price);
            command.AddParameter("Informations", n.Informations);
            command.AddParameter("Langue", n.Langue);
            command.AddParameter("Dimension", n.Dimension);
            command.AddParameter("Published", n.Published);
            command.AddParameter("Type", n.TypeId);
            _connection.ExecuteNonQuery(command);
        }
    }
}
