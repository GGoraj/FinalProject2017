using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using dreamstarter_web.Models.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace dreamstarter_web.Models.ViewModels {

    public class NewCampaignViewModel{

        

        // //video
        // public string VideoTitle {get; set;}
        // public string VideoUrl {get; set;}

       
        [Required]
        public string Title {get; set;}

        //photo
        [Required]
        public IFormFile PhotoFile {get; set;}

        [Required]
        public string Synopsis{get; set;}
        [Required]
        public double AmountRequired {get; set;}

       [Required]
        public string DetailDescription{get; set;}

        //no model validation here
        public DateTime StartDate {get; set;}

        [Required]
        public DateTime EndDate {get; set;}

    
        
        

        
    }
}