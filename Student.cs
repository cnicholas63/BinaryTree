/*
 * 20/10/14 C Nicholas 22489355
 * Student data class used for testing BinaryTree
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{

    
    class Student // Student record class
    {
        public String surname;
        public String forename;
        public int age;
        public String course;

        public Student(String surname, String forename)
        {
            this.surname = surname;
            this.forename = forename;
            age = 0;
            course = "Application Development";
        }


    }
}
