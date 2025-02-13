using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace winter_task
{
    internal class Program
    {
        static void Main()
        {
            List<string> NameDiscipline = new List<string>();                       
            
            string PathToListDiscipline = "D:\\FolderLists\\ListOfDisciplineName.txt";
            
            if (File.Exists(PathToListDiscipline) == true) 
            {
                using (StreamReader SR = new StreamReader(PathToListDiscipline))
                {
                    string sr = Convert.ToString(SR.ReadToEnd());

                    string[] EnumerationOfDisciplines = sr.Split(';');
                    
                    int number = 0;
                    for (int i = 0; i < EnumerationOfDisciplines.Length; i++)
                    {
                        NameDiscipline.Add(EnumerationOfDisciplines[number]);
                        number++;
                    }                   
                }                
            }
            else 
            {
                Directory.CreateDirectory("D:\\FolderLists\\");
                File.Create(PathToListDiscipline).Close(); 
            }

            Console.WriteLine("Если вы хотите создать тест, то напишите *создать*, если вы хотите решать тест, то напишите *решать*");
            string CreatingOrPassingTest = Console.ReadLine();

            if (CreatingOrPassingTest == "создать" )
            {
                Console.WriteLine($"По какой дисциплине вы хотите сделать тест: {String.Join(", ", NameDiscipline)} ");
                string ReaderOfDiscipline = Console.ReadLine();
                if (NameDiscipline.Contains(ReaderOfDiscipline))
                {                    
                    Console.WriteLine("Введите название нового теста, имя не должно повторяться");
                    string NameNewTest = Console.ReadLine();

                    Discipline discipline = new Discipline();
                    discipline.NewTest(ReaderOfDiscipline, NameNewTest);
                    string EndForQuestion = null;
                    while (EndForQuestion != "ДВВ")
                    {
                        Console.WriteLine("Напишите вопрос: ");
                        string TheQuestion = Console.ReadLine();

                        Console.WriteLine("Напишите правильный ответ:");
                        string TheAnswer = Console.ReadLine();

                        Console.WriteLine("Напишите другие варианты ответов (когда вариантов будет достаточно, напишите ДВО): ");

                        string VariantsAnswer = Console.ReadLine();
                        string lineToWrite = null;
                        while (VariantsAnswer != "ДВО")
                        {
                            lineToWrite += VariantsAnswer + "~";
                            VariantsAnswer = Console.ReadLine();
                        }
                        Tests tests = new Tests();
                        tests.Writer(ReaderOfDiscipline, NameNewTest, TheQuestion, TheAnswer, lineToWrite);

                        Console.WriteLine("dfghjkl;lkjhgfdsdfghjkllkjhgfghjkjhоапнгщшгнаевкыевчпс рмилтодщгшнш7геасрполщш87ш6гыуевчасрпgffghjkjhgffghjkjhgfdfghhsetgeszrgsdfghergzdnjt");
                        Console.WriteLine("Если вопросов достаточно напишите: ДВВ. Если недостаточно нажмите Enter");
                        EndForQuestion = Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("Вы хотите добавить дисциплину с таким названием?  да/нет");
                    string AddingNewDiscipline = Console.ReadLine();
                    if (AddingNewDiscipline == "да")
                    {
                        NameDiscipline.Add(ReaderOfDiscipline);
                        Console.WriteLine(String.Join(", ", NameDiscipline));
                        using (StreamWriter SW = new StreamWriter(PathToListDiscipline, true))
                        {
                            SW.Write(";" + ReaderOfDiscipline);
                        }
                    }    
                }
            }
            
            else if (CreatingOrPassingTest == "решать") Console.WriteLine(" о, тоже арбайтен");
            else Console.WriteLine("фу, пиши правильно");

            Console.ReadKey();
            



            //для постоянного повторения поробовать запихнуть в бесконечный цикл
        }
    }
}
