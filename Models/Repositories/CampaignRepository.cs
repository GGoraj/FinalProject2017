using System;
using System.Collections.Generic;
using dreamstarter_web.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace dreamstarter_web.Models.Repositories{

    public class CampaignRepository : ICampaignRepository
    {
        //Class Members
        private MyDbContext _db;
        private DbSet<Campaign> _campaigns;
      

        //Constructor
        public CampaignRepository(MyDbContext db)
        {
            _db = db;
            _campaigns = db.Campaigns;

        }

        public IEnumerable<Campaign> GetAllCampaigns()
        {
            return _campaigns;
        }

        public IEnumerable<Campaign> GetAllByUserId(int userId)
        {
             List<Campaign> usersCampaigns = new List<Campaign>();
            foreach(var campaign in _campaigns){
                if(campaign.UserId.Equals(userId)){
                    usersCampaigns.Add(campaign);
                }
            }
            if(usersCampaigns.Equals(null)) {
                return null;
            }
            else return usersCampaigns;
        }


       

        public Campaign GetSingleCampaign(Campaign campaign)
        {
            foreach(var item in _campaigns){
                if(item.Equals(campaign)) {
                    return campaign;
                }
            }
            return null;
        }

       
        public Campaign GetCampaignById(int CampaignId)
        {
            foreach(var Campaign in _campaigns){
                if(Campaign.CampaignId==CampaignId){
                    return Campaign;
                }
            }
            return null;
        }

       

         public void Delete(int campaignId)
        {
            Campaign camp = GetCampaignById(campaignId);
            _campaigns.Remove(camp);
            _db.SaveChanges();
        }


        public void Update(Campaign campaign)
        {
            throw new System.NotImplementedException();
        }


        public bool Save(Campaign campaign)
        {
            _campaigns.Add(campaign);
            _db.SaveChanges();
            return true;
            
        }
    }
}