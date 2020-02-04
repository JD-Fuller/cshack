using System;
using System.ComponentModel.DataAnnotations;

namespace cshack.Models
{
  public class Burger
  {
    public string Id { get; set; }
    [Required]
    [MinLength(2)]
    [MaxLength(100)]
    public string Name { get; set; }
    [Range(0, 1000)]
    public int Price { get; set; }


    public Burger()
    {
      Id = Guid.NewGuid().ToString();
    }
    public Burger(string name, int price)
    {

      Name = name;
      Price = price;
      Id = Guid.NewGuid().ToString(); //NOTE makes Globaly Unique ID
    }
  }
}