using System;

public static class ReverseString
{
    public static string Reverse(string input)
    {
        if (input.Length == 0)

        {
            return "";
        }
        else
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);

            string reverseString = new string(charArray);
            return reverseString;
        }


    }
}
