using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace branchesPractice.Services
{
    public interface IStudentService
    {
        public List<string> StudentGetAll();
        public int StudentCount(); 
    }
}