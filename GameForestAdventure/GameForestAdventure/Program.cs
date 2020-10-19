using System;
using GameForestAdventure.MenuObjects;
using GameForestAdventure.Player;
namespace GameForestAdventure
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Menu newMenu = new Menu();
            newMenu.StartMenu();
            PlayerCharacter player1 = new PlayerCharacter(10, 20);
            SceneTown Actone = new SceneTown();
            SceneTown.ScenceOne();
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World!");
        }
    }
}
