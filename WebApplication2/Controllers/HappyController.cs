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
    public class HappyController : Controller
    {
        private MusicMovieContext db = new MusicMovieContext();
        // GET: Happy
        public ActionResult Choose()
        {
            return View();
        }
    }
}