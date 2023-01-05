using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class OwnerAccount : GameAccount
    {

        public void WinGame(int rating, string opponentName, Boolean IsMultiplie)
        {
            GamesCount++;
            Console.WriteLine("\n" + UserName + " won!\n");
            History.Add(GamesCount + "\tWinner - " + UserName + "\tLoser - " + opponentName + "\tRating - [+" + rating / 2 + "]x2");
            if (IsMultiplie is true)
            {
                CurrentRating += rating * 3;
            }
            else
            {
                CurrentRating += rating;
            }
            Console.WriteLine(UserName + " rating: " + CurrentRating + "\n");
        }

        public override void LoseGame(int rating, string opponentName)
        {
            GamesCount++;
            History.Add(GamesCount + "\tWinner - " + opponentName + "\tLoser - " + UserName + "\tRating - [-" + rating + "]");
            if (CurrentRating - rating / 4 >= 0)
            {
                CurrentRating -= rating / 4;
            }
            else
            {
                CurrentRating = 0;
            }

            Console.WriteLine(UserName + " rating: " + CurrentRating + "\n");
        }

    }
}
