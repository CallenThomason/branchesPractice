using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace branchesPractice.Services
{
    public class StudentService : IStudentService 
    {
      
      List<string> studentList = ["Jacob Da Best Teacher", "Big Chungus", "Student3"]; 
      
        public List<string> StudentGetAll()
        {
            return studentList; 
        }

        public int StudentCount()
        {
            return studentList.Count; 
        }
    }
}