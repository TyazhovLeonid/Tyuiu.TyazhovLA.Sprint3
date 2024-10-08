﻿using System.ComponentModel.DataAnnotations;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.TyazhovLA.Sprint3.Task7.V26.Lib
{
    public class DataService : ISprint3Task7V26
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue-startValue+1;
            double[] valueArray = new double[len];
            double y;
            int count = 0;
            for (int x = startValue;x <= stopValue;x++)
            {
                y = 5-3*x+((1+Math.Sin(x))/(2*x-0.5));
                valueArray[count] = Math.Round(y,2);
                if (y == 0) valueArray[count] = 0;
                count++;
            }
            return valueArray;
        }
       

    }
}
