using Service.Entities;
using Service;
using System.Globalization;

namespace BlazorProject.Services
{
    public class ConsultService : IConsultService
    {
        private readonly HttpClient httpClient;

        public ConsultService(HttpClient _httpClient)
        {
            this.httpClient = _httpClient;
        }
        public async Task<IEnumerable<Users>> getUsers()
        {
            
            return await httpClient.GetFromJsonAsync<Users[]>("https://jsonplaceholder.typicode.com/users");
        }

        public async Task<IEnumerable<Comments>> getComments()
        {
            var listaComentarios = httpClient.GetFromJsonAsync<Comments[]>("https://jsonplaceholder.typicode.com/comments");

           
            return await httpClient.GetFromJsonAsync<Comments[]>("https://jsonplaceholder.typicode.com/comments");
        }

        public async Task<IEnumerable<Posts>> getPosts()
        {
            return await httpClient.GetFromJsonAsync<Posts[]>("https://jsonplaceholder.typicode.com/posts");
        }


    }

}
