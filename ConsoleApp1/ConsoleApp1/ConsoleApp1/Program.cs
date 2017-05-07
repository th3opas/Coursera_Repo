using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program 
    {
        static void Main(string[] args)
        {
            int[] check;
            
            int[] numbers;
            Dices Dices = new Dices();
            int dicemin = 1;
            int dicemax = 6;
            int dicenum = 2;
            int results = 0;
            string custom = "a";
            int counter = 0;
            int cheat = 0;
            string play = "a";
            if (custom != "c")
            {
                Console.WriteLine("you want to customize your dices? if yes press c");
                custom = Console.ReadLine();
            }

            Console.WriteLine("ready?");
            play=Console.ReadLine();
            if (custom == "c")
            {
                Console.Write("Give min dice range");
                string diceminstr = Console.ReadLine();

                dicemin = Int32.Parse(diceminstr);

                Console.Write("Give max dice range");
                string dicemaxstr = Console.ReadLine();
                dicemax = Int32.Parse(dicemaxstr);

                Console.Write("Give number of dices");
                string dicenumstr = Console.ReadLine();
                dicenum = Int32.Parse(dicenumstr);
              
            }
            check = new int[dicemax];
            while (play != "q")
            {
                int a = dicemin;
                if (play == "o") {
                    a = 4;
                   
                    cheat = cheat + 1;
                }
                results = 0;
                numbers = new int[dicenum];
               
                for (int i = 1; i <= dicenum; i++)
                {
                    int rolling= Dices.ThrowDice(a, dicemax);
                    results=results+ rolling;
                    numbers[i-1] = rolling;
                    counter = counter + 1;
                    Console.WriteLine("you rolled:" + rolling);
                }
                for(int i = 0; i <= dicenum-1; i++)
                {
                    for(int j = 0; j <= dicemax-1; j++)
                    {
                        if (numbers[i] == j + 1) {
                            check[j] = check[j] + 1;
                            
                        }
                    }
                }

                
                Console.WriteLine("you rolled a sum of"+":"+results);
                Console.WriteLine("press q if you want to quit rolling");
                play = Console.ReadLine();
               if (play == "q")
                {
                    for(int i = 0; i <= dicemax - 1; i++) {
                        Console.WriteLine("you rolled" + " " + (i+1)+":" + " "+check[i]+ " "+"out of" + " " + counter+ " "+"times");
                            }
                    Console.WriteLine("You also cheated" + "  "+ cheat + "  " + "times" + "  " + "congratulations!! :D");

                    Console.ReadKey();
                }
               
            }
        }
    }
}
