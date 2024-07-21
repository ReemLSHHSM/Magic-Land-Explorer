using System;
using MagicLandExplorer.Tasks;
using Newtonsoft.Json;
namespace MagicLandExplorer
{
    internal class Program
    {
        public delegate void method_tester();
        public delegate void answer_tester(ref string answer);

        static void Main(string[] args)
        {
            bool keepAsking = true;

            Console.WriteLine("Welcome to the Magic Land :)\n");
            Console.WriteLine("[1] Destinations name with a duration less than 100 minutes \n");
            Console.WriteLine("[2] Destination with the longest duration \n");
            Console.WriteLine("[3] View all Destinations \n");
            Console.WriteLine("[4] Top three longest-duration destinations \n");
            while (keepAsking)
            {

                Console.WriteLine("What question would you like to ask? \n");
                string answer = Console.ReadLine();
                
                answer_tester tester = test_answer;
                // Invoking 
                tester(ref answer);

                // Defining a delegate
                method_tester del;

                bool validChoice = false;
                while (!validChoice)
                {
                    switch (answer)
                    {
                        case "1":
                            del = FilterDestinations.find_destination;
                            del.Invoke();
                            validChoice = true;
                            break;
                        case "2":
                            del = LongestDuration.longest_Duration;
                            del.Invoke();
                            validChoice = true;
                            break;
                        case "3":
                            del = SortByName.sortNames;
                            del.Invoke();
                            validChoice = true;
                            Console.WriteLine();
                            break;
                        case "4":
                            del = Top3Duration.getTop3;
                            del.Invoke();
                            validChoice = true;
                            break;
                        default:
                            Console.WriteLine("Invalid input :< \nPlease try again! \n");
                            answer = Console.ReadLine();
                            Console.WriteLine();
                            tester(ref answer);
                            Console.WriteLine();
                            break;
                    }
                }

                Console.WriteLine("Do you want to ask another question (yes/no)? \n");
                string wants = Console.ReadLine();
                Console.WriteLine();
                while (wants.ToLower() != "yes" && wants.ToLower() != "no")
                {
                    Console.WriteLine("Invalid input :< \nPlease try again! \nDo you want to ask another question (yes/no)? \n");
                    wants = Console.ReadLine();
                    Console.WriteLine();
                }

                if (wants.ToLower() != "yes")
                {
                    keepAsking = false;
                    Console.WriteLine("Till next time :) \n");
                }
            }

            Console.ReadKey();
        }

        public static void test_answer(ref string answer)
        {
            bool test_answer = Int32.TryParse(answer, out int result);
            Console.WriteLine();

            while (((result > 4 || result < 1) || !test_answer) && (answer.ToLower() != "yes" && answer.ToLower() != "no"))
            {
                Console.WriteLine("Invalid input :< \nPlease try again! \n");
                Console.WriteLine("What question would you like to ask? \n");
                answer = Console.ReadLine();
                Console.WriteLine();
                test_answer = Int32.TryParse(answer, out result);
                Console.WriteLine();
            }
        }
    }
}
