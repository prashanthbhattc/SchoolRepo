using School.Entities;
using School.Manager.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Manager.Implimentations
{
    public class StudentFacade : IStudentFacade
    {
        public int create(Student student)
        {
            throw new NotImplementedException();
        }

        public List<Student> search(StudentFilter studentFilter)
        {
            throw new NotImplementedException();
        }

        public bool update(int id, Student student)
        {
            throw new NotImplementedException();
        }
    }
}
