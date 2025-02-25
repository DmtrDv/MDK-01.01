using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace winter_task
{
    public class Discipline
    {
        public void NewTest(string a, string b)
        {
            string c = $"D:\\FolderLists\\FolderTest\\{a}";            
            if (Directory.Exists(c) == true)
            {
                if (File.Exists($"D:\\FolderLists\\FolderTest\\{a}\\{b}.txt"))
                {
                    Console.WriteLine("Такой тест уже есть");
                }
                else
                    File.Create($"D:\\FolderLists\\FolderTest\\{a}\\{b}.txt").Close(); 
            }
            if (Directory.Exists(c) == false)
            {
                Directory.CreateDirectory(c);
                File.Create($"D:\\FolderLists\\FolderTest\\{a}\\{b}.txt").Close();
            }
        }

        

    }
}
