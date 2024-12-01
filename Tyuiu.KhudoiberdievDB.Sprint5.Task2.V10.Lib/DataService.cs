﻿using System.IO;

using System.Reflection.Metadata.Ecma335;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.KhudoiberdievDB.Sprint5.Task2.V10.Lib
{
    public class DataService : ISprint5Task2V10
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask2.csv");
            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;

            if (fileExist)
            {
                File.Delete(path);
            }

            int rows = matrix.GetUpperBound(0) + 1;
            int cols = matrix.GetUpperBound(1) + 1;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        matrix[i, j] = 1;
                    }
                    if (matrix[i, j] < 0)
                    {
                        matrix[i, j] = 0;
                    }

                }
            }
            string str = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (j != cols - 1)
                    {
                        str = str + matrix[i, j] + ";";
                    }

                    else { str = str + matrix[i, j]; }

                }


                    if (i != rows -1 )
                    {
                        File.AppendAllText(path, str + Environment.NewLine);
                    }
                    else
                    {
                        File.AppendAllText(path, str);
                    }
                    str = "";
                
                
            }
            return path;

        }

    } 
}
        
    

