// This class is the overall Program helper to keep track of all the Map objects and methods to control updates and events on maps
// Provides functionality to  build a Map object from a txt file using SetMapState()
// Provides functionality to display the Map on the console using DisplayMap()
// Provides functionality to keep track of player object which is a berry in this case by CheckBerryReady() and CheckBerryFound
// Provides functionality to control user console input to change the players location on terminal using PlayerMovement()

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
        // Create two strings to allow looping through the map and displaying of it using DisplayMap()
        string mapbuilder1 = "";
        string mapbuilder2 = "";

        // StreamReader for parsing thorugh the map txt document
        public StreamReader MapBuild = new StreamReader("mapfile.txt");

        // TODO: Stream Writer to allow the player to save progress and load the game
        public StreamWriter MapSave = new StreamWriter(Directory.GetCurrentDirectory() + "\\MapData.txt");

        // TotalMap holds all the map data for the current map generated from the stream writer MapBuild
        public string[,] totalMap = new string[30, 30];

        // SetMapState() uses the 2d totalMap array to populate each index with a string to represent a 2d game board
        public void SetMapState()
        {
            // Count to keep track of rows index
            int count = 0;
            // Loop to go through the entire MapBuild file
            while (MapBuild.EndOfStream == false)
            {
                // Temporary string to hold each line of the MapBuild's file being parsed
                string templine = MapBuild.ReadLine();
                // Trim leading and trailing spaces from the current ReadLine();
                templine = templine.Trim();
                // inner loop to add each character to the 2d array column by column
                for (int i = 0; i < templine.Length; i++)
                {
                    totalMap[count, i] = templine[i].ToString();
                }
                // count is row location in 2d array
                count++;
            }
            MapBuild.Close();
        }
        // DisplayMap() loops through the totalMap[,] 2d array and prints it to the console screen
        public void DisplayMap()
        {
            // Loop for building each row index of the 2d totalMap[,] array
            for (int i = 0; i < 30; i++)
            {
                // Loop for building each column index of the 2d totalMap[,] array
                for (int ii = 0; ii < 30; ii++)
                {
                    mapbuilder1 = mapbuilder1 + this.totalMap[i, ii];
                }
                // Using the premade empty strings mapbuilder2 and mapbuilder1 to represent the whole map
                mapbuilder2 = mapbuilder2 + mapbuilder1 + "\n";
                mapbuilder1 = "";
            }
            // Writes the final map to the screen
            Console.WriteLine(mapbuilder2);
        }
        // CheckBerryReady() Accepts a Map object and loops through the 2d array totalMap indexes looking for the string "M" which is a Monster
        // If it does not find anymore "M" strings in totalMap it returns true to say that a "B" string must be added to the 2d array totalMap 
        public bool CheckBerryReady(Map currentmap)
        {
            // Loop for each row index of the 2d totalMap[,] array
            for (int i = 0; i < 30; i++)
            {
                // Loop for building each column index of the 2d totalMap[,] array
                for (int ii = 0; ii < 30; ii++)
                {
                    // Checks the current index provided by i and ii for a "M" string in currentmap.totalMap
                    if (currentmap.totalMap[i, ii].Equals("M") == true)
                    {
                        return false;
                    }
                }

            }
            return true;
        }
        // CheckBerryFound() Accepts a Map object and loops through the 2d array totalMap indexes looking for the string "B" which is a berry
        // If it does not find one it returns true and allows the program.cs to end the game
        public bool CheckBerryFound(Map currentmap)
        {
            // Loop for each row index of the 2d totalMap[,] array
            for (int i = 0; i < 30; i++)
            {
                // Loop for building each colomn index of the 2d totalMap[,] array
                for (int ii = 0; ii < 30; ii++)
                {
                    // Checks the current index provided by i and ii for a "B" string in currentmap.totalMap
                    if (currentmap.totalMap[i, ii].Equals("B") == true)
                    {
                        return false;
                    }
                }

            }
            return true;
        }

        // PlayerMovement() Accepts a PlayerCharacter and Map object to allow the player to simulate movement in the 2d array currentmap.totalMap[,]
        // Once the player types "North"-"n", "South"-"s" "East"-"e" or "West"-"w" in the console the string representation of the player "P" gets updated on the screen
        // This method is made to have currentmap.DisplayMap() used right after it to show the new players location
        public void PlayerMovement(PlayerCharacter player, Map currentmap)
        {
            // userChoice holds the users console input
            string userChoice = "";
            Console.WriteLine("Where would you like to move next? North,South,East,West? Use n,s,e,w for short commands");
            Console.WriteLine("go fight all the m M's on map to get a berry to apear");
            userChoice = Console.ReadLine();

            // if and else statement to translate each possible command into a new location for the string "P" to be placed in the 2d currentmap.totalMap[,] array
            // The First if statement checks to see the userChoice variable = "north" or "n" and checks if the 2d array currentmap.totalMap[,] is  not a wall character
            if ((userChoice.ToLower().Equals("north") | userChoice.ToLower().Equals("n")) && !currentmap.totalMap[player.ReturnPos().X - 1, player.ReturnPos().Y].Equals("|"))
            {
                //If all conditions were passed the following commands update the players "P" string to the new location in currentmap.totalMap[,]
                // Finally it also adds a " " to the previous Player position to replace the old "P" string 
                currentmap.totalMap[player.ReturnPos().X, player.ReturnPos().Y] = " ";
                player.SetPos(player.ReturnPos().X - 1, player.ReturnPos().Y);
                currentmap.totalMap[player.ReturnPos().X, player.ReturnPos().Y] = "p";

                // The Second else if statement checks to see the userChoice variable = "south" or "s" and checks if the 2d array currentmap.totalMap[,] is  not a wall character
            }
            else if (userChoice.ToLower().Equals("south") | userChoice.ToLower().Equals("s") && !currentmap.totalMap[player.ReturnPos().X + 1, player.ReturnPos().Y].Equals("|"))
            {
                // If all conditions were passed the following commands update the players "P" string to the new location in currentmap.totalMap[,]
                // Finally it also adds a " " to the previous Player position to replace the old "P" string 
                currentmap.totalMap[player.ReturnPos().X, player.ReturnPos().Y] = " ";
                player.SetPos(player.ReturnPos().X + 1, player.ReturnPos().Y);
                currentmap.totalMap[player.ReturnPos().X, player.ReturnPos().Y] = "p";

                // The Second else if statement checks to see the userChoice variable = "east" or "e" and checks if the 2d array currentmap.totalMap[,] is  not a wall character 
            }
            else if (userChoice.ToLower().Equals("east") | userChoice.ToLower().Equals("e") && !currentmap.totalMap[player.ReturnPos().X, player.ReturnPos().Y + 1].Equals("|"))
            {
                // If all conditions were passed the following commands update the players "P" string to the new location in currentmap.totalMap[,]
                // Finally it also adds a " " to the previous Player position to replace the old "P" string 
                currentmap.totalMap[player.ReturnPos().X, player.ReturnPos().Y] = " ";
                player.SetPos(player.ReturnPos().X, player.ReturnPos().Y + 1);
                currentmap.totalMap[player.ReturnPos().X, player.ReturnPos().Y] = "p";
            }
            // The third else if statement checks to see the userChoice variable = "west" or "w" and checks if the 2d array currentmap.totalMap[,] is  not a wall character 
            else if (userChoice.ToLower().Equals("west") | userChoice.ToLower().Equals("w") && !currentmap.totalMap[player.ReturnPos().X, player.ReturnPos().Y - 1].Equals("|"))
            {
                // If all conditions were passed the following commands update the players "P" string to the new location in currentmap.totalMap[,]
                // Finally it also adds a " " to the previous Player position to replace the old "P" string 
                currentmap.totalMap[player.ReturnPos().X, player.ReturnPos().Y] = " ";
                player.SetPos(player.ReturnPos().X, player.ReturnPos().Y - 1);
                currentmap.totalMap[player.ReturnPos().X, player.ReturnPos().Y] = "p";
            }
            // Final else statement makes sure that the user input follows the required guidelines, if not it recursively calls itself until correct input is supplied.
            else
            {
                Console.WriteLine("There is an object stopping your movement, try a new direction or you typed a wrong key!");
                // Calls itself if the user inputs wrong commands 
                PlayerMovement(player, currentmap);

            }
        }


    }
}
