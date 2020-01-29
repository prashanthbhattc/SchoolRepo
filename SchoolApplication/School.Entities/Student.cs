using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Entities
{
    public class Student_Info
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Category { get; set; }
        public int Standard { get; set; }
        public string DOB  { get; set; }
        public string BloodGroup { get; set; }
        public string ParentsName { get; set; }
        public string ParentsContactNumber { get; set; }
        public string Address {get;set;}
        public string Transport_details { get; set; }
       
    }

     public class School_info
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        
    }

     public class Examination_Info
    {
        public string SubjectEntry { get; set; }
        public string ExamEntry { get; set; }
        public int MarksEntry { get; set; }
        public string ScoreReport { get; set; }
        
    }

      public class Library_info
    {
        public string Bookcode { get; set; }
        public int Bookentry { get; set; }
        public int Bookissue { get; set; }
        public int Bookreturn { get; set; }
        
    }
}

