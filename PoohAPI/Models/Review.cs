﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PoohAPI.Models
{
    /// <summary>
    /// Class with review information for a company.
    /// </summary>
    public class Review
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int CompanyId { get; set; }
        [Required]
        public int UserId { get; set; }
        [Range(1.0, 5.0)]
        [Required]
        public double Stars { get; set; }
        public string WrittenReview { get; set; }
        /// <summary>
        /// This property denotes if a review has been verified by the company/internship coordinator.
        /// </summary>
        public bool VerifiedReview { get; set; }
        public DateTime CreationDate { get; set; }
        /// <summary>
        /// Denotes whether or not the review has been Locked. Locked reviews can no longer be deleted or edited throught the API.
        /// </summary>
        public bool Locked
        {
            get
            {
                return CreationDate.AddHours(72) < DateTime.Now ? true : false;
            }
        }
    }
}
