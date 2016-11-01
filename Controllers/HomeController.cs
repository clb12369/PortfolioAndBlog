using Microsoft.AspNetCore.Mvc;

[Route("/")]
public class HomeController : Controller
{

    // private IBlogRepo posts;
    // public IBlogRepo BlogApiController(IBlogRepo b){
    //     posts = b;
    // }

    [HttpGet]
    [HttpGet("home")]
    public IActionResult Root(){
    return View("Index");
    }


    [HttpGet("about")]
    public IActionResult About(){
        return View();
    }
}