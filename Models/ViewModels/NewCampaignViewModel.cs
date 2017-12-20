using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using dreamstarter_web.Models.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace dreamstarter_web.Models.ViewModels {

    public class NewCampaignViewModel{
       
        public string Title {get; set;}

        //photo
        public IFormFile PhotoFile {get; set;}
        public string Synopsis{get; set;}
        public double AmountRequired {get; set;}

       
        public string DetailDescription{get; set;}
        public DateTime StartDate {get; set;}

        public DateTime EndDate {get; set;}

    
        
        

        
    }
}