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
            Winner.WinGame(Rating, Loser.UserName);
        }
        else
        {
            Winner.WinGame(Rating, Loser.UserName);
        }

        Loser.LoseGame(Rating, Winner.UserName);
    }

    public void NoPrivilegeGameRating(GameAccount Winner, GameAccount Loser)
    {
        Random rand = new Random();
        Rating = rand.Next(10, 20);

        Winner.WinGame(Rating, Loser.UserName);
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
                Console.WriteLine("\nSecond player won!\n"); // Другий переміг
            }
            else
            {
                Console.WriteLine("\nFirst player won!\n"); // Перший переміг
            }
        }
        else if (FirstPlayer.Choise == 2) // Paper
        {
            if (SecondPlayer.Choise == 1)
            {
                Console.WriteLine("\nFirst player won!\n"); // Перший переміг
            }
            else if (SecondPlayer.Choise == 2)
            {
                Console.WriteLine("\nDraw! Try again!\n"); // Ничья
            }
            else
            {
                Console.WriteLine("\nSecond player won!\n"); // Другий переміг
            }
        }
        else // Scissors
        {
            if (SecondPlayer.Choise == 1)
            {
                Console.WriteLine("\nSecond player won!\n"); // Другий переміг
            }
            else if (SecondPlayer.Choise == 2)
            {
                Console.WriteLine("\nFirst player won!\n"); // Перший переміг
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

    public void NoPrivilegeGame(GameAccount FirstPlayer, GameAccount SecondPlayer)
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
                NoPrivilegeGameRating(SecondPlayer, FirstPlayer); // Другий переміг
            }
            else
            {
                NoPrivilegeGameRating(FirstPlayer, SecondPlayer); // Перший переміг
            }
        }
        else if (FirstPlayer.Choise == 2) // Paper
        {
            if (SecondPlayer.Choise == 1)
            {
                NoPrivilegeGameRating(FirstPlayer, SecondPlayer); // Перший переміг
            }
            else if (SecondPlayer.Choise == 2)
            {
                Console.WriteLine("\nDraw! Try again!\n"); // Ничья
            }
            else
            {
                NoPrivilegeGameRating(SecondPlayer, FirstPlayer); // Другий переміг
            }
        }
        else // Scissors
        {
            if (SecondPlayer.Choise == 1)
            {
                NoPrivilegeGameRating(SecondPlayer, FirstPlayer); // Другий переміг
            }
            else if (SecondPlayer.Choise == 2)
            {
                NoPrivilegeGameRating(FirstPlayer, SecondPlayer); // Перший переміг
            }
            else
            {
                Console.WriteLine("\nDraw! Try again!\n"); // Ничья
            }
        }
    }
}