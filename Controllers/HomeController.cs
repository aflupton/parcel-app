using Microsoft.AspNetCore.Mvc;
using ParcelApp.Models;

namespace ParcelApp.Controllers
{
    public class HomeController : Controller
    {
      [Route("/")]
       public ActionResult Form()
       {
         return View();
       }
      [Route("/result")]
      public ActionResult Result()
      {
        string inputHeight = Request.Query["height"];
        string inputLength = Request.Query["length"];
        string inputWidth = Request.Query["width"];
        string inputWeight = Request.Query["weight"];

        int validHeight = int.Parse(inputHeight);
        int validLength = int.Parse(inputLength);
        int validWidth = int.Parse(inputWidth);
        int validWeight = int.Parse(inputWeight);

        if (validHeight > 0 && validLength > 0 && validWidth > 0 && validWeight > 0) {
          Parcel newParcel = new Parcel();
          newParcel.SetHeight(Request.Query["height"]);
          newParcel.SetLength(Request.Query["length"]);
          newParcel.SetWidth(Request.Query["width"]);
          newParcel.SetWeight(Request.Query["weight"]);
          // newParcel.SetVolume();
          // newParcel.SetPrice();
          return View("Quote", newParcel);
          // return View("Quote", newParcel.SetPrice);

        } else {
          return View("Form");
        }


        // string inputVolume = newParcel.SetVolume(RequestQuery["volume"]);



      }
    }
}
