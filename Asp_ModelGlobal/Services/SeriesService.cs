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
    public class SeriesService : ISeriesService<Series>
    {
        private readonly HttpClient _client;
        public SeriesService(HttpClient client)
        {
            _client = client;
        }
        public void Add(Series s)
        {
            using (_client)
            {
                string contentJson = JsonSerializer.Serialize(s);
                HttpContent httpContent = new StringContent(contentJson);
                httpContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

                HttpResponseMessage httpResponseMessage = _client.PostAsync($"api/Series/Add", httpContent).Result;
                httpResponseMessage.EnsureSuccessStatusCode();
            }
        }

        public IEnumerable<Series> GetAll()
        {
            using (_client)
            {
                HttpResponseMessage httpResponseMessage = _client.GetAsync($"api/Series/").Result;
                httpResponseMessage.EnsureSuccessStatusCode();
                string json = httpResponseMessage.Content.ReadAsStringAsync().Result;

                //Attention faut envoyer un tableau de l'objet, Il risque de vouloir instancer IEnumerable mais c'est une interface.
                return JsonSerializer.Deserialize<IEnumerable<Series>>(json, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
            }
        }

        public Series GetOne(int id)
        {
            using (_client)
            {
                HttpResponseMessage httpResponseMessage = _client.GetAsync($"api/Series/{id}").Result;
                httpResponseMessage.EnsureSuccessStatusCode();
                string json = httpResponseMessage.Content.ReadAsStringAsync().Result;
                return JsonSerializer.Deserialize<Series>(json, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });

            }
        }

        public void Update(int id,Series s)
        {
            using (_client)
            {
                string contentJson = JsonSerializer.Serialize(new SeriesForm(id, s.Nom));
                HttpContent httpContent = new StringContent(contentJson);
                httpContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

                HttpResponseMessage httpResponseMessage = _client.PostAsync($"api/Series/update", httpContent).Result;
                httpResponseMessage.EnsureSuccessStatusCode();
            }
        }
    }
}
