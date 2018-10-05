using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace DAL
{
    public class Course
    {
        [Key]
        public int course_id { get; set; }

        public string name { get; set; }

        

    }
}
