using Bibliotheque_Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Asp_ModelGlobal.Entities;
using System.Net.Http;
using System.Text.Json;

namespace Asp_ModelGlobal.Services
{
    public class NovelsService : INovelsService<Novels>
    {
        private readonly HttpClient _client;
        public NovelsService(HttpClient client)
        {
            _client = client;
        }

        public void Add(Novels novels)
        {
            using (_client)
            {
                string contentJson = JsonSerializer.Serialize(new {novels});
                HttpContent httpContent = new StringContent(contentJson);
                httpContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

                HttpResponseMessage httpResponseMessage = _client.PostAsync($"api/Novels/Add",httpContent).Result;
            }
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
        public void Update(Novels n)
        {
            _globalNovels.Update(n.ToGobal()); 
        }
    }
}
