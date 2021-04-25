using System;
using System.Collections;
using System.Collections.Generic;

using System.Text;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {


            //Question1:
            Console.WriteLine("Question 1:");
            int[] ar1 = { 2, 5, 1, 3, 4, 7 };
            int n1 = 3;
            ArrayShuffling(ar1, n1);
            Console.WriteLine("");


            //Question 2 
            Console.WriteLine("\nQuestion 2:");
            int[] ar2 = { 0, 1, 0, 3, 12 };
            MoveZeroes(ar2);
            Console.WriteLine("");

            //Question3
            Console.WriteLine("\nQuestion 3:");
            int[] ar3 = { 1, 2, 3, 1, 1, 3 };
            GetColorPairs(ar3);
            Console.WriteLine("");

            //Question 4
            Console.WriteLine("Question 4:");
            int[] ar4 = { 2, 7, 11, 15 };
            int target = 9;
            GetTwoSum(ar4, target);
            Console.WriteLine();
            Console.ReadKey();

            //Question 5
            Console.WriteLine("\nQuestion 5:");
            string s5 = "korfsucy";
            int[] indices = { 6, 4, 3, 2, 1, 0, 5, 7 };
            var result = RestoreString(s5, indices);
            Console.WriteLine(result);
            Console.ReadKey();

            //Question 6
            Console.WriteLine("Question 6:");
            string s61 = "bulls";
            string s62 = "sunny";
            if (Isomorphic(s61, s62))
            {
                Console.WriteLine("Yes the two strings are Isomorphic");
            }
            else
            {
                Console.WriteLine("No, the given strings are not Isomorphic");
            }
            Console.WriteLine();
            Console.ReadKey();

            //Question 7
            Console.WriteLine("Question 7");
            int[,] scores = { { 1, 91 }, { 1, 92 }, { 2, 93 }, { 2, 97 }, { 1, 60 }, { 2, 77 }, { 1, 65 }, { 1, 87 }, { 1, 100 }, { 2, 100 }, { 2, 76 } };
            HighFive(scores);
            Console.WriteLine();
            Console.ReadKey();

            //Question 8
            Console.WriteLine("\nQuestion 8:");
            int n8 = 19;
            if (GetHappyNumber(n8))
            {
                Console.WriteLine("{0} is a happy number", n8);
            }
            else
            {
                Console.WriteLine("{0} is not a happy number", n8);
            }

            Console.WriteLine();
            Console.ReadKey();

            //Question 9
            Console.WriteLine("Question 9:");
            // int.MaxValue
            int a = 0;
            a = int.MaxValue;
            int[] ar9 = { 7, 1, 5, 3, 6, 4 };
            int profit = GetStocks(ar9);
            if (profit == 0)
            {
                Console.WriteLine("No Profit is possible");
            }
            else
            {
                Console.WriteLine("Profit is {0}", profit);
            }
            //Console.WriteLine(a);
            Console.ReadKey();

            //Question 10
            Console.WriteLine("\nQuestion 10:");
            int n10 = 3;
            Stairs(n10);
            Console.WriteLine(Stairs(n10));
            Console.ReadKey();



        }

        //Question 1      
        //It took me 3 hours to solve this problem. To divide the array into two parts according to odd-even of the index of the array.
        //I have a problem to print the array using return function because of void, thus I use for loop to print all numbers in the new array.

        public int[] Shuffle(int[] nums, int n)
        {
            try
            {

                int len = nums.Length;
                int[] res = new int[len];
                int j = -1;
                if ((n <= 500 && n >= 1) && (len == 2 * n))
                {
                    for (int i = 0; i < n; i++)
                    {
                        j = j + 1;
                        res[j] = nums[i];
                        j = j + 1;
                        res[j] = nums[n + i];

                    }
                }
                return res;





            }
            catch (Exception)
            {
                throw;
            }

        }


        //Question 2
        //It took me 3 hours to solve the problem using in place instead of create a new array
        //I need to make all the non-zeros in the front and all zeros in the end in this array by replacing the position


        private static void MoveZeroes(int[] ar2)
        {
            try
            {


                //Count of non-zero elements 
                int count = 0;

                //Count the length of array
                int n = ar2.Length;

                //Traverse the array.If element encountered is non-zero, then replace the element  
                for (int i = 0; i < n; i++)

                    if (ar2[i] != 0)

                        //count is incremented and shift all non-zero elements from the starting of the original array
                        ar2[count++] = ar2[i];


                //Make all elements 0 to end, starting from the last non-zero element. 
                while (count < n)
                    ar2[count++] = 0;

                // Print out array
                for (int i = 0; i < n; i++)
                    Console.Write(ar2[i] + " ");
                Console.ReadKey();

            }
            catch (Exception)
            {

                throw;
            }

        }
        //Question 3
        //It took me 4 hours to solve the problem and learn dictionary function.To make time complexity to be O(n),we need to use dictionary.
        //Contains key function in the dictionary is very useful, it will make the value in the array to be the key in this dictionary.
        //And we can use the value in the dictionary to count counts.


        public int NumIdenticalPairs(int[] nums)
        {
            try
            {

                if (nums == null || nums.Length == 0)
                    return 0;

                int res = 0;
                Dictionary<int, int> dict = new Dictionary<int, int>();

                foreach (var num in nums)
                {
                    if (!dict.ContainsKey(num))
                        dict.Add(num, 0);

                    dict[num] += 1;
                }

                foreach (var item in dict.Values)
                    if (item != 1)
                        res += item * (item - 1) / 2;

                return res;

            }
            catch (Exception)
            {

                throw;
            }
        }

        //Question 4
        //It took me 4 hours to solve the problem.
        //I need to determine if the two element add up equals to target and the print the index of the elements using dictionary to reduce time complexity




        //Question 5
        //It took me 3 hours to solve the problem
        //The importance of this one is to rearrange the indices, to make the value of indices is the index of the cArr

        public static string RestoreString(string s, int[] indices)
        {
            try
            {
                if (s == null || s == "")
                    return "";

                char[] arr = new char[s.Length];
                for (int i = 0; i < s.Length; i++)
                {
                    arr[indices[i]] = s[i];
                }
                return new string(arr);
            }
            catch (Exception)
            {
                throw new Exception("An Erro Occur while restoring strings");
            }
        }

        //Question 6
        //It took me 6 hours to solve the problem
        //create two dictionaries to store the value of the array to be the key

        public bool IsIsomorphic(string s, string t)
        {
            try
            {
                if (s.Length != t.Length) return false;

                var dict = new Dictionary<char, char>();

                for (var i = 0; i < s.Length; i++)
                {
                    if (!dict.ContainsKey(s[i]) && !dict.ContainsValue(t[i]))
                        dict[s[i]] = t[i];
                    else if (!dict.ContainsKey(s[i]) || dict[s[i]] != t[i]) return false;
                }

                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Question 7
        //It took me 6 hours to solve the problem and I learn how to use dictionary and sort them in the list as well as double dimensional array

        private static void HighFive(int[,] items)
        {
            try
            {
                var dict = new SortedDictionary<int, List<int>>();
                for (int j = 0; j < items.GetLength(0); j++)
                //foreach (var student in items)
                {
                    var studentId = items[j, 0];
                    var score = items[j, 1];
                    if (dict.ContainsKey(studentId))
                    {
                        dict[studentId].Add(score);
                    }
                    else
                    {
                        dict[studentId] = new List<int>();
                        dict[studentId].Add(score);
                    }
                }

                // now walk through the dict
                var keys = dict.Keys;
                var ans = new int[keys.Count, keys.Count];
                int i = 0;
                // Console.Write(keys);
                foreach (var student in dict)
                {
                    //ans[i] = new int[2];
                    ans[i, 0] = student.Key;
                    var sum = 0;
                    // sort the score and get the first 5
                    var temp = student.Value.ToArray();
                    Array.Sort(temp);
                    var k = 5;
                    for (int j = temp.Length - 1; j >= 0 && k > 0; j--)
                    {
                        //Console.WriteLine(temp[j]);
                        sum += temp[j];
                        k--;
                    }
                    ans[i, 1] = sum / 5;
                    //Console.WriteLine("[{0},{1}]",student.Key,ans[i,1]);
                    i++;
                }

                Console.Write("[[{0},{1}],[{2},{3}]]", ans[0, 0], ans[0, 1], ans[1, 0], ans[1, 1]);
            }


            catch (Exception)
            {

                throw;
            }

        }


        //Question 8
        //It took me 7 hours to solve the problem
        //It's important to divide digits by using divide and mod method

        public bool IsHappy(int n)

        {
            try
            {

                var hashset = new HashSet<int>();

                while (!hashset.Contains(n) && n != 1)
                {
                    hashset.Add(n);
                    var newNum = 0;

                    while (n != 0)
                    {
                        newNum = newNum + (int)Math.Pow(n % 10, 2);
                        n = n / 10;
                    }

                    n = newNum;
                }

                return n == 1;

            }
            catch (Exception)
            {

                throw;
            }
        }


        //Question 9
        //It took me 4 hours to solve the problem.
        //It's somewhat similar to GetTwoSum but need to pay attention that it must be the latter minus the former elements

        public int GetMaxProfit(int[] prices)
        {
            try
            {
                if (prices.Length <= 1)
                {
                    return 0;
                }
                int GetMaxProfit = Int32.MinValue;
                int i = prices.Length - 1;
                Stack<int> tracker = new Stack<int>();
                while (i >= 0)
                {
                    while (tracker.Count != 0 && prices[i] > tracker.Peek())
                    { //always save the maxValue available value on top of stack
                        tracker.Pop();
                    }
                    if (tracker.Count == 0)
                    {
                        tracker.Push(prices[i]);
                    }
                    else
                    {
                        GetMaxProfit = Math.Max(tracker.Peek() - prices[i], GetMaxProfit);//Check the GetMaxProfit with the current difference
                    }
                    i--;
                }

                return GetMaxProfit < 0 ? 0 : GetMaxProfit;
            }
            catch (Exception)
            {

                throw;
            }

        }

        //Question 10
        //It took me 2 hours to solve the problem.
        //I learnt the concept of Fibonacci series.

        public static int FindStep(int n)
        {
            try
            {
                {
                    if (n == 1 || n == 0)
                        return 1;
                    else if (n == 2)
                        return 2;

                    else
                        return FindStep(n - 3) + FindStep(n - 2) + FindStep(n - 1);
                }
            }
            catch (Exception)
            {
                throw new Exception("An erro occue while finding steps");
            }
        }

        private static int Stairs(int n)
        {
            try
            {
                int first = 1;
                int second = 1;
                while (n-- > 0)
                {
                    int tmp = first;
                    first = second;
                    second = tmp + second;
                }
                return first;
            }
            catch (Exception)
            {
                throw new Exception("an erro occur in stairs function");
            }

        }

        private static void ArrayShuffling(int[] nums, int n)
        {
            try
            {
                int[] answer = new int[2 * n];
                int k = 0, m = n;
                for (int i = 0; i < 2 * n; i++)
                {
                    if (i % 2 == 0)
                        answer[i] = nums[k++];
                    else
                        answer[i] = nums[m++];
                }
                for (int i = 0; i < 2 * n; i++)
                    Console.Write(answer[i] + " ");
                Console.ReadKey();
            }
            catch (Exception)
            {
                throw new Exception("An erro occue while shuffling array");
            }
        }

        private static void GetColorPairs(int[] nums)
        {
            try
            {
                Dictionary<int, int> dict = new Dictionary<int, int>();

                int count = 0;

                for (int i = 0; i < nums.Length; i++)
                {
                    if (dict.ContainsKey(nums[i]))
                    {
                        count += dict[nums[i]];
                        dict[nums[i]]++;
                    }
                    else
                    { dict[nums[i]] = 1; }
                }

                Console.WriteLine(count);
                Console.ReadKey();

            }
            catch (Exception)
            {

                throw;
            }
        }
        private static int GetStocks(int[] prices)
        {
            try
            {
                int minprice = int.MaxValue;
                int GetMaxProfit = 0;

                for (int i = 0; i < prices.Length; i++)
                {
                    if (prices[i] < minprice)
                    {
                        minprice = prices[i];
                    }
                    else if (prices[i] - minprice > GetMaxProfit)
                    {
                        GetMaxProfit = prices[i] - minprice;
                    }
                }

                return GetMaxProfit;
            }
            catch (Exception)
            {

                throw new Exception("error while getting stoks");
            }
        }


        private static bool Isomorphic(string s, string t)
        {
            try
            {
                Dictionary<char, int> lookups = new Dictionary<char, int>();
                Dictionary<char, int> lookupt = new Dictionary<char, int>();

                for (int i = 0; i < s.Length; i++)
                {
                    if (!lookups.ContainsKey(s[i]))
                        lookups.Add(s[i], 0);
                    if (!lookupt.ContainsKey(t[i]))
                        lookupt.Add(t[i], 0);

                    if (lookups[s[i]] != lookupt[t[i]])
                        return false;

                    lookups[s[i]] = i + 1;
                    lookupt[t[i]] = i + 1;
                }
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
        private static void GetTwoSum(int[] nums, int target)
        {
            try
            {
                var dict = new Dictionary<int, int>();

                for (int i = 0; i < nums.Length; i++)
                {
                    if (dict.ContainsKey(target - nums[i])) 
                    {
                        Console.Write("[{0},{1}]", dict[target - nums[i]], i);
                    }
                    else if (!dict.ContainsKey(nums[i])) 
                    {
                        dict.Add(nums[i], i);
                    }
                }
                return;
            }
            catch (Exception)
            {
                throw new Exception("Erro occur while making two sum");
            }
        }
        private static bool GetHappyNumber(int n)

        {
            try
            {
                HashSet<int> hset = new HashSet<int>() { n };
                while (n != 1)
                {
                    int nn = 0;
                    while (n > 0)
                    {
                        int d = n % 10;
                        nn += d * d;
                        n = n / 10;
                    }
                    if (!hset.Add(nn))
                        return false;
                    n = nn;
                }
                return true;
            }
            catch (Exception)
            {
                throw new Exception("Erro while Getting Happy numbers");
            }
        }

    }


}
