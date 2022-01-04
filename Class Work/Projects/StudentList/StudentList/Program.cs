using System;
using System.Collections.Generic;

namespace StudentList
{

    public class student
    {
        public string name { get; set; }
        public double age { get; set;}
        public double math { get; set; }
        public double science { get; set; }
        public double english { get; set; }
        public double computer { get; set; }
        public double music { get; set; }

        class Program

        {

            static void Main(string[] args)
            {
                student stu1 = new student(){name = "Cameron Sands", age = 11, math = 92, science = 88, english = 90, computer = 100, music = 92};
                student stu2 = new student(){name = "Jaden Stubbs",  age = 12, math = 72, science = 58, english = 60, computer = 80,  music = 100};
                student stu3 = new student(){name = "Isiah Cole",    age = 10, math = 92, science = 88, english = 90, computer = 100, music = 92 };
                student stu4 = new student(){name = "Isabelle John", age = 11, math = 100,science = 88, english = 95, computer = 78,  music = 85};
                student stu5 = new student(){name = "Jackie Pierce", age = 12, math = 99, science = 88, english = 90, computer = 100, music = 95};

                List<student> studentList = new List<student>();

                studentList.Add(stu1);
                studentList.Add(stu2);
                studentList.Add(stu3);
                studentList.Add(stu4);
                studentList.Add(stu5);

                Console.WriteLine("____________________________Student Report Card Data___________________________ ");
                Console.WriteLine(" _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ ");
                Console.WriteLine
                ("Student's Name={0} | Student's Age={1} | Math={2} | Science={3} | English={4}, | Computer={5} | Music={6} |",
                  stu1.name, stu1.age, stu1.math, stu1.science, stu1.english, stu1.computer, stu1.music);
                Console.WriteLine(" _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ ");
                Console.WriteLine
                ("Student's name: {0} | Student's Age: {1} | Math - {2} | Science - {3} | English={4} | Computer={5} | Music={6} |",
                    stu2.name, stu2.age, stu2.math, stu2.science, stu2.english, stu2.computer, stu2.music);
                Console.WriteLine(" _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ ");
                Console.WriteLine
                ("Student's Name:{0} | Stduent's Age:{1} | Math={2} | Science={3} | English={4} |  Computer={5}| Music={6}|",
                    stu2.name, stu2.age, stu2.math,stu2.science, stu2.english, stu2.computer, stu2.music);
                Console.WriteLine(" _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ ");
                Console.WriteLine
                ("Student's Name={0} | Student's Age={1} | Math={2} | Science={3} | English={4} | Computer={5} | Music={6} |",
                stu3.name, stu3.age, stu3.math, stu3.science, stu3.english, stu3.computer, stu3.music);
                Console.WriteLine(" _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ ");
                Console.WriteLine("Student's Name={0} | Student's Age={1} | Math={2} | Science={3} | English={4} | Computer={5} | Music={6} |",
                    stu4.name, stu4.age, stu4.math, stu4.science, stu4.english, stu4.computer, stu4.music);
                Console.WriteLine(" _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ ");
                Console.WriteLine("Student's Name={0} | Student' Age={1} | Math={2} | Science={3} | English={4} | Computer={5} | Music={6} |",
                    stu5.name, stu5.age, stu5.math, stu5.science, stu5.english, stu5.computer, stu5.music);



            }
        }  }
}
