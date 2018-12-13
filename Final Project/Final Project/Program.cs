using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero myHero = new Hero("Tony", "the Tiger", true);
            Hero myOtherHero = new Hero("Flash", "Zoom", "Human", "Speed", true);
            Hero thirdHero = new Hero("Wonder Woman", "All bad people", "Amazonian", "Stength, Speed, Fly");

            /*
                Problem 7:
                Each Hero must:
                 - Investigate
                 - FightCrime (at least one must win. at least one must not win)
                 - Fly (at least one superhero should be able to fly)
                 - Climb
            */

            myHero.ChargePower();
            myHero.Investigate();
            myHero.FightCrime("The Bank");
            myHero.Climb(10);

            myOtherHero.ChargePower();
            myOtherHero.Investigate();
            myOtherHero.FightCrime("The Sky");
            myOtherHero.Fly();
            myOtherHero.Climb(50);

            thirdHero.ChargePower();
            thirdHero.Investigate();
            thirdHero.FightCrime("The Stadium");
            thirdHero.Fly();
            thirdHero.Climb(100);
        }
    }
}