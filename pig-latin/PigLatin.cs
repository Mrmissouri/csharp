using System;

public static class PigLatin
{
    public static string Translate(string word)
    {
        string firstLetter = word.Substring(0, 1);
        string secondLetter = word.Substring(1);
        string thirdLetter = word.Substring(2, 1);
        string translation = "";


        switch (firstLetter)
        {
            case "a":
                translation = word + "ay";
                break;

            case "e":
                translation = word + "ay";
                break;

            case "i":
                translation = word + "ay";
                break;


            case "o":
                translation = word + "ay";
                break;

            case "u":
                translation = word + "ay";
                break;

            case "p":
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

                break;


                // default:
                //     translation = secondLetter + firstLetter + "ay";

                //  break;


        }

        return translation;

    }










}
