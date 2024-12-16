using System;

class MainClass 
{
    public static int CodingChallenge(string inputString) 
    {
        string orderVowels = "aeiou";
        int maxLength = 0, currentLength = 0, vowelIndex = 0;

        foreach (char i in inputString)
        {
            if (vowelIndex < orderVowels.Length && i == orderVowels[vowelIndex])
                currentLength++;  
            else if (vowelIndex < orderVowels.Length - 1 && i == orderVowels[vowelIndex + 1])
            {
                vowelIndex++;  
                currentLength++;  
            }
            else if (!orderVowels.Contains(i))
            {
                vowelIndex = 0;
                currentLength = 0;
            }
            else 
            {
                maxLength = Math.Max(maxLength, currentLength);
                currentLength = 0;
                vowelIndex = (i == 'a') ? 0 : vowelIndex;  
            }

            if (vowelIndex == orderVowels.Length)  
                maxLength = Math.Max(maxLength, currentLength); 

        }
        return maxLength; 
    }

    static void Main() 
    {  
        Console.WriteLine("Enter the string:");
        Console.WriteLine(CodingChallenge(Console.ReadLine()));  
    }
}
