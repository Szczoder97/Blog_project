using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog_project.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace Blog_project.Controllers
{
    [Authorize]
    public class PostController : Controller
    {
        BlogDBContext db;

        public PostController(BlogDBContext db)
        {
            this.db = db;
        }

        [AllowAnonymous]
        public IActionResult Index()
        {
            return View(db.Posts.OrderBy(c=>c.publishedDate));
        }

        [AllowAnonymous]
        public async Task<IActionResult> Details(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var post = await db.Posts.SingleOrDefaultAsync(c => c.id == id);
            if(post == null)
            {
                return NotFound();
            }
            return View(post);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Post post)
        {
            if (ModelState.IsValid)
            {
                db.Posts.Add(post);
                await db.SaveChangesAsync();
                TempData["Message"] = "Post added";
                return RedirectToAction(nameof(Index));
            }
            return View(post);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var post = await db.Posts.SingleOrDefaultAsync(c => c.id == id);
            if(post == null)
            {
                return NotFound();
            }
            return View(post);
        }

        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Post post)
        {
            if (ModelState.IsValid)
            {
                db.Posts.Update(post);
                await db.SaveChangesAsync();
                TempData["Message"] = "Edited";
                return RedirectToAction(nameof(Index));
            }
            return View(post);
        }
    }
}
