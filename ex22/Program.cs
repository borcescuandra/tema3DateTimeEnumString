using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex22
{
    class Program
    {
        static void Main(string[] args)
        {
            String str1 = "";
            String str2 = "Hello world";
            String str3 = "myStRing";
            String str4 = "always";
            String str5 = "I like coding.";
            String str6 = "   newString     ";
            String str7 = null;
            String str8 = ", user!";
            String str9 = "llo";

            bool test1 = String.IsNullOrEmpty(str1);
            bool test2 = String.IsNullOrEmpty(str7);



            Console.WriteLine(test1);
            Console.WriteLine(test2);

            Console.WriteLine(String.Compare(str2, str3));
            Console.WriteLine(str6);
            Console.WriteLine(str6.Trim());
            Console.WriteLine(str3.ToLower());
            Console.WriteLine(str4.ToUpper());

            String newString = String.Concat(str2, str8);
            Console.WriteLine(newString);

            Console.WriteLine(str4.IndexOf("ways"));
            Console.WriteLine(str2.Contains(str9));

        }
    }
}
