namespace Inversion_of_Control
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exam? exam = null;

            Console.Write("Exam type? (paper|online) ");
            var examtype = Console.ReadLine();

            if (!string.IsNullOrEmpty(examtype))
            {
                exam = ExamFromString(examtype);
            }

            if (exam == null)
            {
                Console.WriteLine($"Unknown exam type {examtype}");
                return;
            }

            exam?.ConductExam();
        }

        private static Exam? ExamFromString(string type)
        {
            if (type.Equals("online"))
            {
                return new OnlineExam();
            }
            else if (type.Equals("paper"))
            {
                return new PenAndPaperExam();
            }

            return null;
        }
    }

}



