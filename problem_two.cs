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

class Solution {

    // Complete the staircase function below.
    static void staircase(int n) {
        
     var result = "#";
    for (int i = 0 ; i < n; i++){
        int num = n;
        for (int j = n - 1 ; j > i ; j--)
        { Console.Write(" ");}
        Console.Write(result);
        Console.WriteLine();
        result = "#" + result;
}

    }

    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());

        staircase(n);
    }
}
