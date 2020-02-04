using System;
using System.ComponentModel.DataAnnotations;

namespace cshack.Models
{
  public class Burger
  {
    public string Name { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }
    public int Id { get; set; }


    public Burger(string name, string description, int price)
    {
      Name = name;
      Price = price;
      Description = description;
    }
  }
}