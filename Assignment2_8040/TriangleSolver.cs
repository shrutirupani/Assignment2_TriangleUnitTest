using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_8040
{
   public static class TriangleSolver
    {
        public static string Analyze( int side1 , int side2 , int side3)
        {
            if(side1 + side2 > side3 && side2 + side3 > side1 && side1 + side3 > side2)
            {
                Console.WriteLine("It is valid Triangle");
                
                 if( side1 == side2 && side2 == side3)
                {
                    return ("It is Equilateral Triangle");
                }
                else if (side1 == side2 || side1 == side3 || side2 == side3)
                {
                    return ("It is Isosceles Triangle");
                }
                else
                {
                    return ("It is Scalene Triangle");
                } 
            }
            else
            {
                return ("It is not valid Triangle");
            } 
        }
    }
}
