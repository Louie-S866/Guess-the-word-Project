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
    public partial class Customise_Page : Form
    {
        List<ComboBox> restrictedHintsSelectors = new List<ComboBox>(8); // Creation of a list which holds every hint selector in it
        public Customise_Page()
        {
            InitializeComponent();

            // Changes the size of the tab to fullscreen
            WindowState = FormWindowState.Maximized;

            // Ensures that only the values in the selector can be chosen
            Difficulty_Selector.DropDownStyle = ComboBoxStyle.DropDownList;
            SeventhHint_Reveal_Selector.DropDownStyle = ComboBoxStyle.DropDownList;
            Hint1_Selector.DropDownStyle = ComboBoxStyle.DropDownList;
            Hint2_Selector.DropDownStyle = ComboBoxStyle.DropDownList;
            Hint3_Selector.DropDownStyle = ComboBoxStyle.DropDownList;
            Hint4_Selector.DropDownStyle = ComboBoxStyle.DropDownList;
            Hint5_Selector.DropDownStyle = ComboBoxStyle.DropDownList;
            Hint6_Selector.DropDownStyle = ComboBoxStyle.DropDownList;
            Hint7_Selector.DropDownStyle = ComboBoxStyle.DropDownList;
            Hint8_Selector.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void Customise_Page_Load(object sender, EventArgs e)
        {

        }
        public void UpdateRestrictedHints()
        {
            // Populates the selectors list with all hint selectors
            restrictedHintsSelectors = new List<ComboBox>
            {
                Hint1_Selector,
                Hint2_Selector,
                Hint3_Selector,
                Hint4_Selector,
                Hint5_Selector,
                Hint6_Selector,
                Hint7_Selector,
                Hint8_Selector
            };

            for (int i = 0; i < 8; i++)
            {
                if (restrictedHintsSelectors[i].Text == "Yes")
                { // If a hint is restricted (Text == "Yes") then the number of that hint is stored in the index of the hint list
                    Program.Game.GetRestrictedHints().Add(i);
                }
                else
                {
                    // Otherwise the value "100" is stored in the index of the hint list, which means that the hint isn't restricted
                    Program.Game.GetRestrictedHints().Add(100);
                }
            }
        }
        private void Back_Button_Click(object sender, EventArgs e)
        {
            // Hides the current page and shows the previous page (Play Game Menu)
            Play_Game_Menu Play_Game_Menu = new Play_Game_Menu();
            this.Hide();
            Play_Game_Menu.Show();
        }

        private void Play_Game_Button_Click(object sender, EventArgs e)
        { // When this button is clicked, it means that the user has customised the game

            // These are the conditions used for the user to continue
            // All input boxes & selectors need to have a value in them which has to be of the correct format to continue
            if (Difficulty_Selector.Text != ""
                && RandomWord_InputBox.Text != ""
                && TotalGuesses_InputBox.Text != ""
                && Int32.Parse(TotalGuesses_InputBox.Text) > 0
                && MultiplyingFactor_InputBox.Text != ""
                && Double.Parse(MultiplyingFactor_InputBox.Text) >= 0 
                && ChooseTimerValue_InputBox.Text != ""
                && Int32.Parse(ChooseTimerValue_InputBox.Text) > 1 
                && SeventhHint_Reveal_Selector.Text != "") // All conditions, all input boxes and selectors need an appropriate input
            {
                // Code run if all conditions are true
                
                // All of the settings updated
                Program.Player.UpdateTotalGuesses(Convert.ToInt32(TotalGuesses_InputBox.Text)); // Updates the total guesses to what the user chose
                Program.Settings.UpdateDifficulty(Difficulty_Selector.Text); // Updates the difficulty to what the user chose
                Program.Game.UpdateRandomWord(RandomWord_InputBox.Text); // Updates the random word to what the user chose
                Program.Game.UpdateTimerValue(Convert.ToInt32(ChooseTimerValue_InputBox.Text)); // Updates how much time the user is given to guess the word
                Program.Game.UpdateMultiplyingFactor(Convert.ToDouble(MultiplyingFactor_InputBox.Text)); // Updates the multiplying factor
                Program.Game.UpdateUserCustomiseGame(true); // Tells the programme that the user has customised the game
                Program.Game.UpdateSeventhHintRevealTimes(Convert.ToByte(SeventhHint_Reveal_Selector.Text)); // Updates how many times the seventh hint can be revealed

                Program.Game.ClearRestrictedHints(); // Clears the list so the updated restricted hints can be used
                UpdateRestrictedHints(); // Updates which hints are restricted or not

                // Generates a random word based on the random word given
                Program.Game.UpdateRandomWord(RandomWord_InputBox.Text);

                // Updates the secretHintValue, number of guesses and the difficulty chosen for later processing
                Program.Settings.UpdateDifficulty(Difficulty_Selector.Text);

                // Hides the current page and shows the Game Page
                Game_Page Game_Page = new Game_Page();
                this.Hide();
                Game_Page.Show();
            }
            else
            {
                // Creates an alert box if the user has selected one or less value for difficulty and word length
                MessageBox.Show("Please select suitable values for all input boxes and selectors");
            }
        }
        private void button1_Click(object sender, EventArgs e) // Guidance button click event handler (it functions as intended but the names are different - reason unknown)
        {
            // This corresponds to the guidance / information button
            // A list of all the guidelines are displayed in an alert box when this button is clicked
            MessageBox.Show("*Guidance*" +
                            "\r\n\r\nMultiplying factor:\r\nIf you want to keep the default multiplying factors, set the multiplying factor input to zero." +
                            "\r\nThe Multiplying Factor should range between 1 and 2 (2 maximum is advised)" + // Multiplying factor
                            "\r\n\r\nTimer:\r\nThe timer is in seconds, meaning that 1 = 1 second.\r\nThe timer number should ideally range from 60 seconds to infinity." + // Timer
                            "\r\n\r\nHints:\r\nIf you want to restrict a hint, set the selector to 'Yes'." +
                            "\r\nIf the Seventh hint is restricted, how ever many times the seventh hint is revealed is irrelevant." + // Hints
                            "\r\n\r\nTotal guesses:\r\nThe total guesses relates to how many the user has to find the word.  Must be greater than 1." + // Total Guesses
                            "\r\n\r\nRandom word:\r\nThe random word should be in a word format without any spaces or special characters (otherwise the game is impossible)."); // Random word
        }
    }
}
