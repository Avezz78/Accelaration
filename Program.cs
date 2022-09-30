using System;

namespace demo1
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            
            student s = new student();

            s.Marksscored = 400;
            s.Studentid = 123;
            s.StudentName = "sahil";
            s.Standard = 10;
            s.StudentAttended = 220;
            s.TotalMarks = 600;
            s.TotalWorkingDays = 250;

            
            Console.WriteLine("student name:"+s.StudentName);
            Console.WriteLine("student id:"+s.Studentid);
            Console.WriteLine("student attended:"+s.StudentAttended);
            Console.WriteLine("standard:"+s.Standard);
            Console.WriteLine("totalmarks:"+s.TotalMarks);
            Console.WriteLine("totalworkingdays:"+s.TotalWorkingDays);
            Console.WriteLine("totalmarksScored:"+s.Marksscored);
           Console.WriteLine("Result:"+s.Result);

            s.Percentage();
        }
    }
}
