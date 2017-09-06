using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LudoSpil
{
    public class Dice
    {
        private int diceValue;

        public Dice()
        {
            this.ThrowDice();
        }

        public int ThrowDice()
        {
            Random rnd = new Random();
            this.diceValue = rnd.Next(1, 7);

            return this.diceValue;
        }

        //Looks at the dice and reads its value
        public int GetDiceValue()
        {
            return this.diceValue;
        }
    }
}
