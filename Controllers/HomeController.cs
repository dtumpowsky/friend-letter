using Microsoft.AspNetCore.Mvc;
using FriendLetter.Models;

namespace FriendLetter.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public ActionResult Letter()
        {
        LetterVariable myLetterVariable = new LetterVariable();
        myLetterVariable.SetRecipient("Jessica");
        myLetterVariable.SetLocation("Cleveland");
        myLetterVariable.SetItems("Hoola Hoop");
        return View(myLetterVariable);
        }

    }
}
