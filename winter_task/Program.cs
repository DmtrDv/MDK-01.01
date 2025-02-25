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
            int eternity = 0;
            while (eternity == 0)
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

                if (CreatingOrPassingTest == "создать")
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

                            Console.WriteLine("Напишите все варианты ответов (когда вариантов будет достаточно, напишите ДВО): ");

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

                else if (CreatingOrPassingTest == "решать")
                {
                    Console.WriteLine($"По какой дисциплине вы хотите решать тест: {String.Join(", ", NameDiscipline)}");
                    string ReaderOfDiscipline = Console.ReadLine();
                    if (NameDiscipline.Contains(ReaderOfDiscipline) &&
                        Directory.Exists($"D:\\FolderLists\\FolderTest\\{ReaderOfDiscipline}") == true)
                    {
                        string[] allFiles = Directory.GetFiles($"D:\\FolderLists\\FolderTest\\{ReaderOfDiscipline}");
                        string Tests = null;
                        foreach (string fileName in allFiles)
                        {
                            Tests += Path.GetFileName(fileName);
                            Tests = Tests.Remove(Tests.LastIndexOf(".")) + ", ";
                        }
                        Console.WriteLine($"Введите тест, который хотите решать: {Tests}");
                        string NameOfTest = Console.ReadLine();
                        if (Tests.Contains(NameOfTest))
                        {
                            Tests tests = new Tests();
                            tests.ReaderTest(ReaderOfDiscipline, NameOfTest);

                        }
                        else { Console.WriteLine("Нет такого теста"); }
                    }
                    else Console.WriteLine("Нет такой дисциплины или тестов по ней");
                }
                else Console.WriteLine("фу, пиши правильно");

                Console.ReadKey();

            }
        }
    }
}
