using System;
using System.Collections.Generic;

namespace ShipYard.Models
{
  public class Parcel
  {
    public int Length { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }
    public int Weight { get; set; }
    public int Volume { get; set; }
    public double Cost { get; set; }

    private static List<Parcel> _instances = new List<Parcel> {};


    public Parcel(int length, int width, int height, int weight)
    {
      Length = length;
      Width = width;
      Height = height;
      Weight = weight;
      Volume = Volume1();
      Cost = CostToShip();
      _instances.Add(this);
    }

    public static List<Parcel> GetAll()
    {
      return _instances;
    }
    public int Volume1()
    {
      return this.Length * this.Width * this.Height;
    }

    public double CostToShip()
    {
      return (this.Volume * this.Weight) * .3;
    }
  }
}