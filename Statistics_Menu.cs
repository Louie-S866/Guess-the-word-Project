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
    public partial class Statistics_Menu : Form
    {
        public Statistics_Menu()
        {
            InitializeComponent();

            // Changes the size of the tab to fullscreen
            WindowState = FormWindowState.Maximized;
            // Anchor is used to determine where each feature is located

            DisplayStatistics();

            // Displays the first 3 guesses
            First_Three_Guesses_Label.Text = "First three guesses: " + "\r\n1. " + Program.Player.GetFirstThreeGuesses()[2] + "\r\n2. " + Program.Player.GetFirstThreeGuesses()[1] + "\r\n3. " + Program.Player.GetFirstThreeGuesses()[0];

            // Displays the last 3 guesses
            Last_Three_Guesses_Label.Text = "Last three guesses: " + "\r\n1. " + Program.Player.GetLastThreeGuesses()[0] + "\r\n2. " + Program.Player.GetLastThreeGuesses()[1] + "\r\n3. " + Program.Player.GetLastThreeGuesses()[2];

            #region InitiateChangeBackgroundColour
            // This code is used to carry out the mouse over events (changing the background colour)
            Back_Button.MouseEnter += Back_Button_MouseEnter;
            Back_Button.MouseLeave += Back_Button_MouseLeave;
            Reset_Statistics_Button.MouseEnter += Reset_Statistics_Button_MouseEnter;
            Reset_Statistics_Button.MouseLeave += Reset_Statistics_Button_MouseLeave;
            #endregion
        }
        #region ChangeBackgroundColour
        // Changes the background colour of buttons when you hover over it with your mouse.
        private void Back_Button_MouseEnter(object sender, EventArgs e)
        {
            Back_Button.BackColor = Color.Gray;
            Back_Button.ForeColor = SystemColors.Control;
        }
        private void Back_Button_MouseLeave(object sender, EventArgs e)
        {
            Back_Button.BackColor = Color.Silver;
            Back_Button.ForeColor = SystemColors.ControlText;
        }
        private void Reset_Statistics_Button_MouseEnter(object sender, EventArgs e)
        {
            Reset_Statistics_Button.BackColor = Color.DarkRed;
            Reset_Statistics_Button.ForeColor = SystemColors.Control;
        }
        private void Reset_Statistics_Button_MouseLeave(object sender, EventArgs e)
        {
            Reset_Statistics_Button.BackColor = Color.Red;
            Reset_Statistics_Button.ForeColor = SystemColors.ControlText;
        }
        #endregion
        private void Back_Button_Click(object sender, EventArgs e)
        {
            // Hides the current page and shows the previous page (Home Menu)
            Home_Menu Home_Menu = new Home_Menu();
            this.Close();
            Home_Menu.Show();
        }
        private void Statistics_Menu_Label_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Easter Egg 4: Jenna was here");
        }
        private void DisplayStatistics()
        {
            // A for loop is used to repeat the switch statement as many times as there are statistics
            for (int i = 0; i < Program.Database.GetFullStatistics().Length; i++)
            {
                // A switch statement is called as many times as the for loop runs
                // It updates the statistics label with what data is currently in the label, as well as the new statistic on the line below
                switch (i)
                {
                    case 0:
                        All_Stats_Label.Text = All_Stats_Label.Text + "\r\nPlayerID:  " + Program.Database.GetDataArray()[i];
                        // The code within the switch statements update the statistics label with whatever is already in the label
                        // and the new statistic on the line below.
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
        private void Reset_Statistics_Button_Click(object sender, EventArgs e)
        {
            // Create an error message with an input box and stores it in the variable "data"
            string data = Microsoft.VisualBasic.Interaction.InputBox("Are you sure you want to Reset all Statistics?\r\n1) Yes\r\n2) No", "Reset Statistics", "2");

            // If the input is = 1, then all statistics are reset. 
            if (data == "1")
            {
                // Due to there being only one database at the moment, the current PlayerID is fed in, this will change as more records get added (more PlayerIDs)
                Program.Database.ResetStatistics(Convert.ToByte(Program.Database.GetPlayerID()));
                All_Stats_Label.Text = "All Statistics: ";
                DisplayStatistics();
            }
        }
    }
}
