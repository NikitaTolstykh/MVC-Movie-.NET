using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MVC_Movie.Controllers;

public class HelloWorldController
{
    public String Index()
    {
        return "This is my default action...";
    }

    public string Welcome(string name, int ID = 1)
    {
        return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
    }
    
}