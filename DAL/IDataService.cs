using System.Collections.Generic;
using System.Net.Http.Headers;
using DAL.Models;

namespace DAL
{
    public interface IDataService
    {
        List<Course> GetCourses();

        List<Evaluation> GetEvaluations();
    }
}