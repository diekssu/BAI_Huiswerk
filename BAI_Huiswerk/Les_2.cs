using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace BAI_Huiswerk
{
    public class Les_2
    {
        public static void calcDistance()
        {
            int[,] Distances = new int[6, 6]
            {
                {0, 50, 135, 120, 65, 65},
                {50, 0, 140, 75, 20, 70},
                {135, 140, 0, 220, 170, 75},
                {120, 75, 220, 0, 55, 145},
                {65, 20, 170, 55, 0, 90 },
                {65, 70, 75, 145, 90, 0}
            };

            int smallestDistance = 10000000;
            int currentDistance = 0;

            for (int i = 0; i < 6; i++)
            {
                for (int b = 0; b < 6; b++)
                {
                    currentDistance += Distances[i, b];
                }
                if (currentDistance < smallestDistance)
                {
                    smallestDistance = currentDistance;
                }
                currentDistance = 0;
            }
            Console.WriteLine(smallestDistance);
        }
    }
}
