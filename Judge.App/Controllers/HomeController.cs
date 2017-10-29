namespace Judge.App.Controllers
{
   using Services;
   using Services.Contracts;
   using SimpleMvc.Framework.Contracts;

   public class HomeController:BaseController
   {
      private readonly IUserService users;

      public HomeController()
      {
         this.users = new UserService();
      }

      public IActionResult Index()
      {
         this.ViewModel["userName"] = this.users;
         return this.View();
      }
   }
}
