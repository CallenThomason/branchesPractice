using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace branchesPractice.Services
{
    public class StudentService : IStudentService 
    {
      
      List<string> studentList = ["Callen", "Student2", "Student3"]; 
      
        public List<string> StudentGetAll()
        {
            return studentList; 
        }
    }
}