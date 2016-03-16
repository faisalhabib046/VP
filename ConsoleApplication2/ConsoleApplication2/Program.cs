using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 11, 8, 5,12};
            for (int i = 0; i < 6; i++)
            {
                if (array[i]==0)
                {
                    array[i] = array[i];
                }
               if (array[i]>=array[i+1])
                {
                    array[i + 1] = array[i];
                }
               else if (array[i + 1] < array[i])
               {
                   array[i] = array[i + 1];
               }

                Console.WriteLine(array[i]);
            }
        }
    }
}
