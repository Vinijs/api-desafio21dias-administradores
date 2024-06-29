using api.ModelViews;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers;

[ApiController]
[Route("/token")]
public class TokenController : ControllerBase
{
    [HttpHead]
    public ActionResult Index(){
        return StatusCode(204);
     }
}
