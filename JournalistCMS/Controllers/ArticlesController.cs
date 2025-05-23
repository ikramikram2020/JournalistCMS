using System.Web.Mvc;
using JournalistCMS.Models;
using System.Collections.Generic;

namespace JournalistCMS.Controllers
{
    public class ArticlesController : Controller
    {
        AppDbContext db = new AppDbContext();

        public ActionResult Index()
        {
            string journalist = Session["Journalist"].ToString();
            List<Article> articles = new List<Article>();

            foreach (var item in db.Articles)
                if (item.Author == journalist)
                    articles.Add(item);

            return View(articles);
        }

        public ActionResult Create() => View();

        [HttpPost]
        public ActionResult Create(Article newArticle)
        {
            newArticle.Author = Session["Journalist"].ToString();
            newArticle.PublishDate = System.DateTime.Now;
            db.Articles.Add(newArticle);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            var article = db.Articles.Find(id);
            return View(article);
        }

        public ActionResult Edit(int id)
        {
            var article = db.Articles.Find(id);
            return View(article);
        }

        [HttpPost]
        public ActionResult Edit(Article updatedArticle)
        {
            var article = db.Articles.Find(updatedArticle.Id);
            article.Title = updatedArticle.Title;
            article.Content = updatedArticle.Content;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var article = db.Articles.Find(id);
            return View(article);
        }

        [HttpPost]
        public ActionResult DeleteConfirmed(int id)
        {
            var article = db.Articles.Find(id);
            db.Articles.Remove(article);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
