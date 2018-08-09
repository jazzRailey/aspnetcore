using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace OdeToFood.Pages
{
    public class GreetingModel : PageModel
    {
        private readonly IGreeter _greeting;
        public string CurrentGreeting { get; set; }
        public GreetingModel(IGreeter greeting)
        {
            _greeting = greeting;
        }
        public void OnGet(string name, string lastname)
        {
            CurrentGreeting = _greeting.GetMessageOfTheDay() + " First param is : " + name + " Second param is : " + lastname;
        }
    }
}