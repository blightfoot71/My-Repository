
namespace DynamicBinding
{
    class Program
    {
        static void Main(string[] args)
        {
            object obj = "Mosh";
            // obj.GetHashCode()

            // Below is an example of reflection Mosh says it's messy
            //var methodInfo = obj.GetType().GetMethod("GetHashCode");
            //methodInfo.Invoke(null, null);

            //object excelObject = "mosh";
            //excelObject.Optimize();     // We get a compile error because the object class doesn't have a method called Optimize

            // Do the following instead using dynamic (much cleaner than reflection above
            //dynamic excelObject = "mosh";
            //excelObject.Optimize();

            //dynamic name = "Mosh";
            ////name = 10;              // dynamics make things like this possible and it will run
            //name++;                     // This doesn't work

            //dynamic a = 10;
            //dynamic b = 5;
            //var c = a + b;      // c becomes dynamic
            
            
            int i = 5;
            dynamic d = i;      // at run-time d will be an integer
            long l = d;         // implicit casting from int to long int
        }
    }
}
