using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;

namespace Guess_the_Word___Y13_Programming_Project
{
    public class Game
    {
        #region Customise Page
        // These variables are only used when the game is customised (excluding the SeventhHintRevealTimes, where 6 is the default)
        // All variables (excluding the SeventhHintRevealTimes) default is the
        // text that is held within each input box / selector on the customised page as startup

        int SeventhHintRevealTimes = 6; // The number of times the seventh hint can be revealed (6 is default)
        bool UserCustomisedGame = false; // Corresponds to if the user customised the game or not
        int TimerValue = 400; // Corresponds to how much time the user is given (400 is the default)
        double MultiplyingFactor = 1.1; // Corresponds to the multiplying factor (1.1 is the default)
        List<int> restrictHints = new List<int>(8); // Populates the hint list with empty values; 
        // Creation of the list that holds all restricted hints


        #region Get Values (Getters)
        public List<int> GetRestrictedHints()
        {
            return restrictHints; // Returns the list which holds which hints are restricted or not
        }
        public int GetTimerValue()
        {
            return TimerValue; // Returns the total time given to the user
        }
        public int GetSeventhHintRevealTimes()
        {
            return SeventhHintRevealTimes; // Returns how many times the seventh hint can be called
        }
        public bool GetUserCustomiseGame()
        {
            return UserCustomisedGame; // Returns if the user customised the current game or not
        }
        public double GetMultiplyingFactor()
        {
            return MultiplyingFactor; // Returns the multiplying factor
        }
        #endregion

        #region Update Values (Setters)
        public void ClearRestrictedHints()
        {
            restrictHints.Clear(); // Clears the restricted hints list
        }
        public void UpdateUserCustomiseGame(bool value)
        {
            UserCustomisedGame = value; // Updates if the user customised the game or not
        }
        public void UpdateSeventhHintRevealTimes(int value)
        {
            // Updates the number of times the seventh hint can be called
            SeventhHintRevealTimes = value;
        }
        public void UpdateTimerValue(int value)
        {
            TimerValue = value; // Updates the time given with the value given
        }
        public void UpdateMultiplyingFactor(double value)
        {
            MultiplyingFactor = value; // Updates the multiplying factor with the value given
        }
        #endregion

        #endregion

        // Creation of necessary variables
        bool WinOrLoss;
        protected string RandomWord;

        // Enable secret hint
        bool secretHintEnable;

        // Creation of arrays which hold all of the words (grouped by number of characters)
        string[] FiveLetterWords = System.IO.File.ReadAllLines(@"C:\School\Programming Project\Application - Guess the word\Guess the Word - Y13 Programming Project\bin\Debug\net6.0-windows\Word_File.txt");
        string[] FourLetterWords = System.IO.File.ReadAllLines(@"C:\School\Programming Project\Application - Guess the word\Guess the Word - Y13 Programming Project\bin\Debug\net6.0-windows\FourLetterWords.txt");
        string[] ThreeLetterWords = System.IO.File.ReadAllLines(@"C:\School\Programming Project\Application - Guess the word\Guess the Word - Y13 Programming Project\bin\Debug\net6.0-windows\ThreeLetterWords.txt");
        string[] SevenLetterWords = System.IO.File.ReadAllLines(@"C:\School\Programming Project\Application - Guess the word\Guess the Word - Y13 Programming Project\bin\Debug\net6.0-windows\SevenLetterWords.txt");

        public Game()
        { // Constructor - assigning values to variables
            WinOrLoss = false;
            RandomWord = string.Empty;
            secretHintEnable = true;
        }
        public bool GetSecretHintEnable()
        {
            // returns if the secret hint should be revealed or not
            return secretHintEnable;
        }
        public void UpdateSecretHintEnable(bool value)
        {
            // Changes the Secret Hint Enable variable to the opposite of what it is
            secretHintEnable = value;
        }
        public void UpdateRandomWord(string value)
        {
            RandomWord = value;
        }
        public void GenerateRandomWord(int CharacterCount)
        {
            Random r = new Random();
            switch (CharacterCount)
            {
                case 3:
                    RandomWord = ThreeLetterWords[r.Next(0, ThreeLetterWords.Length)].ToUpper();
                    break; // Assigns a random three letter word to RandomWord

                case 4:
                    RandomWord = FourLetterWords[r.Next(0, FourLetterWords.Length)].ToUpper();
                    break; // Assigns a random four letter word to RandomWord

                case 5:
                    RandomWord = FiveLetterWords[r.Next(0, FiveLetterWords.Length)].ToUpper();
                    break; // Assigns a random five letter word to RandomWord

                default:
                    RandomWord = SevenLetterWords[r.Next(0, SevenLetterWords.Length)].ToUpper();
                    break; // Assigns a random seven letter word to RandomWord
            }
        }
        public bool ValidateWord(string Word, string Guess, int TotalLetters)
        {
            int TempValue = 0;
            Word = Word.ToUpper();
            Guess = Guess.ToUpper();
            // User input is made uppercase as well as the random word selected
            if (Guess.Length == TotalLetters)
            {
                for (int i = 0; i < Guess.Length; i++) // Repeats itself the same number of times as there are characters in guess
                {
                    if (Convert.ToInt32(Guess[i]) >= 65 && Convert.ToInt32(Guess[i]) <= 90)
                    {
                        TempValue++; // TempValue increases if the guess doesn't have any special characters in it
                    }
                }
                if (TempValue == Guess.Length) // If the TempValue is the same as the guess length, then no special characters were used
                {
                    if (Word == Guess) // Checks if the user input is the same as the random word
                    {
                        return true; // Only returns true if the user has guessed the word correctly
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    // Displays an alert box if TempValue != Guess length - Meaning special characters were used
                    MessageBox.Show("Please refrain from using any special characters in your answer");
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public string GetRandomWord()
        {
            return RandomWord;
        }
        public bool GetWinOrLoss()
        {
            return WinOrLoss;
        }
        public void UpdateWinOrLoss(bool Value)
        {
            WinOrLoss = Value;
        }
    }
}
