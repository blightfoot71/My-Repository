using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableExercises
{
    public class HashTableExercises
    {
        public static int CountPairsWithDiff(int[] numbers, int difference)
        {
            var set = new HashSet<int>();

            foreach (var number in numbers)
                set.Add(number);

            var count = 0;
            foreach (var number in numbers)
            {
                if (set.Contains(number + difference))
                    count++;
                if (set.Contains(number - difference))
                    count++;
                set.Remove(number);
            }
            return count;
        }

        public static int CountPairsWithDiffUsingForLoops(int[] numbers, int diffence)
        {
            var count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    if ((numbers[i] - numbers[j]) == 2)
                        count++;
                }
            }

            return count;
        }

        public static int[] TwoSum(int[] numbers, int target)
        {
            // This function does not work
            var map = new Dictionary<int, int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                int complement = target - numbers[i];
                if (map.ContainsKey(complement))
                {
                    return new int[] { map[complement], i };
                }
                map[i] = numbers[i];
            }

            return null;
        }
    }
}
