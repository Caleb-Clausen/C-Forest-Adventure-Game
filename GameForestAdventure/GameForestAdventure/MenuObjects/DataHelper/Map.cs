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

        public void Movement(PlayerCharacter player, Map currentmap)
        {
            string userChoice = "";
            Console.WriteLine("Where would you like to move next? North,South,East,West?");
            userChoice = Console.ReadLine();

            if(userChoice.ToLower().Equals("north"))
            {
                currentmap.totalMap[player.ReturnPos().X, player.ReturnPos().Y] = " ";
                player.SetPos(player.ReturnPos().X-1, player.ReturnPos().Y);
                currentmap.totalMap[player.ReturnPos().X, player.ReturnPos().Y] = "p";
            }else if (userChoice.ToLower().Equals("south"))
            {
                currentmap.totalMap[player.ReturnPos().X, player.ReturnPos().Y] = " ";
                player.SetPos(player.ReturnPos().X + 1, player.ReturnPos().Y);
                currentmap.totalMap[player.ReturnPos().X, player.ReturnPos().Y] = "p";
            }else if (userChoice.ToLower().Equals("east"))
            {
                currentmap.totalMap[player.ReturnPos().X, player.ReturnPos().Y] = " ";
                player.SetPos(player.ReturnPos().X, player.ReturnPos().Y+1);
                currentmap.totalMap[player.ReturnPos().X, player.ReturnPos().Y] = "p";
            }
            else
            {
                currentmap.totalMap[player.ReturnPos().X, player.ReturnPos().Y] = " ";
                player.SetPos(player.ReturnPos().X, player.ReturnPos().Y-1);
                currentmap.totalMap[player.ReturnPos().X, player.ReturnPos().Y] = "p";
            }
        }

       
    }
}
