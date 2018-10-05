using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using DAL.Models;

namespace DAL
{

    public class DataService : IDataService
    {
        public List<Course> GetCourses()
        {
            using (var db = new EvalContext())
            {
                return db.Course
                    .OrderBy(c => c.course_id)
                    .ToList();
            }
        }

        public List<Evaluation> GetEvaluations()
        {
            using (var db = new EvalContext())
            {
                return db.Evaluation
                    .OrderBy(e => e.evaluation_id)
                    .ToList();
            }
        }
    }
}

