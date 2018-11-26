using Microsoft.AspNetCore.Mvc;
using SeedProject.Models;

namespace SeedProject.Controllers
{
  public  class HomeController : Controller
  {
    // Change these
    [Route("/hello")]
    public string Hello() { return "Hello Friend!"; }

    [Route("/Goodbye")]
    public string Goodbye() { return "Goodbye friend."; }

  }
}
