using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AplikacjaWeb.Pages
{
    public class ContactModel : PageModel
    {
        private string tel = "";
        private string address = "";
        private string name = "";

        public string Tel { get => tel; set => tel = value; }
        public string Address { get => address; set => address = value; }
        public string Name { get => name; set => name = value; }    

        public Model.Forms? Forms { get; set; }

        public void OnGet()
        {
            tel = "777888999";
            address = "Zbożowa 14, 42-000 Czeladź";
            name = "TEB";
            //Forms = new Model.Forms();
        }

        //[HttpPost]
        public JsonResult AjaxMethod()
        {
            Forms = new Model.Forms
            {
               
            };
            return new JsonResult("TEST");
        }

        public JsonResult OnPostSubmitAsync()
        {
            //if (!ModelState.IsValid)
            return new JsonResult("success");
        }

        //public void OnPost()
        //{
            
        //    //Console.WriteLine("HEJ HEJ");
        //    Console.WriteLine(AjaxMethod());
        //}
    }
}
