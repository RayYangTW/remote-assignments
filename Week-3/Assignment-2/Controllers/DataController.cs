using Microsoft.AspNetCore.Mvc;

namespace Assignment_2.Controllers;

[ApiController]
[Route("[controller]")]
public class DataController : ControllerBase
{
  [HttpGet]
  public IActionResult Get(string? number)
  {
    if (number == null)
    {
      return Ok("Lack of Parameter");
    }
    else if (!int.TryParse(number, out int num) || int.Parse(number) < 0)
    {
      return Ok("Wrong Parameter");
    }
    else
    {
      return Ok(Calculation(int.Parse(number)));
    }
  }

  private int Calculation(int num)
  {
    return num * (num + 1) / 2;
  }
}
