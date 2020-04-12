using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashMap
{
    public class HashMap
    {
        private class Entry
        {
            public int key;
            public string value;

            public Entry(int key, String value)
            {
                this.key = key;
                this.value = value;
            }
        }

        private Entry[] entries = new Entry[5];
        private int count;

        public void Put(int key, string value)
        {
            var entry = getEntry(key);
            if (entry != null)
            {
                entry.value = value;
                return;
            }

            if (IsFull())
                throw new ArgumentOutOfRangeException();

            entries[getIndex(key)] = new Entry(key, value);
            count++;
        }

        public string Get(int key)
        {
            //if (entries[Hash(key)].key == key)
            //    return entries[Hash(key)].value;

            //return entries[getIndex(key)].value;

            var entry = getEntry(key);
            return entry != null ? entry.value : null;
        }

        public void Remove(int key)
        {
            var index = getIndex(key);
            if (index == -1 || entries[index] == null)
                return;

            entries[index] = null;
            count--;
        }

        private Entry getEntry(int key)
        {
            var index = getIndex(key);
            return index >= 0 ? entries[index] : null;
        }

        private int getIndex(int key)
        {
            int steps = 0;

            while (steps < entries.Length)
            {
                int index = Index(key, steps++);
                var entry = entries[index];
                if (entry == null || entry.key == key)
                    return index;
            }

            return -1;
        }

        private int Index (int key, int i)
        {
            return (Hash(key) + i) % entries.Length;
        }

        private int Hash (int key)
        {
            return key % entries.Length;
        }

        private bool IsFull()
        {
            return count == entries.Length;
        }

        public int Size()
        {
            return count;
        }
    }
}
