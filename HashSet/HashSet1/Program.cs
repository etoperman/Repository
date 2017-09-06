namespace HashSet1
{
    using System.Collections.Generic;
    using System.Diagnostics;

    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = {1, 2, 3};
            int[] array2 = {3, 4, 5};
            int[] array3 = {9, 10, 11};

            var set = new HashSet<int>(array1);
            var a = set.Overlaps(array2);   //true?
            var b = set.Overlaps(array3);   //false?

            Debug.WriteLine(a);
            Debug.WriteLine(b);
        }
    }
}
