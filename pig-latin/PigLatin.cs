using System;
using System.Text; //Allows us to use the StringBuilder class.

public static class PigLatin
{
    private static string result;

    public static string Translate(string word)
    {


        //Code added after in class instruction
        string[] vowels = new string[] { "a", "e", "i", "o", "u", "y" };
        StringBuilder output = new StringBuilder();
        string[] words = word.Split(' ');

        foreach (string value in words)  //Runs switch case on each value of the
                                         //array 
        {


            string firstLetter = value.Substring(0, 1);
            string secondLetter = value.Substring(1);
            string thirdLetter = (value.Length > 2) ? value.Substring(2, 1) : null;
            string translation = "";


            switch (firstLetter)
            {
                case "a":
                    translation = word + "ay";
                    output.Append(translation);
                    break;

                case "e":
                    translation = word + "ay";
                    output.Append(translation);
                    break;

                case "i":
                    translation = word + "ay";
                    output.Append(translation);
                    break;


                case "o":
                    translation = word + "ay";
                    output.Append(translation);
                    break;

                case "u":
                    translation = word + "ay";
                    output.Append(translation);
                    break;

                /*case "p":
                    translation = secondLetter + firstLetter + "ay";
                    break;

                case "k":
                    translation = secondLetter + firstLetter + "ay";
                    break;
                case "x":
                    translation = secondLetter + firstLetter + "ay";
                    break;
                case "q":
                    translation = secondLetter + firstLetter + "ay";

                 */


                default:
                    //Already checked against all vowels, so now the word
                    //starts with a consonant and we can test further rules

                    // Handle "qu", for example "queen" becomes "eenquay"

                    if (firstLetter == "q" && secondLetter == "u")
                    {
                        translation = value.Substring(2) + firstLetter + secondLetter + "ay";
                        output.Append(translation);
                        break;
                    }

                    // Handle "xr" and "yt"

                    if ((firstLetter == "x" && secondLetter == "r") || (firstLetter == "y" && secondLetter == "t"))
                    {
                        translation = value + "ay";
                        output.Append(translation);
                        break;
                    }


                    // check if the second letter is also a consonant, 
                    //essentially verifying that the word starts with 
                    //a consonant cluster
                    bool isVowel = false;
                    foreach (string letter in vowels)
                    {
                        if (secondLetter == letter)
                        {
                            isVowel = true;
                        }
                    }

                    if (isVowel)
                    {
                        // the second letter is a vowel
                        translation = value.Substring(1) + firstLetter + "ay";
                        output.Append(translation);
                    }
                    else
                    {
                        // check if the third letter is also a consonant, 
                        //essentially verifying that the word starts with
                        //a consonant cluster                    
                        isVowel = false; // reset value
                        foreach (string letter in vowels)
                        {
                            if (thirdLetter == letter)
                            {
                                if (thirdLetter != "u")
                                {
                                    // Handle any consonant + 
                                    //"qu" at the word's beginning, 
                                    //example "square" becomes "aresquay"

                                    isVowel = true;
                                }
                            }
                        }

                        if (isVowel)
                        {
                            // the second letter is a consonant
                            translation = value.Substring(2) + firstLetter + secondLetter + "ay";
                            output.Append(translation);
                        }
                        else
                        {
                            translation = value.Substring(3) + firstLetter + secondLetter + thirdLetter + "ay";
                            output.Append(translation);
                        }
                    }

                    break;
            }


            output.Append(" "); // adds space between words
        }

        result = output.ToString().TrimEnd();
        return result;
    }



}
