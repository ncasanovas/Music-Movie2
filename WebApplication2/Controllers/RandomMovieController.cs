using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;
using System.Data.SqlClient;

namespace WebApplication2.Controllers
{
    public class RandomMovieController : Controller
    {

        private MusicMovieContext db = new MusicMovieContext();

        // GET: RandomMovie
        public ActionResult RandomHappy()
        {

            


            return View(db.Movies.FirstOrDefault(m => m.Mood_ID == 1));


        }
        public ActionResult RandomPassionate()
        {

            

            
            return View(db.Movies.FirstOrDefault(m => m.Mood_ID == 2));


        }
        public ActionResult RandomMelancholic()
        {




            return View(db.Movies.FirstOrDefault(m => m.Mood_ID == 3));


        }
        public ActionResult RandomPeaceful()
        {
            


            return View(db.Movies.FirstOrDefault(m => m.Mood_ID == 4));

            
        }
    }
}