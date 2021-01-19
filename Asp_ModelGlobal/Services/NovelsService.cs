using Bibliotheque_Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq; 
using System.Net.Http;
using System.Text.Json;
using Asp_ModelGlobal.Entities;
using API_EntitiesForm;

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
                string contentJson = JsonSerializer.Serialize(novels);
                HttpContent httpContent = new StringContent(contentJson);
                httpContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

                HttpResponseMessage httpResponseMessage = _client.PostAsync($"api/Novels/Add",httpContent).Result;
                httpResponseMessage.EnsureSuccessStatusCode();
            }
        }

        public void Delete(int id)
        {
            using(_client)
            {                
                HttpResponseMessage httpResponseMessage = _client.DeleteAsync($"api/Novels/delete/{id}").Result;
                httpResponseMessage.EnsureSuccessStatusCode();
            }
            
        }

        public IEnumerable<Novels> GetAll()
        {
            using (_client)
            {
                HttpResponseMessage httpResponseMessage = _client.GetAsync($"api/Novels/").Result;
                httpResponseMessage.EnsureSuccessStatusCode();
                string json = httpResponseMessage.Content.ReadAsStringAsync().Result;

                //Attention faut envoyer un tableau de l'objet, Il risque de vouloir instancer IEnumerable mais c'est une interface.
                return JsonSerializer.Deserialize<IEnumerable<Novels>>(json, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
            }
        }        

        public Novels GetOne(int id)
        {
            using (_client)
            {
                HttpResponseMessage httpResponseMessage = _client.GetAsync($"api/Novels/{id}").Result;
                httpResponseMessage.EnsureSuccessStatusCode();
                string json = httpResponseMessage.Content.ReadAsStringAsync().Result;
                return JsonSerializer.Deserialize<Novels>(json, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
            }
        }       
        public void Update(int id,Novels novels)
        {
            using (_client)
            {
                novels.Id = id;
                string json = JsonSerializer.Serialize(novels);                
                HttpContent httpcontent = new StringContent(json);
                httpcontent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");


                HttpResponseMessage httpResponseMessage = _client.PutAsync($"api/Novels/update/{id}",httpcontent).Result;
                httpResponseMessage.EnsureSuccessStatusCode();
            }

        }
    }
}
