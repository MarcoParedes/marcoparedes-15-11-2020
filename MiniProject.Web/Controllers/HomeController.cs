using MiniProject.Domain.Interfaces;
using MiniProject.Domain.Models;
using MiniProject.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace MiniProject.Web.Controllers
{
    public class HomeController : Controller
    {

        private readonly IAlbumsService albumsService;
        private readonly IPhotosService photosService;
        private readonly ICommentsService commentsService;
        public HomeController()
        {
            albumsService = new AlbumsService();
            photosService = new PhotosService();
            commentsService = new CommentsService();
        }
    
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<JsonResult> GetAlbums()
        {
            List<Album> albums = await albumsService.GetAlbums();
            return Json(albums, JsonRequestBehavior.AllowGet);
        }

        public async Task<ActionResult> GetPhotos(int id)
        {
            List<Photo> photos = await photosService.GetPhotos(id);
            return PartialView("_Photos", photos);
        }

        public async Task<ActionResult> GetComments(int id)
        {
            List<Comment> comments = await commentsService.GetComments(id);
            return PartialView("_Comments", comments);
        }

    }
}