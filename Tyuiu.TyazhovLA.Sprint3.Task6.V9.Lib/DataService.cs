using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.TyazhovLA.Sprint3.Task6.V9.Lib
{
    public class DataService : ISprint3Task6V9
    {

        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int x,d;
            int count = 0;
            for (x = startValue; x <= stopValue; x++)
            {
                for (d = 1; d <= x; d++)
                {
                    if (x % d == 0) 
                    { 
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
