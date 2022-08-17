using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Class1> student = new List<Class1>()
            {
                new Class1() {studentId=1,Name="Shyam",Dept="ECE",Dob="21.05.2000"},
                new Class1() {studentId=2,Name="Abhishek",Dept="EE",Dob="24.01.2001"},
                new Class1() {studentId=3,Name="Subhojit",Dept="IT",Dob="18.09.1999"},
                new Class1() {studentId=4,Name="Sohan",Dept="ECE",Dob="10.11.1997"}
            };

            var depList = from dlst in student
                          where dlst.Dept == "ECE"
                          select dlst;

            foreach (var dep in depList)
                Console.WriteLine(dep.studentId + "-" + dep.Name + "......" + "ECE" + "-" + dep.Dob);
        }
    }

    public class Class1
    {
        public int studentId { get; set; }
        public string Name { get; set; }
        public string Dept { get; set; }

        public string Dob { get; set; }
    }
}
