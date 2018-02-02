using dreamstarter_web.Controllers;
using dreamstarter_web.Models.Entities;
using dreamstarter_web.Models.Repositories;

namespace dreamstarter_web.Utilities{

    public class UserLogger : IUserLogger
    {
        private IUserRepository _userRepository;
        private User User {get; set;}

        public UserLogger(IUserRepository userRepository){
            _userRepository = userRepository;
        }

        public bool IsLoggedIn()
        {
            int userId = AccountController.UserId;
            if(AccountController.UserId!=0){
                User = _userRepository.GetUserById(userId);
            return true;
            }
            else return false;
        }


        public string Name()
        {
            return User.Name;
        }


        public string ProfilePicture()
        {
            return User.ProfilePicture;
        }
    }
}