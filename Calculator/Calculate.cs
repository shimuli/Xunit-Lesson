using System.Collections.Generic;
namespace Calculator
{
    public class Calculate
    {
        public int Add(int A, int B)
        {
            return A + B;
        }

        public double AddDouble(double A, double B)
        {
            return A + B;
        }

        public List<int> FiboNumbers => new List<int> { 1,1,2,3,5,8,13};
    }
}
