using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EventManager.Models
{
    public class Registration
    {
        [Key]
        public int RegistrationID { get; set; }

        public int EventID { get; set; }

        public string ApplicationUserID { get; set; }
    }
}