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
            var FirstPlayer = new GameAccount();
            Console.WriteLine($"Enter first player name:");
            FirstPlayer.UserName = Console.ReadLine();

            var SecondPlayer = new OwnerAccount();
            Console.WriteLine($"Enter second player name:");
            SecondPlayer.UserName = Console.ReadLine();

            while (true) // Меню програми
            {
                Console.WriteLine("Choose what you want:\n1.Start the game\n2.Check the history\n3.Close the game\n");
                menu_choise = Convert.ToInt32(Console.ReadLine());
                if (menu_choise == 1) // Почати гру
                {
                    Console.WriteLine("Choose the game:\n1.Rating Game\n2.Training\n3.No-privilege Game\n");
                    menu_choise = Convert.ToInt32(Console.ReadLine());
                    ClearCurrentConsoleLine();
                    var Game = new Game();
                    switch(menu_choise)
                    {
                        case 1: Game.RatingGame(FirstPlayer, SecondPlayer); break;
                        case 2: Game.Training(FirstPlayer, SecondPlayer); break;
                        case 3: Game.NoMultiplieGame(FirstPlayer, SecondPlayer); break;
                    }
                    menu_choise = 1;
                }
                else if (menu_choise == 2) // Переглянути історію ігор
                {
                    Console.WriteLine("Choose player history:\n1." + FirstPlayer.UserName + "\n2." + SecondPlayer.UserName + "\n3.Back to menu\n");
                    menu_choise = Convert.ToInt32(Console.ReadLine());
                    ClearCurrentConsoleLine();
                    switch (menu_choise)
                    {
                        case 1: FirstPlayer.GetStats(); break;
                        case 2: SecondPlayer.GetStats(); break;
                        case 3: continue;
                    }
                    menu_choise = 1;
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