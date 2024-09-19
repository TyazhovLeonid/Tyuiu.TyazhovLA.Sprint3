using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.TyazhovLA.Sprint3.Task1.V27.Lib
{
    public class DataService : ISprint3Task1V27
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double res = 1;
            while (startValue<=stopValue)
            {
                res *= Math.Pow(1/(Math.Pow(value, startValue)),3);
                startValue++;
            }
            return Math.Round(res,3);
        }
    }
}
