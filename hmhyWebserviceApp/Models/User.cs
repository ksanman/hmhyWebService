using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace hmhyWebserviceApp.Models
{
    public class MainUser
    {
        [Required]
        public int userId { get; set; }
        public UserCredentials userCreds {get;set;}
        
        // Other user objects...
    }
}