using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExercises
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public static int GetFirstMatchingIndex(List<int> nums, int valueToMatch) 
        { 
            int matchingIndex = -1; 
 
            if (nums == null)
            {
                return matchingIndex;
            }
            if (nums.Count < 0) 
            { 
                return matchingIndex;
            }
             for (var i = 0; i < nums.Count; i++) 
             { 
                   if (nums[i] == valueToMatch) 
                    { 
                       matchingIndex = i; 
                       return matchingIndex;
                    } 
             } 
        }
    }
}
