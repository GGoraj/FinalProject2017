using System.Collections.Generic;
using dreamstarter_web.Models.Entities;

namespace dreamstarter_web.Models.Repositories{

    public interface ICampaignRepository
    {
        // Basic Crud opreation
        IEnumerable<Campaign> GetAllCampaigns();
        IEnumerable<Campaign> GetAllByUserId(int userId);
        Campaign GetSingleCampaign(Campaign campaign);
        Campaign GetCampaignById(int campaignId);
        void Delete(int campaignId);
        void Update(Campaign campaign);
        bool Save(Campaign campaign);
        double MakeDonation(int campaignId, double amount);
    } 
}