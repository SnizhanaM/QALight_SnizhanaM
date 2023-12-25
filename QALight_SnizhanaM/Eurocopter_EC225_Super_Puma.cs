using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QALight_SnizhanaM
{
    class Eurocopter_EC225_Super_Puma : Helicopter
    {
        public Eurocopter_EC225_Super_Puma(string helicopterType, string maxSpeedOfHelicopter, string maxHeightOfHelicopter, string helicopterIssueYear)
        {
            TypeOfHelicopter = helicopterType;
            MaxHelicopterSpeed = maxSpeedOfHelicopter;
            MaxHelicopterHeight = maxHeightOfHelicopter;
            _yearOfHelicopterIssue = helicopterIssueYear;
        }
        public override void ShowHelicopterInfo()
        {
            Console.WriteLine($"Type of helicopter is {TypeOfHelicopter}, its maximum speed is {MaxHelicopterSpeed}, its maximum height is {MaxHelicopterHeight}.");
        }
        public override int GetYearOfHelicopterIssue()
        {
            int helicopterIssueYear = Convert.ToInt32(_yearOfHelicopterIssue);
            return helicopterIssueYear;
        }
        //crashed into a kindergarten in Brovary in 2023
    }
}
