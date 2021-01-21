//watermelon
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace watermelon1
{
    class Program
    {
        static void Main(string[] args)
        {
            int weight = Convert.ToInt32(Console.ReadLine());
            if(weight==2)
            {
             Console.WriteLine("No");   
            }
            else if (weight % 2 == 0)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
//way to long word


namespace longwords
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int count=0;
            string x="";
            for (int i = 0; i < n; i++)
            {
                string words = Console.ReadLine();

               
                    if (words.Length-1 < 10)
                    {
                        Console.Write(words);
                    }
                    else 
                    {

                        count = words.Length - 2;
                        x=words[0] + count + words[words.Length - 1];
                        Console.WriteLine(x);
                        count++;
                        
                    }

                }
            }
        }
    }
//wrong subtraction


namespace longwords
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string[] ans = a.Split(' ');
            int n=Convert.ToInt32(ans[0]);
            int k =Convert.ToInt32(ans[1]);
           
            for (int i = 0; i <k; i++)
            {
                if (n%10!= 0)
                {
                  n = n-1;
                }
                else
                {
                   n =n/10;        
                }
            }
            Console.WriteLine(n);
        }
        }
    }

//team


namespace longwords
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i <a; i++)
            {
                string b = Console.ReadLine();
                string[] c = b.Split(' ');
                int x = Convert.ToInt32(c[0]);
                int y = Convert.ToInt32(c[1]);
                int z = Convert.ToInt32(c[2]);
                int p = x + y + z;
                if (p >= 2)
                {
                    sum++;
                }
               
            }
             Console.WriteLine(sum);
            }
        }
    }
       
//string task


namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string x = "";
            
            for (int i = 0; i < a.Count(); i++)
            {
                if (a[i] == 'a' || a[i] == 'e' || a[i] == 'i' || a[i] == 'o' || a[i] == 'u' || a[i] == 'y'||a[i] == 'A' || a[i] == 'E' || a[i] == 'I' || a[i] == 'O' || a[i] == 'U' || a[i] == 'Y')
                {
                   
                }
                else
                {
                    x=x+"."+a[i];
                   
                }
            }
            Console.Write(x.ToLower());
        }
    }
}
