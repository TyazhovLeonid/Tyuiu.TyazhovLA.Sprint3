using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.TyazhovLA.Sprint3.Task6.V9.Lib
{
    public class DataService : ISprint3Task6V9
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int i, z;
            int count = 0;
            for (i = startValue; i <= stopValue; i++)
            {
                for (z = 1; z <= i; z++) ;
                {
                    if (i % z == 0) count += 1;
                }
            }
            return count;
        }
    }
}
