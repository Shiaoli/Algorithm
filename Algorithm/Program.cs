using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Program pro = new Program();

            // 14 Easy
            /*
            string[] strs = new string[] { "flower", "flow", "flight" };
            Console.WriteLine(strs);
            string result14 = pro.LongestCommonPrefix(strs);
            Console.WriteLine(result14);
            */

            // 15 Medium
            /*
            int[] nums = new int[] { -1, 0, 1, 2, -1, -4 };
            IList<IList<int>> result15 = pro.ThreeSum(nums);
            foreach (var ll in result15)
            {
                foreach (var num in ll)
                {
                    Console.WriteLine(num);
                }
                Console.WriteLine();
                Console.WriteLine("the next line is ");
            }
            //Console.WriteLine(result15);
            */

            // 16 Medium
            int[] nums16 = new int[] {-1, 2, 1, -4 };
            int result16 = pro.ThreeSumClosest(nums16, 1);
            Console.WriteLine(result16);

        }

        // 14 Easy
        public string LongestCommonPrefix(string[] strs)
        {
            int length = 0;
            int shortLength = strs[0].Length;
            Console.WriteLine(strs.Length);
            for (int i = 0; i < strs.Length; i++)
            {
                Console.WriteLine(strs[i].Length);
                if (shortLength > strs[i].Length)
                {
                    shortLength = strs[i].Length;
                    Console.WriteLine(shortLength);
                }


            }
            Console.WriteLine(shortLength);
            string s0 = strs[0];
            for (int i = 0; i < shortLength; i++)
            {
                for (int j = 1; j < strs.Length; j++)
                {
                    string temp_s = strs[j];
                    if (s0[i] != temp_s[i])
                    {
                        length = i;
                        break;
                    }
                }
            }
            Console.WriteLine(length);
            string result = strs[0].Substring(0, length - 1);
            return result;
        }

        //15 Medium
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            List<IList<int>> result = new List<IList<int>>();
            List<int> temp = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    for (int k = j + 1; k < nums.Length; k++)
                    {
                        if ((nums[i] + nums[j] + nums[k]) == 0)
                        {
                            temp.Add(nums[i]);
                            temp.Add(nums[j]);
                            temp.Add(nums[k]);
                            result.Add(temp);
                            for (int t = 0; t < temp.Count; t++)
                            {
                                Console.WriteLine(temp[t]);
                            }
                            Console.WriteLine(temp.Count);
                            temp.RemoveRange(0, temp.Count);
                        }
                    }
                }
            }

            // TODO: result is empty now, not able to put temp in
            foreach (var m in result)
            {
                foreach (var n in m)
                {
                    Console.WriteLine(n);
                }
            }
            return result;

        }

        //16 Medium
        public int ThreeSumClosest(int[] nums, int target)
            {
                int closet = Math.Abs(nums[0] + nums[1] + nums[2] - target);
                int sum = nums[0]+nums[1]+nums[2];
            Console.WriteLine(sum);
                for(int i = 0; i < nums.Length; i++)
                {
                    for(int j = i + 1; j < nums.Length; j++)
                    {
                        for(int k = j + 1; k < nums.Length; k++)
                        {
                            if (Math.Abs(nums[i] + nums[j] + nums[k] - target) < closet)
                            {
                                sum = nums[i] + nums[j] + nums[k];
                            Console.WriteLine(sum);
                                closet = Math.Abs(nums[i] + nums[j] + nums[k] - target);
                            }
                        }
                    }
                }
                return sum;
            }

        // 17 Medium
        public IList<string> LetterCombinations(string digits)
        {
            char[][] mapping = new char[8][];
            mapping[0] = new char[3] { 'a', 'b', 'c' };
            mapping[1] = new char[3] { 'd', 'e', 'f' };
            mapping[2] = new char[3] { 'g', 'h', 'i' };
            mapping[3] = new char[3] { 'j', 'k', 'l' };
            mapping[4] = new char[3] { 'm', 'n', 'o' };
            mapping[5] = new char[4] { 'p', 'q', 'r', 's' };
            mapping[6] = new char[3] { 't', 'u', 'v' };
            mapping[7] = new char[4] { 'w', 'x', 'y', 'z' };

            List<string> result = new List<string>();
            for(int i = 0; i < digits.Length; i++)
            {
                if(digits[i] == '0'|| digits[i] == '1')
                {
                    result.Add("");
                }
                else
                {
                    for()
                }
            }
        }
    }
}
