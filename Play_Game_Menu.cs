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
    public partial class Play_Game_Menu : Form
    {
        public Play_Game_Menu()
        {
            InitializeComponent();

            // Used for ensuring keybinds work
            // this.KeyPreview = true;

            // Changes the size of the tab to fullscreen
            WindowState = FormWindowState.Maximized;
            // Anchor is used to determine where each feature is located

            Program.Game.UpdateSecretHintEnable(true);

            #region InitiateChangeBackgroundColour
            // This code is used to carry out the mouse over events (changing the background colour)
            Play_Game_Button.MouseEnter += Play_Game_Button_MouseEnter;
            Play_Game_Button.MouseLeave += Play_Game_Button_MouseLeave;
            Settings_Menu_Button.MouseEnter += Settings_Button_MouseEnter;
            Settings_Menu_Button.MouseLeave += Settings_Button_MouseLeave;
            Back_Button.MouseEnter += Back_Button_MouseEnter;
            Back_Button.MouseLeave += Back_Button_MouseLeave;
            enableSecretHint_Button.MouseEnter += enableSecretHint_Button_MouseEnter;
            enableSecretHint_Button.MouseLeave += enableSecretHint_Button_MouseLeave;
            customise_Button.MouseEnter += Customise_Game_Button_MouseEnter;
            customise_Button.MouseLeave += Customise_Game_Button_MouseLeave;
            #endregion
        }
        #region ChangeBackgroundColour
        // Changes the background colour of buttons when you hover over it with your mouse.
        private void enableSecretHint_Button_MouseEnter(object sender, EventArgs e)
        {
            if (enableSecretHint_Button.BackColor == Color.LimeGreen | enableSecretHint_Button.BackColor == Color.Green)
            {
                enableSecretHint_Button.BackColor = Color.Green;
                enableSecretHint_Button.ForeColor = SystemColors.Control;
            }
            else if (enableSecretHint_Button.BackColor == Color.Red | enableSecretHint_Button.BackColor == Color.DarkRed)
            {
                enableSecretHint_Button.BackColor = Color.DarkRed;
                enableSecretHint_Button.ForeColor = SystemColors.Control;
            }
        }
        private void enableSecretHint_Button_MouseLeave(object sender, EventArgs e)
        {
            if (enableSecretHint_Button.BackColor == Color.LimeGreen | enableSecretHint_Button.BackColor == Color.Green)
            {
                enableSecretHint_Button.BackColor = Color.LimeGreen;
                enableSecretHint_Button.ForeColor = SystemColors.ControlText;
            }
            else if (enableSecretHint_Button.BackColor == Color.Red | enableSecretHint_Button.BackColor == Color.DarkRed)
            {
                enableSecretHint_Button.BackColor = Color.Red;
                enableSecretHint_Button.ForeColor = SystemColors.ControlText;
            }
        }
        private void Customise_Game_Button_MouseEnter(object sender, EventArgs e)
        {
            customise_Button.BackColor = Color.Green;
            customise_Button.ForeColor = SystemColors.Control;
        }
        private void Customise_Game_Button_MouseLeave(object sender, EventArgs e)
        {
            customise_Button.BackColor = Color.LimeGreen;
            customise_Button.ForeColor = SystemColors.ControlText;
        }
        private void Play_Game_Button_MouseEnter(object sender, EventArgs e)
        {
            Play_Game_Button.BackColor = Color.Green;
            Play_Game_Button.ForeColor = SystemColors.Control;
        }
        private void Play_Game_Button_MouseLeave(object sender, EventArgs e)
        {
            Play_Game_Button.BackColor = Color.LimeGreen;
            Play_Game_Button.ForeColor = SystemColors.ControlText;
        }
        private void Settings_Button_MouseEnter(object sender, EventArgs e)
        {
            Settings_Menu_Button.BackColor = Color.DarkBlue;
            Settings_Menu_Button.ForeColor = SystemColors.Control;
        }
        private void Settings_Button_MouseLeave(object sender, EventArgs e)
        {
            Settings_Menu_Button.BackColor = Color.Blue;
            Settings_Menu_Button.ForeColor = SystemColors.ControlText;
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
        private void Play_Game_Button_Click(object sender, EventArgs e)
        {
            // Generates a random word based on the settings chosen
            Program.Game.GenerateRandomWord(Program.Settings.GetTotalLetters());

            // Updates the secretHintValue, number of guesses and the difficulty for later processing
            Program.Settings.UpdateDifficulty(Program.Settings.GetDifficulty());

            // Hides the current page and shows the Game Page
            Game_Page Game_Page = new Game_Page();
            this.Close();
            Game_Page.Show();
        }
        private void Settings_Menu_Button_Click(object sender, EventArgs e)
        {
            // Hides the current page and shows the Settings Menu
            Settings_Menu Settings_Menu = new Settings_Menu();
            this.Close();
            Settings_Menu.Show();
        }
        private void Back_Button_Click(object sender, EventArgs e)
        {
            // Hides the current page and shows the previous page (Home Menu)
            Home_Menu Home_Menu = new Home_Menu();
            this.Close();
            Home_Menu.Show();
        }
        // Testing the keybinds for buttons
        private void Play_Game_Menu_KeyDown(object sender, KeyEventArgs e)
        {

        }
        private void Title_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Phoenix was here - please give a good <3");
        }
        private void Play_Game_Menu_Load(object sender, EventArgs e)
        {

        }
        private void enableSecretHint_Button_Click(object sender, EventArgs e)
        {
            if (enableSecretHint_Button.BackColor == Color.LimeGreen | enableSecretHint_Button.BackColor == Color.Green)
            {
                // If the secret hint is enabled and the button is clicked, the button is changed to red, the text is changed to disabled
                // and the secretHintEnable variable is changed to false
                enableSecretHint_Button.BackColor = Color.Red;
                enableSecretHint_Button.Text = "Secret Hint:\r\nDisabled";
                Program.Game.UpdateSecretHintEnable(false);
            }
            else if (enableSecretHint_Button.BackColor == Color.Red | enableSecretHint_Button.BackColor == Color.DarkRed)
            {
                // If the secret hint is disabled and the button is clicked, the button is changed to green, the text is changed to enabled
                // and the secretHintEnable variable is changed to true
                enableSecretHint_Button.BackColor = Color.LimeGreen;
                enableSecretHint_Button.Text = "Secret Hint:\r\nEnabled";
                Program.Game.UpdateSecretHintEnable(true);
            }
        }
        private void customise_Button_Click(object sender, EventArgs e)
        {
            this.Close(); // Closes the current menu
            Program.CustomisePage.Show(); // Shows the Customise_Page
            // An alert box is shown telling the user that the right format needs to be used for the following settings
            MessageBox.Show("*Warning*" +
                            "\r\n\r\nNumbers:\r\nOnly numbers can be input in the multiplying factor, the total guesses and the timer boxes." +
                            "\r\n\r\nWord format:\r\nOnly words can be input into the random word box." +
                            "\r\n\r\n*This mode is aimed at the couch co-op players*");
        }
    }
}
