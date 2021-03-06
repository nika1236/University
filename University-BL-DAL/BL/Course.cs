﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University_BL_DAL.DAL;

namespace University_BL_DAL.BL
{
    public class Course
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long FacultyId { get; set; }
        public long LecturerId { get; set; }

        public Course() { }

        public Course(long id, string name, long faculty_id, long lecturer_id)
        {
            this.Id = id;
            this.Name = name;
            this.FacultyId = faculty_id;
            this.LecturerId = lecturer_id;
        }

        public static IEnumerable<Course> GetAll()
        {
            return (CourseDAL.GetAll());
        }

        public static Course Find(long id)
        {
            return (CourseDAL.Find(id));
        }

        public static Course FindByName(string name)
        {
            return (CourseDAL.FindByName(name));
        }

        public bool Create()
        {
            bool res = false;
            res = CourseDAL.Create(this);
            return (res);
        }

        public bool Update()
        {
            return (CourseDAL.Update(this));
        }

        public bool Delete()
        {
            return (CourseDAL.Delete(this));
        }
    }
}
