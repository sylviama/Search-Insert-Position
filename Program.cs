using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Your code goes here
            int[] nums=new int[]{1,3,5,6,7,9};
            int target=11;
            Solution solu=new Solution();
            int result=solu.SearchInsert(nums, target);
            Console.WriteLine("Location or Insert Location: {0}", result);
        }
    }
    
    public class Solution {
        public int SearchInsert(int[] nums, int target) {
            //return location index if found
            for(var i=0;i<nums.Length;i++)
            {
                if(target==nums[i])
                {
                    return i;
                }
            }
            
            //find location to insert if still running
            for(var j=0;j<nums.Length;j++)
            {
                if(nums[j]>target)
                {
                    return j;
                }
            }
            
            return nums.Length;
        }
    }
}
