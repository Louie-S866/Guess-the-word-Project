using Pulumi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using static Guess_the_Word___Y13_Programming_Project.Program;

namespace Guess_the_Word___Y13_Programming_Project
{
    public partial class Game_Page : Form
    {
        // Creates necessary variables
        int Counter = 0;
        double secretHintValue = Program.Settings.GetSecretHintValue();

        // This is the global list used to note down what hints have been revealed or not
        List<int> excludedNumbers = new List<int>() { 0, 0, 0, 0, 0, 0, 0, 0 };

        // Corresponds to the RevealLetters procedure
        // They are set to true when the corresponding letter
        // has been revealed
        bool first = false;
        bool second = false;
        bool third = false;
        bool fourth = false;
        bool fifth = false;
        bool sixth = false;
        bool seventh = false;

        int TotalTimeGiven; // Keeps track of the total time given to the user

        public Game_Page()
        {
            // Changes the size of the tab to fullscreen
            WindowState = FormWindowState.Maximized;
            // Anchor is used to determine where each feature is located

            InitializeComponent();

            #region Keybinds
            // Keybind code
            this.KeyPreview = true;
            this.KeyDown += Game_Page_KeyDown;
            #endregion

            // Updates the difficulty display label to show the current difficulty
            Difficulty_Display_Label.Text = "Difficulty: " + Program.Settings.GetDifficulty();
            // Updates the hidden word label with the random word - will be revealed when the user wins / loses
            Hidden_Word_Label.Text = Program.Game.GetRandomWord();

            // Makes it so only the user cannot input any values into the selector
            Hint_Number_Selector.DropDownStyle = ComboBoxStyle.DropDownList;

            // Makes the default value = "Random" so it isn't blank on startup
            Hint_Number_Selector.SelectedItem = "Random";

            if (Program.Game.GetUserCustomiseGame()) // This is run if the user has customised the game
            {
                resetRandomWord_Button.Visible = false; // Makes it so the user cannot reset the game page, since it would be pointless
                Timer_Count_Label.Text = Program.Game.GetTimerValue().ToString(); // Sets the time limit to whatever the user chose
                TotalTimeGiven = Program.Game.GetTimerValue(); // Total time given to the user

                for (int i = 0; i < 8; i++) // Restricts the appropriate hints
                {
                    switch (Program.Game.GetRestrictedHints()[i]) // Loops through every item in the list and if the value is the hint number, then that hint is restricted
                    {
                        case 0:
                            Hint1_Label.Text = "-----Restricted-----"; // Restricts first hint
                            Hint1_Label.ForeColor = Color.Red;
                            break;

                        case 1:
                            Hint2_Label.Text = "-----Restricted-----"; // Restricts second hint
                            Hint2_Label.ForeColor = Color.Red;
                            break;

                        case 2:
                            Hint3_Label.Text = "-----Restricted-----"; // Restricts third hint
                            Hint3_Label.ForeColor = Color.Red;
                            break;

                        case 3:
                            Hint4_Label.Text = "-----Restricted-----"; // Restricts fourth hint
                            Hint4_Label.ForeColor = Color.Red;
                            break;

                        case 4:
                            Hint5_Label.Text = "-----Restricted-----"; // Restricts fifth hint
                            Hint5_Label.ForeColor = Color.Red;
                            break;

                        case 5:
                            Hint6_Label.Text = "-----Restricted-----"; // Restricts sixth hint
                            Hint6_Label.ForeColor = Color.Red;
                            break;

                        case 6:
                            Hint7_Label.Text = "-----Restricted-----"; // Restricts seventh hint
                            Hint7_Label.ForeColor = Color.Red;
                            break;

                        case 7:
                            Hint8_Label.Text = "-----Restricted-----"; // Restricts eighth hint
                            Hint8_Label.ForeColor = Color.Red;
                            break;
                    }
                }
            }
            else
            {
                switch (Program.Settings.GetDifficulty())
                { // Restricts certain hints and determines the time given depending on the difficulty chosen
                    case "Easy":
                        Timer_Count_Label.Text = "720"; // sets a 12 minute time limit
                        TotalTimeGiven = 720; // Total time given to the user

                        Program.Player.UpdateTotalGuesses(500); // Updates the total guesses
                        break; // No restrictions for the "Easy" difficulty

                    case "Medium": // Hint 2 & 5 is retricted
                        Hint2_Label.Text = "-----Restricted-----";
                        Hint2_Label.ForeColor = Color.Red;

                        Hint5_Label.Text = "-----Restricted-----";
                        Hint5_Label.ForeColor = Color.Red;

                        Timer_Count_Label.Text = "600"; // sets a 10 minute time limit
                        TotalTimeGiven = 600; // Total time given to the user

                        Program.Player.UpdateTotalGuesses(150); // Updates the total guesses
                        break;

                    case "Hard": // Hint 1, 2 & 4 are restricted
                        Hint1_Label.Text = "-----Restricted-----";
                        Hint1_Label.ForeColor = Color.Red;

                        Hint2_Label.Text = "-----Restricted-----";
                        Hint2_Label.ForeColor = Color.Red;

                        Hint4_Label.Text = "-----Restricted-----";
                        Hint4_Label.ForeColor = Color.Red;

                        Timer_Count_Label.Text = "480"; // sets a 8 minute time limit
                        TotalTimeGiven = 480; // Total time given to the user

                        Program.Player.UpdateTotalGuesses(120); // Updates the total guesses
                        break;

                    case "Extremely Hard": // Hint 1, 2, 3 & 4 are restricted
                        Hint1_Label.Text = "-----Restricted-----";
                        Hint1_Label.ForeColor = Color.Red;

                        Hint2_Label.Text = "-----Restricted-----";
                        Hint2_Label.ForeColor = Color.Red;

                        Hint3_Label.Text = "-----Restricted-----";
                        Hint3_Label.ForeColor = Color.Red;

                        Hint4_Label.Text = "-----Restricted-----";
                        Hint4_Label.ForeColor = Color.Red;

                        Timer_Count_Label.Text = "420"; // sets a 7 minute time limit
                        TotalTimeGiven = 420; // Total time given to the user

                        Program.Player.UpdateTotalGuesses(100); // Updates the total guesses
                        break;

                    default: // Hint 1, 2, 3 and 6 are retricted (impossible difficulty)
                        Hint1_Label.Text = "-----Restricted-----";
                        Hint1_Label.ForeColor = Color.Red;

                        Hint2_Label.Text = "-----Restricted-----";
                        Hint2_Label.ForeColor = Color.Red;

                        Hint3_Label.Text = "-----Restricted-----";
                        Hint3_Label.ForeColor = Color.Red;

                        Hint6_Label.Text = "-----Restricted-----";
                        Hint6_Label.ForeColor = Color.Red;

                        Timer_Count_Label.Text = "300"; // sets a 5 minute time limit
                        TotalTimeGiven = 300; // Total time given to the user

                        Program.Player.UpdateTotalGuesses(75); // Updates the total guesses
                        break;
                }
            }

            RefreshWordLimit(); // Updates the word limit so it displays the correct number of guesses available
            // Used to update the word limit (guess limit) accordingly

            // Only used for developer testing
            // Displays the Random word
            RandomWord_Label.Text = Program.Game.GetRandomWord();
            RandomWord_Label.Visible = false; // Cannot be seen by the user if false

            #region statstics

            // Updates the total games played
            Program.Database.UpdateTotalGamesPlayed(Convert.ToInt32(Program.Database.GetTotalGamesPlayed()) + 1);

            #region UpdateStatsDisplay
            // This for loop with a nested switch statement is used to display the first 4 statistics, done by updating the statistics display label
            for (int i = 0; i < 4; i++)
            {
                switch (i)
                {
                    case 0:
                        Statistics_Display_Label.Text = Statistics_Display_Label.Text + "\r\nPlayerID:  " + Program.Database.GetDataArray()[i];
                        break;

                    case 1:
                        Statistics_Display_Label.Text = Statistics_Display_Label.Text + "\r\nTotal Wins:  " + Program.Database.GetDataArray()[i];
                        break;

                    case 2:
                        Statistics_Display_Label.Text = Statistics_Display_Label.Text + "\r\nTotal Hints:  " + Program.Database.GetDataArray()[i];
                        break;

                    default:
                        Statistics_Display_Label.Text = Statistics_Display_Label.Text + "\r\nTotal Guesses:  " + Program.Database.GetDataArray()[i];
                        break;
                }
            }
            #endregion // This region is used to update the statistics display with the first 4 values

            #endregion

            #region InitateChangeBackgroundColour
            // This code is used to carry out the mouse over events (changing the background colour)
            Main_Menu_Button.MouseEnter += Main_Menu_Button_MouseEnter;
            Main_Menu_Button.MouseLeave += Main_Menu_Button_MouseLeave;
            Reveal_Hint_Button.MouseEnter += Reveal_Hint_Button_MouseEnter;
            Reveal_Hint_Button.MouseLeave += Reveal_Hint_Button_MouseLeave;
            Quit_Button.MouseEnter += Quit_Button_MouseEnter;
            Quit_Button.MouseLeave += Quit_Button_MouseLeave;
            Enter_Button.MouseEnter += Enter_Button_MouseEnter;
            Enter_Button.MouseLeave += Enter_Button_MouseLeave;
            Continue_Button.MouseEnter += Continue_Button_MouseEnter;
            Continue_Button.MouseLeave += Continue_Button_MouseLeave;
            resetRandomWord_Button.MouseEnter += resetRandomWord_Button_MouseEnter;
            resetRandomWord_Button.MouseLeave += resetRandomWord_Button_MouseLeave;
            #endregion

            #region timer
            time_limit_Timer = new System.Windows.Forms.Timer(); // Instantiates it as a timer
            time_limit_Timer.Tick += new EventHandler(time_limit_Timer_Tick); // Every time there is a tick, the EventHandler is called
            time_limit_Timer.Interval = 1000; // Tick interval is set to every 1 second
            time_limit_Timer.Start(); // The timer starts on startup
            #endregion
        }
        private void time_limit_Timer_Tick(object sender, EventArgs e)
        {
            // This decrements the label (showing the remaining time by 1
            Timer_Count_Label.Text = (int.Parse(Timer_Count_Label.Text) - 1).ToString();

            if (int.Parse(Timer_Count_Label.Text) < 1)
            {
                // When the timer reaches 0, the user loses and an alert box tells the user that 'Time is up'
                time_limit_Timer.Stop(); // Timer stops decrementing by 1

                // This is what happens when the user loses
                MessageBox.Show("Time is up!");
                Program.Game.UpdateWinOrLoss(false);
                Hidden_Word_Label.Visible = true;
                Main_Menu_Button.Visible = false;
                Quit_Button.Visible = false;
                Continue_Button.Visible = true;
            }
            else if (int.Parse(Timer_Count_Label.Text) == 60)
            {
                MessageBox.Show("1 minute left!"); // A reminder telling the user that there is 1 minute remaining
            }
        }
        #region ChangeBackgroundColour
        // Changes the background colour of buttons when you hover over it with your mouse
        private void resetRandomWord_Button_MouseEnter(object sender, EventArgs e)
        {
            resetRandomWord_Button.BackColor = Color.DarkRed;
            resetRandomWord_Button.ForeColor = SystemColors.Control;
        }
        private void resetRandomWord_Button_MouseLeave(object sender, EventArgs e)
        {
            resetRandomWord_Button.BackColor = Color.Red;
            resetRandomWord_Button.ForeColor = SystemColors.ControlText;
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
        private void Reveal_Hint_Button_MouseEnter(object sender, EventArgs e)
        {
            Reveal_Hint_Button.BackColor = Color.Gray;
            Reveal_Hint_Button.ForeColor = SystemColors.Control;
        }
        private void Reveal_Hint_Button_MouseLeave(object sender, EventArgs e)
        {
            Reveal_Hint_Button.BackColor = Color.Silver;
            Reveal_Hint_Button.ForeColor = SystemColors.ControlText;
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
        private void Enter_Button_MouseEnter(object sender, EventArgs e)
        {
            Enter_Button.BackColor = Color.Gray;
            Enter_Button.ForeColor = SystemColors.Control;
        }
        private void Enter_Button_MouseLeave(object sender, EventArgs e)
        {
            Enter_Button.BackColor = Color.Silver;
            Enter_Button.ForeColor = SystemColors.ControlText;
        }
        #endregion
        private void Game_Page_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // If the enter key is clicked, then the enter button is clicked
                Enter_Button.PerformClick();
            }
        }
        private void MyTimer_Tick(object sender, EventArgs e)
        {
            if (Correct_Error_Label.Text == "Correct!")
            {
                Correct_Error_Label.Visible = true;
            } // Makes the correct label visible (if the user has guessed correctly
            else
            {
                Correct_Error_Label.Visible = false;
                Error_Length_Label.Visible = false;
            } // Makes all error labels invisible
        }
        private void Reveal_Hint_Recursion()
        {
            int hintNumber;
            Random r = new Random();

            if (Hint_Number_Selector.Text == "Random")
            {
                if (Hint1_Label.Text != "1." && Hint2_Label.Text != "2." && Hint3_Label.Text != "3." && Hint4_Label.Text != "4." && Hint5_Label.Text != "5." && Hint6_Label.Text != "6." && Hint7_Label.Text.Length >= 45 && Hint8_Label.Text != "8.")
                {
                    hintNumber = 100;
                } // If all hints have been used, the hintNumber is set to a value outside of the number of hints, thus showing an error message in the default statement in the switch statement
                else
                {
                    int value = r.Next(1, 9);

                    // Cycles through excludedNumbers global list until a hint is found which hasn't been revealed or isn't restricted
                    while (excludedNumbers.Contains(value))
                    {
                        value = r.Next(1, 9);
                    }

                    hintNumber = value;
                }
            }
            else
            {
                hintNumber = Convert.ToInt32(Hint_Number_Selector.Text);

                if (Hint1_Label.Text != "1." && Hint2_Label.Text != "2." && Hint3_Label.Text != "3." && Hint4_Label.Text != "4." && Hint5_Label.Text != "5." && Hint6_Label.Text != "6." && Hint7_Label.Text.Length >= 45 && Hint8_Label.Text != "8.")
                {
                    hintNumber = 100;
                } // If all hints have been used, the hintNumber is set to a value outside of the number of hints, thus showing an error message in the default statement in the switch statement
                else if (excludedNumbers.Contains(hintNumber))
                {
                    // Checks if the hint has already been revealed or not, if this case is true, then the following message is shown
                    MessageBox.Show("You have already revealed this hint.");

                    // The hint number is then updates so the default case can be run
                    hintNumber = 100;
                }
            }

            switch (hintNumber)
            {
                case 1:
                    // Hint 1 - Displays the first letter
                    excludedNumbers[0] = 1; // Global list is updated to tell the programme that the hint has been revealed

                    if (Hint1_Label.Text == "-----Restricted-----")
                    {
                        if (Hint_Number_Selector.Text == "Random")
                        {
                            // If the hint is restricted and it was because of a random input, then another random hint is selected
                            Reveal_Hint_Recursion(); // Calls the recursive function
                            MessageBox.Show("Restricted hint selected.  Access: Denied");
                            break;
                        }// Checks if the hint selected is restricted or not
                        else if (Hint1_Label.Text == "1.")
                        { // Reveals the 1st hint
                            Hint1_Label.Text = "1. First letter: " + Program.Hint.GetHint(Convert.ToInt32(hintNumber), Program.Game.GetRandomWord());
                            Program.Database.UpdateTotalHints(Convert.ToInt32(Program.Database.GetTotalHints()) + 1); // Updates the total hints statistic
                            Program.Hint.RevealButtonClick();
                        }
                    }
                    break;

                case 2:
                    // Hint 2 - Total number of vowels
                    excludedNumbers[1] = 2; // Global list is updated to tell the programme that the hint has been revealed
                    if (Hint2_Label.Text == "-----Restricted-----")
                    {
                        if (Hint_Number_Selector.Text == "Random")
                        {
                            // If the hint is restricted and it was because of a random input, then another random hint is selected
                            Reveal_Hint_Recursion(); // Calls the recursive function
                            break;
                        }
                        MessageBox.Show("Restricted hint selected.  Access: Denied");
                        break;
                    }// Checks if the hint selected is restricted or not
                    else if (Hint2_Label.Text == "2.")
                    {// Reveals the 2nd hint
                        Hint2_Label.Text = "2. Number of vowels: " + Program.Hint.GetHint(Convert.ToInt32(hintNumber), Program.Game.GetRandomWord());
                        Program.Database.UpdateTotalHints(Convert.ToInt32(Program.Database.GetTotalHints()) + 1); // Updates the total hints statistic
                        Program.Hint.RevealButtonClick();
                    }
                    break;

                case 3:
                    // Hint 3 - Total number of consonants
                    excludedNumbers[2] = 3; // Global list is updated to tell the programme that the hint has been revealed

                    if (Hint3_Label.Text == "-----Restricted-----")
                    {
                        if (Hint_Number_Selector.Text == "Random")
                        {
                            // If the hint is restricted and it was because of a random input, then another random hint is selected
                            Reveal_Hint_Recursion(); // Calls the recursive function
                            break;
                        }
                        MessageBox.Show("Restricted hint selected.  Access: Denied");
                        break;
                    }// Checks if the hint selected is restricted or not
                    else if (Hint3_Label.Text == "3.")
                    { // Reveals the 3rd hint
                        Hint3_Label.Text = "3. Number of consonants: " + Program.Hint.GetHint(Convert.ToInt32(hintNumber), Program.Game.GetRandomWord());
                        Program.Database.UpdateTotalHints(Convert.ToInt32(Program.Database.GetTotalHints()) + 1); // Updates the total hints statistic
                        Program.Hint.RevealButtonClick();
                    }

                    break;

                case 4:
                    // Hint 4 - Most frequent vowel
                    // Y is not included as a vowel
                    excludedNumbers[3] = 4; // Global list is updated to tell the programme that the hint has been revealed
                    if (Hint4_Label.Text == "-----Restricted-----")
                    {
                        if (Hint_Number_Selector.Text == "Random")
                        {
                            // If the hint is restricted and it was because of a random input, then another random hint is selected
                            Reveal_Hint_Recursion(); // Calls the recursive function
                            break;
                        }
                        MessageBox.Show("Restricted hint selected.  Access: Denied");
                        break;
                    }// Checks if the hint selected is restricted or not
                    else if (Hint4_Label.Text == "4.")
                    { // Reveals the 4th hint
                        if (Program.Hint.GetHint(Convert.ToInt32(hintNumber), Program.Game.GetRandomWord()).Length == 2 && Program.Hint.GetHint(Convert.ToInt32(hintNumber), Program.Game.GetRandomWord()).Length != 19)
                        {
                            Hint4_Label.Text = string.Format("4. Most frequent vowel: {0} + {1}", Program.Hint.GetHint(Convert.ToInt32(hintNumber), Program.Game.GetRandomWord())[0], Program.Hint.GetHint(Convert.ToInt32(hintNumber), Program.Game.GetRandomWord())[1]);
                        }
                        else if (Program.Hint.GetHint(Convert.ToInt32(hintNumber), Program.Game.GetRandomWord()).Length == 3 && Program.Hint.GetHint(Convert.ToInt32(hintNumber), Program.Game.GetRandomWord()).Length != 19)
                        {
                            Hint4_Label.Text = string.Format("4. Most frequent vowel: {0} + {1} + {2}", Program.Hint.GetHint(Convert.ToInt32(hintNumber), Program.Game.GetRandomWord())[0], Program.Hint.GetHint(Convert.ToInt32(hintNumber), Program.Game.GetRandomWord())[1], Program.Hint.GetHint(Convert.ToInt32(hintNumber), Program.Game.GetRandomWord())[2]);
                        }
                        else
                        {
                            Hint4_Label.Text = "4. Most frequent vowel: " + Program.Hint.GetHint(Convert.ToInt32(hintNumber), Program.Game.GetRandomWord());
                        }
                        Program.Database.UpdateTotalHints(Convert.ToInt32(Program.Database.GetTotalHints()) + 1); // Updates the total hints statistic
                        Program.Hint.RevealButtonClick();
                    }
                    break;

                case 5:
                    // Hint 5 - Displays the word length
                    excludedNumbers[4] = 5; // Global list is updated to tell the programme that the hint has been revealed
                    if (Hint5_Label.Text == "-----Restricted-----")
                    {
                        if (Hint_Number_Selector.Text == "Random")
                        {
                            // If the hint is restricted and it was because of a random input, then another random hint is selected
                            Reveal_Hint_Recursion(); // Calls the recursive function
                            break;
                        }
                        MessageBox.Show("Restricted hint selected.  Access: Denied");
                        break;
                    }// Checks if the hint selected is restricted or not
                    else if (Hint5_Label.Text == "5.")
                    { // Reveals the 5th hint
                        Hint5_Label.Text = "5. Word length: " + Program.Hint.GetHint(Convert.ToInt32(hintNumber), Program.Game.GetRandomWord());
                        Program.Database.UpdateTotalHints(Convert.ToInt32(Program.Database.GetTotalHints()) + 1); // Updates the total hints statistic
                        Program.Hint.RevealButtonClick();
                    }
                    break;

                case 6:
                    // Hint 6 - Displays the last letter
                    excludedNumbers[5] = 6; // Global list is updated to tell the programme that the hint has been revealed
                    if (Hint6_Label.Text == "-----Restricted-----")
                    {
                        if (Hint_Number_Selector.Text == "Random")
                        {
                            // If the hint is restricted and it was because of a random input, then another random hint is selected
                            Reveal_Hint_Recursion(); // Calls the recursive function
                            break;
                        }
                        MessageBox.Show("Restricted hint selected.  Access: Denied");
                        break;
                    }// Checks if the hint selected is restricted or not
                    else if (Hint6_Label.Text == "6.")
                    { // Reveals the 6th hint
                        Hint6_Label.Text = "6. Last letter: " + Program.Hint.GetHint(Convert.ToInt32(hintNumber), Program.Game.GetRandomWord());
                        Program.Database.UpdateTotalHints(Convert.ToInt32(Program.Database.GetTotalHints()) + 1); // Updates the total hints statistic
                        Program.Hint.RevealButtonClick();
                    }
                    break;

                case 7:
                    // Hint 7 - returns consonants that aren't in the random word
                    if (Hint7_Label.Text == "-----Restricted-----")
                    {
                        // If the hint is restricted then it is deemed as revealed
                        excludedNumbers[6] = 7;

                        if (Hint_Number_Selector.Text == "Random")
                        {
                            // If the hint is restricted and it was because of a random input, then another random hint is selected
                            Reveal_Hint_Recursion(); // Calls the recursive function
                            break;
                        }
                        MessageBox.Show("Restricted hint selected.  Access: Denied");
                        break;
                    }// Checks if the hint selected is restricted or not
                    else if (Hint7_Label.Text.Length >= 45)
                    {
                        // if the whole hint has been revealed (6 times in this case)
                        // then its index in a global list is updated with the number hint that is being used - 7
                        // this list is then used to see if the hint has already been revealed, so the hint number won't be called if it is called randomly
                        excludedNumbers[6] = 7;
                    }
                    else
                    {
                        // Updates the label with the hint values
                        Hint7_Label.Text = "7. Consonants that aren't in the word: " + Program.Hint.GetHint(Convert.ToInt32(hintNumber), Program.Game.GetRandomWord());
                        Program.Database.UpdateTotalHints(Convert.ToInt32(Program.Database.GetTotalHints()) + 1); // Updates the total hints statistic
                        Program.Hint.RevealButtonClick();
                    }
                    break;

                case 8:
                    // Hint 8 - A random number is revealed and its location if the user guesses a random number correctly (from 1 - 6)
                    excludedNumbers[7] = 8; // Global list is updated to tell the programme that the hint has been revealed
                    if (Hint8_Label.Text == "-----Restricted-----")
                    {
                        if (Hint_Number_Selector.Text == "Random")
                        {
                            // If the hint is restricted and it was because of a random input, then another random hint is selected
                            Reveal_Hint_Recursion(); // Calls the recursive function
                            break;
                        }
                        MessageBox.Show("Restricted hint selected.  Access: Denied");
                        break;
                    }// Checks if the hint selected is restricted or not
                    else
                    { // Reveals the hint
                      // An alert box containing all of the details is revealed
                        int userGuess = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("A random number has been generated.  If you guess the random number chosen (between 1 and 6), then a random character will be revealed along with its location in the random word.\r\n\r\nPlease input a value between 1 and 6.\r\n\r\n*The random character chosen cannot be the first or last character", "Random character reveal", ""));

                        if (userGuess == Convert.ToInt32(Program.Hint.GetHint(Convert.ToInt32(hintNumber), Program.Game.GetRandomWord()))) // Condition is if the user guesses the random value chosen
                        {
                            // The 8th hint in the hint class returns the index, the character is found using the index given
                            // Due to the first value of the Random Word starting at 0, the character location needs to be incremented by 1 so the user knows the exact character location
                            int characterLocation = Convert.ToByte(Program.Hint.GetHint(Convert.ToInt32(hintNumber), Program.Game.GetRandomWord())) + 1;

                            // The random character is found by using the same index saved (GetHint is not called in case a different random index gets generated)
                            // The index is decremented by 1 to get the correct character
                            char randomCharacter = Program.Game.GetRandomWord()[characterLocation - 1];

                            // Label is updated
                            Hint8_Label.Text = "8. Random character: " + randomCharacter + ", Character location: " + characterLocation;
                            Program.Database.UpdateTotalHints(Convert.ToInt32(Program.Database.GetTotalHints()) + 1); // Updates the total hints statistic
                            Program.Hint.RevealButtonClick();
                        }
                        else
                        {
                            // Since the hint can only be used once, if the hint user guesses incorrectly, then the hint is made restricted and the colour is changed to red
                            Hint8_Label.ForeColor = Color.Red;
                            Hint8_Label.Text = "-----Restricted-----";
                            MessageBox.Show("You guessed incorrectly, better luck next time!");
                        }
                    }
                    break;

                default:
                    if (Hint1_Label.Text != "1." && Hint2_Label.Text != "2." && Hint3_Label.Text != "3." && Hint4_Label.Text != "4." && Hint5_Label.Text != "5." && Hint6_Label.Text != "6." && Hint7_Label.Text.Length >= 42 && Hint8_Label.Text != "8.")
                    {
                        MessageBox.Show("You have used all up all of your hints");
                    } // Displays an error message (alert box) if the user has used up all hints
                    break;
            } // Displays an error message (alert box) if the user has used up all hints
        }
        private void UpdateCounter()
        {
            Counter++;
        }
        private void ResetCounter()
        {
            Counter = 0;
        }
        private void Reveal_Hint_Button_Click(object sender, EventArgs e)
        {
            Reveal_Hint_Recursion();

            Random r = new Random();

            #region RefreshStatistics
            if (FullDisplayButton.Text == "Hide Stats")
            {
                Statistics_Display_Label.Text = "Statistics Display:                         ";
                for (int i = 0; i < Program.Database.GetFullStatistics().Length; i++)
                {
                    switch (i)
                    {
                        case 0:
                            Statistics_Display_Label.Text = Statistics_Display_Label.Text + "\r\nPlayerID:  " + Program.Database.GetDataArray()[i];
                            break;

                        case 1:
                            Statistics_Display_Label.Text = Statistics_Display_Label.Text + "\r\nTotal Wins:  " + Program.Database.GetDataArray()[i];
                            break;

                        case 2:
                            Statistics_Display_Label.Text = Statistics_Display_Label.Text + "\r\nTotal Hints:  " + Program.Database.GetDataArray()[i];
                            break;

                        case 3:
                            Statistics_Display_Label.Text = Statistics_Display_Label.Text + "\r\nTotal Guesses:  " + Program.Database.GetDataArray()[i];
                            break;

                        case 4:
                            Statistics_Display_Label.Text = Statistics_Display_Label.Text + "\r\nPercentage of Games Won:  " + Program.Database.GetDataArray()[i];
                            break;

                        case 5:
                            Statistics_Display_Label.Text = Statistics_Display_Label.Text + "\r\nMost Successful Letter Word:  " + Program.Database.GetDataArray()[i];
                            break;

                        case 6:
                            Statistics_Display_Label.Text = Statistics_Display_Label.Text + "\r\nLowest Number of Guesses:  " + Program.Database.GetDataArray()[i];
                            break;

                        case 7:
                            Statistics_Display_Label.Text = Statistics_Display_Label.Text + "\r\nTotal Challenges Won:  " + Program.Database.GetDataArray()[i];
                            break;

                        case 8:
                            Statistics_Display_Label.Text = Statistics_Display_Label.Text + "\r\nWords guessed in First Guess:  " + Program.Database.GetDataArray()[i];
                            break;

                        case 9:
                            Statistics_Display_Label.Text = Statistics_Display_Label.Text + "\r\nWords guessed in Second Guess:  " + Program.Database.GetDataArray()[i];
                            break;

                        case 10:
                            Statistics_Display_Label.Text = Statistics_Display_Label.Text + "\r\nWords guessed in Third Guess:  " + Program.Database.GetDataArray()[i];
                            break;

                        default:
                            Statistics_Display_Label.Text = Statistics_Display_Label.Text + "\r\nTotal Games Played:  " + Program.Database.GetDataArray()[i];
                            break;
                    }
                }
            }
            else if (FullDisplayButton.Text == "Full Stats")
            {
                Statistics_Display_Label.Text = "Statistics Display:                         ";
                for (int i = 0; i < 4; i++)
                {
                    switch (i)
                    {
                        case 0:
                            Statistics_Display_Label.Text = Statistics_Display_Label.Text + "\r\nPlayerID:  " + Program.Database.GetDataArray()[i];
                            break;

                        case 1:
                            Statistics_Display_Label.Text = Statistics_Display_Label.Text + "\r\nTotal Wins:  " + Program.Database.GetDataArray()[i];
                            break;

                        case 2:
                            Statistics_Display_Label.Text = Statistics_Display_Label.Text + "\r\nTotal Hints:  " + Program.Database.GetDataArray()[i];
                            break;

                        default:
                            Statistics_Display_Label.Text = Statistics_Display_Label.Text + "\r\nTotal Guesses:  " + Program.Database.GetDataArray()[i];
                            break;
                    }
                }
            }
            #endregion

            #region RandomHintConsequences
            // Random chance that a hint consequence can be revealed
            switch (r.Next(1, 12))
            {
                case 1 | 3: // Consequence that removes 5 guesses from the user
                    MessageBox.Show("Random hint consequence:  Minus 5 total guesses");
                    Program.Player.UpdateTotalGuesses(Program.Player.GetTotalGuesses() - 5);

                    if (Program.Player.GetTotalGuesses() <= 0) // Checks if the user has 0 or negative guesses, meaning they lost
                    { // Corresponds to if the user has run out of guesses
                        Program.Game.UpdateWinOrLoss(false);
                        Hidden_Word_Label.Visible = true;
                        Main_Menu_Button.Visible = false;
                        Quit_Button.Visible = false;
                        Continue_Button.Visible = true;

                        MessageBox.Show("You ran out of guesses!"); // Tells the user why they lost
                    }
                    RefreshWordLimit(); // Refreshes the word limit label so it is up to date
                    break;

                case 2 | 4: // Consequence that takes away 10 seconds from the timer
                    MessageBox.Show("Random hint consequence:  Minus 10 seconds on timer");
                    Timer_Count_Label.Text = (Convert.ToInt32(Timer_Count_Label.Text) - 10).ToString();
                    break;

                case 5 | 6: // Disables the word limit so the user deosn't know how many guesses they have left
                    MessageBox.Show("Random hint consequence:  Word limit disabled");
                    Word_Limit_Label.Visible = false;
                    break;

                case 12: // Disables the secret hint
                    MessageBox.Show("Rare random hint consequence:  Secret hint disabled");
                    Program.Game.UpdateSecretHintEnable(false);
                    break;
            }
            #endregion
        }
        private void RevealLetters(double First, double Second, double Third, double Fourth, double Fifth, double Sixth, double Seventh)
        {
            // first, second ... (global variables) are changed to true to;
            // ensure that each part of the if statement is run only once, this ensures the hints are only updated once per letter revealed
            if (Counter >= First && first == false)
            {
                first = true;
                secretHint_Label.Visible = true; // Secret hint title is made visible
                SecretHintTitle_Label.Visible = true; // Secret hint label is made visible
                secretHint_Label.Text = "First letter: " + Program.Game.GetRandomWord()[0].ToString(); // First letter is added
                Program.Database.UpdateTotalHints(Convert.ToInt32(Program.Database.GetTotalHints()) + 1); // Total hints statistics is incremented
            }
            else if (Second != 0 && Counter >= Second && second == false)
            { // If second != 0, then the word is 1 character long, the rest of the if statement is not run (only true when the user customises the game)
                second = true;
                secretHint_Label.Text += "\r\nSecond letter: " + Program.Game.GetRandomWord()[1].ToString(); // Second letter is added
                Program.Database.UpdateTotalHints(Convert.ToInt32(Program.Database.GetTotalHints()) + 1); // Total hints statistics is incremented
            }
            else if (Third != 0 && Counter >= Third && third == false)
            { // If third != 0, then the word is 2 characters long, the rest of the if statement is not run (only true when the user customises the game)
                third = true;
                secretHint_Label.Text += "\r\nThird letter: " + Program.Game.GetRandomWord()[2].ToString(); // Third letter is added
                Program.Database.UpdateTotalHints(Convert.ToInt32(Program.Database.GetTotalHints()) + 1); // Total hints statistics is incremented
            }
            else if (Fourth != 0 && Counter >= Fourth && fourth == false)
            { // If fourth is = 0 & third != 0, then the word is 3 characters long, the rest of the if statement is not run
                fourth = true;
                secretHint_Label.Text += "\r\nFourth letter: " + Program.Game.GetRandomWord()[3].ToString(); // Fourth letter is added
                Program.Database.UpdateTotalHints(Convert.ToInt32(Program.Database.GetTotalHints()) + 1); // Total hints statistics is incremented
            }
            else if (Fifth != 0 && Counter >= Fifth && fifth == false)
            { // If fifth is = 0 & fouth != 0, then the word is 4 characters long, the rest of the if statement is not run
                fifth = true;
                secretHint_Label.Text += "\r\nFifth letter: " + Program.Game.GetRandomWord()[4].ToString(); // Fifth letter is added
                Program.Database.UpdateTotalHints(Convert.ToInt32(Program.Database.GetTotalHints()) + 1); // Total hints statistics is incremented
            }
            else if (Sixth != 0 && Counter >= Sixth && sixth == false)
            { // If sixth is = 0 & fifth != 0, then the word is 5 characters long, the rest of the if statement is not run
                sixth = true;
                secretHint_Label.Text += "\r\nSixth letter: " + Program.Game.GetRandomWord()[5].ToString(); // Sixth letter is added
                Program.Database.UpdateTotalHints(Convert.ToInt32(Program.Database.GetTotalHints()) + 1); // Total hints statistics is incremented
            }
            else if (Seventh != 0 && Counter >= Seventh && seventh == false)
            { // If seventh is = 0 & sixth != 0, then the word is 6 characters long, the rest of the if statement is not run
                seventh = true;
                secretHint_Label.Text += "\r\nSeventh letter: " + Program.Game.GetRandomWord()[6].ToString(); // Seventh letter is added
                Program.Database.UpdateTotalHints(Convert.ToInt32(Program.Database.GetTotalHints()) + 1); // Total hints statistics is incremented
            }
        }
        private double GetMultiplyingFactor()
        {
            if (Program.Game.GetUserCustomiseGame()) // Checks if the user has customised the game
            {
                // If the user customised the game, then the multiplying factor is returned
                return Program.Game.GetMultiplyingFactor();
            }
            else
            {
                // This is run if the user hasn't customised the game
                switch (Program.Settings.GetDifficulty())
                {
                    // Returns the basic multiplying factor
                    case "Easy":
                        return 1;

                    case "Medium":
                        return 1.1;

                    case "hard":
                        return 1.2;

                    case "Extremely Hard":
                        return 1.3;

                    default:
                        return 1.4;
                }
            }
        }
        private void Quit_Button_Click(object sender, EventArgs e)
        { // Updates the corresponding features accordingly
          // Updates if the user has customised the game or not to false, meaning that the user didn't customise the game
            Program.Game.UpdateUserCustomiseGame(false);
            // Stops the timer
            time_limit_Timer.Stop();

            Program.Game.UpdateWinOrLoss(false);
            ResetCounter(); // Resets the guesses for the next time the user plays the game
            Hidden_Word_Label.Visible = true;
            Main_Menu_Button.Visible = false;
            Quit_Button.Visible = false;
            Continue_Button.Visible = true;
            resetRandomWord_Button.Visible = false;

            // Resets the global variable holding all of the consonants for hint 7
            Program.Hint.ResetSeventhHintValues();
        }
        private void Main_Menu_Button_Click(object sender, EventArgs e)
        {
            // Updates if the user has customised the game or not to false, meaning that the user didn't customise the game
            Program.Game.UpdateUserCustomiseGame(false);
            // Stops the timer
            time_limit_Timer.Stop();

            // Hides the current page and shows the home menu page
            Home_Menu Home_Menu = new Home_Menu();
            this.Close();
            Home_Menu.Show();

            // Resets the counter in case the user wants to play again
            ResetCounter();

            // Resets the global variable holding all of the consonants for hint 7
            Program.Hint.ResetSeventhHintValues();
        }
        private void RefreshWordLimit()
        {
            // Calculates what the word limit should say
            if (Program.Player.GetTotalGuesses() > 100)
            {
                Word_Limit_Label.Text = "Word limit: Unlimited";
            }
            else
            {
                Word_Limit_Label.Text = "Word limit: " + Program.Player.GetTotalGuesses();
            }
            // This code is used to decrement the guesses and display it accordingly as well as altering when the word limit should say "Unlimited"
        }
        private void Enter_Button_Click(object sender, EventArgs e)
        {
            // Updates the statistics - Adds 1 to the total number of guesses
            Program.Database.UpdateTotalGuesses(Convert.ToInt32(Program.Database.GetTotalGuesses()) + 1);

            #region ErrorTimer
            System.Windows.Forms.Timer MyTimer = new System.Windows.Forms.Timer();
            MyTimer.Interval = 3 * 1000;
            MyTimer.Tick += new EventHandler(MyTimer_Tick);
            MyTimer.Start();
            #endregion // This code represents a timer which is used to remove the incorrect label when the user has entered a guess wrong

            #region Secret hint
            // This IF statement checks if the secret hint should be enabled, if so then the secret hint code is run
            if (Program.Game.GetSecretHintEnable())
            {
                // Increments the counter to show how many guesses the user has entered
                UpdateCounter();
                double k = GetMultiplyingFactor(); // Updates the values to be multiplied by the multiplying factor and displays the correct letter if conditions are true
                                                   // The value given is set to 0 automatically if the user hasn't chosen to customise the page, if not then the value given is what the multiplying factor is updated to

                #region Number of characters
                // The number of characters are added to a list by the index that they are in, for example if there are 2 characters then the list would be { 1, 2 }
                // This is used to determine which characters should be revealed by the secret hint in which order
                List<int> numberOfCharactersList = new List<int>();

                for (int i = 0; i < Program.Game.GetRandomWord().Length; i++)
                {
                    // The list is updated depending on how many characters the random word has
                    // Although only 7 characters can be revealed because of the revealLetters subroutine
                    numberOfCharactersList.Add(i + 1);
                }

                if (numberOfCharactersList.Count() < 7)
                {
                    for (int i = 0; i < 7; i++)
                    {// If less than 7 characters are added to the numberOfCharactersList then values need to be added to the list (multiple zeros) in order for the RevealLetters to have appropriate, working arguments
                     // Therefore 7 more values are added to the list which all have the value of 0, this ensures that the RevealLetters subroutine works.
                     // 7 values are added to ensure that the number of items in the list exceeds 7
                        numberOfCharactersList.Add(0);
                    }
                }
                #endregion

                RevealLetters((numberOfCharactersList[0] * secretHintValue) * k, (numberOfCharactersList[1] * secretHintValue) * k, (numberOfCharactersList[2] * secretHintValue) * k, (numberOfCharactersList[3] * secretHintValue) * k, (numberOfCharactersList[4] * secretHintValue) * k, (numberOfCharactersList[5] * secretHintValue) * k, (numberOfCharactersList[6] * secretHintValue) * k);
            }
            #endregion // Secret hint processing

            #region AlterInputDataType
            // Puts the word inputted into a string
            string Input = Input_Box.Text.ToUpper();
            Program.Player.UpdateGuess(Input);
            #endregion

            #region FirstAndLastThreeGuesses
            // Updates the first and last three guesses - for statistics
            Program.Player.UpdateFirstThreeGuesses();
            Program.Player.UpdateLastThreeGuesses();
            #endregion

            #region Word limit
            // Decrements the amount of total guesses available
            Program.Player.UpdateTotalGuesses(Program.Player.GetTotalGuesses() - 1);

            RefreshWordLimit();
            #endregion // This code is used to decrement the guesses and display it accordingly as well as altering when the word limit should say "Unlimited"

            #region Validate input
            // Validates if the guess entered is in the correct format and returns true when the guess is the same as the random word
            bool answer = Program.Game.ValidateWord(Program.Game.GetRandomWord(), Input, Program.Settings.GetTotalLetters());

            // Displays the hidden word and continue button if the user guessed the word correctly or ran out of guesses
            if (answer)
            {
                // Stops the timer
                time_limit_Timer.Stop();

                // This calculates and shows how long it took for the user to guess the word correctly
                VictoryTimer_Label.Visible = true;
                VictoryTimer_Label.Text = VictoryTimer_Label.Text + " " + Convert.ToString(TotalTimeGiven - Convert.ToInt32(Timer_Count_Label.Text)) + " seconds";

                // Corresponds to the user guessing the word correctly
                // Updates the corresponding labels and makes the correct features visible / invisible
                Program.Game.UpdateWinOrLoss(true);
                Hidden_Word_Label.Visible = true;
                Correct_Error_Label.Text = "Correct!";
                Correct_Error_Label.ForeColor = Color.Gold;
                Correct_Error_Label.Visible = true;
                Main_Menu_Button.Visible = false;
                Quit_Button.Visible = false;
                Continue_Button.Visible = true;

                resetRandomWord_Button.Visible = false;

                #region Statistics
                if (Counter < Convert.ToInt32(Program.Database.GetLowestGuessCount()) | Convert.ToInt32(Program.Database.GetLowestGuessCount()) == 0)
                {
                    // If the statistics are reset, the counter is set to 0, and the value is then updated to whatever the user's first counter is.
                    Program.Database.UpdateLowestGuessCount(Counter);
                } // This IF statement is used to calculate if the lowest guess count needs to be updated or not

                // Updates the total wins
                Program.Database.UpdateTotalWins(Convert.ToInt32(Program.Database.GetTotalWins()) + 1);

                // Checks if the difficulty is "Impossible", referencing to the challenge difficulty and updates the wins accordingly
                if (Program.Settings.GetDifficulty() == "Impossible")
                {
                    Program.Database.UpdateChallengesWon(Convert.ToInt32(Program.Database.GetChallengesWon()) + 1);
                }

                // Updates the words guessed in the first, second or third guess accordingly by first checking if the counter is equal to 1, 2 or 3
                if (Counter == 1)
                {
                    Program.Database.UpdateWordsGuessedInFirstGuess(Convert.ToInt32(Program.Database.GetWordsGuessedInFirstGuess()) + 1);
                }
                else if (Counter == 2)
                {
                    Program.Database.UpdateWordsGuessedInSecondGuess(Convert.ToInt32(Program.Database.GetWordsGuessedInSecondGuess()) + 1);
                }
                else if (Counter == 3)
                {
                    Program.Database.UpdateWordsGuessedInThirdGuess(Convert.ToInt32(Program.Database.GetWordsGuessedInThirdGuess()) + 1);
                }

                // Increments the values which correspond to each letter word
                // Used to calculate the most successful letter word
                switch (Program.Settings.GetTotalLetters())
                {
                    case 3:
                        Program.Database.UpdateThree(Convert.ToInt32(Program.Database.GetDataArray()[12]) + 1);
                        break;

                    case 4:
                        Program.Database.UpdateFour(Convert.ToInt32(Program.Database.GetDataArray()[13]) + 1);
                        break;

                    case 5:
                        Program.Database.UpdateFive(Convert.ToInt32(Program.Database.GetDataArray()[14]) + 1);
                        break;

                    default: // Case 7
                        Program.Database.UpdateSeven(Convert.ToInt32(Program.Database.GetDataArray()[16]) + 1);
                        break;
                }
                #endregion

            }
            else if (Program.Player.GetTotalGuesses() <= 0)
            { // Corresponds to if the user has run out of guesses
                Program.Game.UpdateWinOrLoss(false);
                Hidden_Word_Label.Visible = true;
                Main_Menu_Button.Visible = false;
                Quit_Button.Visible = false;
                Continue_Button.Visible = true;

                MessageBox.Show("You ran out of guesses!"); // Tells the user why they lost
            }
            else if (answer == false && Input.Length > Program.Settings.GetTotalLetters())
            { // Corresponds to if the user has inputted a word which is too long for the random word length
                Error_Length_Label.Text = "Word is too long";
                Error_Length_Label.Visible = true;
            }
            else if (answer == false && Input.Length < Program.Settings.GetTotalLetters())
            { // Corresponds to if the user has inputted a word which is too short for the random word length
                Error_Length_Label.Text = "Word is too short";
                Error_Length_Label.Visible = true;
            }
            else
            {
                Correct_Error_Label.Visible = true;
            }
            #endregion // This code is used to validate the input and display the corresponding labels / buttons

            #region RefreshStatistics
            if (FullDisplayButton.Text == "Hide Stats")
            {
                Statistics_Display_Label.Text = "Statistics Display:                         ";
                for (int i = 0; i < Program.Database.GetFullStatistics().Length; i++)
                {
                    switch (i)
                    {
                        case 0:
                            Statistics_Display_Label.Text = Statistics_Display_Label.Text + "\r\nPlayerID:  " + Program.Database.GetDataArray()[i];
                            break;

                        case 1:
                            Statistics_Display_Label.Text = Statistics_Display_Label.Text + "\r\nTotal Wins:  " + Program.Database.GetDataArray()[i];
                            break;

                        case 2:
                            Statistics_Display_Label.Text = Statistics_Display_Label.Text + "\r\nTotal Hints:  " + Program.Database.GetDataArray()[i];
                            break;

                        case 3:
                            Statistics_Display_Label.Text = Statistics_Display_Label.Text + "\r\nTotal Guesses:  " + Program.Database.GetDataArray()[i];
                            break;

                        case 4:
                            Statistics_Display_Label.Text = Statistics_Display_Label.Text + "\r\nPercentage of Games Won:  " + Program.Database.GetDataArray()[i];
                            break;

                        case 5:
                            Statistics_Display_Label.Text = Statistics_Display_Label.Text + "\r\nMost Successful Letter Word:  " + Program.Database.GetDataArray()[i];
                            break;

                        case 6:
                            Statistics_Display_Label.Text = Statistics_Display_Label.Text + "\r\nLowest Number of Guesses:  " + Program.Database.GetDataArray()[i];
                            break;

                        case 7:
                            Statistics_Display_Label.Text = Statistics_Display_Label.Text + "\r\nTotal Challenges Won:  " + Program.Database.GetDataArray()[i];
                            break;

                        case 8:
                            Statistics_Display_Label.Text = Statistics_Display_Label.Text + "\r\nWords guessed in First Guess:  " + Program.Database.GetDataArray()[i];
                            break;

                        case 9:
                            Statistics_Display_Label.Text = Statistics_Display_Label.Text + "\r\nWords guessed in Second Guess:  " + Program.Database.GetDataArray()[i];
                            break;

                        case 10:
                            Statistics_Display_Label.Text = Statistics_Display_Label.Text + "\r\nWords guessed in Third Guess:  " + Program.Database.GetDataArray()[i];
                            break;

                        case 11:
                            Statistics_Display_Label.Text = Statistics_Display_Label.Text + "\r\nTotal Games Played:  " + Program.Database.GetDataArray()[i];
                            break;

                        default:
                            Statistics_Display_Label.Text = Statistics_Display_Label.Text + "\r\nHighest Win Streak:  " + Program.Database.GetDataArray()[17];
                            break;
                    }
                }
            }
            else if (FullDisplayButton.Text == "Full Stats")
            {
                Statistics_Display_Label.Text = "Statistics Display:                         ";
                for (int i = 0; i < 4; i++)
                {
                    switch (i)
                    {
                        case 0:
                            Statistics_Display_Label.Text = Statistics_Display_Label.Text + "\r\nPlayerID:  " + Program.Database.GetDataArray()[i];
                            break;

                        case 1:
                            Statistics_Display_Label.Text = Statistics_Display_Label.Text + "\r\nTotal Wins:  " + Program.Database.GetDataArray()[i];
                            break;

                        case 2:
                            Statistics_Display_Label.Text = Statistics_Display_Label.Text + "\r\nTotal Hints:  " + Program.Database.GetDataArray()[i];
                            break;

                        default:
                            Statistics_Display_Label.Text = Statistics_Display_Label.Text + "\r\nTotal Guesses:  " + Program.Database.GetDataArray()[i];
                            break;
                    }
                }
            }
            #endregion

            Input_Box.Text = ""; // Removes what the user guessed so the user doesn't have to delete the guess to enter a new guess
        }
        private void Continue_Button_Click(object sender, EventArgs e)
        {
            // Updates if the user has customised the game or not to false, meaning that the user didn't customise the game
            Program.Game.UpdateUserCustomiseGame(false);
            // Stops the timer
            time_limit_Timer.Stop();

            // Hides the current page and shows the victory page
            Victory_Page Victory_Page = new Victory_Page();
            this.Close();
            Victory_Page.Show();

            // Resets the counter in case the user wants to play again
            ResetCounter();

            // Resets the global variable holding all of the consonants for hint 7
            Program.Hint.ResetSeventhHintValues();
        }
        private void RefreshStatistics()
        {
            // Checks what the text is on the button and processes the data accordingly
            if (FullDisplayButton.Text == "Full Stats")
            {
                for (int i = 4; i < Program.Database.GetFullStatistics().Length; i++)
                {
                    switch (i) // Updates the statistics display label with more statstics (the ones missing), thus making the label longer
                    {
                        case 4:
                            Statistics_Display_Label.Text = Statistics_Display_Label.Text + "\r\nPercentage of Games Won:  " + Program.Database.GetDataArray()[i];
                            break;

                        case 5:
                            Statistics_Display_Label.Text = Statistics_Display_Label.Text + "\r\nMost Successful Letter Word:  " + Program.Database.GetDataArray()[i];
                            break;

                        case 6:
                            Statistics_Display_Label.Text = Statistics_Display_Label.Text + "\r\nLowest Number of Guesses:  " + Program.Database.GetDataArray()[i];
                            break;

                        case 7:
                            Statistics_Display_Label.Text = Statistics_Display_Label.Text + "\r\nTotal Challenges Won:  " + Program.Database.GetDataArray()[i];
                            break;

                        case 8:
                            Statistics_Display_Label.Text = Statistics_Display_Label.Text + "\r\nWords guessed in First Guess:  " + Program.Database.GetDataArray()[i];
                            break;

                        case 9:
                            Statistics_Display_Label.Text = Statistics_Display_Label.Text + "\r\nWords guessed in Second Guess:  " + Program.Database.GetDataArray()[i];
                            break;

                        case 10:
                            Statistics_Display_Label.Text = Statistics_Display_Label.Text + "\r\nWords guessed in Third Guess:  " + Program.Database.GetDataArray()[i];
                            break;
                        case 11:
                            Statistics_Display_Label.Text = Statistics_Display_Label.Text + "\r\nTotal Games Played:  " + Program.Database.GetDataArray()[i];
                            break;

                        default:
                            Statistics_Display_Label.Text = Statistics_Display_Label.Text + "\r\nHighest Win Streak:  " + Program.Database.GetDataArray()[17];
                            break;
                    }
                }
                FullDisplayButton.Text = "Hide Stats"; // Updates the text on the button
            } // Maximises the display - Shows all statistics
            else
            {
                Statistics_Display_Label.Text = "Statistics Display:                         "; // Resets the label so it only shows "Statistics Display:" - Gets rid of all statistics
                for (int i = 0; i < 4; i++)
                {
                    switch (i) // Updates the statistics display with only the 4 basic / essential statistics
                    {
                        case 0:
                            Statistics_Display_Label.Text = Statistics_Display_Label.Text + "\r\nPlayerID:  " + Program.Database.GetDataArray()[i];
                            break;

                        case 1:
                            Statistics_Display_Label.Text = Statistics_Display_Label.Text + "\r\nTotal Wins:  " + Program.Database.GetDataArray()[i];
                            break;

                        case 2:
                            Statistics_Display_Label.Text = Statistics_Display_Label.Text + "\r\nTotal Hints:  " + Program.Database.GetDataArray()[i];
                            break;

                        default:
                            Statistics_Display_Label.Text = Statistics_Display_Label.Text + "\r\nTotal Guesses:  " + Program.Database.GetDataArray()[i];
                            break;
                    }
                }
                FullDisplayButton.Text = "Full Stats"; // Updates the text on the button
            } // Minimises the display - Shows the first 4 values
        }
        private void FullDisplayButton_Click(object sender, EventArgs e) // This is used to maximise / minimise the stats display to show all / first 4 values
        {
            RefreshStatistics();
        }
        private void resetRandomWord_Button_Click(object sender, EventArgs e)
        {
            // This region holds the code to reset the page, this generates a new random word, creates a new page and closes the old one
            // The timer is also stopped to avoid crashes when the form is closed
            #region ReloadPage
            // Create an error message with an input box and stores it in the variable "data"
            string data = Microsoft.VisualBasic.Interaction.InputBox("Are you sure you want to reset the current random word?\r\n1) Yes\r\n2) No", "Reset Random Word", "2");

            // If the input is = 1, then all statistics are reset. 
            if (data == "1")
            {
                // Stops the timer
                time_limit_Timer.Stop();

                // Generates a random word based on the settings chosen
                Program.Game.GenerateRandomWord(Program.Settings.GetTotalLetters());

                // Hides the current page and shows the Game Page
                Game_Page Game_Page = new Game_Page();
                this.Close();
                Game_Page.Show();
            }
            #endregion
        }
    }
}