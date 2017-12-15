using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class MelancholicController : Controller
    {
        private MusicMovieContext db = new MusicMovieContext();
        
        // GET: Melancholic
        public ActionResult Choose()
        {
            List<Mood> moodList = db.Moods.ToList();
            
            ViewBag.Moods = moodList;

            return View(db.Movies.ToList());
            
        }

       
    }
}