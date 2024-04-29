using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask28
{
    internal class Exam
    {
        public Student[] Students;
        public int Point;
        public string Subject;
        public DateTime StartDate;
        public DateTime EndDate;

        public Exam(int point, string subject, DateTime StartDate, DateTime EndDate)
        {
            point = Point;
            subject = Subject;
            StartDate = StartDate;
            EndDate = EndDate;
        }

        public void PassExam()
        {
            if(Point >50)
            {
                Console.WriteLine($"Subject : {Subject} passed");
            }
            else
            {
                Console.WriteLine($"Subject : {Subject} failed");
            }
        }
        public void ExamTime()
        {
            if(EndDate - StartDate > new TimeSpan(1, 0, 0))
            {
                Console.WriteLine($"{Subject} exam more than a hour");
            }
            else
            {
                Console.WriteLine($"{Subject} exam less than a hour");
            }
        }
    }
}
