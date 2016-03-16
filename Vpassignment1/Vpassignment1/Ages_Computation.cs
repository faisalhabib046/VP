using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Vpassignment1
{
    //age computation class.
    class Ages_Computation
    {
        //input taking method.
        public DateTime[] inputDate(int siblings)
        {
            DateTime[] array = new DateTime[siblings];

            for (int i = 0; i < siblings; i++)
            {
                Console.WriteLine("\nEnter Date of Birth of Sibling : {0}", i + 1);
                array[i] = Convert.ToDateTime(Console.ReadLine());
            }
            return (array);
        }//End input Function


        //input conversion in int array.
        public void conversion(ref int[] day, ref int[] month, ref int[] year, DateTime[] array)
        {
            for (int i = 0; i < day.Length; i++)
            {
                day[i] = array[i].Day;
                month[i] = array[i].Month;
                year[i] = array[i].Year;
            }
        }//End Conversion function


        //calculation method to find total life time
        public void AgeCalculation(ref int[] day, ref int[] month, ref int[] year)
        {
            for (int i = 0; i < day.Length; i++)
            {
                day[i] = DateTime.Now.Day - day[i];
                month[i] = DateTime.Now.Month - month[i];
                if (DateTime.Now.Year > year[i])
                {
                    year[i] = DateTime.Now.Year - year[i];

                    if (day[i] < 0)
                    {
                        day[i] = day[i] - (day[i] * 2);
                        day[i] = 30 - day[i];
                        month[i] = month[i] - 1;
                    }
                    if (month[i] < 0)
                    {
                        month[i] = month[i] - (month[i] * 2);
                        month[i] = 12 - month[i];
                        year[i] = year[i] - 1;
                    }
                    Console.WriteLine("\nAge of Sibling {0} is : {1} Days {2} Months {3} Years", i + 1, day[i], month[i], year[i]);
                }
                else
                {
                    Console.WriteLine("Date Of Birth Can't be exceeded Today's date");
                }
            }
        }//End calculation method


        //Calculate difference between siblings
        public void Age_Differ(int[] day, int[] month, int[] year, int sibling)
        {
            for (int i = 0; i < sibling; i++)
            {
                if (i != sibling - 1)
                {
                    Console.WriteLine("\nAge Difference between {0} and {1}", i + 1, i + 2);
                    int d = day[i] - day[i + 1];
                    int m = month[i] - month[i + 1];
                    int y = year[i] - year[i + 1];

                    if (d < 0)
                    {
                        d = d - (d * 2);
                        d = 30 - d;
                        m = m - 1;
                    }
                    if (m < 0)
                    {
                        m = m - (m * 2);
                        m = 12 - m;
                        y = y - 1;
                    }
                    if (y < 0)
                    {
                        y = 0;
                    }
                    Console.WriteLine("\n{0} Days, {1} Months, {2} Years.", d, m, y);
                    i++;
                }
                else
                {
                    Console.WriteLine("\nAge Difference between {0} and {1}", i, i + 1);
                    int d = day[i] - day[i - 1];
                    int m = month[i] - month[i - 1];
                    int y = year[i] - year[i - 1];

                    if (d < 0)
                    {
                        d = d - (d * 2);
                        d = 30 - d;
                        m = m - 1;
                    }
                    if (m < 0)
                    {
                        m = m - (m * 2);
                        m = 12 - m;
                        y = y - 1;
                    }
                    if (y < 0)
                    {
                        y = y - (y * 2);
                    }
                    Console.WriteLine("\n{0} Days, {1} Months, {2} Years.", d, m, y);
                }
            }
        }//End difference function

    }//End of class
}
