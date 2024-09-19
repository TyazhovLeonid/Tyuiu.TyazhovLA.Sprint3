using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.TyazhovLA.Sprint3.Task3.V15.Lib
{
    public class DataService : ISprint3Task3V15
    {
        public int GetMinCharCount(string value, char item)
        {
            int count = 0;
            int countx = 0;
            char[] g= value.ToCharArray();
            for (int i = 0;i<=g.Length-2;i++)
            {
                if (g[i] == 'm' && g[i + 1] == 'm' && g[i + 2] == 'm') count += 1;
            }

            return count;
        }
    }
}
