using System;

class Student
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number [1-add,2-delete,3-view,4-update] the student details: ");
        int choice = Convert.ToInt32(Console.ReadLine());
        switch (choice)
        {
            case 1:
                Console.WriteLine("student details are added");
                break;
            case 2:
                Console.WriteLine("student details are deleted");
                break;
            case 3:
                Console.WriteLine("student details can be viewd");
                break;
            case 4:
                Console.WriteLine("student details can be updated");
                break;
            default:
                Console.WriteLine("Invalid choice:enter valid number");
                break;

        }
    }
}