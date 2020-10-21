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
        // enum to allow movement of the player
        public enum Movement { Front, Left, Right, Back}
        static void Main(string[] args)
        {
            Map forestMap = new Map();
            forestMap.SetMapState();

            bool gameRunning = true;

            Menu newMenu = new Menu();
            newMenu.StartMenu();
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

                forestMap.DisplayMap();
                forestMap.PlayerMovement(player1, forestMap);
                //SceneTown.ScenceOne();
            }
            

        }
    }
}
