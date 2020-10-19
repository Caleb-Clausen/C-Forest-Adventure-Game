using System;
using System.Collections.Generic;
using System.Text;

namespace GameForestAdventure.MenuObjects.DatabaseHelper
{
    class DataBaseTool
    {
        private static string connecectString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|Database1.mdf;Integrated Security=True";

        public class Columns
        {
            public const string playerName = "playerName";
        }
    }
}
