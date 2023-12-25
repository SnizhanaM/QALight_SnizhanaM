using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QALight_SnizhanaM
{
    class Boeing : Plane
    {
        public Boeing(string planeType, string maxSpeed, string maxHeight, string issueYear)
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


    } //757-200, 1990 The hijacked aircraft struck a parked China Southwest Airlines Boeing 707, 
}
