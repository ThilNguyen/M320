using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inversion_of_Control
{
    public class OnlineExam : Exam
    {
        public override void DistributeToStudents()
        {
            Console.WriteLine("DistributeToStudents");
            Console.WriteLine("    Send participation link to students");
        }

        public override void RecordResults()
        {
            Console.WriteLine("RecordResults");
            Console.WriteLine("    Constantly update database with student answers");
        }

        public override void CollectExams()
        {
            Console.WriteLine("CollectExams");
            Console.WriteLine("    Display countdown, lock exam and display finishing message");
        }

        public override void Grade()
        {
            Console.WriteLine("Grade");
            Console.WriteLine("    Compare student answers with stored answer template,");
            Console.WriteLine("    record grading refinements of teacher,");
            Console.WriteLine("    calculate final grade depending on awarded points");
        }

        public override void PublishResults()
        {
            Console.WriteLine("PublishResults");
            Console.WriteLine("    Enable read-only access to exam along with grading information");
        }
    }
}
