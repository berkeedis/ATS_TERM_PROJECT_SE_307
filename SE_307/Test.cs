using System;
using System.Collections.Generic;

namespace SE_307
{
    class Test
    {
        static void Main(string[] args)
        {
            List<ATS> ats = new List<ATS>();
            List<People> peoples = new List<People>();

            TextFile TextFileObj = new TextFile();

            ATS b1 = new ATS("SE 116", "Homework", 2, "12 / 04 / 2021", 17, 04, 2021, "e-mail", "No");
            ATS b2 = new ATS("FENG 102", "Project", 1, "22 / 04 / 2020", 27, 05, 2021, "CD", "Yes");
            ATS b3 = new ATS("MATH 154", "Homework", 1, "18 / 05 / 2020", 24, 05, 2021, "print-out", "No");
            ATS b4 = new ATS("PHYS 102", "Prelab", 4, "02 / 03 / 2021", 03, 03, 2021, "hand-written", "No");
            ATS b5 = new ATS("ENG 102", "Postlab", 3, "14 / 04 / 2020", 16, 04, 2021, "e-mail", "No");

            Admin admin = new Admin();

            ats.Add(b1);
            ats.Add(b2);
            ats.Add(b3);
            ats.Add(b4);
            ats.Add(b5);

            List<ATS> UmutcanHazırCourse = new List<ATS>();
            ATS umutB1 = b1;
            UmutcanHazırCourse.Add(umutB1);
            People p1 = new People("Umutcan Hazır", "1234", UmutcanHazırCourse);
            peoples.Add(p1);

            List<ATS> BerkeEdisCourse = new List<ATS>();
            ATS berkeB1 = b1;
            BerkeEdisCourse.Add(berkeB1);
            ATS berkeB2 = b2;
            BerkeEdisCourse.Add(berkeB2);
            ATS berkeB3 = b3;
            BerkeEdisCourse.Add(berkeB3);

            People p2 = new People("Berke Edis", "1234", BerkeEdisCourse);
            peoples.Add(p2);

            List<ATS> BerkOzumKayaCourse = new List<ATS>();
            ATS berkB1 = b4;
            BerkOzumKayaCourse.Add(berkB1);
            ATS berkB2 = b5;
            BerkOzumKayaCourse.Add(berkB2);

            People p3 = new People("Berk Özüm Kaya", "1234", BerkeEdisCourse);
            peoples.Add(p3);

            People loggedInUser = null;
            bool checkAccount = false;
            bool loop = true;

            UserSelectMenu userSelectObj = new UserSelectMenu();

            userSelectObj.userSelect();

            for (; ; )
            {
                int userSelector = Convert.ToInt32(Console.ReadLine());

                if (userSelector == 1)
                {
                    while (loop)
                    {
                        Console.WriteLine("Enter your username: ");
                        string username = Console.ReadLine();
                        Console.WriteLine("Enter your password: ");
                        string password = Console.ReadLine();

                        for (int i = 0; i < peoples.Count; i++)
                        {
                            if (username == peoples[i].Username && password == peoples[i].Password)
                            {
                                checkAccount = true;
                                loggedInUser = peoples[i];
                                loop = false;
                            }
                        }

                        if (!checkAccount)
                        {
                            Console.WriteLine("Wrong USERNAME & PASSWORD");
                            Console.WriteLine("");
                            Console.WriteLine("Press 1 to enter again");
                            Console.WriteLine("Press 0 to cancel");
                            string choice = Console.ReadLine();
                            if (choice == "0")
                            {
                                loop = false;

                            }
                        }

                    }

                    if (checkAccount)
                    {
                        Console.WriteLine("System checks your account status, wait a minute...");
                        Console.WriteLine("");
                        Console.WriteLine("Identify is confirmed!..");
                    }
                    else
                    {
                        Console.WriteLine("");
                    }

                    bool check = true;

                    if (checkAccount)
                    {
                        while (check)
                        {
                            for (int i = 0; i < peoples.Count; i++)
                            {
                                if (loggedInUser.Username == peoples[i].Username && loggedInUser.Password == peoples[i].Password)
                                {
                                    Console.WriteLine("-------------------------");
                                    Console.WriteLine(peoples[i].Username + " Profile ");
                                    Console.WriteLine("-------------------------");
                                    Console.WriteLine("Assignments: ");
                                    for (int y = 0; y < peoples[i].Ats.Count; y++)
                                    {
                                        Console.WriteLine("-------------------------");
                                        Console.WriteLine("Course code: " + ats[y].CourseCode);
                                        Console.WriteLine("Assignment Type: " + ats[y].AssignmentType);
                                        Console.WriteLine("Assignment Number: " + ats[y].AssignmentNumber);
                                        Console.WriteLine("Assignment Date: " + ats[y].AssignmentDate);
                                        Console.WriteLine("Submission Deadline: " + ats[i].AssignmentDeadlineDay + "/" + ats[i].AssignmentDeadlineMonth + "/" + ats[i].AssignmentDeadlineYear);
                                        Console.WriteLine("Submission Type: " + ats[y].SubmissionType);
                                        Console.WriteLine("Teamwork: " + ats[y].Teamwork);
                                        Console.WriteLine("");
                                    }
                                }
                            }
                            break;
                        }

                    }

                    userSelectObj.userSelect();
                }

                else if (userSelector == 2)
                {
                    void mainMenu()
                    {
                        Console.WriteLine("*********M E N U*********");
                        Console.WriteLine("");
                        Console.WriteLine("Press 1 for list of all assignment records...............................");
                        Console.WriteLine("Press 2 for list of assignments with a user entered course code..........");
                        Console.WriteLine("Press 3 for list of assignments with a user entered assignment type......");
                        Console.WriteLine("Press 4 for list of submission deadline is after the user entered date...");
                        Console.WriteLine("Press 5 for list of assignments with a team with submission deadline.....");
                        Console.WriteLine("Press 6 for list of assignments individually with submission deadline....");
                        Console.WriteLine("Press 7 for update assignments...........................................");
                        Console.WriteLine("Press 8 for add assignments..............................................");
                        Console.WriteLine("Press 9 for delete assignments...........................................");
                        Console.WriteLine("Press 10 for the read a text files.......................................");
                        Console.WriteLine("Press 0 to exit program............................................");


                        int userInput = Convert.ToInt32(Console.ReadLine());

                        if (userInput == 1)
                        {
                            admin.listAllAssignment(ats);
                            mainMenu();
                        }

                        else if (userInput == 2)
                        {
                            admin.listByCourseCode(ats);
                            mainMenu();
                        }

                        else if (userInput == 3)
                        {
                            admin.listByAssignmentType(ats);
                            mainMenu();
                        }

                        else if (userInput == 4)
                        {
                            admin.listByAfterDeadline(ats);
                            mainMenu();

                        }

                        else if (userInput == 5)
                        {
                            admin.listWithTeam(ats);
                            mainMenu();
                        }
                        else if (userInput == 6)
                        {
                            admin.listIndividually(ats);
                            mainMenu();
                        }

                        else if (userInput == 7)
                        {
                            admin.updateAssignment(ats);
                            mainMenu();
                        }

                        else if (userInput == 8)
                        {
                            admin.addAssignment(ats);

                            mainMenu();

                        }

                        else if (userInput == 9)
                        {
                            admin.deleteAssignment(ats);
                            mainMenu();
                        }
                        else if (userInput == 10)
                        {
                            TextFileObj.TextReader();

                            mainMenu();
                        }
                        else
                        {
                            Environment.Exit(0);
                        }
                    }
                    mainMenu();
                }
                else
                    Environment.Exit(0);
            }
        }

    }
}

