using MiniProject.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MiniProject.Domain.Interfaces
{
    public interface IAlbumsService
    {
        Task<List<Album>> GetAlbums();
    }
}
