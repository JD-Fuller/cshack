using System;
using System.Collections.Generic;
using cshack.DB;
using cshack.Models;

namespace cshack.Services
{
  public class BurgersService
  {

    private readonly BurgersRepository _repo;

    public BurgersService(BurgersRepository br)
    {
      _repo = br;
    }



    public IEnumerable<Burger> Get()
    {
      return _repo.Get();
    }

    public Burger GetById(int id)
    {
      var exists = _repo.GetById(id);
      if (exists == null)
      {
        throw new Exception("Invalid Id");
      }
      return exists;
    }

    internal Burger Create(Burger newData)
    {
      //business rules can go here
      _repo.Create(newData);
      return newData;
    }

    internal Burger Edit(Burger update)
    {
      var exists = _repo.GetById(update.Id);
      if (exists == null)
      {
        throw new Exception("Invalid Id");
      }
      _repo.Edit(update);
      // _repo.Burgers.Add(burgerUpdate);
      return update;
    }

    internal String Delete(int id)
    {
      var exists = _repo.GetById(id);
      if (exists == null)
      {
        throw new Exception("Invalid Id");
      }
      _repo.Delete(id);
      return "Successfully Deleted";
    }
  }
}