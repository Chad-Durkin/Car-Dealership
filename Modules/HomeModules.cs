using System;
using System.Collections.Generic;
using Nancy;
using CarDealership.Objects;

namespace CarDealership
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/"] = _ => View["index.cshtml"];

            Get["/add_car_form"] = _ => View["addCar.cshtml"];

            Post["/addCar"] = _ => {
                Car newCar = new Car(
                    Request.Form["carModel"],
                    Request.Form["carMake"],
                    Request.Form["carColor"],
                    Request.Form["carYear"],
                    Request.Form["carMile"],
                    Request.Form["carPrice"]
                );
                newCar.Save();
                return View["addCar.cshtml"];
            };

            Get["/carListing"] = _ => {
                List<Car> allCars = Car.GetAll();
                return View["carListing.cshtml", allCars];
            };


            Get["/searchCar"] = _ => {
                    return View["searchCar.cshtml"];
            };
            // Get["/searchResult"] = _ => {
            //     Car findCar = new Car();
            //     findCar.SetModel(Request.Query["carModel"]);
            //     findCar.SetMake(Request.Query["carMake"]);
            //     findCar.SetColor(Request.Query["carColor"]);
            //     findCar.SetYear(Request.Query["carYear"]);
            //     findCar.SetMiles(Request.Query["carMile"]);
            //     findCar.SetPrice(Request.Query["carPrice"]);
            //     List<Car> matchedCars = Car.searchCars(findCar);
            //     return View["searchResult.cshtml", matchedCars];
            // };
        }
    }
}
