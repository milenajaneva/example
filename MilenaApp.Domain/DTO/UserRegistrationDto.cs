﻿using System.ComponentModel.DataAnnotations;

namespace MilenaApp.Domain.DTO
{
    public class UserRegistrationDto
    {
        [Required(ErrorMessage = "Name is required!!!")]
        [StringLength(200)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Name is required!!!")]
        [StringLength(200)]
        public string LastName { get; set; }

        [EmailAddress(ErrorMessage = "Invalid email address!!!")]
        [Required(ErrorMessage = "Email is required!!!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password is required!!!")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm password is required!!!")]
        [Compare("Password", ErrorMessage = "The Password and Confirm Password do not match.")]
        public string ConfirmPasswword { get; set; }

        public string PhoneNumbeer { get; set; }
    }
}