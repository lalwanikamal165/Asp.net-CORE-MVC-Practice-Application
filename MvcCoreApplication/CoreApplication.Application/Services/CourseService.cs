using CoreApplication.Application.Interface;
using CoreApplication.Application.ViewModels;
using CoreApplication.Domain.Commands;
using CoreApplication.Domain.Core.Bus;
using CoreApplication.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreApplication.Application.Services
{
   public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;
        private readonly IMediatorHandler _bus;

        public CourseService(ICourseRepository courseRepository,IMediatorHandler bus)
        {
            _courseRepository = courseRepository;
            _bus = bus;
        }

        public void Create(CourseViewModel courseViewModel)
        {
            var CreateCourseCommand = new CreateCourseCommand(
                courseViewModel.Name,
                courseViewModel.Description,
                courseViewModel.ImageUrl
                );

            _bus.SendCommand(CreateCourseCommand);
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
