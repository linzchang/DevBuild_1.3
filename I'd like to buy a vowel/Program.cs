using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace I_d_like_to_buy_a_vowel
{
    class Program
    {
        static void Main(string[] args)
        {
            string userText;
            int length, letter;

            //Ask user for a phrase
            Console.WriteLine("Enter a word or phrase: ");
            userText = Console.ReadLine();
            length = userText.Length;
            letter = 0;

            //Call method to add up vowels in phrase
            int vowels = AddVowel(userText, letter, length);

            //Print out total number of vowels in phrase
            Console.WriteLine("Your word/phrase contains " + vowels + " vowels.");
        }

        public static int AddVowel(string userText, int letter, int length)
        {
            int count = 0;

            //Adds up each vowel that occurs in phrase
            for (letter = 0; letter < length; letter++)
            {

                if (userText[letter] == 'a' || userText[letter] == 'e' || userText[letter] == 'i' || userText[letter] == 'o' || userText[letter] == 'u' || 
                    userText[letter] == 'A' || userText[letter] == 'E' || userText[letter] == 'I' || userText[letter] == 'O' || userText[letter] == 'U')
                {
                    count++;
                }
            }
            return count;
        }
    }
}
