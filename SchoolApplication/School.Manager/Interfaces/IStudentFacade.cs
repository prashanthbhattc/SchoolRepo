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
        int create(Student student);
        bool update(int id, Student student);
        List<Student> search(StudentFilter studentFilter);

    }
}
