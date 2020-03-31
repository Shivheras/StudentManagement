using StudentCourse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentCourse.Domains
{
    public class CourseListDomain:BaseDomain
    {
        public List<CourseLists> Get(int StudentId)
        {
            var reader = this.GetReader($"select * from CourseLists where StudentId='{StudentId}' ");
            var courses = new List<CourseLists>();
            while (reader.Read())
            {
                var course = new CourseLists();
                course.CourseListId = reader.GetInt32(0);
                course.CourseName = reader.GetString(1);
                course.Description = reader.GetString(2);
                course.Type = reader.GetBoolean(3);
                course.Price = reader.GetString(4);

                courses.Add(course);
            }
            return courses;
        }
        
        
    }
}
