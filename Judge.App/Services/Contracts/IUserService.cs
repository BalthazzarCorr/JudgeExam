namespace Judge.App.Services.Contracts
{
   using ViewModels.Users;

   public interface IUserService
    {
      bool Create(string email, string password, string name);

      bool UserExists(string email, string password);

      LoginModel GetById(int id);
   }
}
