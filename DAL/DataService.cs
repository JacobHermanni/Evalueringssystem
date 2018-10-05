using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace DAL
{

    public class DataService : IDataService
    {
        // obsolete, posts ved søgning findes i form af WeightedResult.cs og enkelte posts findes gennem getPost()
        public List<Course> GetCourses()
        {
            using (var db = new TestingContext())
            {
                return db.Course
                    .OrderBy(x => x.id)
                    .ToList();
            }
        }
    }
}

