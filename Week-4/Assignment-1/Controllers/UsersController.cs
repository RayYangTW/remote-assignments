using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Assignment_1.Data;
using Assignment_1.Models;
using Assignment_1.Models.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using BCrypt.Net;

namespace Assignment_1.Controllers
{
  public class UsersController : Controller
  {
    private readonly assignmentContext _assignmentContext;

    public UsersController(assignmentContext assignmentContext)
    {
      this._assignmentContext = assignmentContext;
    }

    [HttpGet]
    public IActionResult Signin()
    {
      return View();
    }

    [HttpPost]
    public async Task<IActionResult> Signin(SigninViewModel signinRequest)
    {
      var existingUser = await _assignmentContext.User.FirstOrDefaultAsync(u => u.Email == signinRequest.Email);

      var password = signinRequest.Password;
      var hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);

      if (existingUser == null)
      {
        TempData["Message"] = "帳號不存在，請註冊。";
        return RedirectToAction("Signup");
      }

      bool passwordIsMatch = BCrypt.Net.BCrypt.Verify(password, existingUser?.Password);

      if (!passwordIsMatch)
      {
        TempData["Message"] = "帳號或密碼錯誤。";
        return RedirectToAction("Signin");
      }
      else
      {
        TempData["Message"] = "登入成功！";
        return RedirectToAction("Member", "Home");
      }
    }

    [HttpGet]
    public IActionResult Signup()
    {
      return View();
    }

    [HttpPost]
    public async Task<IActionResult> Signup(SignupViewModel signupRequest)
    {
      var existingUser = await _assignmentContext.User.FirstOrDefaultAsync(u => u.Email == signupRequest.Email);
      var Password = signupRequest.Password;
      var PasswordCheck = signupRequest.PasswordCheck;

      if (!ModelState.IsValid)
      {
        TempData["Message"] = "輸入資料有誤，請確認電子信箱格式及密碼需大於6碼。";

        return RedirectToAction("Signup");
      }

      if (existingUser != null)
      {
        TempData["Message"] = "帳號已存在，請登入";
        return RedirectToAction("Signin");
      }
      else if (Password == PasswordCheck)
      {
        var user = new User()
        {
          Id = Guid.NewGuid(),
          Email = signupRequest.Email,
          Password = BCrypt.Net.BCrypt.HashPassword(signupRequest.Password),
        };

        await _assignmentContext.User.AddAsync(user);
        await _assignmentContext.SaveChangesAsync();
        TempData["Message"] = "帳號建立成功！";
        return RedirectToAction("Member", "Home");
      }
      return RedirectToAction("Signin");

    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
      return View("Error!");
    }
  }
}