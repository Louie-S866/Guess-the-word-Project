using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guess_the_Word___Y13_Programming_Project
{
    public partial class Victory_Page : Form
    {
        public Victory_Page()
        {
            InitializeComponent();

            // Changes the size of the tab to fullscreen
            WindowState = FormWindowState.Maximized;
            // Anchor is used to determine where each feature is located

            // Used to update the hidden word label showing the hidden word the user guessed
            HiddenWord_Label.Text = HiddenWord_Label.Text + Program.Game.GetRandomWord();

            if (Program.Game.GetWinOrLoss() == true)
            {
                // Changes the text and colour of the title according to if the user has won or not
                // Victory / Won
                Victory_Label.Text = "Victory!";
                Victory_Label.ForeColor = Color.Gold;

                // Increments the winning streak by 1 (temporary highest win streak statistic) 
                Program.Database.UpdateTemporaryHighestWinStreak(Convert.ToInt32(Program.Database.GetTemporaryHighestWinStreak()) + 1);
                // Updates the highest win streak if the user has beat the record
                Program.Database.CheckHigher();
            }
            else
            {
                // Defeat / Lost
                Victory_Label.Text = "Defeat..";
                Victory_Label.ForeColor = Color.DarkRed;

                // Resets the temporary highest win streak because the user lost
                Program.Database.UpdateTemporaryHighestWinStreak(0);
            }

            // Displays the first 3 guesses
            First_Three_Guesses_Label.Text = First_Three_Guesses_Label.Text + "\r\n1. " + Program.Player.GetFirstThreeGuesses()[2] + "\r\n2. " + Program.Player.GetFirstThreeGuesses()[1] + "\r\n3. " + Program.Player.GetFirstThreeGuesses()[0];

            // Displays the last 3 guesses
            Last_Three_Guesses_Label.Text = Last_Three_Guesses_Label.Text + "\r\n1. " + Program.Player.GetLastThreeGuesses()[0] + "\r\n2. " + Program.Player.GetLastThreeGuesses()[1] + "\r\n3. " + Program.Player.GetLastThreeGuesses()[2];


            // Updates the percentage of wins the user has
            // Calculates the regular percentage
            double Percentage = Convert.ToDouble(Program.Database.GetTotalWins()) / Convert.ToDouble(Program.Database.GetTotalGamesPlayed()) * 100;
            // Rounds the percentage to 2 decimal places
            double RoundedPercentage = Math.Round(Percentage, 2);
            Program.Database.UpdatePercentageGamesWon(RoundedPercentage);

            // Calculates and updates the most successful letter word statistic
            Program.Database.UpdateMostSuccessfulLetterWord(Program.Database.GetHighestWord());

            DisplayStatistics();

            DisplayStatistics();

            #region InitiateChangeBackgroundColour
            // This code is used to carry out the mouse over events (changing the background colour)
            Play_Again_Button.MouseEnter += Play_Again_Button_MouseEnter;
            Play_Again_Button.MouseLeave += Play_Again_Button_MouseLeave;
            Main_Menu_Button.MouseEnter += Main_Menu_Button_MouseEnter;
            Main_Menu_Button.MouseLeave += Main_Menu_Button_MouseLeave;
            Quit_Button.MouseEnter += Quit_Button_MouseEnter;
            Quit_Button.MouseLeave += Quit_Button_MouseLeave;
            #endregion
        }
        #region ChangeBackgroundColour
        // Changes the background colour of buttons when you hover over it with your mouse.
        private void Play_Again_Button_MouseEnter(object sender, EventArgs e)
        {
            Play_Again_Button.BackColor = Color.Green;
            Play_Again_Button.ForeColor = SystemColors.Control;
        }
        private void Play_Again_Button_MouseLeave(object sender, EventArgs e)
        {
            Play_Again_Button.BackColor = Color.LimeGreen;
            Play_Again_Button.ForeColor = SystemColors.ControlText;
        }
        private void Main_Menu_Button_MouseEnter(object sender, EventArgs e)
        {
            Main_Menu_Button.BackColor = Color.Gray;
            Main_Menu_Button.ForeColor = SystemColors.Control;
        }
        private void Main_Menu_Button_MouseLeave(object sender, EventArgs e)
        {
            Main_Menu_Button.BackColor = Color.Silver;
            Main_Menu_Button.ForeColor = SystemColors.ControlText;
        }
        private void Quit_Button_MouseEnter(object sender, EventArgs e)
        {
            Quit_Button.BackColor = Color.DarkRed;
            Quit_Button.ForeColor = SystemColors.Control;
        }
        private void Quit_Button_MouseLeave(object sender, EventArgs e)
        {
            Quit_Button.BackColor = Color.Red;
            Quit_Button.ForeColor = SystemColors.ControlText;
        }
        #endregion
        private void DisplayStatistics()
        {
            // This procedure updates the All Stats label with all statistics (minus the stats used to calculate other stats)
            All_Stats_Label.Text = "All Statistics: "; // The label is renamed because it has example code in the design
            for (int i = 0; i < Program.Database.GetFullStatistics().Length; i++)
            {
                switch (i)
                {
                    case 0: // All statistics work properly as intended + represent the correct data
                        All_Stats_Label.Text = All_Stats_Label.Text + "\r\nPlayerID:  " + Program.Database.GetDataArray()[i];
                        break;

                    case 1:
                        All_Stats_Label.Text = All_Stats_Label.Text + "\r\nTotal Wins:  " + Program.Database.GetDataArray()[i];
                        break;

                    case 2:
                        All_Stats_Label.Text = All_Stats_Label.Text + "\r\nTotal Hints:  " + Program.Database.GetDataArray()[i];
                        break;

                    case 3:
                        All_Stats_Label.Text = All_Stats_Label.Text + "\r\nTotal Guesses:  " + Program.Database.GetDataArray()[i];
                        break;

                    case 4:
                        All_Stats_Label.Text = All_Stats_Label.Text + "\r\nPercentage of Games Won:  " + Program.Database.GetDataArray()[i];
                        break;

                    case 5:
                        All_Stats_Label.Text = All_Stats_Label.Text + "\r\nMost Successful Letter Word:  " + Program.Database.GetDataArray()[i];
                        break;

                    case 6:
                        All_Stats_Label.Text = All_Stats_Label.Text + "\r\nLowest Number of Guesses:  " + Program.Database.GetDataArray()[i];
                        break;

                    case 7:
                        All_Stats_Label.Text = All_Stats_Label.Text + "\r\nTotal Challenges Won:  " + Program.Database.GetDataArray()[i];
                        break;

                    case 8:
                        All_Stats_Label.Text = All_Stats_Label.Text + "\r\nWords guessed in First Guess:  " + Program.Database.GetDataArray()[i];
                        break;

                    case 9:
                        All_Stats_Label.Text = All_Stats_Label.Text + "\r\nWords guessed in Second Guess:  " + Program.Database.GetDataArray()[i];
                        break;

                    case 10:
                        All_Stats_Label.Text = All_Stats_Label.Text + "\r\nWords guessed in Third Guess:  " + Program.Database.GetDataArray()[i];
                        break;

                    case 11:
                        All_Stats_Label.Text = All_Stats_Label.Text + "\r\nTotal Games Played:  " + Program.Database.GetDataArray()[i];
                        break;

                    default:
                        All_Stats_Label.Text = All_Stats_Label.Text + "\r\nHighest Win Streak:  " + Program.Database.GetDataArray()[17];
                        break;
                }
            }
        }
        private void Main_Menu_Button_Click(object sender, EventArgs e)
        {
            // Hides the current page and shows the Home Menu
            Home_Menu Home_Menu = new Home_Menu();
            this.Close();
            Home_Menu.Show();
        }
        private void Play_Again_Button_Click(object sender, EventArgs e)
        {
            // Resets the player guesses before rerouting to the Game Page
            Program.Player.ResetGuesses();

            // Hides the current page and shows the Game Page
            Play_Game_Menu Play_Game_Menu = new Play_Game_Menu();
            this.Close();
            Play_Game_Menu.Show();
        }
        private void Quit_Button_Click(object sender, EventArgs e)
        {
            // Resets the temporary highest win streak
            Program.Database.UpdateTemporaryHighestWinStreak(0);

            // Writes all of the data so everything can be saved
            Program.Database.WriteStatistics(Program.Database.GetPlayerID(), Program.Database.GetTotalWins(), Program.Database.GetTotalHints(), Program.Database.GetTotalGuesses(), Program.Database.GetPercentageGamesWon(), Program.Database.GetMostSuccessfulLetterWord(), Program.Database.GetLowestGuessCount(), Program.Database.GetChallengesWon(), Program.Database.GetWordsGuessedInFirstGuess(), Program.Database.GetWordsGuessedInSecondGuess(), Program.Database.GetWordsGuessedInThirdGuess(), Program.Database.GetTotalGamesPlayed(), Program.Database.GetHighestWinStreak());

            Program.Database.WriteDataArray(); // This writes all of the numerical data to the Data.txt

            // Quits the game
            // MessageBox.Show("You are quitting the game.");
            System.Environment.Exit(0);
        }
        private void Victory_Label_Click(object sender, EventArgs e)
        {
            if (Victory_Label.Text == "Victory!")
            {
                MessageBox.Show("You clicked this label, I don't know how to get rid of this code");
            }
            else
            {
                MessageBox.Show("Haha you lost");
            }
        }
    }
}
