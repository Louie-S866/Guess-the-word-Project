using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Net.Http;
using Postgrest.Attributes;
using Postgrest.Models;
using System.Windows.Forms;
using Supabase;
using Supabase.Interfaces;
using System.Threading.Tasks;

namespace Guess_the_Word___Y13_Programming_Project
{
    public class Database : Game
    {
        // Creation of arrays which hold the data held within each text file (stored in the same place)
        string[] readlines = System.IO.File.ReadAllLines(@"C:\School\Programming Project\Application - Guess the word\Guess the Word - Y13 Programming Project\DatabaseTextFile\Database.txt");
        string[] dataArray = System.IO.File.ReadAllLines(@"C:\School\Programming Project\Application - Guess the word\Guess the Word - Y13 Programming Project\DatabaseTextFile\Data.txt");

        #region MostSuccessfulLetterWord

        #region UpdateValues
        public void UpdateThree(int value)
        {
            // Updates the data in dataArray corresponding to how many 3 letter words the user has guessed to what the parameter is
            dataArray[12] = value.ToString();
        }
        public void UpdateFour(int value)
        {
            // Updates the data in dataArray corresponding to how many 4 letter words the user has guessed to what the parameter is
            dataArray[13] = value.ToString();
        }
        public void UpdateFive(int value)
        {
            // Updates the data in dataArray corresponding to how many 5 letter words the user has guessed to what the parameter is
            dataArray[14] = value.ToString();
        }

        // There is a space for six letters at index 15, however I have not found any file that contains all 6 letter words at the moment
        // However, I have created space in the code for when a 6 letter word file is found and the code needs to be updated

        public void UpdateSeven(int value)
        {
            // Updates the data in dataArray corresponding to how many 7 letter words the user has guessed to what the parameter is
            dataArray[16] = value.ToString();
        }
        #endregion

        #region GetValues
        public string GetThree()
        {
            // Returns the data in dataArray corresponding to how many 3 letter words the user has guessed
            return dataArray[12];
        }
        public string GetFour()
        {
            // Returns the data in dataArray corresponding to how many 4 letter words the user has guessed
            return dataArray[13];
        }
        public string GetFive()
        {
            // Returns the data in dataArray corresponding to how many 5 letter words the user has guessed
            return dataArray[14];
        }

        // There is a space for six letters at index 15, however I have not found any file that contains all 6 letter words at the moment
        // However, I have created space in the code for when a 6 letter word file is found and the code needs to be updated

        public string GetSeven() // This is set to 17 incase I find a file with all 6 letter words in, which will take up the 16th space in the text file
        {
            // Returns the data in dataArray corresponding to how many 7 letter words the user has guessed
            return dataArray[16];
        }
        #endregion

        public string GetHighestWord()
        {
            // Creation of local variables (arrays) with 4 indexes (3, 4, 5, 7 letters)
            int[] tempArray = new int[4];
            string[] strings = new string[4]; // Both arrays' size will be increased if more word files are used
            for (int i = 0; i < 4; i++)
            {
                switch (i)
                { // Adds values to each empty array
                    case 0:
                        tempArray[0] = Convert.ToInt32(GetThree());
                        strings[0] = "3";
                        break;

                    case 1:
                        tempArray[1] = Convert.ToInt32(GetFour());
                        strings[1] = "4";
                        break;

                    case 2:
                        tempArray[2] = Convert.ToInt32(GetFive());
                        strings[2] = "5";
                        break;

                    default: // case 4
                        tempArray[3] = Convert.ToInt32(GetSeven());
                        strings[3] = "7";
                        break;
                }
            }

            for (int i = 0; i < 4; i++)
            {
                if (tempArray[i] == tempArray.Max())
                { // Checks if the current value in tempArray is the same as the maximum value in tempArray
                    // If the condition is true, then it returns the corresponding number of letters (as a string)
                    return strings[i];
                }
            }

            // Only used because all code paths need to return a value - the programme should return a value in the for loop
            // This return command is a backup if the rest of the code fails
            return strings[2]; // Guess if the user has won more games with 5 letter words (as standard)
        }

        #endregion

