using Service.Entities;
using Service;

namespace WebProject.Models
{
    public class UserModel
    {
        //Instancia del service
        ApiConsume service = new ApiConsume();
        public List<Users> RequestUsers()
        {
            var listaUsuarios = service.RequestUsers();

            return listaUsuarios;
        }

    }
}
