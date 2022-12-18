using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inversion_of_Control
{
    public abstract class Exam
    {
        public virtual void ConductExam()
        {
            DistributeToStudents();
            RecordResults();
            CollectExams();
            Grade();
            PublishResults();
        }

        public abstract void DistributeToStudents();
        public abstract void RecordResults();
        public abstract void CollectExams();
        public abstract void Grade();
        public abstract void PublishResults();
    }
}
