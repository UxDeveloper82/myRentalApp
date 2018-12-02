using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    [AllowAnonymous]
    public class BlogsController : Controller
    {
        private ApplicationDbContext _context;

        public BlogsController()
        {
            _context = new ApplicationDbContext();
        }


        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Blogs
        public ActionResult Index()
        {
            var blog = _context.Blogs.ToList();
            return View(blog);
        }

        public ActionResult Details(int id)
        {
            var blogDetail = _context.Blogs.SingleOrDefault(d=>d.Id == id);

            return View(blogDetail);
        }
        public ActionResult New()
        {
            var newPost = _context.Blogs.ToList();
            return View(newPost);
        }

        [HttpPost]
        public ActionResult Create (Blog blog)
        {
            _context.Blogs.Add(blog);
            _context.SaveChanges();

            return RedirectToAction("Index","Blogs");

        }
    }
}