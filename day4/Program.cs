using System;
class Stringpg
{
    static void Main(string[] args)
    {
        //code to find number of vowels
        string name = "Csharp language is invented in 2002";
        string low = name.ToLower();
        int count = 0;
        foreach (char ch in low)
        {
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
            {
                count++;
            }
        }
        Console.WriteLine("The number of vowels are: " + count);
        
         //code to find spaces 
        string[] con = name.Split(' ');
        Console.WriteLine("The number of spaces are: " + ((con.Length) - 1));

        //code to find number of special characters
        string name2 = "Csharp $language is invented $in 2002$";
        string[] con2 = name2.Split('$');
        Console.WriteLine("The number of special characters are: " + ((con2.Length) - 1));

        //code to find number of words in the given string
        string[] con3 = name.Split(' ');
        Console.WriteLine("The number of words in given string  are: " + (con3.Length));

    }
}