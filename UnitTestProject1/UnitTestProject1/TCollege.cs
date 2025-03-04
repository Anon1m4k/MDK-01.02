using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    [TestClass]
    public class TCollege
    {

       // public struct College
       // {
         //   public string name;
          //  public List<string> students;
            //public List<string> expected;
        //}
        public Dictionary<string, List<string>> expectedInfo = new Dictionary<string, List<string>>()
        {
            {"П-10", new List<string>() { "Баранов Даниил" , "Курчаков Артем", "Колобанов Захар"} },
            {"Л-20", new List<string>() { "Смирнова Екатерина" , "Бычков Дмитрий", "Суханов Дмитрий"} },
            {"Н-30", new List<string>() { "Венедиктов Дмитрий" , "Сучков Артем", "Водянов Захар"} },
        };





        [TestMethod]
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
    }
}
