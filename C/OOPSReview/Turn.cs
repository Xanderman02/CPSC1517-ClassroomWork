using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSReview
{
    public class Turn
    {
        // auto implimented properties
        public int Player1 { get; set; }
        public int Player2 { get; set; }

        // the next segment is optional

        public Turn()
        {
            
        }

        public Turn(int player1, int player2)
        {
            Player1 = player1;
            Player2 = player2;
        }

    }
}
