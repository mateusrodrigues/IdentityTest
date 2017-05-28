using System;
using System.ComponentModel.DataAnnotations;

namespace IdentityTest.Auth.Models.ViewModels
{
    public class RegisterViewModel
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
        [EmailAddress]
        public string Email
        {
            get;
            set;
        }

        [Required]
        public string Password
        {
            get;
            set;
        }
    }
}
