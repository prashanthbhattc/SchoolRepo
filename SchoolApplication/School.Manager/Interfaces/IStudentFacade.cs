using School.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Manager.Interfaces
{
   public  interface IStudentFacade
    {
        int create(Student_Info student);
        bool update(int id, Student_Info student);
        List<Student_Info> search(StudentFilter studentFilter);

    }
}
