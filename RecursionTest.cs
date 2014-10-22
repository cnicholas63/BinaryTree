using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class RecursionTest
    {
        public RecursionTest(int num) {
            Recursion(num);
        }

        private int Recursion(int num) {

            if (num >= 0)
            {
                Recursion(num - 1);
                Console.WriteLine(num);               
            }

            return num;
        }

    }
}
