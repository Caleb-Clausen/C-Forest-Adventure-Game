// This class is the overall Program helper to keep track of one game scene called SceneTown and all the values and actions associated with this stage
// Provides functionality to display a text based Scene that prints out ASCII town art on the console by calling ScenceOne()

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using GameForestAdventure.Player_And_Monsters;

namespace GameForestAdventure.MenuObjects
{
    class SceneTown
    {
        // StreamReader to open a file that has ASCII art in string form
        public StreamReader Town = new StreamReader("TownArt.txt");

        // ScenceOne() Accepts a PlayerCharacter object to pull the current name of the user and then builds a 2d text game scene to start the games story
        public void ScenceOne(PlayerCharacter currentPlayer)
        {
            // art holds the entire txt file to print out the ASCII art
            string art = Town.ReadToEnd();
            Town.Close();
            // Writes the current ASCII art to the terminal and then prompts the user to choose to go to the forest or go back to sleep
            Console.WriteLine(art);
            Console.WriteLine("You are starting your grand adventure from your humble house!");
            Console.WriteLine("Your significant other says it's time to go out and get a magic berry!");
            Console.WriteLine("You better head to the forest to go get the magic berry");
            Console.WriteLine("You have two choices, \n 1.rollover and sleep or \n 2.get out to the forest?");
            Console.WriteLine(" What will you do?");
            // if user choose 1 then the game ends as a joke and it sets the GameForestAdventure.Program enum to the next scene called exit
            if (Int32.Parse(Console.ReadLine()) == 1)
            {
                Console.WriteLine("Laziness has no place in the wild, sorry {0}, the game has already finished", currentPlayer.playerName);
                GameForestAdventure.Program.currentSceneWorld = GameForestAdventure.Program.CurrentScene.Exit;
                Console.ReadKey();
            }
            // if user choose 2 then the game ends and it sets the GameForestAdventure.Program enum to the next scene called Forest
            else
            {
                Console.WriteLine("You made the right choice!!! Off the forest, carefull there are bears and wolves out there");
                GameForestAdventure.Program.currentSceneWorld = GameForestAdventure.Program.CurrentScene.Forest;
            }

        }

    }
}

