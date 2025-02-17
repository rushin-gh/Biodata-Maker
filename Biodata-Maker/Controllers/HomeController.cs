using System;
using System.Web.Mvc;

using Biodata_Maker.Models;

using Rotativa;

namespace Biodata_Maker.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UserDataDisplay(User user)
        {
            var pdf = new ActionAsPdf(
                "GetHTML",
                new
                {
                    user.UserName,
                    user.UserDOB,
                    user.BirthPlace,
                    user.Height,
                    user.Color,
                    user.BloodGroup,
                    user.Education,
                    user.Occupation,
                    user.FatherName,
                    user.MotherName,
                    user.BrotherCount,
                    user.SisterCount,
                    user.Cast,
                    user.Kuladevata,
                    user.NativeAddress,
                    user.MobileNumber
                }
            )
            {
                FileName = "UserDetails.pdf",
                PageSize = Rotativa.Options.Size.A4,
            }; ;
            return pdf;
        }

        public ActionResult GetHTML(
            string userName,
            DateTime userDOB,
            string birthPlace,
            double height,
            string color,
            string bloodGroup,
            string education,
            string occupation,
            string fatherName,
            string motherName,
            int brotherCount,
            int sisterCount,
            string cast,
            string kuladevata,
            string nativeAddress,
            string mobileNumber
        )
        {
            User curUser = new User
            {
                UserName = userName,
                UserDOB = userDOB,
                BirthPlace = birthPlace,
                Height = height,
                Color = color,
                BloodGroup = bloodGroup,
                Education = education,
                Occupation = occupation,
                FatherName = fatherName,
                MotherName = motherName,
                BrotherCount = brotherCount,
                SisterCount = sisterCount,
                Cast = cast,
                Kuladevata = kuladevata,
                NativeAddress = nativeAddress,
                MobileNumber = mobileNumber
            };

            if (curUser != null)
            {
                return View("UserDataDisplay", curUser);
            }
            return View("Index");
        }
    }
}