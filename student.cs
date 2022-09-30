using System;

namespace demo1
{
    internal class student
    {
         private int studentid;
         private string studentName;
         private int totalMarks;
         private int totalWorkingDays;
         private  int standard;
         private int studentAttended;
         private  int marksscored;
         public int Result;

      
        public int Studentid
        {
            get { return studentid; }
            set { studentid = value; }
           
        }
        public string StudentName
        {
            get { return studentName; }
            set { studentName = value; }
        
        }
        
        
        public int TotalMarks
        {
            get { return totalMarks; }
            set
            {
                totalMarks = value;
            }
        }
        public int TotalWorkingDays
        {
            get { return totalWorkingDays; }
            set
            {
                totalWorkingDays = value;
            }
           
        }

        public int Standard
        {
            get { return standard; }
            set
            {
                standard = value;
            }
           
        }

        public int StudentAttended
        {
            get { return studentAttended; }
            set
            {
                studentAttended = value;
            }
        }
        public int Marksscored
        {
            get { return marksscored; }
            set
            {
                marksscored = value;
            }
        }


        public int Percentage()
        {
            Result = (Marksscored / TotalMarks) * 100;

            return Result;
        }
    }
}
