using System;
using System.Collections.Generic;
using System.Text;

namespace Student_Grade_Report
{
    class Modules :  IModule, IGrade
    {
        //IModule properties
        public string Module { get; set; }
        public double Weight { get; set; }

        //IGrade properties
        public int Grade { get; set; }

        private bool gradeInfo = false;

        public Modules(string _module, double _weight)
        {
            Module = _module;
            Weight = _weight;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"\nModule: {Module} \nWeight: {Weight}");

            if (gradeInfo)
            {
                Console.WriteLine($"Grade: {Grade}");
            }
            else
            {
                Console.WriteLine($"Grade: N/A");
            }
        }

        public void UpdateGrade(int _grade)
        {
            Grade = _grade;
            gradeInfo = true;
        }
    }
}
