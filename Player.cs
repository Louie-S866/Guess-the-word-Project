using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess_the_Word___Y13_Programming_Project
{
    public class Player : Database
    {
        // string Username;  - These will be necessary for the extra login page
        // string Password;

        string Guess;
        int TotalGuesses;
        string[] FirstThreeGuesses = { null, null, null };
        string[] LastThreeGuesses = { null, null, null };

        public Player()
        {
            Guess = string.Empty;
            // Declares the amount of total guesses the user will get as default
            TotalGuesses = 100;
        }
        #region Updating Values (Setters / Procedures)
        public void UpdateGuess(string input)
        {
            Guess = input;
        }
        public void UpdateFirstThreeGuesses()
        {
            if (FirstThreeGuesses[2] == null | FirstThreeGuesses[1] == null)
            {
                FirstThreeGuesses[2] = FirstThreeGuesses[1];
                FirstThreeGuesses[1] = FirstThreeGuesses[0];
                FirstThreeGuesses[0] = Guess;
            } // Used to update the first three guesses for the victory page statistics
        }
        public void UpdateLastThreeGuesses()
        {
            LastThreeGuesses[2] = LastThreeGuesses[1];
            LastThreeGuesses[1] = LastThreeGuesses[0];
            LastThreeGuesses[0] = Guess;
        } // Used to update the last three guesses for the victory page statistics
        public void UpdateTotalGuesses(int Value)
        {
            TotalGuesses = Value;
        }
        #endregion
        public void ResetGuesses()
        {
            for (int i = 0; i < 3; i++)
            {
                FirstThreeGuesses[i] = null;
                LastThreeGuesses[i] = null;
            } // Resets the first and last three guesses so the user can play again without the previous guesses
        }

        #region Get Values (Getters / Functions)
        public string[] GetFirstThreeGuesses()
        {
            return FirstThreeGuesses;
        }
        public string[] GetLastThreeGuesses()
        {
            return LastThreeGuesses;
        }
        public int GetTotalGuesses()
        {
            return TotalGuesses;
        }
        #endregion
    }
}
