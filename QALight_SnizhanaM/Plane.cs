using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QALight_SnizhanaM
{
    abstract class Plane : IFlyable
    {
        public string TypeOfPlane { get; set; }
        public string MaxSpeed { get; set; }
        public string MaxHeight { get; set; }

        protected string _yearOfIssue;
        static public int PlanesCount = 0;

        
        /*public virtual int GetYearOfIssue(string issueYear)
        {
            return issueYear;
        }*/

        public abstract void ShowPlaneInfo();

        public void RegisterFlyingTransport()
        {
            PlanesCount++;
            Console.WriteLine($"PlanesCount: {PlanesCount}");
        }
    }
}
