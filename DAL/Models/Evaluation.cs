using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace DAL.Models
{
    class Evaluation
    {
        [Key]
        public int id { get; set; }

        public string course_id { get; set; }

    }
}