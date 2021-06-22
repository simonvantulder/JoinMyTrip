using System;
using System.ComponentModel.DataAnnotations;

namespace LoginReg.Models
{
    public class UTRel // Many Users/Tourists : Many Guided Trips
    {
        [Key] // Primary Key
        public int UTRelId { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        /**********************************************************************
        Relationship properties: foreign keys and navigation properties. 
        Navigation properties are null unless .Include is used. 
        "Object reference not set to an instance of an object"
        will be the error if accessed but not included. 
        **********************************************************************/
        public int UserTouristId { get; set; }
        public User UserTourist { get; set; } 
        public int GuidedTripId { get; set; }
        public Trip GuidedTrip { get; set; } 
    }
}