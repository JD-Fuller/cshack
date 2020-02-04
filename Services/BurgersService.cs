using System;
using System.Collections.Generic;
using cshack.DB;
using cshack.Models;

namespace cshack.Services
{
  public class BurgersService
  {
    public IEnumerable<Burger> Get()
    {
      return FAKEDB.Burgers;
    }

    public Burger GetById(string id)
    {
      Burger found = FAKEDB.Burgers.Find(elem => elem.Id == id);
      if (found == null)
      {
        throw new Exception("Invalid Id");
      }
      return found;
    }

    internal Burger Create(Burger newBurger)
    {
      FAKEDB.Burgers.Add(newBurger);
      return newBurger;
    }

    internal Burger Edit(Burger burgerUpdate)
    {
      var current = FAKEDB.Burgers.Find(elem => elem.Id == burgerUpdate.Id);
      if (current == null)
      {
        throw new Exception("Invalid Id");
      }
      FAKEDB.Burgers.Remove(current);
      FAKEDB.Burgers.Add(burgerUpdate);
      return burgerUpdate;
    }

    internal String Delete(string id)
    {
      var current = FAKEDB.Burgers.Find(elem => elem.Id == id);
      if (current == null)
      {
        throw new Exception("Invalid Id");
      }
      FAKEDB.Burgers.Remove(current);
      return "Successfully Deleted";
    }
  }
}