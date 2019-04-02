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
            /*
            int[] nums16 = new int[] {-1, 2, 1, -4 };
            int result16 = pro.ThreeSumClosest(nums16, 1);
            Console.WriteLine(result16);
            */

            // 20 Easy
            /***
            string s = "(){}]";
            bool result20 = pro.IsValid(s);
            Console.WriteLine(result20);
            ****/

            //26 easy
            /***
            int[] nums = { 0, 0, 0, 1, 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 5 };
            int result26 = pro.RemoveDuplicates(nums);
            Console.WriteLine(result26);
            ***/

            //27 easy
            int[] val27 = { 0, 1, 2, 2, 3, 3, 0, 3, 4 };
            int v27 = 2;
            int length27 = pro.RemoveElement(val27, v27);

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

        // 17 Medium Not finished
        /*
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

            int length = 1;
            for(int i = 0; i < digits.Length; i++)
            {
                if(digits[i] == '7'|| digits[i] == '9')
                {
                    length = length * 4;
                }
                else
                {
                    length = length * 3;
                }
            }

            for(int )
        }
        */

        // 20, Easy finished
        public bool IsValid(string s)
        {
            var intString = new List<int>();
            for(int i = 0; i < s.Length; i++)
            {
                switch (s[i])
                {
                    case '(':
                        intString.Add(1);
                        break;
                    case ')':
                        intString.Add(-1);
                        break;
                    case '{':
                        intString.Add(2);
                        break;
                    case '}':
                        intString.Add(-2);
                        break;
                    case '[':
                        intString.Add(3);
                        break;
                    case ']':
                        intString.Add(-3);
                        break;
                    default:
                        break;
                }
            }
            var match = new Stack<int>();
            foreach(int num in intString)
            {
                if(match.Count == 0)
                {
                    match.Push(num);
                }
                else
                {
                    if(match.Peek()+num == 0)
                    {
                        match.Pop();
                    }
                    else
                    {
                        match.Push(num);
                    }
                }
            }
            if(match.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //21, Easy not finish
        
        /*
        public ListNode MergeTwoList(ListNode l1, ListNode l2)
        {
            ListNode first = l1.next;
            ListNode second = l2;
            ListNode backup = l2;
            //l2 = l2.next;
            while(l1.next != null)
            {
                if (l1.val < l2.val)
                {
                    l1.next = l2;
                    l2 = l1;
                }
                else
                {
                    l2 = l2.next;
                }
            }
        }
        **/

        //26 easy finished
        public int RemoveDuplicates(int[] nums)
        {
            int compare = nums[0];
            int length = nums.Length;
            for(int i=1; i < nums.Length; i++)
            {
                if(compare == nums[i])
                {
                    length--;
                }
                else
                {
                    compare = nums[i];
                    nums[i - nums.Length + length] = nums[i];
                }
            }
            return length;
        }

        //27 easy finished
        public int RemoveElement(int[] nums, int val)
        {
            int movement = 0;
            for (int i = 0; i < nums.Length - movement; i++)
            {
                if (nums[i] == val)
                {
                    for (int j = i; j < nums.Length - 1; j++)
                    {
                        nums[j] = nums[j + 1];
                    }
                    nums[nums.Length - 1] = val;
                    movement++;
                    i--;
                    Console.WriteLine(movement);
                }
            }
            return nums.Length - movement;
        }

        //28 Easy finished
        public int StrStr(string haystack, string needle)
        {
            if (needle.Length == 0)
            {
                return 0;
            }
            else
            {
                int stamp = 0;
                for (int i = 0; i < haystack.Length; i++)
                {
                    if (haystack[i] == needle[0])
                    {
                        stamp = i;
                        int t = i;
                        for (int j = 0; j < needle.Length; j++)
                        {
                            if (haystack[t] != needle[j])
                            {
                                break;
                            }
                            else
                            {
                                if (j == needle.Length - 1)
                                {
                                    return stamp;
                                }
                            }
                            if (t < haystack.Length - 1)
                            {
                                t++;
                            }
                            else
                            {
                                if (j != needle.Length - 1)
                                    return -1;
                            }
                        }
                    }
                }
            }
            return -1;
        }

        //459. Repeated Substring Pattern Easy Finished
        public bool RepeatedSubstringPattern(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                int len = i + 1;
                if (s.Length % len == 0)
                {
                    string sub = s.Substring(0, len);
                    //Console.WriteLine(sub);
                    for (int j = len; j < s.Length; j += len)
                    {
                        string compare = s.Substring(j, len);
                        //Console.WriteLine(compare);
                        if (sub != compare)
                            break;
                        else
                        {
                            if (j + len == s.Length)
                                return true;
                        }
                    }
                    //return true;
                }
            }
            return false;
        }

    }
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
}
