using Supabase.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Guess_the_Word___Y13_Programming_Project.Program;
using Supabase;
using System.Threading.Tasks;
using Postgrest.Attributes;
using Postgrest.Models;
using Microsoft.VisualBasic;

namespace Guess_the_Word___Y13_Programming_Project
{
    public partial class Home_Menu : Form
    {
        public Home_Menu()
        {
            InitializeComponent();

            // Changes the size of the tab to fullscreen
            WindowState = FormWindowState.Maximized;
            // Anchor is used to determine where each feature is located

            #region InitiateChangeBackgroundColour
            // This code is used to carry out the mouse over events (changing the background colour)
            Play_Button.MouseEnter += Play_Button_MouseEnter;
            Play_Button.MouseLeave += Play_Button_MouseLeave;
            Statistics_Button.MouseEnter += Statistics_Button_MouseEnter;
            Statistics_Button.MouseLeave += Statistics_Button_MouseLeave;
            QuitGame.MouseEnter += Quit_Button_MouseEnter;
            QuitGame.MouseLeave += Quit_Button_MouseLeave;
            #endregion
        }
        #region ChangeBackgroundColour
        // Changes the background colour of buttons when you hover over it with your mouse.
        private void Play_Button_MouseEnter(object sender, EventArgs e)
        {
            Play_Button.BackColor = Color.Green;
            Play_Button.ForeColor = SystemColors.Control;
        }
        private void Play_Button_MouseLeave(object sender, EventArgs e)
        {
            Play_Button.BackColor = Color.LimeGreen;
            Play_Button.ForeColor = SystemColors.ControlText;
        }
        private void Statistics_Button_MouseEnter(object sender, EventArgs e)
        {
            Statistics_Button.BackColor = Color.DarkBlue;
            Statistics_Button.ForeColor = SystemColors.Control;
        }
        private void Statistics_Button_MouseLeave(object sender, EventArgs e)
        {
            Statistics_Button.BackColor = Color.Blue;
            Statistics_Button.ForeColor = SystemColors.ControlText;
        }
        private void Quit_Button_MouseEnter(object sender, EventArgs e)
        {
            QuitGame.BackColor = Color.DarkRed;
            QuitGame.ForeColor = SystemColors.Control;
        }
        private void Quit_Button_MouseLeave(object sender, EventArgs e)
        {
            QuitGame.BackColor = Color.Red;
            QuitGame.ForeColor = SystemColors.ControlText;
        }
        #endregion
        #region DoNotUnderstand
        // Do not touch - Don't know what it is
        // ------------------------------------------------------------------------------
        private void Play_Button_MouseLeave1(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        // ------------------------------------------------------------------------------
        #endregion
        private void Play_Button_Click(object sender, EventArgs e)
        {
            // Hides the current page and shows the Play Game Menu
            Play_Game_Menu Play_Game_Menu = new Play_Game_Menu();
            this.Hide();
            Play_Game_Menu.Show();
        }
        private void Statistics_Button_Click(object sender, EventArgs e)
        {
            // Hides the current page and shows the Statistics Menu
            Statistics_Menu Statistics_Menu = new Statistics_Menu();
            this.Hide();
            Statistics_Menu.Show();
        }
        private void QuitGame_Click(object sender, EventArgs e)
        {
            // Resets the temporary highest win streak
            Program.Database.UpdateTemporaryHighestWinStreak(0);

            // Writes all of the data so everything can be saved
            Program.Database.WriteStatistics(Program.Database.GetPlayerID(), Program.Database.GetTotalWins(), Program.Database.GetTotalHints(), Program.Database.GetTotalGuesses(), Program.Database.GetPercentageGamesWon(), Program.Database.GetMostSuccessfulLetterWord(), Program.Database.GetLowestGuessCount(), Program.Database.GetChallengesWon(), Program.Database.GetWordsGuessedInFirstGuess(), Program.Database.GetWordsGuessedInSecondGuess(), Program.Database.GetWordsGuessedInThirdGuess(), Program.Database.GetTotalGamesPlayed(), Program.Database.GetHighestWinStreak());
            Program.Database.WriteDataArray(); // This writes all of the numerical data to the Data.txt

            // Exits the programme
            System.Environment.Exit(0);
        }
        private void temporaryButton_Click(object sender, EventArgs e)
        {

        }
    }
}
