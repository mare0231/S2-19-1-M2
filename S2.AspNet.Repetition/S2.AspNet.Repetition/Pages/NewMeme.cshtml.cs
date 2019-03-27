using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using S2.AspNET.Repetition.DAL;

namespace S2.AspNet.Repetition.Pages
{
    public class NewMemeModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public int ImageSelected { get; set; }
        [BindProperty(SupportsGet = true)]
        public string MemeText { get; set; } = "";
        public string SelectedImageUrl { get; set; }
        [BindProperty(SupportsGet = true)]
        public string TextPosition { get; set; }
        [BindProperty(SupportsGet = true)]
        public string MemeName { get; set; }
        [BindProperty(SupportsGet = true)]
        public string FontSize { get; set; }
        [BindProperty(SupportsGet = true)]
        public string TextColor { get; set; }
        public void OnGet()
        {
            MemeImageRepository memeImageRepo = new MemeImageRepository(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=MemeGenerator;Integrated Security=True;");

            if (ImageSelected > 0)
            {
                SelectedImageUrl = memeImageRepo.GetUrlFrom(ImageSelected);
            }

        }
    }
}