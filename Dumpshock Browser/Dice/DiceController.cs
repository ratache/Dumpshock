using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dumpshock_Browser.Dice
{
    class DiceController
    {
        private List<Dice> diceList;
        private int successes, threshold, critical, failure = 0;

        public void initDicePool(int dices, int diceSize)
        {
            diceList = new List<Dice>();

            for(int i = 0; i < dices; i++)
            {
                diceList.Add(new Dice(diceSize));
            }

        }

        public void rollDicePool(int diff)
        {
            successes = 0;
            Random rnd = new Random();

            if (diceList.Count > 0)
            {
                for(int i = 0; i < diceList.Count; i++)
                {
                    int r = diceList[i].DiceRoll(rnd);

                    Console.WriteLine(r.ToString() + " ");//debug line
                    if (diceList[i].diceResult > diff)
                    {
                        successes++;
                    }
                }
            }
        }

        public int getSpecificDye(int index)
        {
            return diceList[index].diceResult;
        }

        public int getSuccesses()
        {
            return successes;
        }
    }
}
