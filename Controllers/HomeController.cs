using System.Globalization;
using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class HomeController: Controller//controller diye bir şey yoktu ama biz mvc özelliğinden yararlanmak istediğimiz için controllera soldaki ampule tıklayarak tanımladık ve artık homecontroller bir controller olma yeteneği kazandı.
    {
        //localhost
        //localhost/home
         //localhost/home/index
        public IActionResult Index()
        {
            int time = DateTime.Now.Hour;
            
            ViewData["Greeting"]= time > 12 ? "Have a good day":"Good Morning";
            int UserCount = Repository.Users.Where(info=> info.WillYouAttend == true).Count();
            //ViewData["UserName"]= "Behiye";

            var meetingInfo = new Meetinginfo()
            {
                Id = 1,
                Location = "Gdansk, Old Town",
                Date = new DateTime(2023,12,17,20,0,0),
                NumberOfPeople = UserCount
            };

            return View(meetingInfo);
        } 
    }
}