// See https://aka.ms/new-console-template for more information

string myString = "We promptly judged antique ivory buckles for the next prize";

string result = Result.pangrams(myString);

Console.WriteLine(result);

class Result
{

    /*
     * Complete the "pangrams" function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string pangrams(string s)
    {
        // ["a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z']
        // ["a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"]
        string alphabet = "abcdefghijklmnopqrstuvwxyz";
        bool isPangram = alphabet.All(c => s.ToLower().Contains(c));
        return isPangram ? "pangram" : "not pangram";
    }

}