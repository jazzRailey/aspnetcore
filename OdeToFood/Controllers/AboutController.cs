using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OdeToFood.Controllers
{
    [Route("[controller]/[action]")]
    public class AboutController : Controller
    {
        public string Phone() {
            return "+631955144654";
        }
        public string Address()
        {
            return "Valenzuela City";
        }
        public string Test() {
            return "Test";
        }
    }
}
