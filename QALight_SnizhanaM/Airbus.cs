using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QALight_SnizhanaM
{
    class Airbus : Plane
    {
        public Airbus(string planeType, string maxSpeed, string maxHeight, string issueYear)
        {
            TypeOfPlane = planeType;
            MaxSpeed = maxSpeed;
            MaxHeight = maxHeight;
            _yearOfIssue = issueYear;
        }
        public override void ShowPlaneInfo()
        {
            Console.WriteLine($"Type of plane is {TypeOfPlane}, its maximum speed is {MaxSpeed}, its maximum height is {MaxHeight}.");
        }

        public string GetYearOfIssue()
        {
            return _yearOfIssue;
        }

        //2003 was damaged by maintenance personnel
    }
}
