﻿using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace IdentityTest.Auth.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [MaxLength(100)]
        public string FirstName
        {
            get;
            set;
        }

        [Required]
        [MaxLength(100)]
        public string LastName
        {
            get;
            set;
        }

        [Required]
        public DateTime JoinDate
        {
            get;
            set;
        }
    }
}
