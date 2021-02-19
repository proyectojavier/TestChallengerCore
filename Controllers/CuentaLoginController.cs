using ChallengerCore.Models;
using Firebase.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace ChallengerCore.Controllers
{
    public class CuentaLoginController : Controller
    {
        private static string apiKEY = "AIzaSyAR1xn9seN6ID_IQBxU2FzAeDFlOAs7qZw";
        // GET: CuentaLogin

        public ActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<ActionResult> SignUp(SignUpModel model)
        {
            try
            {
                var autho = new FirebaseAuthProvider(new FirebaseConfig(apiKEY));

                var a = await autho.CreateUserWithEmailAndPasswordAsync(model.Email, model.Password, model.Name, true);
                ModelState.AddModelError(string.Empty, "Please Verify your email");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
            }

            return View();
        }
        // GET: CuentaLogin/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CuentaLogin/Edit/5
      

        // POST: CuentaLogin/Delete/5
       
    }
}
