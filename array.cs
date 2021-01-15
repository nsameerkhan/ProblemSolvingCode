using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace arraytest5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] {10,3,3,5,7,9,2,3,4,5,6,7,2,3,16};
            #region 1.large value in an unsorted array.
            //printarray(array);
            //int largevalue1 = largevalueinarray1(array);
            //Console.WriteLine(largevalue1);
            #endregion
            #region 2.large value in an unsorted array.
            //printarray(array);
            //int largevalue2 = largevalueinarray2(array);
            //Console.WriteLine(largevalue2);
            #endregion
            #region 3.large value in an unsorted array.
            printarray(array);
            int largevalue3 = largevalueinarray3(array);
            Console.WriteLine(largevalue3);
            #endregion
            #region 4.large value in an unsorted array.
            //printarray(array);
            //int largevalue4 = largevalueinarray4(array);
            //Console.WriteLine(largevalue4);
            #endregion
            #region 1.print the elements of an array in reverse.
            //printarray(array);
            //reversearray1(array);
            #endregion
            #region 2.print the elements of an array in reverse.
            //printarray(array);
            //reversearray2(array);
            #endregion
            #region 3.print the elements of an array in reverse.
            //printarray(array);
            //reversearray3(array);
            #endregion
            #region 1.sum of all even position int the elements of array
            //printarray(array);
            //int sumofevenposition1 = sumofevenpositionelements1(array);
            //Console.WriteLine(sumofevenposition1);
            #endregion
            #region 2.sum of all even position int the elements of array
            //printarray(array);
            //int sumofevenposition2 = sumofevenpositionelements2(array);
            //Console.WriteLine(sumofevenposition2);
            #endregion
            #region 1.array A and target value X and return index value.
            //printarray(array);
            //int targetvalue1 = Getinteger("enter the target values:");
            //int target = targetvaluexindex1(array, targetvalue1);
            //Console.WriteLine(target);
            #endregion
            #region 2.array A and target value X and return index value.
            //printarray(array);
            //int targetvalue2 = Getinteger("enter the target values:");
            //int target = targetvaluexindex2(array, targetvalue2);
            //Console.WriteLine(target);
            #endregion
            #region 3.array A and target value X and return index value.
            //printarray(array);
            //int targetvalue3 = Getinteger("enter the target values:");
            //int target = targetvaluexindex3(array, targetvalue3);
            //Console.WriteLine(target);
            #endregion
            #region 1.print elements of an array upto k.
            //printarray(array);
            //int kvalue1 = Getinteger("enter the target values:");
            //printuptok(array, kvalue1);
            #endregion
            #region 2.print elements of an array upto k.
            //printarray(array);
            //int kvalue2 = Getinteger("enter the target values:");
            //printuptok(array, kvalue2);
            #endregion

        }
        public static void gettinginput()
        {

            Random random = new Random(DateTime.Now.Millisecond);
            int arraysize = random.Next(0, 100 + 1);
            int[] myarray = new int[100];
            for (int i = 0; i < arraysize; i++)
            {
                Console.Write(arraysize+"\t");
            }
            Console.WriteLine();
        }
        //1.large value in an array
        public static int largevalueinarray1(int[] myarray)
        {

            int largevalue1 = myarray[0];
            int largevalue2 = myarray[0];
            for (int i = 0; i < myarray.Length / 2; i++)
            {
                for (int j = myarray.Length / 2; j < myarray.Length; j++)
                {
                    if (largevalue1 < myarray[i] || largevalue2 < myarray[j])
                    {
                        largevalue1 = myarray[i];
                        largevalue2 = myarray[j];
                    }
                }
            }
            int largevalue = 0;
            if (largevalue1 > largevalue2)
            {
                largevalue = largevalue1;
            }
            else
            {
                largevalue = largevalue2;
            }
            return largevalue;
        }
        //2.large value in an array
        public static int largevalueinarray2(int[] myarray)
        {
            int largevalue =0;
            int i = 0;
             while(i< myarray.Length)
            {
                if (largevalue < myarray[i])
                {
                    largevalue =myarray[i];
                }
                i++;
            }
            return largevalue;
        }
        //3.large value in an array
        public static int largevalueinarray3(int[] myarray)
        {
            int largevalue =myarray[0];
            for (int i = 1; i < myarray.Length; i++)
            {
                if (largevalue<myarray[i])
                {
                    largevalue = myarray[i];
                }
            }
            return largevalue;
        }
       
        //4.large value in an array
        public static int  largevalueinarray4(int[] myarray)
        {
            int large = 0;
            Array.Sort(myarray);
            foreach (int value in myarray)
            {
                Console.Write(value + "\t ");
            }
            large = myarray[myarray.Length-1];
            Console.WriteLine();
            return large;
           
        }
        //1.print the elements of a array in reverse
        public static void reversearray1(int[] myarray)
        {
            for (int i = myarray.Length - 1; i > myarray.Length / 2; i--)
            {
                Console.Write(myarray[i] + "\t");
            }
            for (int j = myarray.Length / 2; j >= 0; j--)
            {

                Console.Write(myarray[j] + "\t");
            }
        }
       //2.print the elements of a array in reverse
        public static void reversearray2(int[] myarray)
        {
            for (int i=myarray.Length-1;i>= 0;i--)
            {
                Console.Write(myarray[i]+"\t");
            }
            Console.WriteLine();
        }
        //3.print the elements of a array in reverse
        public static void reversearray3(int[] myarray)
        {
            Array.Reverse(myarray);
            foreach (int item in myarray)
            {
                Console.Write(item+"\t");
            }
            Console.ReadKey();
        }
        //1.sum of all even position int the elements of array
        public static int sumofevenpositionelements1(int[] myarray)
        {
            int sum = 0;
            for (int i = 0; i < myarray.Length; i++)
            {
                if (i % 2 == 0)
                {
                    sum = sum + myarray[i];
                }
            }
            return sum;
        }
        //2.sum of all even position int the elements of array
        public static int sumofevenpositionelements2(int[] myarray)
        {
            int sum = 0;
            for (int i = 0; i < myarray.Length; i += 2)
            {

                sum = sum + myarray[i];
                
            }
            return sum;
        }
        //1.array A and a target value X and return index value
        public static int targetvaluexindex1(int[] myarray, int targetvalue)
        {
            int target = -1;
            for (int i = 0; i < myarray.Length; i++)
            {
                if (myarray[i] == targetvalue)
                {
                    target=i;
                }
            }
            return target;
        }
        //2.array A and a target value X and return index value
        public static int targetvaluexindex2(int[] myarray, int targetvalue)
        {
            int target = -1;
            for (int i = myarray.Length - 1; i >= 0; i--)
            {
                if (myarray[i] == targetvalue)
                    {
                        target = i;
                    }
                
            }
            return target;
        }
        //3.array A and a target value X and return index value
        public static int targetvaluexindex3(int[] myarray, int targetvalue)
        {
            int target = -1;
            for (int i =0; i <myarray.Length; i++)
            {
                    target =i;
            }
            return target;
        }
        //1.print elements of an array upto k.
        public static void printuptok1(int[] myarray, int k)
        {
           
            for (int i =0; i <myarray.Length; i++)
            {

                if (myarray[i] != k)
                {
                    Console.Write(myarray[i] + "\t");
                    
                }
                else
                {
                    break;
                }
            }
        }
        //2.print elements of an array upto k.
        public static void printuptok2(int[] myarray, int k)
        {

            for (int i = 0; i < myarray.Length; i++)
            {
                Console.Write(myarray[i] + "\t");
                if (myarray[i] == k)
                {
                    break;
                }
            }
        }
        //print array elements
        public static void printarray(int[] myarray)
        {
            for (int i = 0; i < myarray.Length; i++)
            {
                Console.Write(myarray[i]+"\t");
            }
           
            Console.WriteLine();
        }
        //get input in integer values.
        static public int Getinteger(string message)
        {
            Console.WriteLine(message + ";");
            int tempvalue;

            if (!int.TryParse(Console.ReadLine(), out tempvalue))
            {
                return Getinteger("Please enter valid integer");


            }
            return tempvalue;


        }
        }
    }