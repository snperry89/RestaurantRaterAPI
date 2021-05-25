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

        public virtual List<Rating> Ratings { get; set; } = new List<Rating>();

        public double Rating
        {
            get
            {
                double totalAverageRating = 0;

                foreach (Rating rating in Ratings)
                {
                    totalAverageRating = rating.AverageRating;
                }
                return totalAverageRating / Ratings.Count;
            }
        }

        public bool IsRecommended => Rating > 7.5;
        //bool isRecommended = Rating > 7.5;
        //return isRecommended;
        // longer version of above.  pressing control period  offers suggestions to shorten further
    }
    // This acts similar to our POCO from previous apps
    // Empty constructor is implicit;; we do not need to explicitly define it unless we have an overloaded constructor as well

    // Instead of POCO, we will hear the word 'entity', the objects that we create that we are saving to our database
}