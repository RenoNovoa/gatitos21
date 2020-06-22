using System;

namespace gatitos2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("               ^_^   Welcome to my first C# traveling Experience!     ^_^           ");





            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();




            Console.WriteLine("      What kind of trip would you like to go on, musical,tropical or adventurous? (Enter Choise)");
            string vacationType = Console.ReadLine();
            //Console.WriteLine("Enter your choice ");



            Console.Write("How many are in your group?");
            int groupSize = int.Parse(Console.ReadLine());

            if (groupSize >= 3 && groupSize <= 5)
            {
                Console.WriteLine("Sins your group of " + groupSize + " going on a musical vacation, you shoul take helicopter to New Orleans.");
            }
            else if (groupSize >= 1 && groupSize <= 2)
            {
                Console.WriteLine("Sins your group of " + groupSize + "  going in a adventurous vacation, you should take a first class Whitewater rafting the Grand Canyon");

            }
            else if (groupSize >= 6)
            {
                Console.WriteLine("Sins your group of " + groupSize + "  going on atropical  vacation, you shoul take a charter flight to vacation in Mexico ");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("       ^_^   Thans for traveling with us this summer!    ^_^  ");

            Console.WriteLine(" If you need more information,  send us your numer ( Enter No.)");
            int number = int.Parse(Console.ReadLine());
        }
    }
}
