using CoreApplication.Application.ViewModels;
using System.Collections.Generic;

namespace CoreApplication.Application.Interface
{
    public interface ICourseService
    {
        IEnumerable<CourseViewModel> GetCourses(); 
    }
}
