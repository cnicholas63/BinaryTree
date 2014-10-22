using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            CJNBinaryTree<int> tree;
            Random rand = new Random();

            int[] numbers = new int[10];

            for (int t = 0; t < numbers.Length; t++)
            {
                numbers[t] = rand.Next(101); // populate numbers array with random values between 0 and 100 inclusive
                Console.Write(numbers[t] + " ");
            }
            Console.WriteLine("");
            
            
            tree = new CJNBinaryTree<int>(CompareNums, PrintNums); // Construct new empty tree and pass reference to Compare method

            for (int t = 0; t < numbers.Length; t++)
            {// Populate the tree
                tree.AddNode(numbers[t]);
            }

                // CJNBinaryTree<Student> tree;

                //Student student = new Student("One", "First"); // Instantiate student
                //Student student2 = new Student("Two", "Second");
                //Student student3 = new Student("Three", "Third");
                //Student student4 = new Student("Four", "Fourth");
                //Student student5 = new Student("Five", "Fifth");
                //Student student6 = new Student("Six", "Sixth");
                //Student student7 = new Student("Very", "Veryth");
                //Student student8 = new Student("Zillion", "Zillionth");

                //Console.WriteLine(Compare(student, student2));



                //            tree = new CJNBinaryTree<Student>(student, Compare, PrintStudent); // Construct new empty tree and pass reference to Compare method

                //tree.AddNode(student2);
                //tree.AddNode(student3);
                //tree.AddNode(student4);
                //tree.AddNode(student5);
                //tree.AddNode(student6);
                //tree.AddNode(student7);
                //tree.AddNode(student8);

                //tree.printNode(PrintStudent, tree.root);

            tree.printNode(PrintNums, tree.root);

            Console.WriteLine("Ascending\n");
            
            tree.PrintListAscending(tree.GetRootNode());

            Console.WriteLine("Descending\n");

            tree.PrintListDescending(tree.GetRootNode());

            Console.ReadKey();

        }

        static private int CompareNums(int num1, int num2)
        {
            Console.WriteLine("Comparing " + num1 + " against " + num2);

            if (num1 < num2) return -1;
            else if (num1 == num2) return 0;
            else return 1;
        }

        static private void PrintNums(int num) {
            Console.WriteLine("Value = " + num);
           
        }


 




        
        /*
         * The following methods are passed to the binary tree in order to extend its functionality
         * These are methods designed to work with the node data fields that a generic tree structure 
         * cannot know about
         */
        
        /*  Compares the required field from student1 with that of student2. 
         *  Returns an int < 0 == data1 < data 2, int 0 == equal, int > 0 == data1 > data2
         *  Returns true if student2 > student1. This method is passed to the Binary tree for sorts and searches
         *  This is required as the binary tree is generic 
         */
        static private int Compare(Student data1, Student data2) 
        {
            Console.WriteLine("Comparing " + data1.surname + " against " + data2.surname);
            
            return data1.surname.CompareTo(data2.surname); // Return the result of the comparison
        }

        static private void PrintStudent(Student student)
        {
            Console.WriteLine(student.surname + " " + student.forename);
            //Console.WriteLine(student.forename);
            //Console.WriteLine(student.age);
            //Console.WriteLine(student.course);
        }


    }
}
