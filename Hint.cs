using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess_the_Word___Y13_Programming_Project
{
    public class Hint
    {
        // Creates necessary variables

        int HintCount = 8; // Notes down how many hints there are

        string SeventhHintValues = string.Empty;

        public int GetHintCount()
        {
            return HintCount;
        }
        int RevealButtonClicked = 0;
        public void RevealButtonClick()
        {
            RevealButtonClicked++;
            if (RevealButtonClicked == 25)
            {
                MessageBox.Show("Easter egg 2. Stop clicking this button");
            }
        }
        public string FirstHint(string RandomWord)
        {
            // Hint 1 - First letter of the word
            return RandomWord[0].ToString();
        }
        public string SecondHint(string RandomWord)
        {
            // Hint 2 - Total number of vowels
            int NumberOfVowels = 0;
            for (int i = 0; i < RandomWord.Length - 1; i++)
            {
                if (Convert.ToString(RandomWord[i]) == "A" | Convert.ToString(RandomWord[i]) == "E" | Convert.ToString(RandomWord[i]) == "I" | Convert.ToString(RandomWord[i]) == "O" | Convert.ToString(RandomWord[i]) == "U")
                {
                    NumberOfVowels++;
                }
            }
            return NumberOfVowels.ToString();
        }
        public string ThirdHint(string RandomWord)
        {
            // Hint 3 - Total number of constants
            // Finds the total length and number of vowels, after this it converts them to an integer and finds the number of constants by doing (wordLength - NumberOfVowels) and returns the value as a string
            return (Convert.ToByte(RandomWord.Length) - Convert.ToByte(GetHint(2, RandomWord))).ToString();
        }
        public string FourthHint(string RandomWord)
        {
            // Hint 4 - Most frequent vowel
            // Y is not included as a vowel in this scenario
            // Does not include 2
            int A = 0;
            int E = 0;
            int I = 0;
            int O = 0;
            int U = 0;
            // Creates variables corresponding to the number of times each vowel is used

            for (int i = 0; i < RandomWord.Length; i++)
            { // Iterates through each character, if it is a vowel, the corresponding vowel variable is updated
                switch (Convert.ToString(RandomWord[i]))
                {
                    case "A":
                        A++;
                        break;

                    case "E":
                        E++;
                        break;

                    case "I":
                        I++;
                        break;

                    case "O":
                        O++;
                        break;

                    case "U":
                        U++;
                        break;

                    default:
                        break;
                }
            }

            int[] tempArray = { A, E, I, O, U }; // An array is created to organise the vowels
            int max = 0;
            for (int i = 0; i < 5; i++)
            {
                if (tempArray[0] == tempArray[1] && tempArray[0] > 1)
                {
                    if (max < tempArray[i])
                    {
                        max = tempArray[i];
                    }
                }
            }
            Array.Sort(tempArray); // Sorts the array - Smallest values to the largest
            Array.Reverse(tempArray); // Reverses the array - Largest values to the smallest


            Array.Sort(tempArray); // Sorts the array - Smallest values to the largest
            Array.Reverse(tempArray); // Reverses the array - Largest values to the smallest

            string value = string.Empty;
            if (max > 1 && max == tempArray[0])
            {
                if (tempArray[0] > 1) // If first value of array > 1, then it is a duplicate vowel
                {
                    if (tempArray[0] == A) // Returns the corresponding vowel that is a duplicate
                    {
                        value = "A";
                    }
                    else if (max == E)
                    {
                        value = "E";
                    }
                    else if (max == I)
                    {
                        value = "I";
                    }
                    else if (max == O)
                    {
                        value = "O";
                    }
                    else if (max == U)
                    {
                        value = "U";
                    }
                }
                else
                {
                    return "No duplicate vowels"; // If there are no duplicate vowels
                }
            }

            return value;
        }
        public string FifthHint(string RandomWord)
        {
            // Hint 5 - The word length, primarily used if the user
            // clicks the 'random' option on the total characters selector
            return RandomWord.Length.ToString();
        }
        public string SixthHint(string RandomWord)
        {
            // Hint 6 - Last letter of word
            return RandomWord[RandomWord.Length - 1].ToString();
        }
        public string SeventhHint(string RandomWord)
        {
            // Hint 7, reveals up to a total of 6 random consonants that aren't in the random word
            // Checks if X values(6 as default) have been added and returned

            if (SeventhHintValues.Length != Program.Game.GetSeventhHintRevealTimes()) // The default SeventhHintRevealTimes is 6
            {
                // If the hint hasn't been called X times (6 as default), then a new random consonant is added to the string and returned
                SeventhHintValues = SeventhHintValues + GenerateRandomConsonant(RandomWord);
            }

            return SeventhHintValues;
        }
        public void ResetSeventhHintValues()
        {
            // Resets the variable holding all of the stored consonants so the hint can be run again
            SeventhHintValues = string.Empty;
        }
        public char GenerateRandomConsonant(string RandomWord)
        {
            // An array is made holding all of the consonants in
            char[] consonants = { 'B', 'C', 'D', 'F', 'G', 'H', 'J', 'K', 'L', 'M', 'N', 'P', 'Q', 'R', 'S', 'T', 'V', 'W', 'X', 'Y', 'Z' };

            Random random = new Random();

            char randomConsonant;

            do
            {
                // A random consonant is selected using a random index, which relates to a random consonant in the array
                randomConsonant = consonants[random.Next(consonants.Length)];

                // The while conditions check if the random consonant is in SeventhHintValues or if it is in the random word generated
                // If the conditions are false, then the random consonant can be shown to the user
            } while (IsConsonantInWord(randomConsonant, RandomWord) || IsConsonantInWord(randomConsonant, SeventhHintValues));

            return randomConsonant; // Returns the value which has been checked
        }
        public bool IsConsonantInWord(char character, string word)
        {
            // Check if the character is present within the word given
            // Returns 'true' if the character is within the word
            return word.Contains(character);
        }
        public int EightHint(string RandomWord)
        {
            // Hint 8 - returns a random character that is in the random word
            // The character cannot be the first or last character
            // Only the index is calculated at this stage
            Random r = new Random();

            // Returns an index which is between the first and last character
            return r.Next(1, RandomWord.Length - 2);
        }

        public string GetHint(int hintNumber, string RandomWord)
        {
            switch (hintNumber) // Returns the corresponding hint depending on the hintNumber
            {
                case 1:
                    return FirstHint(RandomWord);

                case 2:
                    return SecondHint(RandomWord);

                case 3:
                    return ThirdHint(RandomWord);

                case 4:
                    return FourthHint(RandomWord);

                case 5:
                    return FifthHint(RandomWord);

                case 6:
                    return SixthHint(RandomWord);

                case 7:
                    return SeventhHint(RandomWord);
                    case 8:
                        return EightHint(RandomWord).ToString();
                default:
                    return FirstHint(RandomWord) + SixthHint(RandomWord);
            }
        }
    }
}
