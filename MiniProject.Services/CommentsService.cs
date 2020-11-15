using MiniProject.Domain.Interfaces;
using MiniProject.Domain.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace MiniProject.Services
{
    public class CommentsService : ICommentsService
    {
        public async Task<List<Comment>> GetComments(int postId)
        {
            string url = $"https://jsonplaceholder.typicode.com/comments?postId={postId}";
            HttpClient httpClient = new HttpClient();

            var response = await httpClient.GetAsync(url);
            string jsonResult = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<Comment>>(jsonResult);
        }
    }
}
