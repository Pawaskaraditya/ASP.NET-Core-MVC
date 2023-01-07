using System.Diagnostics;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

     public IActionResult Login()
    {
        return View();
    }
   
     public IActionResult Entry(string nm,string mail,string pass)
    {
     List<Student> li=new List<Student>();
     li=Streaming.Dser();
     if(li[0]!=null)
     foreach(Student s in li){
        if(s.Email==mail){
            return Redirect("/home/Register2");
        }

     }
     li.Add(new Student (nm,mail,pass));
     Streaming.Ser(li);
        return Redirect("/home/Login");
    }
   
    public IActionResult validate(String mail,String pass)
    {
        List<Student> li=Streaming.Dser();
        if(li!=null)
        foreach(Student s in li){
            if(s.Email==mail&&s.Pass==pass){
                return Redirect("/home/IACSD");
            }
        }
        return Redirect("/home/login2");
    }
    public IActionResult Register()
    {
        return View();
    }
    public IActionResult login2()
    {
        return View();
    }

    public IActionResult Register2()
    {
        return View();
    }
     public IActionResult iacsd()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
