using System.Collections.Generic;
using System.Net.Http.Headers;

namespace DAL
{
    public interface IDataService
    {
        List<Course> GetCourses();
    }
}