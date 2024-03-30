using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2
{
    public class Student
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string ClassName { get; set; }
        public char Grade { get; set; }

        public Student(string id, string firstName, string lastName, int age, string gender, string className, char grade)
        {
            Id=id;
            FirstName=firstName;
            LastName=lastName;
            Age=age;
            Gender=gender;
            ClassName=className;
            Grade=grade;
        }
        public Student()
        {

        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}

