using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static LoginReg.CustomValidators;


namespace LoginReg.Models
{
    public class Trip
    {
        [Key] // denotes PK, not needed if named ModelNameId
        public int TripId { get; set; }

        [Required(ErrorMessage = "is required.")]
        [MinLength(2, ErrorMessage = "must be at least 2 characters")]
        [Display]
        public string Destination { get; set; }

        [Required(ErrorMessage = "is required.")]
        [MinLength(2, ErrorMessage = "must be at least 2 characters")]
        public string Plan { get; set; }

        [FutureDate]
        public DateTime StartDate { get; set; }

        [FutureDate]
        public DateTime EndDate { get; set; }

        //create test in controller then set bool to true/false in there, next create custom validation that requires bool isAfter to be true
        // public bool isAfterStart {get; set;}

        //=========================================================================
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        //=========================================================================

//One User/Trip Guide to Many trips
        public int GuideId { get; set; }
        public User Guide { get; set; } 

//Many Users/Tourists to Many Guided Trips
        public List<UTRel> Tourists { get; set; }
    }


}