// This program genertates an active console based game that allows player movment accross the consolse on a 2d array string based grid
// The player can select differnt options to interact with the world around him through the consele window
// The end objective for the player is to kill all monsters on the 2d map and return home to his house to feed his family 
// Main actions are movement, skill usage, saving and loading, grids.
//
//
using System;
using GameForestAdventure.MenuObjects;
using GameForestAdventure.Player_And_Monsters;
using System.Data.SqlClient;
using GameForestAdventure.MenuObjects.DataHelper;
using System.IO;
using System.Linq;
namespace GameForestAdventure
{
    class Program
    {
        
        
        // bool to keep track of game state
        public bool gameRunning = true;

        // enum to allow skills of the player and enemies
        public enum CombatActions { Attack, Spellattack, Punch, Clawattack}
        public enum CurrentScene { Town, Forest, Menu}
        CurrentScene currentSceneWorld = new CurrentScene();
        static void Main(string[] args)
        {
            CurrentScene currentSceneWorld = new CurrentScene();
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
            PlayerCharacter player1 = new PlayerCharacter(newMenu.Playername, 10, 20);
            Monster wolf = new Monster("Wolf", 10, 20,forestMap);
            Monster bear = new Monster("bear", 10, 20, forestMap);
            Monster wolf1 = new Monster("Wolf", 10, 20, forestMap);
            Monster bear1 = new Monster("bear", 10, 20, forestMap);
            Monster wolf2 = new Monster("Wolf", 10, 20, forestMap);
            Monster bear2 = new Monster("bear", 10, 20, forestMap);
            SceneTown Actone = new SceneTown();
            forestMap.totalMap[player1.ReturnPos().X, player1.ReturnPos().Y] = "p";
            while (gameRunning == true)
            {
                switch (currentSceneWorld)
                {
                    case CurrentScene.Forest:
                        return;
                    case CurrentScene.Menu:
                        return;
                    case CurrentScene.Town:
                        forestMap.DisplayMap();
                        forestMap.PlayerMovement(player1, forestMap);
                        return;

                }

            
                //SceneTown.ScenceOne();
            }
            

        }
    }
}
