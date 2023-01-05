using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class VipAccount : GameAccount
    {

        public void WinGame(int rating, string opponentName, Boolean IsMultiplie)
        {
            GamesCount++;
            Console.WriteLine("\n" + UserName + " won!\n");
            History.Add(GamesCount + "\tWinner - " + UserName + "\tLoser - " + opponentName + "\tRating - [+" + rating / 2 + "]x2");
            if(IsMultiplie is true)
            {
                CurrentRating += rating * 2;
            }
            else
            {
                CurrentRating += rating;
            }
            Console.WriteLine(UserName + " rating: " + CurrentRating + "\n");
        }
    }
}
