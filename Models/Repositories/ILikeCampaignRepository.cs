namespace dreamstarter_web.Models.Repositories{
    public interface ILikeCampaignRepository{


        //if user liked this campaign already- return false ->> else return true
        bool LikeCampaign(int UserId, int CampaignId);
        bool IsCampaignLiked(int UserId, int CampaignId);
        int NumberOfLikes(int CampaignId);
        void RemoveLike(int UserId, int CampaignId);


    }
}