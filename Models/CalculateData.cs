using System;

namespace Lab1Api.Models
{
    public enum Sign
    {
        Plus='+',
        Minus='-',
        Multiply='*',
        Divide='/',
        Degree='^',
        Root='~',
    }

    public class CalculateData
    {
        public double FirstParam { get; set; }

        public double SecondParam { get; set; }

        public string Sign { get; set; }

        public Sign GetSign()
        {
            return (Sign)Sign[0];
        }
    }
}
