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
    public class HistorialMoviesController : Controller
    {
        private MusicMovieContext db = new MusicMovieContext();
        
        // GET: HistorialMovies
        public ActionResult HistorialMovies()
            
        {
            var historialMovies = db.Movies.OrderBy(c => Guid.NewGuid()).ToList();
            


            return View(historialMovies.ToList());
        }
    }
}