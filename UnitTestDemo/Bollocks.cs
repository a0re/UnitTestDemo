using System;

namespace UnitTestDemo
{
    public class Bollocks
    {
        public int bollNum { get; set; }
        public string bollString { get; set; }

        // assigns values to properties
        public Bollocks(int bollNum, string bollString)
        {
            this.bollNum = bollNum;
            this.bollString = bollString;
        }

        // method that returns bollNum summed with the parameter value
        public int AddTo(int n)
        {
            return n + bollNum;
        }

        // method that DIVIDES bollNum BY 
        // the parameter value and returns the dividend

        public int DivBy(int n)
        {
            return bollNum / n; 
        }
        // method that returns the modulud of dividing bollNum BY 
        // the parameter value
        public int ModOfDivBy(int n)
        {
            return bollNum % n;
        }
    }
}
