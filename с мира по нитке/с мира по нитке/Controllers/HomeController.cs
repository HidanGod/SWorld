using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using с_мира_по_нитке.Models;
using System.Data.Entity;

namespace с_мира_по_нитке.Controllers
{
    public class HomeController : Controller
    {
        WorldDbContext db = new WorldDbContext();
        List<User> phones;
        const int pageSize = 10;


        public ActionResult Index(int? id)
        {
            var users = db.Users.Include(p => p.Posts);
            phones = users.ToList();
            int page = id ?? 0;
            if (Request.IsAjaxRequest())
            {
                return PartialView("_News", GetItemsPage(page));
            }
            return View(GetItemsPage(page));
        }

        private List<User> GetItemsPage(int page = 1)
        {
            var itemsToSkip = page * pageSize;

            return phones.OrderBy(t => t.Id).Skip(itemsToSkip).
                Take(pageSize).ToList();
        }





        [HttpGet]
        public ActionResult CreateUser()
        {
            // Формируем список команд для передачи в представление
            SelectList users = new SelectList(db.Users, "Id", "Name");
            ViewBag.User = users;
            return View();
        }

        [HttpPost]
        public ActionResult CreateUser(User user)
        {
            //Добавляем игрока в таблицу
            db.Users.Add(user);
            db.SaveChanges();
            // перенаправляем на главную страницу
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult CreatePost()
        {
            // Формируем список команд для передачи в представление
            SelectList posts = new SelectList(db.Users, "Id", "Name");
            ViewBag.Post = posts;
            return View();
        }

        [HttpPost]
        public ActionResult CreatePost(Post post)
        {
            //Добавляем игрока в таблицу
            db.Posts.Add(post);
            db.SaveChanges();
            // перенаправляем на главную страницу
            return RedirectToAction("Index");
        }

    }
}