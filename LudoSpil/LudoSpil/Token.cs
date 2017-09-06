using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LudoSpil
{
    public class Token
    {
        private gameColor color;
        public Token(gameColor clr)
        {
            this.color = clr;
        }
        public gameColor GetColor()
        {
            return this.color;
        }
    }
}
