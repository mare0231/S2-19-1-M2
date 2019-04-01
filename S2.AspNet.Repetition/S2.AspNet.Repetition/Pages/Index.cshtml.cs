﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using S2.AspNET.Repetition.DAL;
using S2.AspNET.Repetition.Entities;

namespace S2.AspNet.Repetition.Pages
{
    public class IndexModel : PageModel
    {
        public List<MemeImage> MemeImages { get; set; }
        public void OnGet()
        {
            MemeImageRepository memeImageRepo = new MemeImageRepository(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=MemeGenerator;Integrated Security=True;");
            MemeImages = memeImageRepo.GetAllMemeImages();
        }
    }
}