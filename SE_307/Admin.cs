using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE_307
{
    class Admin : IListAllAssignment, IListByCourseCode, IListByAssignmentType, IListByAfterDeadline, IListWithTeam, IListIndividually, IUpdateAssignment, IAddAssignment, IDeleteAssignment
    {

        public List<ATS> listAllAssignment(List<ATS> ats)
        {
            for (int i = 0; i < ats.Count; i++)
            {
                Console.WriteLine("");
                Console.WriteLine("Course Code: " + ats[i].CourseCode);
                Console.WriteLine("Assignment type: " + ats[i].AssignmentType);
                Console.WriteLine("Assignment number: " + ats[i].AssignmentNumber);
                Console.WriteLine("Date: " + ats[i].AssignmentDate);
                Console.WriteLine("Submission Date: " + ats[i].AssignmentDeadlineDay + "/" + ats[i].AssignmentDeadlineMonth + "/" + ats[i].AssignmentDeadlineYear);
                Console.WriteLine("Type: " + ats[i].SubmissionType);
                Console.WriteLine("Teamwork: " + ats[i].Teamwork);
                Console.WriteLine("");
            }
            return ats;
        }

        public List<ATS> listByCourseCode(List<ATS> ats)
        {
            Console.WriteLine("Enter your course Code: ");
            string ar = Console.ReadLine();
            for (int i = 0; i < ats.Count; i++)
            {

                if (ar == ats[i].CourseCode)
                {
                    Console.WriteLine("Assignment type: " + ats[i].AssignmentType);
                    Console.WriteLine("Assignment number: " + ats[i].AssignmentNumber);
                    Console.WriteLine("Date: " + ats[i].AssignmentDate);
                    Console.WriteLine("Submission Date: " + ats[i].AssignmentDeadlineDay + "/" + ats[i].AssignmentDeadlineMonth + "/" + ats[i].AssignmentDeadlineYear);
                    Console.WriteLine("Type: " + ats[i].SubmissionType);
                    Console.WriteLine("Teamwork: " + ats[i].Teamwork);

                }
            }
            return ats;
        }

        public List<ATS> listByAssignmentType(List<ATS> ats)
        {
            Console.WriteLine("Enter your assignment type: ");
            string ast = Console.ReadLine();
            for (int i = 0; i < ats.Count; i++)
            {
                if (ast == ats[i].AssignmentType)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Course ID: " + ats[i].CourseCode);
                    Console.WriteLine("Assignment number: " + ats[i].AssignmentNumber);
                    Console.WriteLine("Date: " + ats[i].AssignmentDate);
                    Console.WriteLine("Submission Date: " + ats[i].AssignmentDeadlineDay + "/" + ats[i].AssignmentDeadlineMonth + "/" + ats[i].AssignmentDeadlineYear);
                    Console.WriteLine("Type: " + ats[i].SubmissionType);
                    Console.WriteLine("Teamwork: " + ats[i].Teamwork);
                    Console.WriteLine("");

                }
            }
            return ats;
        }

        public List<ATS> listByAfterDeadline(List<ATS> ats)
        {
            Console.WriteLine("Please enter Assignment Deadline Day: ");
            var newAssignDeadlineDay = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine("Please enter Assignment Deadline Month: ");
            var newAssignDeadlineMonth = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Please enter Assignment Deadline Year: ");
            var newAssignDeadlineYear = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < ats.Count; i++)
            {

                if (newAssignDeadlineDay <= ats[i].AssignmentDeadlineDay && newAssignDeadlineMonth <= ats[i].AssignmentDeadlineMonth)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Course Code: " + ats[i].CourseCode);
                    Console.WriteLine("Assignment type: " + ats[i].AssignmentType);
                    Console.WriteLine("Assignment number: " + ats[i].AssignmentNumber);
                    Console.WriteLine("Date: " + ats[i].AssignmentDate);
                    Console.WriteLine("Submission Date: " + ats[i].AssignmentDeadlineDay + "/" + ats[i].AssignmentDeadlineMonth + "/" + ats[i].AssignmentDeadlineYear);
                    Console.WriteLine("Type: " + ats[i].SubmissionType);
                    Console.WriteLine("Teamwork: " + ats[i].Teamwork);
                    Console.WriteLine("");

                }

            }

            return ats;
        }

        public List<ATS> listWithTeam(List<ATS> ats)
        {
            for (int i = 0; i < ats.Count; i++)
            {
                if (ats[i].Teamwork == "Yes")
                {
                    Console.WriteLine("Course Code: " + ats[i].CourseCode);
                    Console.WriteLine("Submission Deadline: " + ats[i].AssignmentDeadlineDay + "/" + ats[i].AssignmentDeadlineMonth + "/" + ats[i].AssignmentDeadlineYear);
                    Console.WriteLine("");
                }
            }
            return ats;
        }
        public List<ATS> listIndividually(List<ATS> ats)
        {

            for (int i = 0; i < ats.Count; i++)
            {
                if (ats[i].Teamwork == "No")
                {
                    Console.WriteLine("Course Code: " + ats[i].CourseCode);
                    Console.WriteLine("Submission Deadline: " + ats[i].AssignmentDeadlineDay + "/" + ats[i].AssignmentDeadlineMonth + "/" + ats[i].AssignmentDeadlineYear);
                    Console.WriteLine("");
                }

            }
            return ats;
        }
        public List<ATS> updateAssignment(List<ATS> ats)
        {
            Console.WriteLine("");
            Console.Write("Please select the update course code : ");
            string updateCourseID = Console.ReadLine();

            for (int i = 0; i < ats.Count; i++)
            {
                if (updateCourseID == ats[i].CourseCode)
                {
                    Console.Write("New course Code : ");
                    string newCourseID = Console.ReadLine();
                    ats[i].CourseCode = newCourseID;

                    Console.Write("New assignment Type (Lab, Quiz, Homework, Project) : ");
                    string newAssignType = Console.ReadLine();
                    ats[i].AssignmentType = newAssignType;

                    Console.Write("Assignment Number : ");
                    var newAssignNumber = Convert.ToInt32(Console.ReadLine());
                    ats[i].AssignmentNumber = newAssignNumber;

                    Console.Write("Date(dd/MM/yyyy) : ");
                    string newAssignDate = Console.ReadLine();
                    ats[i].AssignmentDate = newAssignDate;

                    Console.Write("Submission Date Day : ");
                    var newAssignDeadlineDay = Convert.ToInt32(Console.ReadLine());
                    ats[i].AssignmentDeadlineDay = newAssignDeadlineDay;

                    Console.Write("Submission Date Month : ");
                    var newAssignDeadlineMonth = Convert.ToInt32(Console.ReadLine());
                    ats[i].AssignmentDeadlineMonth = newAssignDeadlineMonth;

                    Console.Write("Submission Date Year : ");
                    var newAssignDeadlineYear = Convert.ToInt32(Console.ReadLine());
                    ats[i].AssignmentDeadlineYear = newAssignDeadlineYear;

                    Console.Write("Type(e-mail, Blackboard, print-out) : ");
                    string newSubType = Console.ReadLine();
                    ats[i].SubmissionType = newSubType;

                    Console.Write("Teamwork? (Yes or No) : ");
                    string newTeamwork = Console.ReadLine();
                    ats[i].Teamwork = newTeamwork;
                    Console.WriteLine("");
                }
            }
            return ats;
        }
        public List<ATS> addAssignment(List<ATS> ats)
        {
            Console.WriteLine("");
            Console.Write("Course Code : ");
            string courseID = Console.ReadLine();
            Console.Write("Assignment Type (Lab, Quiz, Homework, Project) : ");
            string assignType = Console.ReadLine();
            Console.Write("Assignment Number : ");
            var assignNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Date(dd/MM/yyyy) : ");
            string assignDate = Console.ReadLine();
            Console.Write("Submission Date day : ");
            var assignDeadlineDay = Convert.ToInt32(Console.ReadLine());
            Console.Write("Submission Date month : ");
            var assignDeadlineMonth = Convert.ToInt32(Console.ReadLine());
            Console.Write("Submission Date year : ");
            var assignDeadlineYear = Convert.ToInt32(Console.ReadLine());
            Console.Write("Type(e-mail, Blackboard, print-out) : ");
            string subType = Console.ReadLine();
            Console.Write("Teamwork? (Yes or No) : ");
            string teamwork = Console.ReadLine();
            Console.WriteLine("");

            ats.Add(new ATS() { CourseCode = courseID, AssignmentType = assignType, AssignmentNumber = assignNumber, AssignmentDate = assignDate, AssignmentDeadlineDay = assignDeadlineDay, AssignmentDeadlineMonth = assignDeadlineMonth, AssignmentDeadlineYear = assignDeadlineYear, SubmissionType = subType, Teamwork = teamwork });

            return ats;
        }

        public List<ATS> deleteAssignment(List<ATS> ats)
        {
            Console.WriteLine("Please, enter the Specify course code want to delete:  ");
            string deleteItem = Console.ReadLine();

            for (int i = 0; i < ats.Count; i++)
            {
                if (deleteItem == ats[i].CourseCode)
                {
                    ats.RemoveAt(i);
                }
            }
            return ats;
        }
    }
}
