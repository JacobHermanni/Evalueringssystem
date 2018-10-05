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

            Console.WriteLine("courses:");

            foreach (var course in courses)
            {
                Console.WriteLine(course.course_id);
                Console.WriteLine(course.course_name);
            }

            var evaluations = testingDB.GetEvaluations();

            Console.WriteLine();
            Console.WriteLine("Evaluations:");

            foreach (var evaluation in evaluations)
            {
                Console.WriteLine(evaluation.evaluation_id);
                Console.WriteLine(evaluation.course_id);
                Console.WriteLine(evaluation.report);
            }


            Console.Read();
        }
    }
}