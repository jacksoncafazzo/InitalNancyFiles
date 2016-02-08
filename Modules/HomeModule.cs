using Nancy;
using Cars.Objects;

namespace Cars
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/form"] = _ => {
        return View["form.html"];
      };
      Get["/cars"] = _ => {
        CarVariables myCarVariables = new CarVariables
        {
          MakeModel = Request.Query["makeModel"],
          Price = Request.Query["price"],
          Miles = Request.Query["miles"],
          Condition = Request.Query["condition"]
        };
        return View["cars.html", myCarVariables];
      };
    }
  }
}
