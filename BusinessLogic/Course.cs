using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic
{
    public class Course
    {
        private string instructorName;
        private byte numberOfCredits;
        private string courseName;

        public Course(string courseName)
        {
            CourseName = courseName;
            InstructorName = "STAFF";
        }

        /// <summary>
        /// The instructor teaching the course
        /// </summary>
        public string InstructorName
        {
            get { return instructorName; }


            set { instructorName = value; }



        }




        /// <summary>
        /// The name of the course
        /// </summary>
        public string CourseName { 
            get => courseName; 
            set => courseName = value; }

        /// <summary>
        /// Number of credits for the course
        /// </summary>
        public byte NumberOfCredits
        {
            get { return numberOfCredits; }
            set
            {

                if (numberOfCredits >= 30 && numberOfCredits <= 0)
                {
                    throw new ArgumentException();
                }
                NumberOfCredits = value;



            }

        }
    }
}

