using CoreApplication.Domain.Interface;
using CoreApplication.Domain.Models;
using CoreApplication.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreApplication.Infra.Data.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private UniversityDBContext _ctx;

        public CourseRepository(UniversityDBContext ctx)
        {
            _ctx = ctx;
        }
        public IEnumerable<Course> GetCourses()
        {
            return _ctx.Courses;
    }
}
