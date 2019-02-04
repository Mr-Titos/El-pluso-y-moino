using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace El_nombro_mystero
{
    class Program
    {
        static void Main(string[] args)
        {
            for (;;)
            {
                Random r = new Random();
                int x, count = 0, m = r.Next(0, 50);
                float b = 0, n = 0;
                bool test = false;


                Console.Write("\nBienvenue en El nombro muystero ! \n");
                n++;

                while (test == false && count < 5)
                {
                    Console.Write("Nombre : ");
                    x = Convert.ToInt32(Console.ReadLine());
                    count++;

                    if (x < m)
                        Console.WriteLine("C'est plus ! \n" + count + "/5");

                    if (x > m)
                        Console.WriteLine("C'est moins ! \n" + count + "/5");

                    if (x == m)
                    {
                        Console.WriteLine("C'est ton dernier mot Jean Pierre ? \n O/N  \n");
                        ConsoleKeyInfo key = Console.ReadKey(true);
                        if (key.KeyChar == 'o')
                        {
                            Console.Write("Et bien vous avez gagné ! \nLe chiffre est bien " + m + " ! \n");
                            b++;
                            test = true;
                        }
                        else
                            Console.WriteLine("Si tu es si indécis réessaye alors !");
                    }
                   else if (count == 5)
                    {
                        Console.WriteLine("Tu es mauvais, tu as perdu ! \nEl nombro mystero etait " + m + " !");

                        
                    }
                    
                }

                int score = (int) ((b / n) * 100);
                Console.WriteLine("Votre score atcuel est de " + score + "%");
            }

        }
    }
}
