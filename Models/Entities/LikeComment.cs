using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace dreamstarter_web.Models.Entities {
    public class LikeComment{


        [Key]
        public int LikeCommentId{get; set;}
        public int UserId {get; set;}
        

        //foreign key
        public int CommentId {get; set;}
        public CommentCampaign CommentCampaign {get; set;}


       
    }
}