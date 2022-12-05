using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inversion_of_Control
{
        public class PenAndPaperExam : Exam
        {
            public override void DistributeToStudents()
            {
                Console.WriteLine("DistributeToStudents");
                Console.WriteLine("    Hand out paper copies of exam");
            }

            public override void RecordResults()
            {
                Console.WriteLine("RecordResults");
                Console.WriteLine("    Students write down their answers on paper");
            }

            public override void CollectExams()
            {
                Console.WriteLine("CollectExams");
                Console.WriteLine("    Request students to hand in their paper copies");
            }

            public override void Grade()
            {
                Console.WriteLine("Grade");
                Console.WriteLine("    Compare student answers with predefined answer template,");
                Console.WriteLine("    award points for (partially) correct answers,");
                Console.WriteLine("    calculate final grade depending on awarded points");
            }

            public override void PublishResults()
            {
                Console.WriteLine("PublishResults");
                Console.WriteLine("    Redistribute exams to students");
            }
        }
}
