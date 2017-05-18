using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wojna
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game(new Player("Kulek"), new Player("Buba"));
            game.Play(1000);
            Console.ReadKey();
        }
    }
}
