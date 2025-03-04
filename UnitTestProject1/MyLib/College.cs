using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public class College
    {
        public Dictionary<string, List<string>> Students = new Dictionary<string, List<string>>();
        public void AddGroup(string group, List <string> Student  )
        {
            Students.Add( group, Student );
        }

        public List<string> GetStudentsByGroup(string group) 
        {
          
         return new List<string>() { };
        }
    }
}
