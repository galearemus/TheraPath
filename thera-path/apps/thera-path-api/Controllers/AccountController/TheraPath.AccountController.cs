using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TheraPathAPI.Namespace
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
      [HttpGet("users")]
      public ActionResult<string> GetUserList()
      {
          return "user";
      }
    }
}
