using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace dreamstarter_web.Models.ViewModels {

    public class LoginViewModel {

        [Required(ErrorMessage = "Email Address")]
        [MaxLength(20)]
        [DataType(DataType.EmailAddress)]
        public string Email{get; set;}

        
        [Required(ErrorMessage = "Enter Your Password")]
        [MaxLength(20)]
        [DataType(DataType.Password)]
        public string Password{get; set;}

        
    }
}