using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace hmhyWebserviceApp.Models
{
    public class UserCredentials
    {
        [Key]
        public int userId { get; set; }
        [Required]
        public string userName { get; set; }
        public string password { get; set; }
    }
}