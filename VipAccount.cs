using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class VipAccount : GameAccount
    {

        public VipAccount()
        {
            UserStatus = "VIP";
        }

        public override void WinGame(int rating, string opponentName)
        {
            GamesCount++;
            Console.WriteLine("\n" + UserName + " won!\n");
            History.Add(GamesCount + "\tWinner[" + UserStatus + "] - " + UserName + "\tLoser - " + opponentName + "\tRating - [+" + rating + "]");
            CurrentRating += rating;
            Console.WriteLine(UserName + " rating: " + CurrentRating + "\n");
        }

        public override void WinGame(int rating, string opponentName, Boolean IsWinstreak)
        {
            GamesCount++;
            Console.WriteLine("\n" + UserName + " won!\n");
            if(IsWinstreak is true)
            {
                History.Add(GamesCount + "\tWinner[" + UserStatus + "] - " + UserName + "\tLoser - " + opponentName + "\tRating - [+" + rating * 2 + "]x2");
                CurrentRating += rating * 2;
            }
            else
            {
                History.Add(GamesCount + "\tWinner[" + UserStatus + "] - " + UserName + "\tLoser - " + opponentName + "\tRating - [+" + rating + "]x1");
                CurrentRating += rating;
            }
            Console.WriteLine(UserName + " rating: " + CurrentRating + "\n");
        }
    }
}
