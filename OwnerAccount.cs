using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class OwnerAccount : GameAccount
    {
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
