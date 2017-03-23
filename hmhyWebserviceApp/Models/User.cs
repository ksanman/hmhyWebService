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
        [Key]
        public int userKey { get; set; }
        public int userId { get; set; }
        [ForeignKey("userId")]
        public UserCredentials userCreds {get;set;}
        
        // Other user objects...
    }
}