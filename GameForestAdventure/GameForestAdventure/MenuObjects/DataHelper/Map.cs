using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading;
using GameForestAdventure.Player_And_Monsters;

namespace GameForestAdventure.MenuObjects.DataHelper
{
    class Map
    {
       string mapbuilder1 = "";
       string mapbuilder2 = "";
       public StreamReader MapBuild = new StreamReader("mapfile.txt");
       public StreamWriter MapSave = new StreamWriter(Directory.GetCurrentDirectory()+ "\\MapData.txt");
       // totalMap holds all the map data for the current map generated from the stream writer MapBuild
       public string[,] totalMap = new string[30, 30];
       public void SetMapState()
        {
            int count = 0;
            while (MapBuild.EndOfStream == false)
            {
                string templine = MapBuild.ReadLine();
                templine = templine.Trim();
                for (int i = 0; i < templine.Length; i++)
                {
                    totalMap[count, i] = templine[i].ToString();
                }
                count++;
            }
            MapBuild.Close();
        }

        public void DisplayMap()
        {
            for (int i = 0; i< 30; i++)
            {
                for (int ii = 0; ii< 30; ii++)
                {
                    mapbuilder1 = mapbuilder1 + this.totalMap[i, ii];
                }
                mapbuilder2 = mapbuilder2 + mapbuilder1 + "\n";
                mapbuilder1 = "";
            }
            Console.WriteLine(mapbuilder2);
        }

        public void PlayerMovement(PlayerCharacter player, Map currentmap)
        {
            string userChoice = "";
            Console.WriteLine("Where would you like to move next? North,South,East,West? Use n,s,e,w for short commands");
            userChoice = Console.ReadLine();

            if((userChoice.ToLower().Equals("north") | userChoice.ToLower().Equals("n")) && !currentmap.totalMap[player.ReturnPos().X-1,player.ReturnPos().Y].Equals("|"))
            {
                currentmap.totalMap[player.ReturnPos().X, player.ReturnPos().Y] = " ";
                player.SetPos(player.ReturnPos().X-1, player.ReturnPos().Y);
                currentmap.totalMap[player.ReturnPos().X, player.ReturnPos().Y] = "p";
            }else if (userChoice.ToLower().Equals("south") | userChoice.ToLower().Equals("s") && !currentmap.totalMap[player.ReturnPos().X + 1, player.ReturnPos().Y].Equals("|"))
            {
                currentmap.totalMap[player.ReturnPos().X, player.ReturnPos().Y] = " ";
                player.SetPos(player.ReturnPos().X + 1, player.ReturnPos().Y);
                currentmap.totalMap[player.ReturnPos().X, player.ReturnPos().Y] = "p";
            }else if (userChoice.ToLower().Equals("east") | userChoice.ToLower().Equals("e") && !currentmap.totalMap[player.ReturnPos().X, player.ReturnPos().Y+1].Equals("|"))
            {
                currentmap.totalMap[player.ReturnPos().X, player.ReturnPos().Y] = " ";
                player.SetPos(player.ReturnPos().X, player.ReturnPos().Y+1);
                currentmap.totalMap[player.ReturnPos().X, player.ReturnPos().Y] = "p";
            }
            else if(userChoice.ToLower().Equals("west") | userChoice.ToLower().Equals("w") && !currentmap.totalMap[player.ReturnPos().X, player.ReturnPos().Y -1].Equals("|"))
            {
                currentmap.totalMap[player.ReturnPos().X, player.ReturnPos().Y] = " ";
                player.SetPos(player.ReturnPos().X, player.ReturnPos().Y-1);
                currentmap.totalMap[player.ReturnPos().X, player.ReturnPos().Y] = "p";
            }
            else
            {
                Console.WriteLine("There is an object stopping your movement, try a new direction or you typed a wrong key!");
                PlayerMovement(player,currentmap);
               
            }
        }

       
    }
}
