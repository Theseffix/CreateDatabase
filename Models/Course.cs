﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace CreateDatabase.Models
{
    class Course
    {
        public int Id { get; set; }
        public int Points { get; set; }
        public string CourseName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Description { get; set; }
        public string CourseAdmin { get; set; }
        //public ICollection<CourseLink> CourseLink { get; set; }
    }
}
