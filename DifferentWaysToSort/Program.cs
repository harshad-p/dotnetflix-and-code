// See https://aka.ms/new-console-template for more information
using System.Collections;

Console.WriteLine("Hello, World!\n\nDifferent ways to sort.");

var array = new int[] { 100, 50, 20, 1, -1, 0, 2, 50 };

// Method 1
Console.WriteLine("\nMethod 1: Using Array.Sort()");
var method1Array = GetCopy(array);
Array.Sort(method1Array);
PrintArray(method1Array);

// Method 2
Console.WriteLine("\nMethod 2: Using List.Sort() method");
var method2List = array.ToList();
method2List.Sort();
PrintList(method2List);

// Method 2
Console.WriteLine("\nMethod 2: Using ICompararer");
var method3List = array.ToList();
method3List.Sort(new MyComparer());
PrintList(method3List);

void PrintArray(Array array)
{
    foreach(var item in array)
        Console.Write(item + ", ");
}

void PrintList(List<int> list)
{
    foreach(var item in list)
        Console.Write(item + ", ");
}

static Array GetCopy(Array array)
{
    Array copiedArray = new int[array.Length];
    Array.Copy(array, copiedArray, array.Length);
    return copiedArray;
}
