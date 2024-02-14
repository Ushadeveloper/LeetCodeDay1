using System;
using System.Collections.Generic;

namespace LeetCodeDay1
{
    class Program
    {

        public int[] TwoSum(int[] nums, int target)
        {
            // Create a dictionary to store the indices of elements
            Dictionary<int, int> numIndices = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];

                // Check if the complement is already in the dictionary
                if (numIndices.ContainsKey(complement))
                {
                    // Return the indices of the two numbers
                    return new int[] { numIndices[complement], i };
                }

                // Add the current number and its index to the dictionary
                numIndices[nums[i]] = i;
            }

            // No solution found
            throw new ArgumentException("No two numbers add up to the target");

        }
        static void Main(string[] args)
        {
            // Example usage
            int[] nums = { 9, 7, 2, 15, 21 };
            int target = 30;

            Program solution = new Program();
            int[] result = solution.TwoSum(nums, target);

            Console.WriteLine($"Indices of the two numbers: [{result[0]}, {result[1]}]");
            Console.ReadLine();
        }
    }
}
