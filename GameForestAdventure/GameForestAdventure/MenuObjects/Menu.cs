// This class is the overall Program helper to keep track of the menu for the user and allows him to play, load and exit the game
// Provides functionality to display a text based menu on the console by calling StartMenu()

using System;
namespace GameForestAdventure.MenuObjects

{
    public class Menu
    {
        // playerChoice holds the choice of the player to Play, load or exit the game
        int playerChoice;

        // playerName holds the string representation of the player
        public string playerName { get; set; }

        // menuOpen holds a bool representation of the menu being opened or closed
        bool menuOpen = true;

        // StartMenu() keeps a console based and user based menu open for the user to select which action the program takes next
        public void StartMenu()
        {
            // While loop to keep the menu open
            while (menuOpen)
            {
                // Prompts the user to select the next option by displaying text to the console screen
                Console.WriteLine("Welcome to the game menu!");
                Console.WriteLine("Here are the current Menu choices");
                Console.WriteLine("(1) Play");
                Console.WriteLine("(2) Load Game");
                Console.WriteLine("(3) Exit Game");
                playerChoice = Convert.ToInt32(Console.ReadLine());
                // Checks the playerChoice integer against three if and if else statements to either Play, Load or exit game
                // if playerChoice == 1 start the game
                if (playerChoice.Equals(1) == true)
                {
                    Console.Clear();
                    Console.WriteLine("Please input your character name");
                    playerName = Console.ReadLine();
                    Console.WriteLine("You start game!");
                    menuOpen = false;

                }
                //TODO: Need to make a new text file and write Map.total to a new file if playerChoice == 2 load an older game
                else if (playerChoice.Equals(2) == true)
                {
                    Console.Clear();
                    Console.WriteLine("Loading...");

                }
                // if playerChoice == 3 exit the game
                else if (playerChoice.Equals(3) == true)
                {
                    Console.Clear();
                    menuOpen = false;
                }
            }
        }
    }
}

