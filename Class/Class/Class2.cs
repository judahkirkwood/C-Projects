using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    public static class SquaredAndCubed
    {
        public static void SquareCube(int input, out int square, out int cube)
        {
            // Input squared
            square = input * input;

            // Input cubed
            cube = input * input * input;
        }
        public static void SquareCube(double input, out double square, out double cube)
        {
            // Input squared
            square = input * input;

            // Input cubed
            cube = input * input * input;
        }
    }
}
