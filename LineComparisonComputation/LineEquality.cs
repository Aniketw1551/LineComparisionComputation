using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonComputation
{
    public class LineEquality
    {
<<<<<<< HEAD
        //instance variable to store distance of given co-ordinates
        static double distance1, distance2;
=======
        //instance variable
        static double distance1, distance2, distance3;
>>>>>>> 6e4f02103bab71dd6b58fb0bc46724c451e006bb

        // Method for creating co-ordinates
        public static void CheckLine()
        {
            LineComputation lc1 = new LineComputation(4.2, 3.2, 1.7, 2.1);
            distance1 = lc1.Length();
            LineComputation lc2 = new LineComputation(3.6, 4.4, 1.2, 2.4);
            distance2 = lc2.Length();
<<<<<<< HEAD
            Console.WriteLine("Length of Line1: " + distance1);
            Console.WriteLine("Length of Line2: " + distance2);

            //checking equality of lines using equals method 
            if (distance1.CompareTo(distance2) > 0)
            {
                Console.WriteLine("line one is greater than line two");
            }
            else if (distance1.CompareTo(distance2) < 0)
            {
                Console.WriteLine("line one is less then line Two");
            }
            else if (distance1.CompareTo(distance2) == 0)
            {
                Console.WriteLine("Both Lines are Equals");
=======
            LineComputation lc3 = new LineComputation(2.7, 4.1, 2.2, 3.8);
            distance3 = lc3.Length();
            Console.WriteLine("Length of Line1: " + distance1);
            Console.WriteLine("Length of Line2: " + distance2);
            Console.WriteLine("Length of Line3: " + distance3);

            //checking equality of lines using equals method 
            if (distance1.Equals(distance2))
            {
                Console.WriteLine("lines one and two are equal");
            }
            else if (distance2.Equals(distance3))
            {
                Console.WriteLine("lines two and three are equal");
            }
            else if (distance1.Equals(distance3))
            {
                Console.WriteLine("lines one and three are equal");
>>>>>>> 6e4f02103bab71dd6b58fb0bc46724c451e006bb
            }
            else
            {
                Console.WriteLine("Lines are not Equal");
            }
        }
    }
}
