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
    public class UserService : IUserService<User>
    {
        private readonly HttpClient _user;
        public UserService(HttpClient user)
        {
            _user = user;
        }
        public void Delete(int id)
        {
            using (_user)
            {
            HttpResponseMessage httpResponseMessage = _user.DeleteAsync($"api/Novels/delete/{id}").Result;
            httpResponseMessage.EnsureSuccessStatusCode();
            }
            
        }

        public IEnumerable<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public User GetOne(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(User u)
        {
            using (_user)
            {
                string contentJson = JsonSerializer.Serialize(new { u });
                HttpContent httpContent = new StringContent(contentJson);
                httpContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

                HttpResponseMessage httpResponseMessage = _user.PostAsync($"api/User/Add", httpContent).Result;
                httpResponseMessage.EnsureSuccessStatusCode();
            };
        }

        public void Update(User u)
        {
            using (_user)
            {
                string contentJson = JsonSerializer.Serialize(new { u });
                HttpContent httpContent = new StringContent(contentJson);
                httpContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

                HttpResponseMessage httpResponseMessage = _user.PostAsync($"api/User/update", httpContent).Result;
                httpResponseMessage.EnsureSuccessStatusCode();
            };
        }
    }
}
