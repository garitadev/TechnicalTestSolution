using Service;
using Service.Entities;

namespace WebProject.Models
{
    public class PostsModel
    {

        //Instancia del service
        ApiConsume service = new ApiConsume();
        public List<Posts> RequestPosts()
        {
            var listaPosts = service.RequestPosts();
            return listaPosts;
        }
    }
}
