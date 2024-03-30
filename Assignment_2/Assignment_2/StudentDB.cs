using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2
{
    public class StudentDB
    {
        // create a file to input user login details
        private static string Path = @"C:\Users\Admin\Desktop\JUZT-OYIN\APP.DEV.C#\Assignment_2\Assignment_2\students.txt";
        private const char Delimiter = '|';

        //private static List<Student> students = new List<Student>();
        private static List<Student> students;

        internal StudentDB()
        {
            if (students == null)
                students = new List<Student>();
        }


        public static List<Student> GetStudents()
        {
            List<Student> students = new List<Student>();

            try
            {
                using (StreamReader sr = new StreamReader(new FileStream(Path, FileMode.OpenOrCreate, FileAccess.Read)))
                {
                    string line; //row
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] parts = line.Split(Delimiter); //columns

                        if (parts.Length == 7)
                        {
                            Student student = new Student
                            {
                                Id = parts[0],
                                FirstName =parts[1],
                                LastName = parts[2],
                                Age = Convert.ToInt32(parts[3]),
                                Gender = parts[4],
                                ClassName = parts[5],
                                Grade = Convert.ToChar(parts[6])
                            };
                            students.Add(student);
                        }

                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return students;
        }
        public static void saveStudent(List<Student> students)
        {
            try 
            {
                using (StreamWriter writer = new StreamWriter(new FileStream(Path, FileMode.Create, FileAccess.Write)))
                {
                    List<Student> stud = new List<Student>()
                {
                    new Student("1001", "John", "Doe", 18, "Male", "Class A", 'A'),
                    new Student("1002", "Jane", "Smith", 17, "Female", "Class B", 'B'),
                    new Student("1003", "Alice", "Johnson", 16, "Female", "Class A", 'A'),
                    new Student("1004", "Bob", "Brown", 17, "Male", "Class C", 'C'),
                    new Student("1005", "Emma", "Wilson", 18, "Female", "Class B", 'B'),
                };
                    foreach (Student student in students)
                    {
                        writer.Write(student.Id.ToString() + Delimiter);
                        writer.Write(student.FirstName + Delimiter);
                        writer.Write(student.LastName + Delimiter);
                        writer.Write(student.Age.ToString() + Delimiter);
                        writer.Write(student.Gender + Delimiter);
                        writer.Write(student.ClassName + Delimiter);
                        writer.WriteLine(student.Grade);
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("An error occured, check it out: " +ex.Message);
            }
        }
            

        public static void saveSingleStudent(Student students)
        {
            try
            {
                //Appending the new student to the already existing students in the textfile
                List<Student> existingStudents = GetStudents();
                existingStudents.Add(students);
                saveStudent(existingStudents);
            }
            catch (Exception ex) { Console.WriteLine("Error occured while appending the new student " +ex.Message); }

        }

        
    }
}
