using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog_project.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

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
                post.userId = User.Identity.Name;
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
            if(post.userId == User.Identity.Name) {
                if (post == null)
                {
                    return NotFound();
                }
                return View(post);
            }
            else
            {
                TempData["Message"] = "You have no permisson!";
                return Redirect("/");
            }
            
        }

        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Post post)
        {
            if(post.userId == User.Identity.Name) {
                if (ModelState.IsValid)
                {
                    db.Posts.Update(post);
                    await db.SaveChangesAsync();
                    TempData["Message"] = "Edited";
                    return RedirectToAction(nameof(Index));
                }
                return View(post);
            }
            else
            {
                TempData["Message"] = "You have no permisson!";
                return Redirect("/");
            }
            
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Post post = db.Posts.Find(id);
            if(post.userId == User.Identity.Name) {
                if (post == null)
                {
                    return NotFound();
                }
                return View(post);
            }
            else
            {
                TempData["Message"] = "You have no permisson!";
                return Redirect("/");
            }
           
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Post post = db.Posts.Find(id);
            if(post.userId == User.Identity.Name) {
                db.Posts.Remove(post);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return Redirect("/");
            }
        }
    }
}