        #region HighestWinStreak
        public void UpdateTemporaryHighestWinStreak(int value)
        {
            dataArray[18] = value.ToString(); // Updates the temporary highest win streak value
        }

        public string GetTemporaryHighestWinStreak()
        {
            return dataArray[18]; // returns the temporary highest win streak value
        }

        public void CheckHigher()
        {
            if (Convert.ToInt32(GetTemporaryHighestWinStreak()) > Convert.ToInt32(GetHighestWinStreak()))
            {
                // Checks if the temporary highest win streak value is greater than the stored highest win streak value
                // If so then the highest win streak value is updated with the temporary highest win streak value
                UpdateHighestWinStreak(Convert.ToInt32(GetTemporaryHighestWinStreak()));
            }
        }

        #endregion

        public string[] GetFullStatistics()
        {
            return readlines; // Returns the array which holds the statistics and their corresponding data
        }
        public string[] GetDataArray()
        { 
            return dataArray; // Returns the array which holds only the data relating to the statistics
        }

        #region UpdateStatistics
        public void UpdatePlayerID(int value)
        {
            dataArray[0] = value.ToString(); // Updates the PlayerID to what is passed as a parameter
        }
        public void UpdateTotalWins(int value)
        {
            dataArray[1] = value.ToString(); // Updates the total wins to what is passed as a parameter
        }
        public void UpdateTotalHints(int value)
        {
            dataArray[2] = value.ToString(); // Updates the total hints used to what is passed as a parameter
        }
        public void UpdateTotalGuesses(int value)
        {
            dataArray[3] = value.ToString(); // Updates the total guesses entered to what is passed as a parameter
        }
        public void UpdatePercentageGamesWon(double value)
        {
            dataArray[4] = value.ToString(); // Updates the percentage of games won to what is passed as a parameter
        }
        public void UpdateMostSuccessfulLetterWord(string value)
        {
            dataArray[5] = value; // Updates the most successful letter word to what is passed as a parameter
        }
        public void UpdateLowestGuessCount(int value)
        {
            dataArray[6] = value.ToString(); // Updates the lowest number of guesses to guess the word to what is passed as a parameter
        }
        public void UpdateChallengesWon(int value)
        {
            dataArray[7] = value.ToString(); // Updates the total challenges won to what is passed as a parameter
        }
        public void UpdateWordsGuessedInFirstGuess(int value)
        {
            dataArray[8] = value.ToString(); // Updates the words guessed in the first guess to what is passed as a parameter
        }
        public void UpdateWordsGuessedInSecondGuess(int value)
        {
            dataArray[9] = value.ToString(); // Updates the words guessed in the second guess to what is passed as a parameter
        }
        public void UpdateWordsGuessedInThirdGuess(int value)
        {
            dataArray[10] = value.ToString(); // Updates the words guessed in the third guess to what is passed as a parameter
        }
        public void UpdateTotalGamesPlayed(int value)
        {
            dataArray[11] = value.ToString(); // Updates the total number of games played to what is passed as a parameter
        }
        public void UpdateHighestWinStreak(int value)
        {
            dataArray[17] = value.ToString(); // updates the highest win streak made by the user to what is passed as a parameter
        }
        #endregion

