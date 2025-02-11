static List<int> gradingStudents(List<int> grades)
{
    List<int> finalgrades = new List<int>();
    foreach (int grade in grades)
        if(grade < 38 || grade % 5 == 0 || grade % 5 < 3)
            finalgrades.Add(grade);
        else if(grade % 5 > 2)
            finalgrades.Add(grade + (5- (grade % 5)));               
        return finalgrades;
}

List<int> g = new List<int>(new int[] { 73, 67, 38, 33 } );
var fg = gradingStudents(g);

foreach (var n in fg)
    Console.WriteLine(n);

/*
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

    // *
    // * Complete the 'gradingStudents' function below.
    // *
    // * The function is expected to return an INTEGER_ARRAY.
    // * The function accepts INTEGER_ARRAY grades as parameter.
     * //

    public static List<int> gradingStudents(List<int> grades)
    {
        List<int> finalgrades = new List<int>();
        foreach (int grade in grades) 
            if(grade < 38 || grade % 5 == 0 || grade % 5 < 3) 
                finalgrades.Add(grade);
            else if(grade % 5 > 2)
                finalgrades.Add(grade + (5- (grade % 5)));                
        return finalgrades;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> grades = new List<int>();

        for (int i = 0; i < gradesCount; i++)
        {
            int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
            grades.Add(gradesItem);
        }

        List<int> result = Result.gradingStudents(grades);

        textWriter.WriteLine(String.Join("\n", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
*/