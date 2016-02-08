using Nancy;
using Parcels.Objects;

namespace Parcels
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/form"] = _ => {
        return View["form.html"];
      };
      Get["/parcels"] = _ => {
        ParcelVariables myParcelVariables = new ParcelVariables
        {
          Height = Request.Query["height"],
          Width = Request.Query["width"],
          Depth = Request.Query["depth"],
          Weight = Request.Query["weight"]
        };
        return View["parcels.html", myParcelVariables];
      };
    }
  }
}
