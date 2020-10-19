using System;
using System.Collections.Generic;
using System.Text;

namespace GameForestAdventure.Player_And_Monsters
{
    class Monster : GenericCharacterActions
    {

        string monsterName;
        int monsterHealth;
        int monsterMana;

        public Monster(string monsterName, int monsterHealth, int monsterMana)
        {
            this.monsterName = monsterName;
            this.monsterHealth = monsterHealth;
            this.monsterMana = monsterMana;

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
