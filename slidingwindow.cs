using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static1
{
    class Program
    {
        static void Main(string[] args)
        {
           #region static method
            //int[] a = new int[] {2,3,7,8,4,6,9,5,6};
            //Console.WriteLine("enter k values:");
            //int b = Convert.ToInt32(Console.ReadLine());
            //int c = findmaxsumarray(a, b);
            //Console.WriteLine(c);
#endregion
            #region dynamic method
            //int[] a = new int[] {2, 3, 4, 5, 6, 7 };
            //int b = findmaxsum(a);
            
            //Console.WriteLine(b);
            #endregion
            #region maximum contiguous subarray sum
            //int[] a = new int[] { -1,2,-2,5,0,3,2,-4,5 };
            //int b = maxcontiguous(a);
            //Console.WriteLine(b);
            #endregion
            #region maximum contiguous subarray sum (alternative)
            int[] a = new int[] { -1, 2, -2, 5, 0, 3, 2, -4, 5 };
            int b = maxcontiguous1(a);
            Console.WriteLine(b);
            #endregion
            #region maximum contiguous subarray sum (alternative)
            //int[] a = new int[] { -1, 2, -2, 5, 0, 3, 2, -4, 5 };
            //int b = maxcontiguous2(a);
            //Console.WriteLine(b);
            #endregion
        }
        //static method
        public static int findmaxsumarray(int[] arr, int k)
        {
            int maxsofar = int.MinValue;
            int currentrunningsum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                currentrunningsum = currentrunningsum + arr[i];
                if (i >= k - 1)
                {
                    maxsofar = Math.Max(maxsofar, currentrunningsum);
                    currentrunningsum = currentrunningsum - arr[i - (k - 1)];
                }
            }
            return maxsofar;
        }
        //dynamic method
        public static int findmaxsum(int[] arr)
        {
            int minwindowsize = int.MaxValue;
            int currentwindowsum = 0;
            int windowstart = 0;
            int targetsum=0;
            for (int windowend = 0; windowend < arr.Length; windowend++)
            {
                currentwindowsum = currentwindowsum + arr[windowend];
                while (currentwindowsum >= targetsum)
                {
                    minwindowsize = Math.Min(minwindowsize, windowend - windowstart+1);
                    currentwindowsum =arr[windowstart];
                    windowstart++;
                }
            }
            return minwindowsize;
        }
        //dynamic with data structures(dictionary,sortedlist)
        //maximum contiguous subarray sum
        public static int maxcontiguous(int[] nums)
        {
            int n = nums.Length;
            int maximumsubarray = int.MinValue;
            for (int left = 0; left < n; left++)
            {
                for (int right = left; right < n; right++)
                {
                    int windowsum = 0;
                    for (int k = left; k <=right; k++)
                    {
                        windowsum = windowsum + nums[k];
                    }
                    maximumsubarray = Math.Max(maximumsubarray, windowsum);
                }
            }
            return maximumsubarray;
        }
        //maximum contiguous subarray sum(alternate)
        public static int maxcontiguous1(int[] nums)
        {
            int n = nums.Length;
            int maximumsubarray = int.MinValue;
            int runningwindowsum = 0;
            for (int left = 0; left < n; left++)
            {
                for (int right = left; right < n; right++)
                {
                    runningwindowsum = runningwindowsum + nums[right];

                    maximumsubarray = Math.Max(maximumsubarray, runningwindowsum);
                }
            }
            return maximumsubarray;
        }
        //kadane's
        public static int maxcontiguous2(int[] nums)
        {
            int maxsofar = nums[0];
            int maxendinghere = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                maxendinghere = Math.Max(maxendinghere + nums[i], nums[i]);
                maxsofar = Math.Max(maxsofar, maxendinghere);
            }
            return maxsofar;
        }
    }
}
