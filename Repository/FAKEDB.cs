using System.Collections.Generic;
using cshack.Models;

namespace cshack.DB
{
  static class FAKEDB
  {
    public static List<Burger> Burgers { get; set; } = new List<Burger>(){
                new Burger("The Mountain", 10)
            }; //NOTE TEMPORARY, DO NOT DO WHEN WE HAVE A DATABASE
  }
}