using Bibliotheque_Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Asp_ModelGlobal.Entities;
using System.Text.Json;
using System.Net.Http;
using API_EntitiesForm;

namespace Asp_ModelGlobal.Services
{
    public class TypesService : ITypesService<Types>
    {
        private readonly HttpClient _client;
        public TypesService(HttpClient client)
        {
            _client = client;
        }
        public IEnumerable<Types> GetAll()
        {
            using (_client)
            {
                HttpResponseMessage httpResponseMessage = _client.GetAsync($"api/Types/").Result;
                httpResponseMessage.EnsureSuccessStatusCode();
                string json = httpResponseMessage.Content.ReadAsStringAsync().Result;

                //Attention faut envoyer un tableau de l'objet, Il risque de vouloir instancer IEnumerable mais c'est une interface.
                return JsonSerializer.Deserialize<IEnumerable<Types>>(json, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
            }
        }

        public Entities.Types GetOne(int id)
        {
            using (_client)
            {
                HttpResponseMessage httpResponseMessage = _client.GetAsync($"api/Types/{id}").Result;
                httpResponseMessage.EnsureSuccessStatusCode();
                string json = httpResponseMessage.Content.ReadAsStringAsync().Result;
                return JsonSerializer.Deserialize<Types>(json, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });

            }
        }

        public void Insert(Types t)
        {
            using (_client)
            {
                string contentJson = JsonSerializer.Serialize(t);
                HttpContent httpContent = new StringContent(contentJson);
                httpContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

                HttpResponseMessage httpResponseMessage = _client.PostAsync($"api/Types/Add", httpContent).Result;
                httpResponseMessage.EnsureSuccessStatusCode();
            }
        }

        public void Update(int id,Types t)
        {
            t.Id = id;
            string contentJson = JsonSerializer.Serialize(t);
            HttpContent httpContent = new StringContent(contentJson);
            httpContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

            HttpResponseMessage httpResponseMessage = _client.PostAsync($"api/Types/update", httpContent).Result;
            httpResponseMessage.EnsureSuccessStatusCode();
        }
    }
}

