// GFG Question : Subarray with given sum
// https://practice.geeksforgeeks.org/problems/subarray-with-given-sum-1587115621/1?page=1&category[]=Arrays&sortBy=submissions


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriverCode
{

    class GFG
    {
        static void Main(string[] args)
        {
            int testcases;// Taking testcase as input
            testcases = Convert.ToInt32(Console.ReadLine());
            while (testcases-- > 0)// Looping through all testcases
            {
                var stringArray = Console.ReadLine().Split(' ');
                int n = int.Parse(stringArray[0]);
                int s = int.Parse(stringArray[1]);
                int[] arr = new int[n];
                stringArray = Console.ReadLine().Split(' ');
                int j = 0;
                for (int i = 0; i < stringArray.Length; i++)
                {

                    if (stringArray[i].CompareTo(" ") != -1)
                    {
                        arr[j] = int.Parse(stringArray[i]);

                        j++;
                    }
                }
                Solution obj = new Solution();
                var res = obj.subarraySum(arr, n, s);
                foreach(int i in res){
                    Console.Write(i+" ");
                }
                Console.WriteLine();
            }

        }
    }




 // } Driver Code Ends
//User function Template for C#

    class Solution
    {
        //Function to find a continuous sub-array which adds up to a given number.
        public List<int> subarraySum(int[] arr, int n, int s)
        {
            int startIndex = 0; // Initialized to traverse the array from the start
            int currentSum = 0; // Set as 0, stores the cumulative sum as we traverse the array.
            for(int i = 0; i < n; i++)
            {
                if(s == arr[i])
                {
                   return new List<int> { i + 1, i + 1 };
                }
                else
                {
                    currentSum += arr[i];

                    while (currentSum > s && startIndex < i)
                    {
                        // If the currentSum goes above the required Sum, start subtracting array values from the beginning of the array
                        currentSum -= arr[startIndex];
                        startIndex++;
                    }

                    if(currentSum == s)
                    {
                        return new List<int> { startIndex + 1, i + 1 };
                    }
                }
            }
            return new List<int> { -1 };
        }

    }

}

// { Driver Code Starts.  // } Driver Code Ends
