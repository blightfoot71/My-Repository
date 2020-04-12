using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BucketSort
{
    class BucketSort
    {
        public void Sort(int[] array, int numberOfBuckets) 
        {
            //for (var i = 0; i < numberOfBuckets; i++)
            //    bucketArray[i].Sort();

            //foreach (var bucket in bucketArray)
            //    bucket.Sort();

            //var j = 0;
            //for (var i = 0; i < numberOfBuckets; i++)
            //{
            //    bucketArray[i].Sort();

            //    while (bucketArray[i].Count > 0)
            //    {
            //        array[j++] = bucketArray[i].First();
            //        bucketArray[i].RemoveAt(0);
            //    }
            //}

            var j = 0;
            foreach (var bucket in CreateBuckets(array, numberOfBuckets))
            {
                bucket.Sort();
                foreach (var item in bucket)
                    array[j++] = item;
            }
        }

        private List<int>[] CreateBuckets(int[] array, int numberOfBuckets)
        {
            List<int>[] bucketArray = new List<int>[numberOfBuckets];

            for (var i = 0; i < bucketArray.Length; i++)
                bucketArray[i] = new List<int>();

            for (var i = 0; i < array.Length; i++)
            {
                var item = array[i];
                var bucket = item / numberOfBuckets;
                bucketArray[bucket].Add(item);
            }

            return bucketArray;
        }
    }
}
