using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
            const string welcomeCohort = ConfigurationManager.welcomeCohort;
            const string presentJobTypes = ConfigurationManager.presentJobTypes;
            const string goodbyeCohort = ConfigurationManager.goodbyeCohort;
            const int durationOfSleep = ConfigurationManager.durationOfSleep;
            Console.WriteLine(welcomeCohort); 
            Thread.Sleep(durationOfSleep); 

            var jobTypes = new string[] { "PM", "Dev", "Other" };
            Console.WriteLine(presentJobTypes); 
            foreach (var type in jobTypes) 
                Console.WriteLine(type); 
 
            Console.WriteLine(goodbyeCohort); 
        }
        public class C1 
        { 
            public void DoStuff() { } 
        } 
        public class C2 
        { 
            public void DoStuff() { } 
        } 
        public class C3 
        { 
            public void DoStuff() { } 
        } 
 
        public class C4 
        { 
            private C1 c1; 
            private C2 c2; 
            private C3 c3; 
 
            public C4(C1 c1, C2 c2, C3 c3) 
            { 
                this.c1 = c1;
                this.c2 = c2;
                this.c3 = c3;
            } 
 
            public void DoStuff() 
            { 
                c1.DoStuff(); 
                c2.DoStuff(); 
                c3.DoStuff(); 
            } 
        } 
    }
}
