
using System.Collections.Generic;

namespace CollegeLib
{
    public class College
    {
        public Dictionary<string, List<string>> Students = new Dictionary<string, List<string>>();
        public void AddGroup(string group, List<string> Student)
        {
            Students.Add(group, Student);
        }
        public List<string> GetStudentsByGroup(string group)
        {
            return new List<string>() { };
        }
    }
}
