using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess_the_Word___Y13_Programming_Project
{
    public class Settings : Game
    {
        // Necessary Variables
        string Difficulty;
        int TotalLetters;
        int secretHintValue = 10;

        public Settings() // Constructor
        {
            TotalLetters = 5;
            Difficulty = "Easy";
        }
        public int GetSecretHintValue()
        {
            return secretHintValue;
        }
        public string GetDifficulty()
        {
            return Difficulty;
        }
        public int GetTotalLetters()
        {
            return TotalLetters;
        }
        public void UpdateDifficulty(string difficulty)
        {
            if (difficulty == "Random") // Selects a random difficulty
            {
                Random r = new Random();
                switch (r.Next(0, 4)) // Updates difficulty accordingly
                {
                    case 0:
                        Difficulty = "Easy";
                        secretHintValue = 10; // Relates to the secret hint on the game page
                        break;

                    case 1:
                        Difficulty = "Medium";
                        secretHintValue = 11;
                        break;

                    case 2:
                        Difficulty = "Hard";
                        secretHintValue = 12;
                        break;

                    case 3:
                        Difficulty = "Extremely Hard";
                        secretHintValue = 13;
                        break;

                    default:
                        Difficulty = "Impossible";
                        secretHintValue = 14;
                        break;
                } // Used to select a random difficulty + its corresponding total guesses
            }
            else
            {
                switch (difficulty) // Updates the difficulty to what the user chose
                {
                    case "Easy":
                        Difficulty = "Easy";
                        secretHintValue = 10;
                        break;

                    case "Medium":
                        Difficulty = "Medium";
                        secretHintValue = 11;
                        break;

                    case "Hard":
                        Difficulty = "Hard";
                        secretHintValue = 12;
                        break;

                    case "Extremely Hard":
                        Difficulty = "Extremely Hard";
                        secretHintValue = 13;
                        break;

                    default:
                        Difficulty = "Impossible";
                        secretHintValue = 14;
                        break;
                } // Updates the difficulty to what the user selected + its corresponding total guesses
            }
        }
        public void UpdateTotalLetters(string totalLetters)
        {
            if (totalLetters == "Random") // Updates total letters with a random value
            {
                Random r = new Random();
                switch (r.Next(0, 3))
                {
                    case 0:
                        TotalLetters = 3;
                        break;

                    case 1:
                        TotalLetters = 4;
                        break;

                    case 2:
                        TotalLetters = 5;
                        break;

                    default:
                        TotalLetters = 7;
                        break;
                }
            }
            else // Updates total letters with what the user selects
            {
                TotalLetters = Convert.ToInt32(totalLetters);
            }
        }
    }
}
