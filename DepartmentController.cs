using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication9.Models;

namespace WebApplication9.Controllers;

public class DepartmentController : Controller
{
       

    public IActionResult Index()
    {
        string s = "a";
        s = "bcd";
        return View();
    }
}