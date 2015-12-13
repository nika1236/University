﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University_BL_DAL.DAL;

namespace University_BL_DAL.BL
{
    public class StudentCourse
    {
        public int Id { get; set; }
        public int ClassroomId { get; set; }
        public int StudentId { get; set; }

        public StudentCourse(int id, int classroom_id, int student_id)
        {
            this.Id = id;
            this.ClassroomId = classroom_id;
            this.StudentId = student_id;
        }
    }
}
