using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World_Program
{
    public class AdditionofTwoNumbers
    {
        public static void AddingToNum()
        {
            int a,b,c;

            Console.WriteLine("Enter value for a and b");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = a + b;
            Console.WriteLine("Addition of {0} & {1} is : {2}",a,b ,c);
        }
        //public void SubOfNum(int d,int e)
        //{
        // Console.WriteLine("")   
        //}
    }
}
