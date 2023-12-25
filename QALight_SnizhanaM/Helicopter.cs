using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QALight_SnizhanaM
{
    abstract class Helicopter : IFlyable
    {
        public string TypeOfHelicopter { get; set; }
        public string MaxHelicopterSpeed { get; set; }
        public string MaxHelicopterHeight { get; set; }

        protected string _yearOfHelicopterIssue;

        static public int HelicoptersCount = 0;

      
        
        public abstract void ShowHelicopterInfo();

        public virtual int GetYearOfHelicopterIssue()
        {
            int helicopterIssueYear = Convert.ToInt32(_yearOfHelicopterIssue);
            return helicopterIssueYear;
        }

        public void RegisterFlyingTransport()
        {
            HelicoptersCount++;
            Console.WriteLine($"HelicoptersCount: {HelicoptersCount}");
        }
    }
}
