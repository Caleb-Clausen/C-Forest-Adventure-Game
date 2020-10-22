// This Class is the overall Program helper to create an object that represents a user, attributes can be specified on object creation
// Implements the IGenericCharacterActions interface
// Provides functionality to override the default constructor adding PlayerCharacter(string playerName, int playerHealth, int playerMana)
// Provides functionality to provide the x and y coordinates in the form of a Point object by calling ReturnPos()
// Provides functionality to set the x and y coordinates for the point object player Location.
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using GameForestAdventure.MenuObjects.DataHelper;
namespace GameForestAdventure.Player_And_Monsters
{
    class PlayerCharacter : IGenericCharacterActions
    {
        // Set the player location point object to prepare it to be displayed on the Map.totalMap[x,y] Array
        Point playerLocation = new Point(28, 14);
        private int playerHealth;
        private int playerMana;
        public string playerName { get; set; }

        // Default constructor override to allow for Player name, player health, Player mana, to be part of the instance
        public PlayerCharacter(string playerName, int playerHealth, int playerMana)
        {
            this.playerName = playerName;
            this.playerHealth = playerHealth;
            this.playerMana = playerMana;

        }

        //TODO: Implement Attack to allow the Player and monsters to attack each other
        private void Attack(Object current)
        {

        }

        //TODO: Implement SpellAttack to allow the Player and monsters to attack each other
        private void SpellAttack(Object current)
        {

        }

        // Returns the Players point object for x and y locations
        public Point ReturnPos()
        {
            return playerLocation;
        }
        // Sets the Players point objects to the new coordinates
        public void SetPos(int x, int y)
        {
            playerLocation.X = x;
            playerLocation.Y = y;
        }
    }
}

