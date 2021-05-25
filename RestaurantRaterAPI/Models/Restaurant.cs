using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RestaurantRaterAPI.Models
{
    public class Restaurant
    {
        [Key] // an annotation to designate property as primary key
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public double Rating { get; set; }

        public bool IsRecommended =>
                //bool isRecommended = Rating > 3.5;
                //return isRecommended;
                Rating > 3.5;  // shorter version of above.  pressing control period to shorten further
    }
    // This acts similar to our POCO from previous apps
    // Empty constructor is implicit;; we do not need to explicitly define it unless we have an overloaded constructor as well

    // Instead of POCO, we will hear the word 'entity', the objects that we create that we are saving to our database
}