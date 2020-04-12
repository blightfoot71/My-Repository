using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableExercisesMostFrequent
{
    public class HashTableExercises
    {
        public static int MostFrequent(int[] numbers)
        {
            var table = new Dictionary<int, int>();

            foreach (var number in numbers)
            {
                if (table.ContainsKey(number))
                {
                    var count = table[number];
                    //table.Remove(number);
                    //table.Add(number, ++count);
                    table[number] = ++count;
                }
                else
                {
                    table[number] = 1;
                }
            }

            int max = 0;
            int result = numbers[0];
            foreach (var number in table)
            {
                if (number.Value > max)
                {
                    max = number.Value;
                    result = number.Key;
                }
            }

            return result;
        }
    }
}
