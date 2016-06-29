using Nancy;
using CarLists.Objects;
using System.Collections.Generic;

namespace CarLists
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["add_new_cars.cshtml"];
       Get["/view_all_cars"] = _ => {
         List<Car> AllCars = Car.GetAll();
         return View["view_all_cars.cshtml", AllCars];
       };
      Post["/cars_added"] = _ => {
        Car newCar = new Car (
          Request.Form["new-make"],
          Request.Form["new-model"],
          Request.Form["new-year"],
          Request.Form["new-mileage"],
          Request.Form["new-price"],
          Request.Form["new-description"]
          );
        newCar.Save();
        return View["cars_added.cshtml", newCar];
      };

    }
  }
}
