using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

using CollegeLib;

namespace CollegeTest
{
    [TestClass]
    public class TCollege
    {
        Dictionary<string, List<string>> expectedInfo = new Dictionary<string, List<string>>()
        {
            //{"П-10", new List<string>() { "Баранов Даниил" , "Курчаков Артем", "Колобанов Захар"} },
            //{"Л-20", new List<string>() { "Смирнова Екатерина" , "Бычков Дмитрий", "Суханов Дмитрий"} },
            //{"Н-30", new List<string>() { "Венедиктов Дмитрий" , "Сучков Артем", "Водянов Захар"} },
        };

        [TestMethod] //наличие любой группы
        public void TGetStudentsByGroupX()
        {
            College college = new College();
            foreach (string group in expectedInfo.Keys)
            {
                college.AddGroup(group, expectedInfo[group]);

                List<string> actual = college.GetStudentsByGroup(group);

                List<string> expected = new List<string>(expectedInfo[group]);

                CollectionAssert.AreEqual(expected, actual);
            }
        }

        [TestMethod] //наличие любой группы
        public void SomeGroup()
        {
            College college = new College();

            // Добавляем группы
            foreach (string group in expectedInfo.Keys)
            {
                college.AddGroup(group, expectedInfo[group]);
            }

            // Проверяем наличие групп
            foreach (string group in expectedInfo.Keys)
            {
                List<string> actual = college.GetStudentsByGroup(group);
                Assert.IsNotNull(actual, $"Группа '{group}' не найдена.");
                Assert.IsTrue(actual.Count > 0, $"Группа '{group}' не содержит студентов.");
            }
        }

        /*[TestMethod]
        public void TGetStudentsByGroupX() //наличие любой группы
        {
            College college = new College();

            // Проходим по всем группам в expectedInfo
            foreach (string group in expectedInfo.Keys)
            {
                // Добавляем группу и студентов в колледж
                college.AddGroup(group, expectedInfo[group]);

                // Получаем фактический список студентов по группе
                List<string> actual = college.GetStudentsByGroup(group);

                // Создаем ожидаемый список студентов из словаря
                List<string> expected = new List<string>(expectedInfo[group]);

                // Сравниваем ожидаемый и фактический списки студентов
                CollectionAssert.AreEqual(expected, actual, $"Список студентов для группы '{group}' не совпадает.");
            }
        }*/

        [TestMethod] //наличие конкретной группы
        public void AGroup()
        {
            College college = new College();

            // Определяем группу и студентов
            string groupName = "П-10";
            List<string> students = new List<string>() { "Баранов Даниил", "Курчаков Артем", "Колобанов Захар" };

            // Добавляем группу в колледж
            college.AddGroup(groupName, students);

            // Проверяем, что группа существует
            List<string> actualStudents = college.GetStudentsByGroup(groupName);

            // Проверяем, что список студентов не пустой
            Assert.IsNotNull(actualStudents, $"Группа '{groupName}' не найдена.");
            Assert.IsTrue(actualStudents.Count > 0, $"Группа '{groupName}' не содержит студентов.");

            // Проверяем, что список студентов соответствует ожидаемому
            CollectionAssert.AreEqual(students, actualStudents, $"Список студентов для группы '{groupName}' не совпадает.");
        }
    }
}
