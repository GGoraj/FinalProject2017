using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace dreamstarter_web.Models.Entities {
    public class User{


        [Key]
        public int UserId{get; set;}
        public string Name {get; set;}
        public string Surname {get; set;}
        public string Town {get; set;}
        public string Postcode {get; set;}
        public string Street {get; set;}
        public string StreetNr {get; set;}
        public string Mobile {get; set;}
        public string Email {get; set;}
        public string Password {get; set;}
        public int Cpr {get; set;}
        public string ProfilePicture {get; set;}


        //navigation properties
        public virtual IEnumerable<Campaign> Campaigns { get; set; }

    }
}