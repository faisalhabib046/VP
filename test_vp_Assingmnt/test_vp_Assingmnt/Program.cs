using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace test_vp_Assingmnt
{
    class Program
    {
        static void Main(string[] args)
        {
            string daa;
            Console.WriteLine("provide input");
            daa = Console.ReadLine();
            //string createddate = Convert.ToDateTime(daa).ToString("yyyy-dd-MM");
            DateTime dt = DateTime.ParseExact(daa, "yyyy-dd-MM", CultureInfo.InvariantCulture);
            Console.WriteLine(dt);
        }
    }
}