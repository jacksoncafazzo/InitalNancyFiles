using System;
using System.Collections.Generic;

class Car
{
  private string _makeModel;
  private int _price;
  private int _miles;
  private string _condition;

  public void SetMakeModel(string newMakeModel)
  {
    _makeModel = newMakeModel;
  }
  public string GetMakeModel()
  {
    return _makeModel;
  }

  public void SetPrice(int newPrice)
  {
    _price = newPrice;
  }
  public int GetPrice()
  {
    return _price;
  }

  public void SetMiles(int newMiles)
  {
    _miles = newMiles;
  }
  public int GetMiles()
  {
    return _miles;
  }

  public void SetCondition(string newCondition)
  {
    _condition = newCondition;
  }
  public string GetCondition()
  {
    return _condition;
  }

}



public class Program
{
  public static void Main()
  {
    // Car porsche = new Car("2014 Porsche 911", 114991, 7864);
    // Car ford = new Car("2011 Ford F450", 55995, 14241);
    // Car lexus = new Car("2013 Lexus RX 350", 44700, 20000);
    // Car mercedes = new Car("Mercedes Benz CLS550", 39900, 37979);
    // Car jalopy = new Car("Uncle Beater's Ride", 500, 250000, "Beater");

    Car newCar = new Car();
    newCar.SetMakeModel("Chevy Crossover");
    newCar.SetMiles(83000);
    newCar.SetPrice(15000);
    newCar.SetCondition("Good");
    Console.WriteLine(newCar.GetMakeModel());
    Console.WriteLine("Miles: " + newCar.GetMiles());
    Console.WriteLine("Price: $" + newCar.GetPrice());
    Console.WriteLine("Condition: " + newCar.GetCondition());
    Console.WriteLine(newCar.GetMakeModel() + " is in " + newCar.GetCondition() + " condition.");




    // Console.WriteLine("Enter maximum price: ");
    // string stringMaxPrice = Console.ReadLine();
    // int maxPrice = int.Parse(stringMaxPrice);
    //
    // Console.WriteLine("Enter maximum miles: ");
    // string stringMaxMiles = Console.ReadLine();
    // int maxMiles = int.Parse(stringMaxMiles);


  }
}
