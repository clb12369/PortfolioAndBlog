using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Threading.Tasks;

[Route("/api/blog")]
public class BlogApiController : Controller {

    private IBlogRepo posts;
    public BlogApiController(IBlogRepo b){
        posts = b;
    }

    // get all posts JSONs
    [HttpGet]
    public IActionResult Read(){
        return Ok(posts);
    }

    // get a single post's JSON
    [HttpGet("{id}")]
    public IActionResult ReadOne(int id){
        var post = posts.Read(id);
        if (post == null)
            return NotFound();

        return Ok(post);
    }

    [HttpPost("new")]
    // [ValidateAntiForgeryToken]
    public IActionResult Create([FromBody] Post p){
        posts.Create(p);
        return Ok(posts);
    }

    [HttpPost("delete/{id}")]
    // [ValidateAntiForgeryToken]
    public IActionResult Delete(int id){
        posts.Delete(id);
        return Ok(posts);
    }


    // update a post 
    [HttpPut("{id}/edit")]
    public IActionResult Update([FromBody] Post p, int id){
        var post = posts.Read(id);
        if (post != null){
            posts.Delete(id);
        }
        p.PostId = id;
        posts.Add(p);
        return Ok(posts); 
    }

}
