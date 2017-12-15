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
        public ActionResult Happy()
        {

            


            return View();


        }
        public ActionResult Passionate()
        {

            


            return View();


        }
        public ActionResult Melancholic()
        {

           


            return View();


        }
        public ActionResult Peaceful()
        {
            


            return View();

            
        }
    }
}