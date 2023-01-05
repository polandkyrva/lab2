using System;
using System.Collections.Generic;
namespace lab2;
#nullable disable

class GameAccount
{
    protected virtual string UserName = " ";
    public int CurrentRating = 0;
    public int GamesCount = 0;
    public int Choise;
    public int UserStatus;
    public List<string> History = new List<string>();

    private Boolean _IsComputer = false;
    private int _WinStreakCounter = 1;
    private string _WinStreakUserName;


    public int GetSecondPlayer()
    {
        int second_player;
        Console.WriteLine("Do you want to add second player?\n Yes - 1\n No - 2");
        second_player = Convert.ToInt32(Console.ReadLine());
        if (second_player == 1)
        {
            Console.WriteLine($"Enter second player name:");
            UserName = Console.ReadLine();
            return 1;
        }
        else
        {
            _IsComputer = true;
            UserName = "Computer";
            UserStatus = 1;
            return 2;
        }
    }
       
    public void GetStats()
    {
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
        if (rating >= 20) // Якщо рейтинг з бонусом
        {
            if(UserStatus == 2)
            {
                History.Add(GamesCount + "\tWinner - " + UserName + "\tLoser - " + opponentName + "\tRating - [+" + rating / 2 + "]x2");
            }
            else if(UserStatus == 3) 
            {
                History.Add(GamesCount + "\tWinner - " + UserName + "\tLoser - " + opponentName + "\tRating - [+" + rating / 3 + "]x3");
            }
        }
        else 
        { 
        History.Add(GamesCount + "\tWinner - " + UserName + "\tLoser - " + opponentName + "\tRating - [+" + rating + "]");
        }
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
        if(_IsComputer is true)
        {
            Random rand = new Random();
            Choise = new Random().Next(1, 4);
        }
        else
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

}
