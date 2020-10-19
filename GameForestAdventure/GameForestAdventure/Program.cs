using System;
using GameForestAdventure.MenuObjects;
using GameForestAdventure.Player_And_Monsters;
using System.Data.SqlClient;
using GameForestAdventure.MenuObjects.DataHelper;

namespace GameForestAdventure
{
    class Program
    {
        // bool to keep track of game state
        public bool gameRunning = true;

        // enum to allow actions of the player and enemies
        public enum CombatActions { Attack, Run, Spell}
        // enum to allow movement of the player
        public enum Movement { Front, Left, Right, Back}
        static void Main(string[] args)
        {
            Map Test = new Map();
            Test.MapSave.Write("COOOOOOL");
            bool gameRunning = true;
            Menu newMenu = new Menu();
            newMenu.StartMenu();
            PlayerCharacter player1 = new PlayerCharacter("nice", 10, 20);
            SceneTown Actone = new SceneTown();
            while(gameRunning = true)
            {
                SceneTown.ScenceOne();
            }
            

        }
    }
}
