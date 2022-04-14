using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_2___07._04._2022
{
    class Program
    {
        static void Questions_funk(int number)
        {
            string[] Questions_arr = new string[]
            {
                $" 1) Where is Azerbaijan Capital ?             ",
                $" 2) Where is Turkey Capital ? ",
                $" 3) Where is Pakistan Capital ? ",
                $" 4) 4 qelem ve 3 defterin deyeri 6 qelem ve 2 defterin deyerine beraberdir . 4 defterin deyerine nece qelem almaq olar ? ",
                $" 5) 2 + 2 : 2 ? ",
                $" 6) Azalan cixilandan 10 vahit boyuk olarsa , ferq 5-in nece qati olar ? ",
                $" 7) ( one ) bu sozun tercumesi nedir ? ",
                $" 8) ( Cherry ) bu hansi meyvenin adidir ? ",
                $" 9) ( age ) bu suzun menasi nedir ? ",
                $" 10) Atamin yasi menim yasimin 3 qatindan 2 vahi boyukdur, 17 il sonra Babamin 90 yasi tamam oldu , atam babamin 23 yasinda dunyaya gelib . Menim indi nece yasim var ? :D "
            };
            Console.WriteLine(Questions_arr[number].ToString());
        }
        static string Answers_funk(int question_count,int answer_count)
        {
            string[,] Answers_arr = new string[,]
            {
                { $"Baku", "Naxcivan", "Ganja" },
                {$"Istanbul","Ankara","Adana"},
                {$"Islamabad","Paris","Dadish"},
                {$"12","8","10"},
                {$"4","2","3"},
                {$"4","2","3"},
                {$"1","2","3"},
                {$"Alma","Banan","Gilas"},
                {$"goz","yash","kondisioner"},
                {$"12","14","16"},
            };
            Console.WriteLine(Answers_arr[question_count,answer_count]);
            return Answers_arr[question_count, answer_count];
        }
        static bool Answers_true(int index,string answer)
        {
            string[] True_answers = new string[10]
            {
                "Baku","Ankara","Islamabad","8","3","2","1","Gilas","yash","14"
            };
            if (True_answers[index] == answer)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        static void true_function()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            for (int i = 0; i < 2; i++)
            {

                Thread.Sleep(400);
            Console.WriteLine($@"     
                                         WOW TRUEEE !!! 
                                                                    ");
                Thread.Sleep(700);
                Console.Clear();
            }
            Console.ForegroundColor = ConsoleColor.Black;

        }
        static void false_function()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            for (int i = 0; i < 2; i++)
            {

                Thread.Sleep(400);
            Console.WriteLine($@"     
                                         WOW FALSE !!! 
                                                                    ");
                Thread.Sleep(700);
                Console.Clear();
            }
            Console.ForegroundColor = ConsoleColor.Black;
        }
        static int Point = 0;
        static int question_Point = 0;
        static void Check_answer(string answer,int first,int second,int third,int index)
        {

            if (answer == "a" || answer == "A")
            {
                if (Answers_true(index, Answers_funk(index, first)))
                {
                    Point += 10;
                    question_Point += 1;
                    true_function();
                }
                else
                {
                    if (Point > 0)
                    {
                        Point -= 10;
                        false_function();
                    }
                    else
                    {
                        false_function();
                    }
                }
            }
            else if (answer == "b" || answer == "B")
            {
                if (Answers_true(index, Answers_funk(index, second)))
                {
                    Point += 10;
                    question_Point += 1;
                    true_function();
                }
                else
                {
                    if (Point > 0)
                    {
                        Point -= 10;
                        false_function();
                    }
                    else
                    {
                        false_function();
                    }
                }
            }
            else if (answer == "c" || answer == "C")
            {
                if (Answers_true(index, Answers_funk(index, third)))
                {
                    Point += 10;
                    question_Point += 1;
                    true_function();
                }
                else
                {
                    if (Point > 0)
                    {
                        Point -= 10;
                        false_function();
                    }
                    else
                    {
                        false_function();
                    }
                }
            }
            else
            {
                false_function();
            }
        }
        static int[] Get_random_funk()
        {
            Random r = new Random();
            int[] random_nums_arr = new int[3];
            int random_num1 = r.Next(0, 3);
            random_nums_arr[0] = random_num1;
            int random_num2 = r.Next(0, 3);
            if (random_num2 != random_nums_arr[0])
            {
                random_nums_arr[1] = random_num2;
            }
            else
            {
                bool check_random_num2 = true;
                while (check_random_num2)
                {
                    random_num2 = r.Next(0, 3);
                    if (random_num2 != random_nums_arr[0])
                    {
                        random_nums_arr[1] = random_num2;
                        check_random_num2 = false;
                    }
                }
            }
            int random_num3 = r.Next(0, 3);
            if (random_num3 != random_nums_arr[0] && random_num3 != random_nums_arr[1])
            {
                random_nums_arr[2] = random_num3;
            }
            else
            {
                bool check_random_num3 = true;
                while (check_random_num3)
                {
                    random_num3 = r.Next(0, 3);
                    if (random_num3 != random_nums_arr[0] && random_num3 != random_nums_arr[1])
                    {
                        random_nums_arr[2] = random_num3;
                        check_random_num3 = false;
                    }
                }
            }
            return random_nums_arr;
        }
        static void Start()
        {
            int answersAndQuestions_count = 0;
            int first_rand_num = Get_random_funk()[0];
            int second_rand_num = Get_random_funk()[1];
            int third_rand_num = Get_random_funk()[2];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine();
                Questions_funk(answersAndQuestions_count);
                Console.WriteLine();
                Console.Write("   A) "); Answers_funk(answersAndQuestions_count, first_rand_num);
                Console.Write("   B) "); Answers_funk(answersAndQuestions_count, second_rand_num);
                Console.Write("   C) "); Answers_funk(answersAndQuestions_count, third_rand_num);
                Console.WriteLine();
                Console.Write("   Answer : ");
                string User_answer = Console.ReadLine();
                Check_answer(User_answer, first_rand_num, second_rand_num, third_rand_num, answersAndQuestions_count);
                
                ++answersAndQuestions_count;
            }
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("   Your Point : "+Point);
            Console.WriteLine();
            Console.WriteLine("   Your TQS : "+question_Point);
            Console.WriteLine();

        }
        static void Informations()
        {
            Console.Title = "Question Task";
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WindowHeight = 22;
            Console.WindowWidth = 90;
        }
        static void Main()
        {
            Informations();
            Start();
        }
    }
}
