using Microsoft.AspNetCore.Mvc;

namespace Assignment_4.Controllers;

[ApiController]
[Route("[controller]")]
public class MyNameController : ControllerBase
{
  private readonly IHttpContextAccessor _httpContextAccessor;
  public MyNameController(IHttpContextAccessor httpContextAccessor)
  {
    this._httpContextAccessor = httpContextAccessor;
  }

  [HttpGet]
  [Route("/myName")]
  public IActionResult Get()
  {
    var result = GetNameFromCookie();
    if (result == null)
    {
      return Redirect("name.html");
    }
    return Ok(GetNameFromCookie());
  }

  [HttpGet]
  [Route("/trackName")]
  public IActionResult StoreName([FromQuery] string name)
  {
    StoreNameToCookie(name);
    return Redirect("/myName");
  }

  [HttpGet]
  [Route("/clearCookie")]
  public IActionResult DeleteName()
  {
    var cookieName = "userName";
    DeleteNameInCookie(cookieName);
    return Redirect("/myName");
  }

  private void StoreNameToCookie(string name)
  {
    var StoreNameToCookie = new CookieOptions();
    StoreNameToCookie.Expires = DateTime.Now.AddDays(1);
    StoreNameToCookie.Path = "/";

    Response.Cookies.Append("userName", name, StoreNameToCookie);
  }

  private string? GetNameFromCookie()
  {
    var cookie = Request.Cookies["userName"];
    return cookie;
  }

  private void DeleteNameInCookie(string cookie)
  {
    Response.Cookies.Delete(cookie);
  }
}
