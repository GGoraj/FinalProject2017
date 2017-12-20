using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using dreamstarter_web.Models.Entities;


namespace dreamstarter_web.Models.Repositories{

    public class UserRepository : IUserRepository
    {

        //Class Members
        private MyDbContext _db;
        private DbSet<User> _users;
      

        //Constructor
        public UserRepository(MyDbContext db)
        {
            _db = db;
            _users = db.Users;

        }


        public IEnumerable<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public User Get(User User)
        {
            foreach (var user in _users)
            {
                if(User.Password.Equals(User.Password)&& User.Email.Equals(User.Email)){
                    return User;
                }
                    
            }
            //if login&&pasword are incorrect or User doesn't exist
            return null;
        }


        public Boolean Save(User User)
        {
            IEnumerable<User> Users = _db.Users;

            //check if user already exists
            foreach (var item in Users)
            {
                if(item.Email.Equals(User.Email)){
                    Console.Write("\nUser already exists in Database************************" + "title: " + User.Email);
                    return false;//User not saved
                }

            }
                Console.Write("\nUser Saved to DB *******************************" + "title: " + User.Email);
                _db.Users.Add(User);
                _db.SaveChanges();
                return true; //User saved
        }

        public bool ValidateLogin(string email, string password){

            foreach (var user in _users)
            {
                if(email.Equals(user.Email) && password.Equals(user.Password)){
                    
                    return true; //validation approved
                }

            }
            return false; //validation failed
        }

        public int GetIdByEmail(string email){
            foreach(User user in _users){
                if(user.Email.Equals(email)){
                    return user.UserId;
                }
                
            }
            return -1;
        }

        public User GetUserById(int Id)
        {
            foreach(User user in _users){
                if(user.UserId == Id){
                    return user;
                }
            }
            return null;
        }

    }


}
