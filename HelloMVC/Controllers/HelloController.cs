using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HelloMVC.Controllers
{
    public class HelloController : Controller
    {
        // GET: /<controller>/
        //Action methods: return some type of ActionResult
        [HttpGet]
        public IActionResult Index()
        {
            /*
             * Index(string name ="World")
            string html = "<form method='post' action='/Hello/Display'>" +
                "<input type ='text' name='name' />" + 
                "<input type ='submit' value ='Greet me!' />" +
                "</form>";
            */

            string html = "<form method='post'>" +
           "<input type ='text' name='name' />" +
           "<input type ='submit' value ='Greet me!' />" +
           "</form>";

            return Redirect("/Hello/Goodbye");

            //return Content(html, "text/html");
            //return Content(string.Format("<h1>Hello {0}</h1>", name), "text/html");
            //Run program and add extension /hello... http://localhost:57952/Hello to see this
            // the /Hello tells it to go to the Hello Controller, /Hello/index will do the same
        }

        // /Hello post
        [Route("/Hello")]
        [HttpPost]
        public IActionResult Display(string name = "World")
        {
            return Content(string.Format("<h1>Hello {0}</h1>", name), "text/html");
        }

        // Handle requests to /Hello/NAME (URL segment)
        [Route("/Hello/{name}")]
        public IActionResult Index2(string name)
        {
            return Content(string.Format("<h1>Hello {0}</h1>", name), "text/html");
        }

        //Default route is /Hello/Goodbye
        //alter the route to this controller to be: /Hello/Aloha
        [Route("/Hello/Aloha")]
        public IActionResult Goodbye()
        {
            return Content("Goodbye");
            // Route: http://localhost:57952/Hello/goodbye
        }
    }
}
