using System;
using dreamstarter_web.Models.Entities;
using Microsoft.EntityFrameworkCore;


namespace dreamstarter_web.Models.Repositories{
    public class LikeCampaignRepository : ILikeCampaignRepository{

        //Class Members
        private MyDbContext _db;
        private DbSet<LikeCampaign> _campaignLikes;
      

        //Constructor
        public LikeCampaignRepository(MyDbContext db)
        {
            _db = db;
            _campaignLikes = db.CampaignLikes;

        }

        //checking if campaign is liked already
        public bool IsCampaignLiked(int UserIdFromView, int CampaignIdFromView)
        {
            foreach(LikeCampaign like in _campaignLikes){
                if((like.UserId == UserIdFromView) && (like.CampaignId == CampaignIdFromView)){
                  
                    return true;
                }
            }
            return false;
        }

        //if like exists - remove it and return false
        //else - add new like and return true
        public bool LikeCampaign(int UserIdFromView, int CampaignIdFromView)
        {
            
           if(IsCampaignLiked(UserIdFromView, CampaignIdFromView)){
                    RemoveLike(UserIdFromView, CampaignIdFromView);
                    return false;
           }
           else {
               LikeCampaign lc = new LikeCampaign{
                            UserId = UserIdFromView,
                            CampaignId = CampaignIdFromView
                        };

                _campaignLikes.Add(lc);
                _db.SaveChanges();
                return true;
           }
            
        }

        public int NumberOfLikes(int CampaignIdInput)
        {
            int likes = 0;
            foreach(LikeCampaign like in _campaignLikes){
                
                //if liked campaignId equals to currently viewed campaign
                //increment number of likes by 1
                if(like.CampaignId == CampaignIdInput){
                    likes++;
                }
            }
            return likes;
        }

        public void RemoveLike(int UserId, int CampaignId){
            foreach(LikeCampaign lc in _campaignLikes){
                if(lc.UserId==UserId && lc.CampaignId == CampaignId){
                    _campaignLikes.Remove(lc);
                    _db.SaveChanges();
                }
            }
        }

       
    }
}