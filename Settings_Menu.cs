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
    public partial class Settings_Menu : Form
    {
        public Settings_Menu()
        {
            InitializeComponent();

            // Changes the size of the tab to fullscreen
            WindowState = FormWindowState.Maximized;
            // Anchor is used to determine where each feature is located

            // Makes it so the user cannot enter their own inputs in each selector
            Total_Letters_Selector.DropDownStyle = ComboBoxStyle.DropDownList;
            Difficulty_Selector.DropDownStyle = ComboBoxStyle.DropDownList;

            #region InitiateChangeBackgroundColour
            // This code is used to carry out the mouse over events (changing the background colour)
            Continue_Button.MouseEnter += Continue_Button_MouseEnter;
            Continue_Button.MouseLeave += Continue_Button_MouseLeave;
            Back_Button.MouseEnter += Back_Button_MouseEnter;
            Back_Button.MouseLeave += Back_Button_MouseLeave;
            #endregion
        }
        #region ChangeBackgroundColour
        // Changes the background colour of buttons when you hover over it with your mouse.
        private void Continue_Button_MouseEnter(object sender, EventArgs e)
        {
            Continue_Button.BackColor = Color.Green;
            Continue_Button.ForeColor = SystemColors.Control;
        }
        private void Continue_Button_MouseLeave(object sender, EventArgs e)
        {
            Continue_Button.BackColor = Color.LimeGreen;
            Continue_Button.ForeColor = SystemColors.ControlText;
        }
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
        #endregion
        private void Back_Button_Click(object sender, EventArgs e)
        {
            if (Difficulty_Selector.Text != "" && Total_Letters_Selector.Text != "")
            {
                // Updates any changes made to the difficulty and total letters settings
                Program.Settings.UpdateTotalLetters(Total_Letters_Selector.Text);
                Program.Settings.UpdateDifficulty(Difficulty_Selector.Text);

                // Hides the current page and shows the previous page (Play Game Menu)
                Play_Game_Menu Play_Game_Menu = new Play_Game_Menu();
                this.Close();
                Play_Game_Menu.Show();
            }
            else
            {
                // Creates an alert box if the user has selected one or less value for difficulty and word length
                MessageBox.Show("Please select suitable values for both Total Letters and Difficulty to go back.");
            }
        }
        private void Continue_Button_Click(object sender, EventArgs e)
        {
            if (Difficulty_Selector.Text != "" && Total_Letters_Selector.Text != "")
            {
                // Updates the difficulty to whatever difficulty is chosen
                // Updates the word length to whatever word length is chosen
                Program.Settings.UpdateDifficulty(Difficulty_Selector.Text);
                Program.Settings.UpdateTotalLetters(Total_Letters_Selector.Text);

                // Creates a random word
                Program.Game.GenerateRandomWord(Program.Settings.GetTotalLetters());

                // Hides the current page and shows the game page
                Game_Page Game_Page = new Game_Page();
                this.Close();
                Game_Page.Show();
            }
            else
            {
                // Creates an alert box if the user hasn't selected any values for difficulty and word length
                MessageBox.Show("Please select suitable values for both Total Letters and Difficulty to continue.");
            }
        }
        private void Difficulty_Label_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Easter egg 1.  James is one of my secret game testers");
        }
    }
}
