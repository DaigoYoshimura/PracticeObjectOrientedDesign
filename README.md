# PracticeObjectOrientedDesign
using System;
using System.Reflection;

public class Triangle
{
    int high = int.Parse(Console.ReadLine());
    int bottom = int.Parse(Console.ReadLine());
    int num = bottom * high / 2;
    Console.Writeline(num);
}
