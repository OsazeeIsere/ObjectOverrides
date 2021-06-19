using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOverrides
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fun with System.Object \n");
            //Person p1 = new Person();

            ////use inherited members of system.object
            //Console.WriteLine("ToString: {0}",p1.ToString());
            //Console.WriteLine("Has Code {0}", p1.GetHashCode());
            //Console.WriteLine("Type: {0}", p1.GetType());

            ////make some other references to p1
            //Person p2 = p1;
            //object o = p2;
            ////are the references pointing to the same object in memory
            //if(o.Equals(p1)&& p2.Equals(o))
            //{
            //    Console.WriteLine("Same instance!");
            //}
            //NOTE: we want these to be identical to test the
            //Equals() and GetHashCode() methods
            Person p3 = new Person("Jason", "Isere", 50,"32223-3");
            Person p4=new Person("Jason", "Isere", 50, "32223-3");

            //get a stringified version of objects.
            Console.WriteLine("p3.ToString() ={0}",p3.ToString());
            Console.WriteLine("p4.ToString() ={0}", p4.ToString());

            //test overridden Equals()
            Console.WriteLine("p3=p4? {0}", p3.Equals(p4));

            //test HashCode()
            Console.WriteLine("Same hash code? {0}", p3.GetHashCode() ==
                p4.GetHashCode());
            Console.WriteLine();

            //change the age of p4 and test again
            p4.Age = 45;
            //get a stringified version of objects.
            Console.WriteLine("p3.ToString() ={0}", p3.ToString());
            Console.WriteLine("p4.ToString() ={0}", p4.ToString());

            //test overridden Equals()
            Console.WriteLine("p3=p4? {0}", p3.Equals(p4));

            //test HashCode()
            Console.WriteLine("Same hash code? {0}", p3.GetHashCode() ==
                p4.GetHashCode());
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
