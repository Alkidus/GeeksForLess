using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TechnicalTask.Models;

namespace TechnicalTask.Controllers
{
    public class HomeController : Controller
    {
        TopicContext db = new TopicContext();
        public ActionResult Index()
        {
            // получаем из бд все объекты Forum
            IEnumerable<Forum> forums = db.Forums;
            // передаем все полученный объекты в динамическое свойство Forums в ViewBag
            ViewBag.Forums = forums;
            // возвращаем представление
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpGet]
        public ActionResult CreatePosts(int id = 1)
        {
            ViewBag.ForumId = id;
            return View();
        }
        [HttpPost]
        public string CreatePosts(Post post)
        {
            post.Created = DateTime.Now;
            // добавляем информацию в базу данных
            db.Posts.Add(post);
            // сохраняем в бд все изменения
            db.SaveChanges();
            System.Threading.Thread.Sleep(2000);
            Response.Redirect("https://localhost:44368/Home/ChooseForum/" + post.ForumId);
            return "Спасибо, пост: \'" + post.Title + "\', создан и сохранён!";
            

        }
        [HttpGet]
        public ActionResult ChooseForum(int id)
        {
            ViewData["ForumId"] = id;
            // получаем из бд все объекты Forum
            IEnumerable<Post> posts = db.Posts.Where(p => p.ForumId == id);
            // передаем все полученный объекты в динамическое свойство Forums в ViewBag
            ViewBag.Posts = posts;
            return View();
        }
        [HttpGet]
        public ActionResult CreateTopic()
        {
            return View();
        }
        [HttpPost]
        public string CreateTopic(Forum forum)
        {
            forum.Created = DateTime.Now;
            // добавляем информацию в базу данных
            db.Forums.Add(forum);
            // сохраняем в бд все изменения
            db.SaveChanges();
            System.Threading.Thread.Sleep(2000);
            Response.Redirect("https://localhost:44368");
            return "Спасибо, пост: \'" + forum.Title + "\', создан и сохранён!";


        }
    }
}