using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RomanToInt("LVIII"));
            Console.Read();
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                int back = target - nums[i];
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (back == nums[j])
                        return new int[] { nums[i], nums[j] };
                }
            }
            return null;
        }

        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            List<int> list = new List<int>();
            list.AddRange(nums1);
            list.AddRange(nums2);

            list.Sort();
            int middle = list.Count / 2;
            if (list.Count % 2 != 0)
            {
                return list[middle];
            }
            else
                return (list[middle - 1] + list[middle]) / (double)2;
        }

        public static string Convert(string s, int numRows)
        {
            if (s == null)
                return null;

            if (numRows == 1 || s.Count() < numRows)
                return s;

            int move = 0;
            bool down = true;
            string output = "";
            string[] set = new string[numRows];
            char[] stringArray = s.ToCharArray();

            for (int i = 0; i < stringArray.Length; i++)
            {
                set[move] += stringArray[i];

                if (move == 0)
                {
                    down = true;
                }
                else if (move == (numRows - 1))
                {
                    down = false;
                }
                if (down == true)
                {
                    move++;
                }
                else if (down == false)
                {
                    move--;
                }
            }
            foreach (var se in set)
            {
                output += se;
            }
            return output;
        }

        public static int Reverse(int x)
        {
            int output = 0;

            while (x != 0)
            {
                if (output > int.MaxValue / 10)
                    return 0;
                if (output < int.MinValue / 10)
                    return 0;
                output = (output * 10) + (x % 10);
                x /= 10;
            }
            return output;
        }

        public static bool IsPalindrome(int x)
        {
            if (x < 0)
                return false;

            int reNum = Reverse(x);

            if (reNum == x)
                return true;
            else
                return false;
        }

        public static int MaxArea(int[] height)
        {
            int lowIndex = 0;
            int highIndex = height.Length - 1;
            int maxArea = 0;

            while (lowIndex < highIndex)
            {
                maxArea = Math.Max(maxArea, (highIndex - lowIndex) * Math.Min(height[highIndex], height[lowIndex]));

                if (height[highIndex] > height[lowIndex])
                    lowIndex++;
                else
                    highIndex--;
            }
            return maxArea;
        }

        public static string IntToRoman(int num)
        {
            if (num < 1 || num > 3999)
                return null;

            string[] symbols = new string[] { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
            int[] values = new int[] { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < symbols.Length; i++)
            {
                while (num >= values[i])
                {
                    sb.Append(symbols[i]);
                    num -= values[i];
                }
            }

            return sb.ToString();
        }

        public static int RomanToInt(string s)
        {
            string[] symbols = new string[] { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
            int[] values = new int[] { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            int output = 0;

            while (s.Length > 0)
            {
                string symbol = symbols.First(x => s.StartsWith(x));
                int index = Array.IndexOf(symbols, symbol);
                output += values[index];
                s = s.Remove(0, symbol.Length);
            }

            return output;
        }

        public static string LongestCommonPrefix(string[] strs)
        {

            return null;
        }
    }
}
