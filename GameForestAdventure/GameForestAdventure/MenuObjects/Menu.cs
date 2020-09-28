using System;
using GameForestAdventure.Player;
namespace GameForestAdventure.MenuObjects
{
    public class Menu
    {
        int playerChoice;
        bool menuOpen = true;
        public Menu()
        {
            playerChoice = 0;
        }
        public void StartMenu()
        {
            while (menuOpen)
            {
                Console.WriteLine("Welcome to the game menu!");
                Console.WriteLine("here are the current Menu choices");
                Console.WriteLine("(1) Play");
                Console.WriteLine("(2) Load Game");
                Console.WriteLine("(3) Exit Game");
                playerChoice = Convert.ToInt32(Console.ReadLine());
                if (playerChoice.Equals(1) == true) {
                    Console.Clear();
                    Console.WriteLine("You start game!");
                    menuOpen = false;

                }
                else if(playerChoice.Equals(2) == true)
                {
                    Console.Clear();
                    Console.WriteLine("Loading...");
                    
                }
                else if (playerChoice.Equals(3) == true)
                {
                    Console.Clear();
                    menuOpen = false;
                }
            }
        }
    }
}
