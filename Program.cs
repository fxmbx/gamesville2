using System;

namespace quest02
{
    class Program
    {
        static string BeanRacket(int startingnumb)
        {
            Console.WriteLine("The number of bean in the racket is {0}", startingnumb);
            string name1 = "ALi", name2 = "Simbi";
            int input, input2;
            string winner =  null;
            while (true)
            {
                if (startingnumb < 2)
                {
                    Console.WriteLine("{0} Won", name2);
                    break;
                }
                Console.WriteLine("{0} Your turn", name1);
                input = Convert.ToInt32(Console.ReadLine());
                if (!(input == 2 || input == 3 || input == 5))
                {
                    Console.WriteLine("{0} broke the game \n {1}", name1, name2);
                    winner = name2;
                    break;
                }
                startingnumb -= input;
                if (startingnumb < 2)
                {
                    Console.WriteLine("{0} Won", name1);
                    break;
                }
                Console.WriteLine("{0} Your turn", name2); 
                input2 = Convert.ToInt32(Console.ReadLine());
                if (!(input == 2 || input == 3 || input == 5))
                {
                    Console.WriteLine("{0} broke the game \n {1} Won", name2,name1);
                    winner = name1;
                    break;
                }
                startingnumb -= input;
              
            }
            return winner;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(BeanRacket(5));
        }
    }
}
