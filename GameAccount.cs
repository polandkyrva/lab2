using System;
using System.Collections.Generic;
namespace lab2;
#nullable disable

class GameAccount
{
    public string UserName = " ";
    public int CurrentRating = 0;
    public int GamesCount = 0;
    public int Choise;
    public string UserStatus;
    public List<string> History = new List<string>();

    private int _WinStreakCounter = 1;
    private string _WinStreakUserName;


    public GameAccount()
    {
        UserStatus = "User";
    }

       
    public void GetStats()
    {
        Console.WriteLine("\n" + UserName + " history:\n");
        for (int i = 0; i < History.Count; i++)
        {
            Console.WriteLine(History[i]);
        }
    }

    public Boolean IsWinStreak(GameAccount Loser)
    {
        if (Equals(UserName, _WinStreakUserName) is true)
        {
            _WinStreakCounter++;
            if (_WinStreakCounter >= 3)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nWinstreak multiplie.\n");
                Console.ResetColor();
                return true;
            }
        }
        else
        {
            Loser._WinStreakUserName = "";
            _WinStreakUserName = UserName;
            Loser._WinStreakCounter = 1;
            _WinStreakCounter = 1;
        }
        return false;
    }

    public virtual void WinGame(int rating, string opponentName)
    {
        GamesCount++;
        Console.WriteLine("\n" + UserName + " won!\n");
        History.Add(GamesCount + "\tWinner[" + UserStatus + "] - " + UserName + "\tLoser - " + opponentName + "\tRating - [+" + rating + "]");
        CurrentRating += rating;
        Console.WriteLine(UserName + " rating: " + CurrentRating + "\n");
    }
    public virtual void WinGame(int rating, string opponentName, Boolean IsWinstreak)
    {
        GamesCount++;
        Console.WriteLine("\n" + UserName + " won!\n");
        History.Add(GamesCount + "\tWinner[" + UserStatus + "] - " + UserName + "\tLoser - " + opponentName + "\tRating - [+" + rating + "]");
        CurrentRating += rating;
        Console.WriteLine(UserName + " rating: " + CurrentRating + "\n");
    }

    public virtual void LoseGame(int rating, string opponentName)
    {
        GamesCount++;
        History.Add(GamesCount + "\tWinner - " + opponentName + "\tLoser - " + UserName + "\tRating - [-" + rating + "]");
        if (CurrentRating - rating/2 >= 0)
        {
            CurrentRating -= rating/2;
        }
        else
        {
            CurrentRating = 0;
        }

        Console.WriteLine(UserName + " rating: " + CurrentRating + "\n");
    }


    public void GetPlayerChoise()
    {
        Choise = 0;
        while (Choise != 1 && Choise != 2 && Choise != 3)
        {
            Console.WriteLine("Rock - 1\tPaper - 2\tScissors - 3\n" + UserName + ", enter your choise:");
            Choise = Convert.ToInt32(Console.ReadLine());
            Program.ClearCurrentConsoleLine();
        }
    }
}
