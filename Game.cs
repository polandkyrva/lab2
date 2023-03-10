using System;
using System.IO;
using System.Collections.Generic;
namespace lab2;


class Game
{
    private int Rating;

    public void GameRating(GameAccount Winner, GameAccount Loser)
    {
        Random rand = new Random();
        Rating = rand.Next(10, 20);

        if (Winner.IsWinStreak(Loser) is true) // Якшо винстрик
        {
            Winner.WinGame(Rating, Loser.UserName, true);
        }
        else
        {
            Winner.WinGame(Rating, Loser.UserName);
        }

        Loser.LoseGame(Rating, Winner.UserName);
    }

    public void NoMultiplieGameRating(GameAccount Winner, GameAccount Loser)
    {
        Random rand = new Random();
        Rating = rand.Next(10, 20);

        Winner.WinGame(Rating, Loser.UserName, false);
        Loser.LoseGame(Rating, Winner.UserName);
    }

    // Rock Paper Scissors
    // Rock - 1    Paper - 2    Scissors - 3
    public void Training(GameAccount FirstPlayer, GameAccount SecondPlayer)
    {
        FirstPlayer.GetPlayerChoise();
        SecondPlayer.GetPlayerChoise();

        if (FirstPlayer.Choise == 1)
        {
            if (SecondPlayer.Choise == 1) // Rock
            {
                Console.WriteLine("\nDraw! Try again!\n"); // Ничья
            }
            else if (SecondPlayer.Choise == 2)
            {
                Console.WriteLine("\n" + SecondPlayer.UserName + " won!\n"); // Другий переміг
            }
            else
            {
                Console.WriteLine("\n" + FirstPlayer.UserName + " won!\n"); // Перший переміг
            }
        }
        else if (FirstPlayer.Choise == 2) // Paper
        {
            if (SecondPlayer.Choise == 1)
            {
                Console.WriteLine("\n" + FirstPlayer.UserName + " won!\n");  // Перший переміг
            }
            else if (SecondPlayer.Choise == 2)
            {
                Console.WriteLine("\nDraw! Try again!\n"); // Ничья
            }
            else
            {
                Console.WriteLine("\n" + SecondPlayer.UserName + " won!\n"); // Другий переміг
            }
        }
        else // Scissors
        {
            if (SecondPlayer.Choise == 1)
            {
                Console.WriteLine("\n" + SecondPlayer.UserName + " won!\n"); ; // Другий переміг
            }
            else if (SecondPlayer.Choise == 2)
            {
                Console.WriteLine("\n" + FirstPlayer.UserName + " won!\n"); // Перший переміг
            }
            else
            {
                Console.WriteLine("\nDraw! Try again!\n"); // Ничья
            }
        }
    }

    public void RatingGame(GameAccount FirstPlayer, GameAccount SecondPlayer)
    {   
        FirstPlayer.GetPlayerChoise();
        SecondPlayer.GetPlayerChoise();

        if (FirstPlayer.Choise == 1)
        {
            if (SecondPlayer.Choise == 1) // Rock
            {
                Console.WriteLine("\nDraw! Try again!\n"); // Ничья
            }
            else if (SecondPlayer.Choise == 2)
            {
                GameRating(SecondPlayer, FirstPlayer); // Другий переміг
            }
            else
            {
                GameRating(FirstPlayer, SecondPlayer); // Перший переміг
            }
        }
        else if (FirstPlayer.Choise == 2) // Paper
        {
            if (SecondPlayer.Choise == 1)
            {
                GameRating(FirstPlayer, SecondPlayer); // Перший переміг
            }
            else if (SecondPlayer.Choise == 2)
            {
                Console.WriteLine("\nDraw! Try again!\n"); // Ничья
            }
            else
            {
                GameRating(SecondPlayer, FirstPlayer); // Другий переміг
            }
        }
        else // Scissors
        {
            if (SecondPlayer.Choise == 1)
            {
                GameRating(SecondPlayer, FirstPlayer); // Другий переміг
            }
            else if (SecondPlayer.Choise == 2)
            {
                GameRating(FirstPlayer, SecondPlayer); // Перший переміг
            }
            else
            {
                Console.WriteLine("\nDraw! Try again!\n"); // Ничья
            }
        }
    }

    public void NoMultiplieGame(GameAccount FirstPlayer, GameAccount SecondPlayer)
    {
        FirstPlayer.GetPlayerChoise();
        SecondPlayer.GetPlayerChoise();

        if (FirstPlayer.Choise == 1)
        {
            if (SecondPlayer.Choise == 1) // Rock
            {
                Console.WriteLine("\nDraw! Try again!\n"); // Ничья
            }
            else if (SecondPlayer.Choise == 2)
            {
                NoMultiplieGameRating(SecondPlayer, FirstPlayer); // Другий переміг
            }
            else
            {
                NoMultiplieGameRating(FirstPlayer, SecondPlayer); // Перший переміг
            }
        }
        else if (FirstPlayer.Choise == 2) // Paper
        {
            if (SecondPlayer.Choise == 1)
            {
                NoMultiplieGameRating(FirstPlayer, SecondPlayer); // Перший переміг
            }
            else if (SecondPlayer.Choise == 2)
            {
                Console.WriteLine("\nDraw! Try again!\n"); // Ничья
            }
            else
            {
                NoMultiplieGameRating(SecondPlayer, FirstPlayer); // Другий переміг
            }
        }
        else // Scissors
        {
            if (SecondPlayer.Choise == 1)
            {
                NoMultiplieGameRating(SecondPlayer, FirstPlayer); // Другий переміг
            }
            else if (SecondPlayer.Choise == 2)
            {
                NoMultiplieGameRating(FirstPlayer, SecondPlayer); // Перший переміг
            }
            else
            {
                Console.WriteLine("\nDraw! Try again!\n"); // Ничья
            }
        }
    }
}