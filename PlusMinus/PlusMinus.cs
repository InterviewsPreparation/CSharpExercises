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
        float positiveRatio=0.0f, zeroRatio=0.0f, negativeRatio=0.0f;
       foreach(var arrElement in arr)
       {   
           switch(Math.Sign(arrElement))
           {
               case 1:
               positiveRatio++;
               break;
               case 0:
               zeroRatio++;
               break;
               case -1:
               negativeRatio++;
               break;
           }            
        }
        //Computing Ratios
        positiveRatio = positiveRatio/arr.Count;
        zeroRatio = zeroRatio/arr.Count;
        negativeRatio = negativeRatio/arr.Count;
        
        //Printing Ratios
        Console.WriteLine(positiveRatio.ToString("0.000000"));
        Console.WriteLine(negativeRatio.ToString("0.000000"));
        Console.WriteLine(zeroRatio.ToString("0.000000"));

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
