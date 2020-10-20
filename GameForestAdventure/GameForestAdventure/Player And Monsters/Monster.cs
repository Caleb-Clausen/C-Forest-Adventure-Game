using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using GameForestAdventure.MenuObjects.DataHelper;
namespace GameForestAdventure.Player_And_Monsters
{
    class Monster : GenericCharacterActions
    {
        Point monsterLocation = new Point(0,0);
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

        private void WalkFront(Map current)
        {

        }

        private void WalkBack(Map current)
        {

        }

        private void WalkLeft(Map current)
        {

        }
        private void WalkRight(Map current)
        {

        }

    }
}
