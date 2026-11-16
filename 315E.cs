using System;
using System.Collections.Generic;
using System.Text;


//Lag en metode som returnerer en array med tall. 
//Som parametre tar du startverdi, sluttverdi og differanse. 
//For eksempel skal
//start=1000,
//slutt = 1028
//differense=7
//gi tallene 1000, 1007, 1014, 1021, 1028

namespace GetAcademyTasks
{
    internal class _315E
    {
        public static int[] GenerateNumberArray(int start, int end, int interval)
        {
            int arraySize = ((end - start) / interval) + 1;

            int[] intervalArray = new int[arraySize];

            return intervalArray;
        }
    }
}
