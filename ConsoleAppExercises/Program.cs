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
        public static IEnumerable<int> GetFirstMatchingIndex(IEnumerable<int> nums, int valueToMatch) 
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
             return matchingIndex;
        }
        public static void DoStuff() 
        { 
            Console.WriteLine("Hello Cohort!"); 
            Thread.Sleep(2000); 
 
            var jobTypes = new string[] { "PM", "Dev", "Other" }; 
            Console.WriteLine("The job types are:"); 
            foreach (var type in jobTypes) 
                Console.WriteLine(type); 
 
            Console.WriteLine("Goodbye Cohort!"); 
        }
    }
}
