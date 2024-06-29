using api.ModelViews;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers;

[ApiController]
[Route("/")]
public class HomeController : ControllerBase
{
    
    // [HttpGet]
    // public ActionResult Index()
    // {
    //     return Redirect("/swagger");
    // }

    [HttpGet]
    [AllowAnonymous]
    public HomeView Index()
    {
        return new HomeView();
    }
}
