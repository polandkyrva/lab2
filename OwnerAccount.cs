using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class OwnerAccount : GameAccount
    {

        public OwnerAccount()
        {
            UserStatus = "Owner";
        }

        public override void WinGame(int rating, string opponentName)
        {
            GamesCount++;
            Console.WriteLine("\n" + UserName + " won!\n");
            History.Add(GamesCount + "\tWinner[" + UserStatus + "] - " + UserName + "\tLoser - " + opponentName + "\tRating - [+" + rating*2 + "]x2");
            CurrentRating += rating * 2;
            Console.WriteLine(UserName + " rating: " + CurrentRating + "\n");
        }
        public override void WinGame(int rating, string opponentName, Boolean IsWinstreak)
        {
            GamesCount++;
            Console.WriteLine("\n" + UserName + " won!\n");
            if(IsWinstreak is true)
            {
                History.Add(GamesCount + "\tWinner[" + UserStatus + "] - " + UserName + "\tLoser - " + opponentName + "\tRating - [+" + rating * 3 + "]x3");
                CurrentRating += rating * 3;
            }
            else
            {
                History.Add(GamesCount + "\tWinner[" + UserStatus + "] - " + UserName + "\tLoser - " + opponentName + "\tRating - [+" + rating * 3 + "]x1");
                CurrentRating += rating;
            }
            Console.WriteLine(UserName + " rating: " + CurrentRating + "\n");
        }

        public override void LoseGame(int rating, string opponentName)
        {
            GamesCount++;
            History.Add(GamesCount + "\tWinner - " + opponentName + "\tLoser - " + UserName + "\tRating - [-" + rating/4 + "](half of score)");
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
