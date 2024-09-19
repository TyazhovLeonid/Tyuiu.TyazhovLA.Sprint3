using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.TyazhovLA.Sprint3.Task3.V15.Lib
{
    public class DataService : ISprint3Task3V15
    {
        public int GetMinCharCount(string value, char item)
        {
            char previousChar = '\0';
            
            int count = 0;
            foreach (char c in value)
            {
                
                if (c == item && previousChar == item) count += 1;
                
                previousChar = c;
                
                
            }   
            return count;
        }
    }
}
