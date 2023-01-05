using System;
using System.IO;
using System.Collections.Generic;


namespace lab2
{
    public class Program
    {
        public static void ClearCurrentConsoleLine()
        {
            // Очищає строку консолі після вводу
            int currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, Console.CursorTop);
            for (int i = 0; i < Console.WindowWidth; i++)
                Console.Write(" ");
            Console.SetCursorPosition(0, currentLineCursor);
            Console.SetCursorPosition(0, Console.CursorTop - 1);
        }

        static void Main(String[] args)
        {
            int menu_choise; 
            GameAccount FirstPlayer = new GameAccount();
            Console.WriteLine($"Enter first player name:");
            FirstPlayer.UserName = Console.ReadLine();

            GameAccount SecondPlayer = new GameAccount();
            Console.WriteLine($"Enter second player name:");
            SecondPlayer.UserName = Console.ReadLine();

            while (true) // Меню програми
            {
                Console.WriteLine("Choose what you want:\n1.Start the game\n2.Check the history\n3.Close the game\n");
                menu_choise = Convert.ToInt32(Console.ReadLine());
                ClearCurrentConsoleLine();
                if (menu_choise == 1) // Почати гру
                {
                    Console.WriteLine("Choose the game:\n1.Rating Game\n2.Training\n3.No-privilege Game\n");
                    menu_choise = Convert.ToInt32(Console.ReadLine());
                    var Game = new Game();
                    if(menu_choise == 1)
                    {
                        Game.RatingGame(FirstPlayer, SecondPlayer);
                    }
                    else if(menu_choise == 2)
                    {
                        Game.Training(FirstPlayer, SecondPlayer);
                    }
                    else if(menu_choise == 3)
                    {
                        Game.NoPrivilegeGame(FirstPlayer, SecondPlayer);
                    }
                    else
                    {
                        continue;
                    }
                    menu_choise = 1;
                }
                else if (menu_choise == 2) // Переглянути історію ігор
                {
                    FirstPlayer.GetStats();
                }
                else if (menu_choise == 3) // Закінчити гру
                {
                    Console.WriteLine("GoodBye!\n");
                    break;
                }
            }
        }
    }
}