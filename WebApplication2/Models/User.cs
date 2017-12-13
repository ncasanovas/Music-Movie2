using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class User
    {

        [Key]
        public string Mail { get; set; }
        public string Password { get; set; }
    }
}