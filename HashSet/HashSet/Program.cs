namespace HashSet
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Diagnostics;

    class Program
    {
        static void Main(string[] args)
        {
            var d = 1200M;
            var d1 = d.ToString("#");

            //var s = "abcertyywtruwyrtwueyrtuweyrtwueyrtuweyrtwueyrwueyruweyruweyrwuerwueyruweyrtuywertwueyruwertw";
            //ModifyS(ref s);

            //int a = 20000;
            //string s = $"{a/100:C}";

            double amount = 44444.56888;
            int Bill1ExpenseAmount = Convert.ToInt32(amount*100);

            string[] array1 =
            {
                "cat",
                "dog",
                "cat",
                "leopard",
                "tiger",
                "cat"
            };
            Debug.WriteLine(string.Join(",",array1));
            var hash = new HashSet<string>(array1);
            var array2 = hash.ToArray();
            Debug.WriteLine(string.Join(",",array2));
        }

        //static void ModifyS(string s)
        static void ModifyS(ref string s)
        {
            s = s.Substring(0, Math.Min(15, s.Length));
        }
    }
}
