/*
 * https://projecteuler.net/problem=1
 * C:\Users\Karm\Documents\Dev\ProjectEuler\ProjectEuler_ProblemArchives\ProjectEuler_ProblemArchives\Problems\PE0001_MultiplesOf3Or5.pdf
*/

using System;

public class PE0001_MultiplesOf3Or5
{
    public static void Run()
    {
        Console.WriteLine("Testing... PE0001_MultiplesOf3Or5\n");

        const int maxNumber = 1000;
        int totalSum = 0;
        for (int i = 1; i < maxNumber; i++)
        {
            if (i % 3 == 0 || i % 5 == 0)
                totalSum = totalSum + i;
        }

        Console.WriteLine(totalSum + "\n");
    }
}
