using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableBuildFromScratch
{
    public class HashTable
    {
        private class Entry
        {
            public int key;
            public string value;

            public Entry(int key, string value)
            {
                this.key = key;
                this.value = value;
            }
        }

        private LinkedList<Entry>[] entries = new LinkedList<Entry>[5];

        public void Put(int key, string value)
        {
            var index = hash(key);
            if (entries[index] == null)
                entries[index] = new LinkedList<Entry>();

            var bucket = entries[index];
            foreach(var entry in bucket)
            {
                if (entry.key == key)
                {
                    entry.value = value;
                    return;
                }
            }

            bucket.AddLast(new Entry(key, value));
        }

        private int hash(int key)
        {
            return key % entries.Length;
        }

        public string Get(int key)
        {
            var index = hash(key);
            var bucket = entries[index];

            if (bucket != null)
            {
                foreach (var entry in bucket)
                    if (entry.key == key)
                        return entry.value;
            }
            return null;

        }

        public void Remove(int key)
        {
            var index = hash(key);
            var bucket = entries[index];

            if (bucket == null)
                throw new ArgumentNullException();

            foreach (var entry in bucket)
                if (entry.key == key)
                {
                    bucket.Remove(entry);
                    return;
                }
            throw new ArgumentOutOfRangeException();
        }
    }
}
