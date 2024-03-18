using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TestWeb.Pages
{
    public class IndexModel : PageModel
    {
       public string Name { get; set; } 
        public List<string> NamesList { get; set; }

        public void OnGet()
        {
            Name = "Bootstrap";
            NamesList = new List<string>(); 
            NamesList.Add("Artem");
            NamesList.Add("Artem");
            NamesList.Add("Artem");
            NamesList.Add("Artem");

        }
    }
}