using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Exam> Exams = new List<Exam>();

            Console.WriteLine("Neche eded imtahan isteyirsiz ?");
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                //List.Add(new Exam())

                Console.WriteLine("Enter Point");
                int point = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Subject");
                string subject = Console.ReadLine();

                Console.WriteLine("Bashlama tarixi");
                DateTime startTime = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Bitme tarixi");
                DateTime endtime = DateTime.Parse(Console.ReadLine());

                Exams.Add(new Exam(point,subject,startTime,endtime));
                
            }

            foreach (Exam exam in Exams)
            {
                exam.PassExam();
                exam.ExamTime();
            }
        }
    }
}