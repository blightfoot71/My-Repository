using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashFirstNonRepeatingCharacter
{
    public class CharFinder
    {
        public char findFirstNonRepeatingChar(string str)
        {
            var map = new Dictionary<char, int>();

            Console.WriteLine(str);

            foreach (var ch in str)
            {
                if (map.ContainsKey(ch))
                {
                    var count = map[ch];
                    count++;
                    map.Remove(ch);
                    map.Add(ch, count);
                } else
                {
                    map.Add(ch, 1);
                }
            }

            foreach (var ch in str)
                if (map[ch] == 1)
                    return ch;

            return char.MinValue;

        }

        public char findFirstRepeatedChar(string str)
        {
            var set = new HashSet<char>();

            foreach (var ch in str)
            {
                if (set.Contains(ch))
                    return ch;

                set.Add(ch);
            }

            return char.MinValue;
        }
    }
}
