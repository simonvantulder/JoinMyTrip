using System;
using System.ComponentModel.DataAnnotations;

namespace LoginReg.Models
{
    public class UARel // Many Users/Tourists : Many Guided Trips
    {
        [Key] // Primary Key
        public int UARelId { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        /**********************************************************************
        Relationship properties: foreign keys and navigation properties. 
        Navigation properties are null unless .Include is used. 
        "Object reference not set to an instance of an object"
        will be the error if accessed but not included. 
        **********************************************************************/
        public int UserParticipantId { get; set; }
        public User UserParticipant { get; set; } 
        public int LedActivityId { get; set; }
        
        // public Game LedActivity { get; set; } 
    }
}