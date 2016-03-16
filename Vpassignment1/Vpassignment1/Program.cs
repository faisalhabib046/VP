using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vpassignment1
{

    class Program
    {
        static void Main(string[] args)
        {
            int siblings;
            try
            {
                Console.WriteLine("Please Enter No of siblings ");
                siblings = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please Give Date of Birth in Following these 3 formats");
                Console.WriteLine("\t\t\tMM-DD-yyyy\n\t\t\tMM-yyyy-DD\n\t\t\tyyyy-MM-DD");

                Ages_Computation obj = new Ages_Computation();

                DateTime[] array = obj.inputDate(siblings);
                int[] day = new int[siblings];
                int[] month = new int[siblings];
                int[] year = new int[siblings];
                obj.conversion(ref day, ref month, ref year, array);
                obj.AgeCalculation(ref day, ref month, ref year);
                if (siblings > 1)
                {
                    obj.Age_Differ(day, month, year, siblings);
                }
                else
                {
                    Console.WriteLine("\nNumber Of Siblings is {0} Difference Can't be Calculated", siblings);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid Input.....! \nplease Enter Valid Input");
            }
        }
    }
}