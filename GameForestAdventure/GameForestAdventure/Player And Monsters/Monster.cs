// This Class is the overall Program helper to create an object that represents a generic monster, attributes can be specified on object creation
// Implements the IGenericCharacterActions interface
// Provides functionality to override the default constructor adding Monster (string monsterName, int monsterHealth, int monsterMana, Map currentmap)
// Provides functionality to set the x and y coordinates in the Map.totalMap[,] array on current object calling MonsterMapPostion()
// Provides functionality to provide the x and y coordinates in the form of a Point object by calling ReturnPos()
// Provides functionality to set the x and y coordinates for the point object monster Location located in the current object

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using GameForestAdventure;
using GameForestAdventure.MenuObjects.DataHelper;

namespace GameForestAdventure.Player_And_Monsters
{

    class Monster : IGenericCharacterActions
    {
        // Random number generator to make random coordinates for the monster Location x and y positions
        Random randomonsterlocation = new Random();

        // Point object to hold the monsters x and y coordinates to allow it to be tracked in 2d Map.totalMap[,] arrays
        Point monsterLocation = new Point(0, 0);
       private string monsterName;
       private int monsterHealth;
       private int monsterMana;

        // Default constructor override to allow for monster name, monster health, monstermana and currentmap to be part of the instance
        public Monster(string monsterName, int monsterHealth, int monsterMana, Map currentmap)
        {
            this.monsterName = monsterName;
            this.monsterHealth = monsterHealth;
            this.monsterMana = monsterMana;
            MonsterMapPostion(currentmap);

        }

        // Sets the monsters position in the currentmap.totalMap[x,y] coordinates to show up on when written to the console
        public void MonsterMapPostion(Map currentmap)
        {
            this.SetPos(randomonsterlocation.Next(1, 25), randomonsterlocation.Next(1, 25));
            currentmap.totalMap[this.ReturnPos().X, this.ReturnPos().Y] = "M";
        }

        // Returns the monsters point object for x and y locations
        public Point ReturnPos()
        {
            return monsterLocation;
        }
        // Sets the monsters point objects to the new coordinates
        public void SetPos(int x, int y)
        {
            monsterLocation.X = x;
            monsterLocation.Y = y;
        }


    }
}

