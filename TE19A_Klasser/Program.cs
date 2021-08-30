using System;

namespace TE19A_Klasser
{
  class Program
  {
    static void Main(string[] args)
    {
      
      Enemy goomba = new Enemy();
      Enemy fireFlower = new Enemy();

      goomba.x = 200;

      Console.WriteLine(fireFlower.x);

      Console.ReadLine();
    }
  }
}
