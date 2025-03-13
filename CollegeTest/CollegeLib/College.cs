
using System;
using System.Collections.Generic;

namespace CollegeLib
{
    public class College
    {
        public Dictionary<string, List<string>> Students = new Dictionary<string, List<string>>();
        public void AddGroup(string group, List<string> Student)
        {
            if (!Students.ContainsKey(group))
            {
                Students.Add(group, Student);
            }
            else
            {
                // Если группа уже существует, можно добавить студентов в существующую группу
                Students[group].AddRange(Student);
            }
        }
        public void AddStudentToGroup(string group, string Student)
        {
            if (Students.ContainsKey(group))
            {
                Students[group].Add(Student);
            }
            else
            {
                throw new Exception($"Группа '{group}' не найдена.");
            }
        }
        public List<string> GetStudentsByGroup(string group)
        {
            if (Students.ContainsKey(group))
            {
                return Students[group]; // Возвращаем список студентов, если группа найдена
            }
            else
            {
                return new List<string>(); // Возвращаем пустой список, если группа не найдена
            }
        }
    }
}
