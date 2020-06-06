﻿using System;
using System.IO;

namespace KeplerCMS.Helpers
{
    public class FigureHelper
    {
        public static string FixFigure(string input)
        {
            var hr = input.Substring(0, 5);
            var hd = input.Substring(5, 5);
            var ch = input.Substring(10, 5);
            var lg = input.Substring(15, 5);
            var sh = input.Substring(20, 5);

            return hr + hd + lg + sh + ch; 
        }
        
        public static string ConvertFigure(string oldFigure)
        {
            var oldFigureData = "./wwwroot/data/figuredata.json";
            var directory = Directory.GetCurrentDirectory();
            var test = "";
            if (File.Exists(directory + oldFigureData))
            {
                test = File.ReadAllText(oldFigureData);
            }
            return test;
        }
    }
}
