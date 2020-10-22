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
        
        Random randomonsterlocation = new Random(); 
        Point monsterLocation = new Point(0,0);
        string monsterName;
        int monsterHealth;
        int monsterMana;


        public Monster(string monsterName, int monsterHealth, int monsterMana, Map currentmap)
        {
            this.monsterName = monsterName;
            this.monsterHealth = monsterHealth;
            this.monsterMana = monsterMana;
            MonsterMapPostion(currentmap);

        }

        public void MonsterMapPostion(Map currentmap)
        {
            this.SetPos(randomonsterlocation.Next(1, 25), randomonsterlocation.Next(1, 25));
            currentmap.totalMap[this.ReturnPos().X, this.ReturnPos().Y] = "M";
        }
        public Point ReturnPos()
        {
            return monsterLocation;
        }
        public void SetPos(int x, int y)
        {
            monsterLocation.X = x;
            monsterLocation.Y = y;
        }


    }
}
