using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApplication3
{
    delegate int del(int a, int x);
    delegate double dol(double d, double u);

    [AttributeUsage(AttributeTargets.Class)]
    class sampleAttribute : Attribute
    {

   public string Topic               
   {
      get 
      { 
         return topic; 
      }
      set 
      { 

        topic = value; 
      }
   }

   private string topic;
    }

    [sampleAttribute]
    class a
    {
        public void func(string a)
        {
            
        }
        
        public static int mul(int val,int val1)
        {
            return val * val1;
        }
    }
    class b
    {
        public static double add(double val, double val1)
        {
            return val + val1;
        }
    }
        class Program
        {
            static void Main(string[] args)
            {
                del obj = new del(a.mul);
                int rehan = obj(4, 4);
                Console.WriteLine(rehan);

                dol obj1 = new dol(b.add);
                double hasnat = obj1(2, 2);
                Console.WriteLine(hasnat);
            }
        }
    }
