﻿using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.KhudoiberdievDB.Sprint5.Task0.V7.Lib;


public class DataService : ISprint5Task0V7

{
    public string SaveToFileTextData(int x)
    {
        string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask0.txt";
        double z= (-(Math.Pow(x, 3))) + 4 * (Math.Pow(x, 2)) - (3.0 / 2.0 * x);
        z = Math.Round(z, 3);
        File.WriteAllText(path, Convert.ToString(z)); 
        return path;
    }
}
