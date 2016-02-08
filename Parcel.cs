using System;
using System.Collections.Generic;

class Parcel
{
  private int _height;
  private int _width;
  private int _depth;
  private int _weight;

  public void SetHeight(int newHeight)
  {
    _height = newHeight;
  }
  public int GetHeight()
  {
    return _height;
  }

  public void SetWidth(int newWidth)
  {
    _width = newWidth;
  }
  public int GetWidth()
  {
    return _width;
  }

  public void SetDepth(int newDepth)
  {
    _depth = newDepth;
  }
  public int GetDepth()
  {
    return _depth;
  }

  public void SetWeight(int newWeight)
  {
    _weight = newWeight;
  }
  public int GetWeight()
  {
    return _weight;
  }
}

public class Program
{
  public static void Main()
  {
    Parcel newParcel = new Parcel();
    newParcel.SetHeight(10);
    newParcel.SetWidth(12);
    newParcel.SetDepth(6);
    newParcel.SetWeight(4);
    Console.WriteLine("New parcel dimensions: ");
    Console.WriteLine("Parcel Height: " + newParcel.GetHeight());
    Console.WriteLine("Parcel Width: " + newParcel.GetWidth());
    Console.WriteLine("Parcel Depth: " + newParcel.GetDepth());
    Console.WriteLine("Parcel Weight: " + newParcel.GetWeight());
  }
}
