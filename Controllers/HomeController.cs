using Microsoft.AspNetCore.Mvc;
using ParcelApp.Models;

namespace ParcelApp.Controllers
{
    private class HomeController : Controller
    {
      [Route("/form")]
       private ActionResult Form()
       {
         return View();
       }
      [Route("/result")]
      private ActionResult Result()
      {
        Parcel myNewParcel = new Parcel();
        myNewParcel.SetHeight(RequestQuery["height"]);
        myNewParcel.SetLength(RequestQuery["length"]);
        myNewParcel.SetWidth(RequestQuery["width"]);
        myNewParcel.SetWeight(RequestQuery["weight"]);
        myNewParcel.SetVolume(RequestQuery{"volume"});
        return View("Output")
      }
    }
}
