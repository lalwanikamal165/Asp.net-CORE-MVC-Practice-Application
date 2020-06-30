using CoreApplication.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreApplication.Domain.Interface
{
    public interface ICourseRepository
    {
        IEnumerable<Course> GetCourses();
        void Add(Course course);
    }
}
