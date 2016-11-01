using System.Collections.Generic;
using HeadWorksTask.Interfaces;
using HeadWorksTask.Entities;

namespace HeadWorksTask.ViewModels
{
    class StudentsPageViewModel : BaseViewModel
    {
        private IStudentsService _studentService;
        private List<Student> StudentList;

        public StudentsPageViewModel()
        {
            this._studentService = new StudentService();
            StudentList = _studentService.GetAllStudents();
        }
    }
}
