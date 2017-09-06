using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LudoSpil
{
    public class Player
    {
        private string name;
        private string color;
        public Token[] PlayerToken = new Token[4];


        //Constructor for new player
        public Player(string playerName, string playerColor)
        {
            //Sets the playername
            this.name = playerName;
            this.color = playerColor;
        }

        //returns name
        public string GetName
        {
            get
            {
                return this.name;
            }
        }
        public string GetColor
        {
            get
            {
                return this.color;
            }
        }
    }
}
