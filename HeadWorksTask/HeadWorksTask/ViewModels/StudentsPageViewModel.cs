using System.Collections.Generic;
using HeadWorksTask.Interfaces;
using HeadWorksTask.Entities;

namespace HeadWorksTask.ViewModels
{
    class StudentsPageViewModel : BaseViewModel
    {
        private IStudentsService _studentService;
        private List<Student> studentList;

        public List<Student> StudentList
        {
            get { return studentList; }
        }

        public StudentsPageViewModel()
        {
            this._studentService = new StudentService();
            studentList = _studentService.GetAllStudents();
        }
    }
}
