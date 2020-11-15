using MiniProject.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MiniProject.Domain.Interfaces
{
    public interface ICommentsService
    {
        Task<List<Comment>> GetComments(int postId);
    }
}
