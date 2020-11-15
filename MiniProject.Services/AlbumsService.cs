using MiniProject.Domain.Interfaces;
using MiniProject.Domain.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject.Services
{
    public class AlbumsService : IAlbumsService
    {
        public AlbumsService()
        {

        }
        public async Task<List<Album>> GetAlbums()
        {
            string url = "https://jsonplaceholder.typicode.com/albums";
            HttpClient httpClient = new HttpClient();

            var response = await httpClient.GetAsync(url);
            string jsonResult = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<Album>>(jsonResult);
        }
    }
}
