using CoreApplication.Application.Interface;
using CoreApplication.Application.ViewModels;
using CoreApplication.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreApplication.Application.Services
{
   public class CourseService : ICourseService
    {
        private ICourseRepository _courseRepository;

        public CourseService(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }
        public CourseViewModel GetCourses()
        {
            return new CourseViewModel()
            {
                Courses = _courseRepository.GetCourses()
            };
        }
    }
}
