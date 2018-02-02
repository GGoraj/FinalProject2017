using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace dreamstarter_web.Models.Entities {
    public class LikeCampaign{


        [Key]
        public int LikeCampaignId {get; set;}

        public int UserId {get; set;}

         //foreign key
        public int CampaignId {get; set;}
        public Campaign Campaign {get; set;}



    }
}