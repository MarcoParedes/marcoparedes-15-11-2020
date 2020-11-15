using MiniProject.Domain.Interfaces;
using MiniProject.Domain.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Configuration;
using System.Net.Http;
using System.Threading.Tasks;

namespace MiniProject.Services
{
    public class AlbumsService : IAlbumsService
    {
        public async Task<List<Album>> GetAlbums()
        {
            string url = $"{ConfigurationManager.AppSettings["baseURL"]}/albums";
            HttpClient httpClient = new HttpClient();

            var response = await httpClient.GetAsync(url);
            string jsonResult = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<Album>>(jsonResult);
        }
    }
}
