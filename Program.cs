using System;
using System.IO;
using System.Linq;

namespace uppgifter1
{
    class First
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Type 1 to see first function");
             Console.WriteLine("Type 2 to see Console text color");
             Console.WriteLine("Type 3 to see Console text color");
             Console.WriteLine("Type 4 to see Date and time");
             Console.WriteLine("Type 5 to check which number is greater ");
             Console.WriteLine("Type 6 to play guess game");
             Console.WriteLine("Type 7 to save file on harddisk");
             Console.WriteLine("Type 8 to load file");
             Console.WriteLine("Type 9 to get entered values root,raised to 2 and 10");
             Console.WriteLine("Type 10 to get tables 1-10");
             Console.WriteLine("Type 11 to get array of random number and its sorting");
             Console.WriteLine("Type 12 to get number between two entered value");
             Console.WriteLine("Type 13 to chech enterd string is palindrom or not");
             Console.WriteLine("Type 14 to get sorting,odd/even from entered comma separated value");
             Console.WriteLine("Type 15 to get add  of entered comma separated value");
             Console.WriteLine("Type 16 to get info from person entered character");

             int a = Convert.ToInt32(Console.ReadLine());
             switch (a)
             {
                 case 1:
                     Hello();
                     break;
                 case 2:
                     Name();
                     break;
                 case 3:
                     ColorChange(); 
                     break;
                 case 4:
                     DateT();
                     break;
                 case 5:
                     Greater();
                     break;
                 case 6:
                     Guess();
                     break;
                 case 7:
                     Filetosave();
                     break;
                 case 8:
                     Filetoopen();
                     break;
                 case 9:
                     Decimal();
                     break;
                 case 10:
                     Table();
                     break;
                 case 11:
                     Array_f();
                     break;
                 case 12:
                     user_in();
                     break;
                 case 13:
                     Palindrom_f();
                     break;
                 case 14:
                     Values();
                     break;
                 case 15:
                     PrintValue();
                     break;
                 case 16:
                     info();
                     break;

                 default:
                     Console.WriteLine("No Match");
                     break;

             }

            


        }
        static void Hello()
        {
            Console.WriteLine("Hello World");
        }

        static void Name()
        {
            Console.WriteLine("Enter your first name:");
            string fname = Console.ReadLine();
            Console.WriteLine("Enter your last name:");
            string lname = Console.ReadLine();
            Console.WriteLine("How old are you:");
            string age = Console.ReadLine();

            Console.WriteLine("\nFirst name:" + fname + "\nLast name:" + lname + "\nYour age:" + age);
        }
        static void ColorChange()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("The Color of text is green");
            Console.ResetColor();
            
        }
        static void DateT()
        {
            DateTime td = DateTime.Now;
            Console.WriteLine(td.ToString("yyyy'/'MM'/'dd' 'T-HH:mm:ss"));

        }
        static void Greater()
        {
            Console.WriteLine("Enter First number:");
            int i =Convert.ToInt32( Console.ReadLine());
            
            Console.WriteLine("Enter Second number:");
            int j = Convert.ToInt32 (Console.ReadLine());

            if (i > j)
            {
                Console.WriteLine("The First number is greater::" + i);
            }
            else
            {
                Console.WriteLine("The second number is greater::" + j);
            }
        }

        static void Guess()
        {
            Random r = new Random();
            int value = r.Next(1, 100);

            int g = 0;
            int nofg = 0;
            
            Console.WriteLine("What number can be random can you guess it from 1 to 100::");

            while (g != value)
            {
                 g = Convert.ToInt32(Console.ReadLine());

                nofg++;
                 if (value > g)
                {
                    Console.WriteLine("Value is greater than your guess..." + g);
                }
                 else if(value < g)
                {
                    Console.WriteLine("Value is lower than your guess...." + g);
                }

            }

            Console.WriteLine("Well played The Value is..." + value + "    number of guesses..."+ nofg);
            

        }
        static void Filetosave()
        {

            Console.WriteLine("Enter one line about your work....");
            String s = Console.ReadLine();

            StreamWriter stream;
            stream = File.CreateText("D:\\usertext.txt");
            stream.WriteLine(s);
            stream.Close();

             
        }
        static void Filetoopen()
        {

            string[] open = File.ReadAllLines("D:\\usertext.Txt"); 
            foreach (string s in open)
            {
                Console.WriteLine(s);
            }
            
             
            

        }
        static void Decimal()
        {
            int d = 0;

            Console.WriteLine("Enter any decimal number:");
            d = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Square root of entered number is....."+ Math.Sqrt(d));
            Console.WriteLine("Entered number raised to 2 is...." + Math.Pow(d,2));
            Console.WriteLine("Entered number raised to 10 is...." + Math.Pow(d,10)); 


        }
        static void Table()
        {
            int m, p,k;

            for( m=1; m<=10; m++)
            {
                Console.WriteLine("____________");
                for(p=1; p<=10; p++)
                {
                    k = m * p;

                    Console.WriteLine(m + " * " + p + " = " + k,"\t");

                }

            }

        }

        static void  Array_f()
        {
            int m = 1, n = 29;
            int[] a = new int[10];
            int[] b = new int[10];


            Random rNum = new Random();
            Console.WriteLine("The First Array of Random numbers....");
            for (int t=0; t<a.Length; t++)
            {
                a[t] = rNum.Next(m, n);
                Console.WriteLine(a[t]);
               
            } 
            Array.Sort(a);
            a.CopyTo(b, 0);
            Console.WriteLine("The Another Array with sorting....");
            for (int j=0;j<b.Length; j++)
            { 
                Console.WriteLine(b[j]);
            }
          
        }

        static void user_in()
        {
            Console.WriteLine("Enter First number :");
            int no1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second number :");
            int no2 = Convert.ToInt32(Console.ReadLine());

            if (no1 >= no2)

                Console.WriteLine("The number between your input numbers....");

            {
                for (int i = no1 -1 ; i > no2; i--)
                {
                    Console.WriteLine(i);
                }

               
            }
            if(no1<=no2)
           
            {
                Console.WriteLine("The number between your input numbers....");

                for (int i = no1+1 ; i < no2; i++)
                {
                    Console.WriteLine(i);
                }

            }

        }
        static void Palindrom_f()
        {
            Console.WriteLine("Enter Any string to check weather it is Palidrom or not::");
            string s = Console.ReadLine();
            string str ="";
          


           for (int i = s.Length - 1; i >= 0; i--)
            {

                str += s[i].ToString ();

            }

                if (str == s)
                {
                    Console.WriteLine("String is Palindrome");
                }
                else
                {
                    Console.WriteLine("String is not Palindrome");
                }
            Console.ReadKey();

        }
        static void Values()
        {
            Console.WriteLine("Enter your values....");
            string v = Console.ReadLine();

            string k = String.Join(",", v.Split(',').Select(c => Convert.ToInt32(c)).OrderBy(i => i));
            Console.WriteLine("Number is sorted..." + k);

            
            foreach (var res in k)
            {
                if(res == ',')
                {
                    continue;
                }
                if (res % 2 == 0)
                {
                    Console.WriteLine("Even number.." + res);
                }
                else
                {
                    Console.WriteLine("Odd number.." + res);
                }

            }
        }
        static void PrintValue()
        {
            Console.WriteLine("Enter your values....");
            string m = Console.ReadLine();
            double  sum = 0;
            string[] m1 = m.Split(',');
            for(int j=0;j<m1.Length;j++)
            {
                m1[j] = m1[j].Trim();
                sum += double.Parse(m1[j]);
            }

            Console.WriteLine("The addition of your values....");
           
            
            Console.WriteLine(sum);

        }
        static void info()
        {
            
            int[] health = new int[10];
            int[] strength = new int[10];
           int[] luck = new int[10];

            Random h = new Random();
            Random s = new Random();
            Random l = new Random();

            Console.WriteLine("How is Your character::");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your opponent ::");
            string cname = Console.ReadLine();

           
            int h1 = h.Next(health.Length);
            Console.WriteLine("Your health is...."+ h1);

            int s1 = s.Next(strength.Length);
            Console.WriteLine("Your Strength is...." + s1);

            int l1 = l.Next(luck.Length);
            Console.WriteLine("Your Luck is...." + l1);

            

            
        }















    }
}
 