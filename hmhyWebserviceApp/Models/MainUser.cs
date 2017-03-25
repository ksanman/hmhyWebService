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
        public bool priviledge { get; set; }
        public int goalId { get; set; }
        public int noteId { get; set; }
        public int calendarId { get; set; }
        public int userGroupId { get; set; }
        // Other user objects...

        [Required]       
        [Key]
        public int userId { get; set; }
        [ForeignKey("userId")]
        public UserCredentials userCreds {get;set;}
     
    }
}