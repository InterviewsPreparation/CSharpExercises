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
     * Complete the 'miniMaxSum' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void miniMaxSum(List<int> arr)
    {
        //descending sort
        arr.Sort((a,b) => b.CompareTo(a));
        long minSum = 0, maxSum = 0;
        //summing up the first 4 elements
        for (int i = 0; i < 4; i++)
        {
            minSum += arr[i];
        }
        //summing up the last 4 elements
        for (int i = arr.Count - 1; i > arr.Count - 5; i--)
        {
            maxSum += arr[i];
        }
        Console.WriteLine(minSum + " " + maxSum);
    }

}

class Solution
{
    public static void Main(string[] args)
    {

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.miniMaxSum(arr);
    }
}
