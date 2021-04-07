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

class Solution
{

    // Complete the beautifulTriplets function below.
    // Given i < j < k
    // A beautiful triplet is arr[j] - arr[i] == arr[k] - arr[j] == d
    static int beautifulTriplets(int d, int[] arr)
    {
        int count = 0;

        // Walk the array with three iterators, looking for beautiful triplets
        for (int i = 0; i < arr.Length - 1; i++)
        {
            // A beautiful triplet has a gap of d
            int val = arr[i] + d;

            // walk forward looking for val
            for (int j = i + 1; j < arr.Length && arr[j] <= val; j++)
            {
                // The first part of the triplet has been found
                if (arr[j] - arr[i] == d)
                {
                    val += d;
                    for (int k = j + 1; k < arr.Length && arr[k] <= val; k++)
                    {
                        // here's the second part of the triplet
                        if (arr[k] - arr[j] == d)
                        {
                            count++;
                        }
                    }
                }
            }
        }

        return count;
    }

    static void Main(string[] args)
    {
        int d = 3;

        int[] arr = new int[] { 1, 2, 4, 5, 7, 8, 10 };

        int result = beautifulTriplets(d, arr);

        Console.WriteLine(result);
    }
}
