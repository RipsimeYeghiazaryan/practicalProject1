using System;

public class maxNumOfUnequalConsectutiveChar
{
    static int MaximumChars(string str)
    {
        string longest = "";
        for (int i = 0; i < str.Length; i++)
        {
            if (longest.Contains(str[i]) == false)
            {
                longest += str[i];
            }
        }
        return longest.Length;
    }
    static public void Main()
    {
        string str = "";

        // Ask the user to type sequence of symbols(string).
        Console.Write("Type a sequence of symbols(string), and then press Enter: ");
        str = Console.ReadLine();

        Console.WriteLine("The maximum number of unequal consecutive characters is {0:0.##}\n", MaximumChars(str));
    }
}