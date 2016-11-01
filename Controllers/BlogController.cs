using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Threading.Tasks;

[Route("/blog")]
public class BlogController : Controller {

    private IBlogRepo posts;
    public BlogController(IBlogRepo b){
        posts = b;
    }

    // route that gets most recent 5 posts
    // [HttpGet ("/")]
    [HttpGet]
    public IActionResult ReadFive(){
        // posts = posts.readLastFive();
        return View(posts);
    }

    // public IActionResult ReadAll(){
    //     return View(posts);
    // }

    // route that gets a post by its id
    [HttpGet("{id}")]
    public IActionResult ReadOne(int id){
        var post = posts.Read(id);
        if (post == null)
            return NotFound();

        return View(post);
        //return Ok("Ok");
    }

    [HttpGet("{id}/edit")]
    public IActionResult Update(int id){
        var post = posts.Read(id);
        return View(post);
    }

    // update a post 
    [HttpPost("{id}/edit")]
    public IActionResult Upsert([FromForm] Post p, int id){
        var post = posts.Read(id);
        if (post != null){
            posts.Delete(id);
        }
        p.PostId = id;
        posts.Add(p);
        return RedirectToAction("ReadFive"); 
    }

    [HttpGet("new")]
    public IActionResult Create(){
        return View();
    }

    [HttpPost("new")]
    // [ValidateAntiForgeryToken]
    public IActionResult HandleCreate([FromForm] Post p){
        posts.Create(p);
        return RedirectToAction("ReadFive");
    }

    [HttpPost("{id}/delete")]
    // [ValidateAntiForgeryToken]
    public IActionResult Delete(int id){
        posts.Delete(id);
        return RedirectToAction("ReadFive");
    }
}