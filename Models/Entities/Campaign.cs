using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace dreamstarter_web.Models.Entities {
    public class Campaign{


        [Key]
        public int CampaignId { get; set; }
        public string Title {get; set;}
        public string ThemeImageFileName {get; set;}
        public double AmountRequired {get; set;}
        public double AmountRaised {get; set;}
        public string Synopsis {get; set;}
        public string DetailDescription {get; set;}
        public DateTime StartDate {get; set;}
        public DateTime EndDate { get; set; }
        public bool IsFinished {get; set; }

       //foreign key to User
       public User User { get; set; }
       public int UserId { get; set; }

        //navigation properties
        public virtual IEnumerable<CommentCampaign> Comments {get; set;}
        public virtual IEnumerable<LikeCampaign> Likes {get; set;}
 
        

        
    }
}