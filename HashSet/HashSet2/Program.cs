using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace HashSet2
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] array1 = {'a', 'b', 'c'};
            char[] array2 = {'b', 'c', 'd'};

            var hash = new HashSet<char>(array1);
            hash.SymmetricExceptWith(array2);   // 'a' and 'd'?

            //Console.WriteLine(hash.ToArray());
            foreach(var e in hash.ToArray())
                Debug.Write(e);
        }
    }
}
