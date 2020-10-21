using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using GameForestAdventure.MenuObjects.DataHelper;
namespace GameForestAdventure.Player_And_Monsters
{
    class PlayerCharacter : GenericCharacterActions
    {
        Point playerLocation = new Point(28,14);
        int playerHealth;
        int playerMana;
        string playerName;
        public PlayerCharacter(string playerName, int playerHealth, int playerMana)
        {
            this.playerName = playerName;
            this.playerHealth = playerHealth;
            this.playerMana = playerMana;
           
        }


        private void Attack(Object current)
        {

        }
        private void SpellAttack(Object current)
        {

        }


        public Point ReturnPos()
        {
            return playerLocation;
        }
        public void SetPos(int x, int y)
        {
          playerLocation.X = x;
          playerLocation.Y = y;
        }

    }
}
