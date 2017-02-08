using System;
using System.Collections.Generic;

namespace CarDealership.Objects
{
    public class Car
    {
        private string _model;
        private string _make;
        private string _color;
        private int _year;
        private int _miles;
        private int _price;
        private static List<Car> _carsList = new List<Car> {};

        public Car(string model, string make, string color, int year, int miles, int price)
        {
            _model = model;
            _make = make;
            _color = color;
            _year = year;
            _miles = miles;
            _price = price;
        }

        public string GetModel()
        {
            return _model;
        }

        public void SetModel(string newModel)
        {
            _model = newModel;
        }

        public string GetMake()
        {
            return _make;
        }

        public void SetMake(string newMake)
        {
            _make = newMake;
        }

        public string GetColor()
        {
            return _color;
        }

        public void SetColor(string newColor)
        {
            _color = newColor;
        }

        public int GetYear()
        {
            return _year;
        }

        public void SetYear(int newYear)
        {
            _year = newYear;
        }

        public int GetMiles()
        {
            return _miles;
        }

        public void SetMiles(int newMiles)
        {
            _miles = newMiles;
        }

        public int GetPrice()
        {
            return _price;
        }

        public void SetPrice(int newPrice)
        {
            _price = newPrice;
        }

        public void Save()
        {
            _carsList.Add(this);
        }

        public static List<Car> GetAll()
        {
            return _carsList;
        }

        public bool WorthBuying(int maxPrice, int maxMiles)
        {
            return (_price < maxPrice && _miles < maxMiles);
        }

        public static List<Car> searchCars(Car carCriteria)
        {
            List<Car> searchMatch = new List<Car> {};
            foreach (var nextCar in _carsList)
            {
                if (nextCar.GetModel() == carCriteria.GetModel())
                {
                    searchMatch.Add(nextCar);
                }
                else if (nextCar.GetMake() == carCriteria.GetMake())
                {
                    searchMatch.Add(nextCar);
                }
                else if (nextCar.GetColor() == carCriteria.GetColor())
                {
                    searchMatch.Add(nextCar);
                }
                else if (nextCar.GetYear() == carCriteria.GetYear())
                {
                    searchMatch.Add(nextCar);
                }
                else if (nextCar.GetMiles() == carCriteria.GetMiles())
                {
                    searchMatch.Add(nextCar);
                }
                else if (nextCar.GetPrice() == carCriteria.GetPrice())
                {
                    searchMatch.Add(nextCar);
                }
            }
            return searchMatch;
        }

    }

}
