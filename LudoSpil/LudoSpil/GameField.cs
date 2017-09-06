using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LudoSpil
{
    public enum FieldType { Home, Safe, InPlay, Finish}
    class GameField
    {
        private gameColor color;
        private int FieldId;
        private Token[] Tokens = new Token[2];

        public GameField(gameColor clr, int id)
        {
            this.color = clr;
            this.FieldId = id;
        }

        /*public bool PlaceToken(Token tkn)
        {
            if (Tokens.Any())
            {
                //See if field has any token on it
            }
            else
            {
                //If there is no token in the field ID place the token
                Tokens[0] = tkn;
            }
        }*/
    }
}
