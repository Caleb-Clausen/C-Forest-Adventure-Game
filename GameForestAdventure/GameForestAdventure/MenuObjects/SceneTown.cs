using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using GameForestAdventure.Player_And_Monsters;

namespace GameForestAdventure.MenuObjects
{
    class SceneTown
    {
        
        public StreamReader Town = new StreamReader("TownArt.txt");
        public void ScenceOne(PlayerCharacter currentPlayer)
        {
            string art = Town.ReadToEnd();
            Town.Close();
            Console.WriteLine(art);
            Console.WriteLine("You are starting your grand adventure from your humble house!");
            Console.WriteLine("Your significant other says it's time to go out and get some berries!");
            Console.WriteLine("You better head to the forest to go get some barries");
            Console.WriteLine("You have two choices, 1.roll over and sleep or 2.get out to the forest?");
            Console.WriteLine("What will you do?");
            if (Int32.Parse(Console.ReadLine()) == 1)
            {
                Console.WriteLine("Laziness has no place in the wild, sorry {0}, the game has already finished", currentPlayer.playerName);
                GameForestAdventure.Program.currentSceneWorld = GameForestAdventure.Program.CurrentScene.Exit;
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("You made the right choice!!! Off the the forest, carefull there are bears and wolves out there");
                GameForestAdventure.Program.currentSceneWorld = GameForestAdventure.Program.CurrentScene.Forest;
            }
            
        }

    }
}
