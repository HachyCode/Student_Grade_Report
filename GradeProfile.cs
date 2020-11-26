using System;
using System.Collections.Generic;
using System.Text;

namespace Student_Grade_Report
{
    class GradeProfile : IStudentInfo
    {
        //IStudentInfo properties
        public string Name { get; set; }
        public int ID { get; set; }

        public Modules modules1 = new Modules("MOD0045", 0.3);
        public Modules modules2 = new Modules("MOD0043", 0.7);
        public Modules modules3 = new Modules("MOD0056", 0.5);
        public Modules modules4 = new Modules("MOD0056", 0.5);
        public Modules modules5 = new Modules("MOD0086", 0.3);
        public Modules modules6 = new Modules("MOD0086", 0.7);

        //Constructor
        public GradeProfile(string _name, int _id)
        {
            Name = _name;
            ID = _id;
        }

        //Methods
        public void Display()
        {
            Console.WriteLine($"\nname: {Name} \nID: {ID}");

            modules1.DisplayInfo();
            modules2.DisplayInfo();
            modules3.DisplayInfo();
            modules4.DisplayInfo();
            modules5.DisplayInfo();
            modules6.DisplayInfo();

            AvarageCalculator();
            Console.WriteLine("\n___________________________________________");
        }

        public void AddGrade(int i,int _grade)
        {
            if (i == 1)
            {
                modules1.UpdateGrade(_grade);
            }
            if (i == 2)
            {
                modules2.UpdateGrade(_grade);
            }
            if (i == 3)
            {
                modules3.UpdateGrade(_grade);
            }
            if (i == 4)
            {
                modules4.UpdateGrade(_grade);
            }
            if (i == 5)
            {
                modules5.UpdateGrade(_grade);
            }
            if (i == 6)
            {
                modules6.UpdateGrade(_grade);
            }

        }

        public void AvarageCalculator()
        {
            double gradeAvarage1 = modules1.Grade * modules1.Weight;
            double gradeAvarage2 = modules3.Grade * modules3.Weight;
            double gradeAvarage3 = modules4.Grade * modules4.Weight;
            double gradeAvarage4 = modules5.Grade * modules5.Weight;
            double gradeAvarage5 = modules6.Grade * modules6.Weight;
            double gradeAvarage6 = modules2.Grade * modules2.Weight;

            double moduleAvarage1 = gradeAvarage1 + gradeAvarage2;
            double moduleAvarage2 = gradeAvarage3 + gradeAvarage4;
            double moduleAvarage3 = gradeAvarage5 + gradeAvarage6;

            double allGradeAdded = moduleAvarage1 + moduleAvarage2 + moduleAvarage3;
            double yearAvarage = allGradeAdded / 3;

            Console.Write($"\n{Name} avarage grade: {yearAvarage}");

            if (yearAvarage >= 70)
            {
                Console.Write(" = 1st");
            }
            else if (yearAvarage >= 60)
            {
                Console.Write(" = 2:1");
            }
            else if (yearAvarage >= 50)
            {
                Console.Write(" = 2:2");
            }
            else if (yearAvarage >= 40)
            {
                Console.Write(" = Pass");
            }
            else
            {
                Console.WriteLine("Error!");
            }

        }
    }
}
