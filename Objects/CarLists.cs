using System.Collections.Generic;

namespace CarLists.Objects
{
  public class Car
  {
    private string _make;
    private string _model;
    private string _year;
    private string _mileage;
    private string _price;
    private string _description;
    private static List<Car> _carList = new List<Car> {};

    public Car (string make, string model, string year, string mileage, string price, string description) {
      _make = make;
      _model = model;
      _year = year;
      _mileage = mileage;
      _price = price;
      _description = description;

    }
    public void SetMake(string newMake)
    {
      _make = newMake;
    }

    public string GetMake()
    {
      return _make;
    }
    public void SetModel(string newModel)
    {
      _model = newModel;
    }
    public string GetModel()
    {
      return _model;
    }

    public void SetYear(string newYear)
    {
    _year = newYear;
    }
    public string GetYear()
    {
    return _year;
    }

    public void SetMileage (string newMileage)
    {
    _mileage = newMileage;
    }
    public string GetMileage()
    {
    return _mileage;
    }

    public void SetPrice(string newPrice)
    {
      _price = newPrice;
    }
    public string GetPrice()
    {
      return _price;
    }

    public void SetDescription(string newDescription)
    {
      _description = newDescription;
    }
    public string GetDescription()
    {
      return _description;
    }

    public static List<Car> GetAll()
    {
      return _carList;
    }
    public void Save()
    {
      _carList.Add(this);
    }

    //
    // public static List<Car> AllCars(Car) {
    //
    // CarList.Add(Car);
    // }


  }
}
