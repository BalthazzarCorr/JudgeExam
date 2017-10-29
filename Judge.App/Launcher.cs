namespace Judge.App
{
   using Data;
   using Microsoft.EntityFrameworkCore;
   using SimpleMvc.Framework;
   using SimpleMvc.Framework.Routers;
   using WebServer;

   class Launcher
    {
       static Launcher()
       {
          using (var db = new JudgeDbContext())
          {
             db.Database.Migrate();
          }
       }

        static void Main(string[] args)
        {
           MvcEngine.Run(new WebServer(3232, new ControllerRouter(), new ResourceRouter()));
      }
    }
}
