using System;
using System.Collections.Generic;
using System.Text;

namespace GameForestAdventure.Player_And_Monsters
{
    class PlayerCharacter : GenericCharacterActions
    {
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

        private void WalkFront(Object current)
        {

        }

        private void WalkBack(Object current)
        {

        }

        private void WalkLeft(Object current)
        {

        }
        private void WalkRight(Object current)
        {

        }

    }
}
