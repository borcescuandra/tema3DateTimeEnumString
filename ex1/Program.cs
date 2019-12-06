using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex22
{
    class Program
    {
        public enum Gender
        {
            Male = 'M',
            Female = 'F',
            Invalid
        }

        static string GetGender(int gender)
        {
            switch (gender)
            {
                case 'M':
                    return "Male -> retirement date: 65";

                case 'F':
                    return "Female -> retirement date: 63";

                default:
                    return null;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti anul:");
            int year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduceti luna:");
            int month = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduceti ziua:");
            int day = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduceti genul(M/F):");
            char gender = Convert.ToChar(Console.ReadLine());

            DateTime birthDate = new DateTime(year, month, day);
            Console.WriteLine(birthDate.ToString("dd/MM/yyyy"));

            DateTime now = DateTime.Now;

            int age = now.Year - birthDate.Year;

            Console.WriteLine("Varsta = {0}", age);
            Gender? Invalid = null;

            Console.WriteLine("Gender = {0}", GetGender(gender));







        }
    }
}
