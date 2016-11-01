using System;
using System.Collections.Generic;
using HeadWorksTask.Entities;
using HeadWorksTask.Interfaces;

[assembly: Xamarin.Forms.Dependency(typeof(IStudentsService))]
namespace HeadWorksTask.ViewModels
{
    class StudentService : IStudentsService
    {
        public List<Student> GetAllStudents()
        {
            List<Student> AllStudents = new List<Student>();

            for(int i = 0; i < 5; i++)
            {
                Student _student = new Student("Name" + i.ToString(),"SecondName" + i.ToString(),(101 + i).ToString());
                AllStudents.Add(_student);
            }

            return AllStudents;
        }
    }
}
