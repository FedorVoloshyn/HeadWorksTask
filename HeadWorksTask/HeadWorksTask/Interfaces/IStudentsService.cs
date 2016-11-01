using System.Collections.Generic;
using HeadWorksTask.Entities;

namespace HeadWorksTask.Interfaces
{
    interface IStudentsService
    {
        List<Student> GetAllStudents();
    }
}
