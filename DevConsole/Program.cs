using System;
using DAL;

namespace DevConsole
{
    class DevProgram
    {
        static void Main(string[] args)
        {
            CoursePrint();
        }

        static void CoursePrint()
        {
            var testingDB = new DataService();

            var courses = testingDB.GetCourses();

            foreach (var course in courses)
            {
                Console.WriteLine(course.id);
                Console.WriteLine(course.name);
            }


            Console.Read();
        }
    }
}