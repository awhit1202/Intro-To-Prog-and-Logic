using System;

class PigLatinTranslator
{
    static void Main()
    {
        do
        {
            // Prompt user for input
            Console.Write("Enter a word: ");
            string inputWord = (Console.ReadLine() ?? string.Empty).ToLower();  // Ensures input is not null

            // Check if input is valid (not empty)
            if (string.IsNullOrEmpty(inputWord))
            {
                Console.WriteLine("Input cannot be empty. Please enter a valid word.");
                continue; // Ask for input again
            }

            // Translate to Pig Latin
            string pigLatinWord = TranslateToPigLatin(inputWord);

            // Display the translated word
            Console.WriteLine($"Pig Latin: {pigLatinWord}");

            // Ask if the user wants to translate another word
            Console.Write("Do you want to translate another word? (yes/no): ");
        } while (Console.ReadLine()?.ToLower() == "yes");
    }

    static string TranslateToPigLatin(string word)
    {
        if (IsVowel(word[0]))
        {
            // Word starts with a vowel, add "way" to the end
            return word + "way";
        }
        else
        {
            // Word starts with a consonant, move consonants before the first vowel to the end and add "ay"
            int firstVowelIndex = FindFirstVowelIndex(word);
            if (firstVowelIndex == -1) // Handle edge case where no vowels are found
            {
                return word + "ay";  // If no vowels, add "ay"
            }
            string prefix = word.Substring(0, firstVowelIndex);
            string suffix = word.Substring(firstVowelIndex);
            return suffix + prefix + "ay";
        }
    }

    static bool IsVowel(char letter)
    {
        // Check if a letter is a vowel
        return "aeiou".Contains(letter);
    }

    static int FindFirstVowelIndex(string word)
    {
        // Find the index of the first vowel in a word
        for (int i = 0; i < word.Length; i++)
        {
            if (IsVowel(word[i]))
            {
                return i;
            }
        }
        // If no vowel is found, return -1
        return -1;
    }
}