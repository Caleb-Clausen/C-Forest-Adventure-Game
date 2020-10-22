// This program genertates an active console based game that allows player movment accross the consolse on a 2d array string based grid
// The player can select differnt options to interact with the world around him through the consele window
// The end objective for the player is to kill all monsters on the 2d map and return home to his house to feed his family with a magic berry
// Main actions are movement, skill usage, saving and loading, grids and diffvert scences progression

using System;
using GameForestAdventure.MenuObjects;
using GameForestAdventure.Player_And_Monsters;
using System.Data.SqlClient;
using GameForestAdventure.MenuObjects.DataHelper;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.ExceptionServices;
using System.Collections.Generic;

namespace GameForestAdventure
{
    class Program
    {
        
        
        // bool to keep track of game state
        public bool gameRunning = true;

        // enum to allow skills of the player and enemies
        public enum CombatActions { Attack, Spellattack, Punch, Clawattack}
        // enum to represent all scences in the game for the player to move through 
        public enum CurrentScene { Town, Forest, Menu, Exit, ForestWithBerry }
        public static CurrentScene currentSceneWorld = new CurrentScene();
        static void Main(string[] args)
        {
           
           
            //Create a new map and call the SetMapState to create the 2d array from the text file in current working directory
            Map forestMap = new Map();
            forestMap.SetMapState();
            // Bool to check the game state
            bool gameRunning = true;
            // Create a new menu to be called and prompt the user if he wishes to load/play/exit application
            Menu newMenu = new Menu();
            newMenu.StartMenu();
            currentSceneWorld = CurrentScene.Town;
            //Create the objects that will be displayed by the forestMap.totalMap[] field
            // PlayerCharacter is the user, Monster, the NPC class 
            PlayerCharacter player1 = new PlayerCharacter(newMenu.playerName, 10, 20);
            // Create a list to hold monsters, speed up process of populating map
            List<Monster> totalmonsters = new List<Monster>();
            int monsterCount = 2;
            while (monsterCount < 5)
            {
                Monster wolf = new Monster("Wolf", 10, 20, forestMap);
                Monster bear = new Monster("bear", 10, 20, forestMap);
                totalmonsters.Add(wolf);
                totalmonsters.Add(bear);
                monsterCount = monsterCount + 2;
            }


            // Create a town sence to get the character options rolling
            SceneTown Actone = new SceneTown();
           // Set the starting player posistion 
            forestMap.totalMap[player1.ReturnPos().X, player1.ReturnPos().Y] = "p";
           
           //Main while loop to control the flow of the players choices and scence magagemnt
            while (gameRunning == true)
            {
                // Switch to check the enum CurrentScene and use cases to find current scence 
                switch (currentSceneWorld)
                {
                    // If the current enum is == Town move the console scene to the town scence then continue
                    case CurrentScene.Town:
                        Actone.ScenceOne(player1);
                        continue;
                    // If the current enum is == Forest, display the map continously and update the player on the console in the 2d map array forestMap.Display()
                    case CurrentScene.Forest:
                        forestMap.DisplayMap();
                        forestMap.PlayerMovement(player1, forestMap);
                        // Checks to see if the berry has been found in the 2d map array forestMap.totalMap[x,y], if found change to new state with berry displayed on map
                        if (forestMap.CheckBerryReady(forestMap) == true)
                        {
                            currentSceneWorld = CurrentScene.ForestWithBerry;
                            forestMap.totalMap[2, 7] = "B";
                            Console.WriteLine("The Bery has arpeared! go get it to finish this quest of livelyhood, press any key to continue");
                            Console.ReadKey();
                        }
                        continue;
                        //Checks to see if all the monsters are vanquaisehd and When the berry is found the game ends while in this scene
                    case CurrentScene.ForestWithBerry:
                        forestMap.DisplayMap();
                        forestMap.PlayerMovement(player1, forestMap);
                        // Checks to see if the berry has been found in this scene, is true then switch currentSceneWorld = CurrentScene.Exit
                        if (forestMap.CheckBerryFound(forestMap) == true)
                        {
                            Console.WriteLine("Great Job {0}, You have survived wolf attacks and bear attacks, you are well on your way to surviving this winter!", player1.playerName);
                            Console.WriteLine("Until next time, Adventure awaits! Ciao Ciao");
                            Console.ReadKey();
                            currentSceneWorld = CurrentScene.Exit;
                            
                        }
                        continue;
                        // TODO: Allows the player to go back to the menu
                    case CurrentScene.Menu:
                        return;
                        // When the currentSceneWorld == CurrentScene.Exit, change the gamerunning to false and end the program
                    case CurrentScene.Exit:
                        gameRunning = false;
                        return;
  

                }
            }
        }
    }
}
