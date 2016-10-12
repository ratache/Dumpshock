using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dumpshock_Browser.Dice
{
    public class Dice
    {
        private int diceSize;
        private bool rolled = false;
        private int result;
        
        public Dice()
        {
            diceSize = 6;
        }
        public Dice(int diceMax)
        {
            diceSize = diceMax;
        }

        /// <summary>
        /// This method rolls the dices in the pool.
        /// We have a couple of values here. 
        /// Failure = the threshold value for a failed roll
        /// Critical = the threshold value for a superb roll (usually max)
        /// Success = the threshold value for a successful roll
        /// 
        /// </summary>
        /// <param name="rnd"></param>
        /// <returns></returns>
        public int DiceRoll(Random rnd)
        {
            result = rnd.Next(1, diceSize + 1); // creates a number between 1 and DiceMax

            rolled = true;
                           
            return diceResult;
        }

        public bool isRolled()
        {
            return rolled;
        }

        public int diceResult
        {
            get { return result; }         
        }
    }

}
