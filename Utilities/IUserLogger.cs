namespace dreamstarter_web.Utilities {
    public interface IUserLogger {
       
        bool IsLoggedIn();
        string ProfilePicture();
        string Name();

    }
}