using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE_307
{
    public class ATS
    {
        private string courseCode;
        private string assignmentType;
        private int assignmentNumber;
        private string assignmentDate;
        private int assignmentDeadlineDay;
        private int assignmentDeadlineMonth;
        private int assignmentDeadlineYear;
        private string submissionType;
        private string teamwork;

        public ATS()
        {
        }

        public ATS(string courseCode, string assignmentType, int assignmentNumber, string assignmentDate, int assignmentDeadlineDay, int assignmentDeadlineMonth, int assignmentDeadlineYear, string submissionType, string teamwork)
        {
            this.courseCode = courseCode;
            this.assignmentType = assignmentType;
            this.assignmentNumber = assignmentNumber;
            this.assignmentDate = assignmentDate;
            this.assignmentDeadlineDay = assignmentDeadlineDay;
            this.assignmentDeadlineMonth = assignmentDeadlineMonth;
            this.assignmentDeadlineYear = assignmentDeadlineYear;
            this.submissionType = submissionType;
            this.teamwork = teamwork;
        }

        public string CourseCode { get => courseCode; set => courseCode = value; }
        public string AssignmentType { get => assignmentType; set => assignmentType = value; }
        public int AssignmentNumber { get => assignmentNumber; set => assignmentNumber = value; }
        public string AssignmentDate { get => assignmentDate; set => assignmentDate = value; }
        public int AssignmentDeadlineDay { get => assignmentDeadlineDay; set => assignmentDeadlineDay = value; }
        public int AssignmentDeadlineMonth { get => assignmentDeadlineMonth; set => assignmentDeadlineMonth = value; }
        public int AssignmentDeadlineYear { get => assignmentDeadlineYear; set => assignmentDeadlineYear = value; }
        public string SubmissionType { get => submissionType; set => submissionType = value; }
        public string Teamwork { get => teamwork; set => teamwork = value; }






    }
}
