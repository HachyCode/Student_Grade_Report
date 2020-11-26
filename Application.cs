using System;
using System.Collections.Generic;
using System.Text;

namespace Student_Grade_Report
{
    class Application
    {
        private bool End = false;
        public static List<GradeProfile> gradeProfiles = new List<GradeProfile>();

        public void Run()
        {
            Data();

            while (!End)
            {
                Console.Clear();
                Console.Write("\n1.Display all student grade profiles \n2.Add new student grade \n3.Quite the program \n\nYour choise: ");
                int choise = Int32.Parse(Console.ReadLine());

                //Displays all info 
                if (choise == 1)
                {
                    Console.Clear();
                    for (int i = 0; i <= gradeProfiles.Count - 1; i++)
                    {
                        gradeProfiles[i].Display();
                    }
                    Console.WriteLine();
                    Console.ReadKey(true);
                }

                //Add new student and its grade
                else if (choise == 2)
                {
                    Console.Clear();

                    //Student Info
                    Console.Write("Enter student name: ");
                    string name = Console.ReadLine();

                    Console.Write("Enter student ID: ");
                    int id = Int32.Parse(Console.ReadLine());

                    gradeProfiles.Add(new GradeProfile(name, id));

                    //module grades
                    int gradeProfilesCount = gradeProfiles.Count - 1;

                    Console.Write($"Enter grade for module MOD0045: ");
                    int grade1 = Int32.Parse(Console.ReadLine());
                    gradeProfiles[gradeProfilesCount].modules1.UpdateGrade(grade1);

                    Console.Write($"Enter grade for module MOD0045: ");
                    int grade2 = Int32.Parse(Console.ReadLine());
                    gradeProfiles[gradeProfilesCount].modules2.UpdateGrade(grade2);

                    Console.Write($"Enter grade for module MOD0045: ");
                    int grade3 = Int32.Parse(Console.ReadLine());
                    gradeProfiles[gradeProfilesCount].modules3.UpdateGrade(grade3);

                    Console.Write($"Enter grade for module MOD0045: ");
                    int grade4 = Int32.Parse(Console.ReadLine());
                    gradeProfiles[gradeProfilesCount].modules4.UpdateGrade(grade4);

                    Console.Write($"Enter grade for module MOD0045: ");
                    int grade5 = Int32.Parse(Console.ReadLine());
                    gradeProfiles[gradeProfilesCount].modules5.UpdateGrade(grade5);

                    Console.Write($"Enter grade for module MOD0045: ");
                    int grade6 = Int32.Parse(Console.ReadLine());
                    gradeProfiles[gradeProfilesCount].modules6.UpdateGrade(grade6);
                }

                //exit the program
                else if (choise == 3)
                {
                    Console.WriteLine("Program qiute!!!");
                    End = true;
                }

                else
                {
                    Console.WriteLine("Something whent wrong. Please try again");
                }
            }
        }

        public void Data()
        {
            gradeProfiles.Add(new GradeProfile("Lily", 111111111));//2:2
            gradeProfiles[0].modules1.UpdateGrade(49);
            gradeProfiles[0].modules2.UpdateGrade(69);
            gradeProfiles[0].modules3.UpdateGrade(53);
            gradeProfiles[0].modules4.UpdateGrade(62);
            gradeProfiles[0].modules5.UpdateGrade(36);
            gradeProfiles[0].modules6.UpdateGrade(42);

            gradeProfiles.Add(new GradeProfile("Bob", 222222222));//2:1
            gradeProfiles[1].modules1.UpdateGrade(67);
            gradeProfiles[1].modules2.UpdateGrade(74);
            gradeProfiles[1].modules3.UpdateGrade(64);
            gradeProfiles[1].modules4.UpdateGrade(59);
            gradeProfiles[1].modules5.UpdateGrade(71);
            gradeProfiles[1].modules6.UpdateGrade(60);

            gradeProfiles.Add(new GradeProfile("Hope", 333333333));//1st
            gradeProfiles[2].modules1.UpdateGrade(74);
            gradeProfiles[2].modules2.UpdateGrade(80);
            gradeProfiles[2].modules3.UpdateGrade(69);
            gradeProfiles[2].modules4.UpdateGrade(68);
            gradeProfiles[2].modules5.UpdateGrade(74);
            gradeProfiles[2].modules6.UpdateGrade(85);
        }
    }
}
