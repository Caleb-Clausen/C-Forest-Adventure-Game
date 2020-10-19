using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace GameForestAdventure.MenuObjects.DataHelper
{
    class Map
    {
       public StreamReader MapBuild = new StreamReader("mapfile.txt");
       public StreamWriter MapSave = new StreamWriter("C:\\Users\\Cloudsan\\source\\repos\\C-Forest-Adventure-Game\\GameForestAdventure\\GameForestAdventure\\bin\\Debug\\netcoreapp3.1");
    }
}
