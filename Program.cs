using System;

namespace VisitorCounter
{
    internal class Program
    {

        /* 
         *   A manager hires a staff member to keep a record of the number of men, women, and children visiting the museum daily. 
         *   The staff will note W if any women visit, M for men, and C for children. 
         *   You need to write code that takes the string that represents the visits and prints the count of men, woman and children. 
         *   The sequencing should be in decreasing order.
         *   Example:
         *  
         *  Input:
         *  WWMMWWCCC
         *  
         *  Expected Output:
         *  4W3C2M
         *  
         *  Explanation:
         *  ‘W’ has the highest count, then ‘C’, then ‘M’.
         *  Note:
         *  - The input is already parsed and passed to a function.
         *  - You need to "print" the final result (not return it) to pass the test cases.
         *  - If the input is- “MMW”, then the expected output is "2M1W" since there is no ‘C’.
         *  - If any of them have the same count, the output should follow this order - M, W, C.
         * 
         */
        static void Main(string[] args)
        {
            // Test Data
            string strInput = "CCWWMM";
            // Expected Output
            // 4W3C2M

            // -The input is already parsed and passed to a function.
            fnCountVisitor(strInput);

            Console.ReadLine();

        }

        static void fnCountVisitor(string strInputData)
        {
            Dictionary<char, int> counts = new Dictionary<char, int>();

            // Keep track of visitor
            counts['M'] = 0;
            counts['W'] = 0;
            counts['C'] = 0;

            // Do the counting
            foreach (char visits in strInputData)
            {
                counts[visits]++;
            }

            // Sort
            List<char> sortedList = new List<char>(counts.Keys);
            sortedList.Sort((x, y) => counts[y].CompareTo(counts[x]));

            // You need to "print" the final result (not return it) to pass the test cases.
            // If any of them have the same count, the output should follow this order - M, W, C.
            foreach (char key in sortedList)
            {
                Console.Write($"{counts[key]}{key}");
            }
        }
    }
}