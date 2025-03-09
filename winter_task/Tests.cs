using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winter_task
{
    public class Tests
    {
        /*private string _NameTest;
        private string _Question;
        private string _Answer;
        List<string> VarA = new List<string>();*/

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

        public void Writer(string discipline, string NameTest, string Question, string Answer, string VarAnswer )
        {
            string path = $"D:\\FolderLists\\FolderTest\\{discipline}\\{NameTest}.txt";
            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.Write($"{Question}~{Answer}~{VarAnswer} \n");
                writer.Close();
            }
        }

        public void ReaderTest(string discipline, string NameTest)
        {
            string path = $"D:\\FolderLists\\FolderTest\\{discipline}\\{NameTest}.txt";
            using (StreamReader reader = new StreamReader(path))
            {
                int score = 0;
                string readable = Convert.ToString(reader.ReadToEnd());
                string[] AlreadyReadStrings = readable.Split('\n');
                string[] AlreadyRead = null;
                for (int i = 0; i < AlreadyReadStrings.Length; i++)
                {
                    int mark = 0;
                    if (AlreadyReadStrings[i] == "") Console.WriteLine($"Твоя оценка: {Mark(score, AlreadyReadStrings.Length - 1)} ");
                    else
                    {
                        AlreadyRead = AlreadyReadStrings[i].Split('~');
                        string Question = AlreadyRead[0];
                        string RightAnswer = AlreadyRead[1];
                        Console.WriteLine(Question);

                        for (int j = 2; j < AlreadyRead.Length; j++)
                        {
                            string VarintsAnswer = AlreadyRead[j];
                            Console.WriteLine(VarintsAnswer);
                        }
                        string AnswerUser = Console.ReadLine();
                        if (AnswerUser == RightAnswer) score++;
                        score = score + 0;                        
                    }
                }
                
            }
        }

        public int Mark(int score, int ScoreQuestion)
        {
            int mark;
            int percent = score * 100 / ScoreQuestion;
            if (percent >= 90) return mark = 5;
            if (percent >= 75 && percent < 90) return mark = 4;
            if (percent >= 50 && percent < 75) return mark = 3;
            else return mark = 2;
        }        
    }
}
