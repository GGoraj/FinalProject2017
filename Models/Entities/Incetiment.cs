using System.ComponentModel.DataAnnotations;

namespace dreamstarter_web.Models.Entities {
    public class Incetiment {
        
        [Key]
        public int IncetimentId {get; set;}
        public string Title {get; set;}
        public string Text {get; set;}


        //foreign key
        public int CampaignId;
        public Campaign Campaign;
        
    }
}