using MiniProject.Domain.Interfaces;
using MiniProject.Domain.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace MiniProject.Services
{
    public class PhotosService : IPhotosService
    {
        public async Task<List<Photo>> GetPhotos(int albumId)
        {
            string url = $"https://jsonplaceholder.typicode.com/photos?albumId={albumId}";
            HttpClient httpClient = new HttpClient();

            var response = await httpClient.GetAsync(url);
            string jsonResult = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<Photo>>(jsonResult);
        }
    }
}
