using System;

namespace dreamstarter_web.Models.ViewModels{

    public class DetailCampaignViewModel{

        public int CampaignId { get; set; }
        public string Title {get; set;}
        public string ThemeImageFileName {get; set;}
        public double AmountRequired {get; set;}
        public double AmountRaised {get; set;}
        public string Synopsis {get; set;}
        public string DetailDescription {get; set;}
        public int PercentDone {get; set;}
        public DateTime EndDate { get; set; }
        public int DaysLeft {get; set;}
        public int NumberOfLikes{get; set;} // number of likes displayed on page reload
        public int UserId {get; set;} // to whom is detail campaign displayed

    }
}