//One-Dimensional array program
using System;
class Onedr
{
    static void Main(string[] args)
    {
        int noofstudent = 2;
        string[] sName = new string[noofstudent];
        Console.WriteLine("Enter the names of 2 students: ");
        for (int i = 0; i < noofstudent ; i++)
        {
            Console.WriteLine("Enter name of student- " + (i + 1));
            sName[i] = Console.ReadLine();
        }
        Console.WriteLine("Student Data:");
        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine("The " + (i + 1) +" student name is: " + sName[i]);
        }
    }
}