﻿using System.IO;
using System.Xml.Schema;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.KhudoiberdievDB.Sprint5.Task1.V15.Lib
{
    public class DataService : ISprint5Task1V15
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");
            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;

            if (fileExist)
            {
                File.Delete(path);
            }

            double y;
            string strY;
            for (int x = startValue; x <= stopValue; x++)
            {
                y = Math.Round(((Math.Cos(x) / (x - 0.4)) + Math.Sin(x) * 8*x + 2),2) ;
                strY=Convert.ToString(y);
                

                if (x != stopValue)
                {
                    File.AppendAllText(path, strY + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path,strY );
                }


            
            
            
            
            }
            return path;

        }
    }
}
