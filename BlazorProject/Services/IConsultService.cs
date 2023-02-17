using Service.Entities;

namespace BlazorProject.Services
{
    public interface IConsultService
    {
        Task<IEnumerable<Users>> getUsers();
        Task<IEnumerable<Comments>> getComments();
        Task<IEnumerable<Posts>> getPosts();

    }
}
