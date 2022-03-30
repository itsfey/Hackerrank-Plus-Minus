using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        float positiveCounter = 0, negativeCounter = 0, zeroCounter = 0;
    float arrayLength = arr.Count();

    foreach(int num in arr){
        if(num > 0)
            positiveCounter++;
        else if(num < 0)
            negativeCounter++;
        else
            zeroCounter++;
    }

    Console.WriteLine(positiveCounter/arrayLength);
    Console.WriteLine(negativeCounter/arrayLength);
    Console.WriteLine(zeroCounter/arrayLength);
}

}


class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}
