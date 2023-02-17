using Service;
using Service.Entities;
using System.Globalization;

namespace WebProject.Models
{
    public class CommentModel
    {
        //Instancia del service
        ApiConsume service = new ApiConsume();
        public List<Comments> RequestCommets()
        {
            var listaComentarios = service.RequestComments();
            ModifyCommets(listaComentarios);

            return listaComentarios;
        }


        //Bonus 1
        public void ModifyCommets(List<Comments> comentarios)
        {
            string comentario;
            foreach (var item in comentarios)
            {
                comentario = item.body!;
                comentario = (CultureInfo.InvariantCulture.TextInfo.ToTitleCase(comentario));
                item.body = comentario;

            }
        }
    }
}
