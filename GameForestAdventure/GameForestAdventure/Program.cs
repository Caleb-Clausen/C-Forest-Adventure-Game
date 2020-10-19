using System;
using GameForestAdventure.MenuObjects;
using GameForestAdventure.Player;
using System.Data.SqlClient;
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
            bool gameRunning = true;
            Menu newMenu = new Menu();
            newMenu.StartMenu();
            PlayerCharacter player1 = new PlayerCharacter(10, 20);
            SceneTown Actone = new SceneTown();
            while(gameRunning = true)
            {
                SceneTown.ScenceOne();
            }
            

        }
    }
}
