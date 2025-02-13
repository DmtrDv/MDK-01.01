using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winter_task
{
    internal class Tests
    {
        private string _NameTest;
        private string _Question;
        private string _Answer;
        List<string> VarA = new List<string>();

        /*public Tests (string NameTest, string Question, string Answer, List<string> VarAnsw)
        {
            _NameTest = NameTest;
            _Question = Question;
            _Answer = Answer;
            VarA = VarAnsw;
        }*/
        public void Writer(string discipline, string NameTest, string Question, string Answer, string VarAnswer )
        {
            string path = $"D:\\FolderLists\\FolderTest\\{discipline}\\{NameTest}.txt";
            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.Write($"{Question}!{Answer}!{VarAnswer} \n");
                writer.Close();
            }
        }
    }
}
