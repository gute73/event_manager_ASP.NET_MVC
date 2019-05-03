using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EventManager.Models
{
    public class Event
    {
        [Key]
        public int EventID { get; set; }

        [Required]
        [StringLength(30)]
        public string Title { get; set; }

        [Required]
        [StringLength(250)]
        public string Location { get; set; }

        [Required]
        public DateTime EventDate { get; set; }

        [Required]
        [DataType(DataType.Time)]
        public DateTime EventTime { get; set; }

        [StringLength(250)]
        public string Description { get; set; }

        public string ApplicationUserID { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }

        public virtual ICollection<Registration> Registrations { get; set; }
    }
}