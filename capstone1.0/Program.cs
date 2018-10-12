using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capstone1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            char doAgain;
            bool runP = true;

            Console.WriteLine("Please enter your first name");
            string firstName = Console.ReadLine();

            while (runP == true)
            {
                Console.WriteLine("{0}, Please enter a word or a sentence", firstName);
                string sentence = Console.ReadLine();
                string pigLatin = toPigLatin(sentence);
                Console.WriteLine(pigLatin);
                Console.WriteLine("\n{0}, Would you like to run the application again? (Y or N)", firstName);

                doAgain = Convert.ToChar(Console.ReadLine());

                if (doAgain == 'n' || doAgain == 'N')
                {
                    runP = false;
                }
                else if (doAgain == 'y' || doAgain == 'Y')
                {
                    runP = true;
                }
                else
                    Console.WriteLine("Invalid entry, try again");
            }

        }
        private static string toPigLatin(string sentence)
        {
            const string vowels = "AEIOUaeio";
            List<string> pigWords = new List<string>();

            foreach (string word in sentence.Split(' '))
            {
                string firstLetter = word.Substring(0, 1);
                string restOfWord = word.Substring(1, word.Length - 1);
                int currentLetter = vowels.IndexOf(firstLetter);

                if (currentLetter == -1)
                {
                    pigWords.Add(restOfWord + firstLetter + "ay");
                }
                else
                {
                    pigWords.Add(word + "way");
                }
            }
            return string.Join(" ", pigWords);
        }
    }
}
