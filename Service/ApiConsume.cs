using Service.Entities;
using RestSharp;
using Newtonsoft.Json;

namespace Service
{
    public class ApiConsume
    {
        //Consumo de servicio Comentarios
        public List<Comments> RequestComments()
        {

            List<Comments> listaComentarios = new List<Comments>();
            var cliente = new RestClient("https://jsonplaceholder.typicode.com/");
            var request = new RestRequest("comments", Method.Get);

            var response = cliente.Execute(request).Content;
            
            listaComentarios = JsonConvert.DeserializeObject<List<Comments>>(response!)!;


            return listaComentarios;
        }


        //Consumo de servicio Posts 
        public List<Posts> RequestPosts()
        {

            List<Posts> listaPosts = new List<Posts>();
            var cliente = new RestClient("https://jsonplaceholder.typicode.com/");
            var request = new RestRequest("posts", Method.Get);

            var response = cliente.Execute(request).Content;
            listaPosts = JsonConvert.DeserializeObject<List<Posts>>(response!)!;


            return listaPosts;
        }

        //Consumo de servicio usuarios
        public List<Users> RequestUsers()
        {

            List<Users> listaUsuarios = new List<Users>();
            var cliente = new RestClient("https://jsonplaceholder.typicode.com/");
            var request = new RestRequest("users", Method.Get);

            var response = cliente.Execute(request).Content;
            listaUsuarios = JsonConvert.DeserializeObject<List<Users>>(response!)!;

           
            return listaUsuarios;
        }



    }
}