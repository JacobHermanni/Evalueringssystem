﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace DAL.Models
{
    public class Evaluation
    {
        [Key]
        public int evaluation_id { get; set; }

        public int course_id { get; set; }

        //TODO: remove this. Instead link to evaluation with id from report table containing cleartext and file/path to file(?)
        public string report { get; set; }        
    }
}