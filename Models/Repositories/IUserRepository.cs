using System.Collections.Generic;
using dreamstarter_web.Models.Entities;

namespace dreamstarter_web.Models.Repositories{

    public interface IUserRepository
    {
         // Basic Crud opreation
       IEnumerable<User> GetAll();
       User Get(User user);//used for authorization
       User GetUserById(int Id);
       bool Save(User User);

       bool ValidateLogin(string email, string password);
       int GetIdByEmail(string email);
       
       
    } 

    
}