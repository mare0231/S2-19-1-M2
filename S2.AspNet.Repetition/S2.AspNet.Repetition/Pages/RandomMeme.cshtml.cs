using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using S2.AspNET.Repetition.DAL;
using S2.AspNET.Repetition.Entities;

namespace S2.AspNet.Repetition.Pages
{
    public class RandomMemeModel : PageModel
    {
        public MemeCreation MemeCreation { get; set; }
        public MemeImage MemeImage { get; set; }
        public void OnGet()
        {
            MemeCreationRepository memeCreationRepo = new MemeCreationRepository(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=MemeGenerator;Integrated Security=True;");
            MemeImage memeImage;
            MemeCreation = memeCreationRepo.GetRandomMeme(out memeImage);
            MemeImage = memeImage;
        }
    }
}