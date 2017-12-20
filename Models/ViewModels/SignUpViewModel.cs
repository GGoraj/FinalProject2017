using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace dreamstarter_web.Models.ViewModels {
    public class SignUpViewModel{


        [Key]
        public int UserId{get; set;}

        
        [Required(ErrorMessage = "First Name")]
        [MaxLength(15)]
        public string Name {get; set;}


        
        [Required(ErrorMessage = "Last Name")]
        [MaxLength(15)]
        public string Surname {get; set;}

        
        [Required(ErrorMessage = "Town")]
        [MaxLength(15)]
        public string Town {get; set;}

        [Required(ErrorMessage = "Postcode")]
        [MaxLength(12)]
        public string Postcode {get; set;}

        [Required(ErrorMessage = "Street")]
        [MaxLength(20)]
        public string Street {get; set;}


        [Required(ErrorMessage = "Street Number")]
        [MaxLength(10)]
        public string StreetNr {get; set;}

        [Required(ErrorMessage = "Mobile Phone Number")]
        [StringLength(8, MinimumLength = 8)]
        //[DataType(DataType.PhoneNumber)]
        public string Mobile {get; set;}

        
        [Required(ErrorMessage = "Email Address")]
        [MaxLength(20)]
        [DataType(DataType.EmailAddress)]
        public string Email {get; set;}

        
        [Required(ErrorMessage = "Enter Your Password")]
        [MaxLength(20)]
        [DataType(DataType.Password)]
        public string Password {get; set;}

    }
}