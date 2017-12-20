
using System.ComponentModel.DataAnnotations;

namespace dreamstarter_web.Models.Entities {

    public class Donation{


        [Key]
        public int DonationId;
        
        public double Amount;
        

        public int UserId; // donor
        

       //Foreign key

        public Campaign Campaign;
        public int CampaignId;

        

    }
}