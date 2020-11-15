using MiniProject.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MiniProject.Domain.Interfaces
{
    public interface IPhotosService
    {
        Task<List<Photo>> GetPhotos(int albumId);
    }
}