        #region GetSpecificStatistics
        public string GetPlayerID()
        {
            return dataArray[0]; // Returns the player ID
        }
        public string GetTotalWins()
        {
            return dataArray[1]; // Returns the total wins
        }
        public string GetTotalHints()
        {
            return dataArray[2]; // Returns the total hints used
        }
        public string GetTotalGuesses()
        {
            return dataArray[3]; // Returns how many guesses the user has entered
        }
        public string GetPercentageGamesWon()
        {
            return dataArray[4]; // Returns the percentage of games the user has won
        }
        public string GetMostSuccessfulLetterWord()
        {
            return dataArray[5]; // Returns the letter word at which the user has guessed the most
        }
        public string GetLowestGuessCount()
        {
            return dataArray[6]; // Returns the lowest number of guesses used to guess the word correctly
        }
        public string GetChallengesWon()
        {
            return dataArray[7]; // Returns how many "impossible" difficulty games the user has won
        }
        public string GetWordsGuessedInFirstGuess()
        {
            return dataArray[8]; // Returns how many words the user has guessed in the first guess
        }
        public string GetWordsGuessedInSecondGuess()
        {
            return dataArray[9]; // Returns how many words the user has guessed in the second guess
        }
        public string GetWordsGuessedInThirdGuess()
        {
            return dataArray[10]; // Returns how many words the user has guessed in the third guess
        }
        public string GetTotalGamesPlayed()
        {
            return dataArray[11]; // Returns how many games the user has played in total
        }
        public string GetHighestWinStreak()
        {
            return dataArray[17]; // Returns the highest win streak made by the user
        }
        #endregion
        public void ResetStatistics(int PlayerID)
        {
            // This procedure updates all of the statistics to 0, with the PlayerID being updated to whatever is passed as an argument
            // All statistics (excluding the PlayerID) should be set to 0 for the statistics to be "reset"
            UpdatePlayerID(PlayerID);
            UpdateTotalWins(0);
            UpdateTotalHints(0);
            UpdateTotalGuesses(0);
            UpdatePercentageGamesWon(0);
            UpdateMostSuccessfulLetterWord("0");
            UpdateLowestGuessCount(0);
            UpdateChallengesWon(0);
            UpdateWordsGuessedInFirstGuess(0);
            UpdateWordsGuessedInSecondGuess(0);
            UpdateWordsGuessedInThirdGuess(0);
            UpdateTotalGamesPlayed(0);
            UpdateThree(0);
            UpdateFour(0);
            UpdateFive(0);
            UpdateSeven(0);
            UpdateHighestWinStreak(0);
        }
        public void WriteStatistics(string ID, string totalWins, string totalHints, string totalGuesses, string PercentageGamesWon, string MostSuccessfulLetterWord, string LowestNumberOfGuesses, string TotalChallengesWon, string WordsInFirst, string WordsInSecond, string WordsInThird, string GamesPlayed, string HighestWinStreak)
        {
            // Creates an array which holds the data for each specific statistic and their data in their correct index in the file.  The parameters are the updates values for each statistics.
            string[] lines = { "PlayerID:  " + ID, "Total Wins:  " + totalWins, "Total Hints:  " + totalHints, "Total Guesses:  " + totalGuesses, "Percentage of games won:  " + PercentageGamesWon, "Most successful letter word:  " + MostSuccessfulLetterWord, "Lowest number of guesses:  " + LowestNumberOfGuesses, "Total challenges won:  " + TotalChallengesWon, "Words guessed in first guess:  " + WordsInFirst, "Words guessed in second guess:  " + WordsInSecond, "Words guessed in third guess:  " + WordsInThird, "Total Games Played:  " + GamesPlayed, "Highest Win Streak:  " + HighestWinStreak };

            // Writes the new updated data to the Database.txt file.  All lines are replaced with the updated lines (holding the correct statistics and their values) which are held in the array "lines" above
            File.WriteAllLines(@"C:\School\Programming Project\Application - Guess the word\Guess the Word - Y13 Programming Project\DatabaseTextFile\Database.txt", lines);
        }
        public void WriteDataArray()
        {
            // Writes the new updated data to the Data.txt file.  All lines are replaced with the updated values 
            File.WriteAllLines(@"C:\School\Programming Project\Application - Guess the word\Guess the Word - Y13 Programming Project\DatabaseTextFile\Data.txt", dataArray);
        }
        public void CreateNewPlayerID(int NewID)
        {
            UpdatePlayerID(NewID);
            UpdateTotalWins(0);
            UpdateTotalHints(0);
            UpdateTotalGuesses(0);
            UpdatePercentageGamesWon(0);
            UpdateMostSuccessfulLetterWord("0");
            UpdateLowestGuessCount(0);
            UpdateChallengesWon(0);
            UpdateWordsGuessedInFirstGuess(0);
            UpdateWordsGuessedInSecondGuess(0);
            UpdateWordsGuessedInThirdGuess(0);
            UpdateTotalGamesPlayed(0);
            UpdateThree(0);
            UpdateFour(0);
            UpdateFive(0);
            UpdateSeven(0);
            UpdateHighestWinStreak(0);
        }
    }
}
