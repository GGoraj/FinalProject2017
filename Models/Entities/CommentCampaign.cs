using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace dreamstarter_web.Models.Entities {
    public class CommentCampaign{


        [Key]
        public int CommentId{get; set;}

        [Required(ErrorMessage = "Fill out campaigns description")]
        [MaxLength(300)]
        public string Text {get; set;}


        //foreign key
        public int CampaignId {get; set;}
        public Campaign Campaign {get; set;}

        //navigation properties
        //public virtual IEnumerable<LikeComment> LikedComments;


       
    }
}