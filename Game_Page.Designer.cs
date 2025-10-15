namespace Guess_the_Word___Y13_Programming_Project
{
    partial class Game_Page
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Title_Label = new Label();
            Main_Menu_Button = new Button();
            Quit_Button = new Button();
            Difficulty_Display_Label = new Label();
            time_limit_Timer = new System.Windows.Forms.Timer(components);
            Input_Box = new TextBox();
            Enter_Button = new Button();
            Hidden_Word_Label = new Label();
            Word_Limit_Label = new Label();
            Statistics_Display_Label = new Label();
            Hint_Display_Label = new Label();
            Reveal_Hint_Button = new Button();
            Hint_Number_Selector = new ComboBox();
            Correct_Error_Label = new Label();
            RandomWord_Label = new Label();
            Continue_Button = new Button();
            Hint1_Label = new Label();
            Hint2_Label = new Label();
            Hint3_Label = new Label();
            Hint4_Label = new Label();
            Hint5_Label = new Label();
            SecretHintTitle_Label = new Label();
            secretHint_Label = new Label();
            Error_Length_Label = new Label();
            Hint6_Label = new Label();
            FullDisplayButton = new Button();
            Hint7_Label = new Label();
            Timer_Count_Label = new Label();
            TimerTitle_Label = new Label();
            VictoryTimer_Label = new Label();
            resetRandomWord_Button = new Button();
            Hint8_Label = new Label();
            SuspendLayout();
            // 
            // Title_Label
            // 
            Title_Label.Anchor = AnchorStyles.Top;
            Title_Label.AutoSize = true;
            Title_Label.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            Title_Label.Location = new Point(321, 9);
            Title_Label.Name = "Title_Label";
            Title_Label.Size = new Size(303, 50);
            Title_Label.TabIndex = 1;
            Title_Label.Text = "Guess The Word";
            // 
            // Main_Menu_Button
            // 
            Main_Menu_Button.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Main_Menu_Button.BackColor = Color.Silver;
            Main_Menu_Button.FlatAppearance.BorderColor = SystemColors.ControlText;
            Main_Menu_Button.FlatStyle = FlatStyle.Flat;
            Main_Menu_Button.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Main_Menu_Button.ForeColor = SystemColors.ControlText;
            Main_Menu_Button.Location = new Point(692, 402);
            Main_Menu_Button.Name = "Main_Menu_Button";
            Main_Menu_Button.Size = new Size(121, 61);
            Main_Menu_Button.TabIndex = 13;
            Main_Menu_Button.Text = "Main Menu";
            Main_Menu_Button.UseVisualStyleBackColor = false;
            Main_Menu_Button.Click += Main_Menu_Button_Click;
            // 
            // Quit_Button
            // 
            Quit_Button.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Quit_Button.BackColor = Color.Red;
            Quit_Button.FlatAppearance.BorderColor = SystemColors.ControlText;
            Quit_Button.FlatStyle = FlatStyle.Flat;
            Quit_Button.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Quit_Button.ForeColor = SystemColors.ControlText;
            Quit_Button.Location = new Point(819, 402);
            Quit_Button.Name = "Quit_Button";
            Quit_Button.Size = new Size(121, 61);
            Quit_Button.TabIndex = 17;
            Quit_Button.Text = "Quit";
            Quit_Button.UseVisualStyleBackColor = false;
            Quit_Button.Click += Quit_Button_Click;
            // 
            // Difficulty_Display_Label
            // 
            Difficulty_Display_Label.Anchor = AnchorStyles.Bottom;
            Difficulty_Display_Label.AutoSize = true;
            Difficulty_Display_Label.BorderStyle = BorderStyle.FixedSingle;
            Difficulty_Display_Label.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            Difficulty_Display_Label.Location = new Point(366, 422);
            Difficulty_Display_Label.Name = "Difficulty_Display_Label";
            Difficulty_Display_Label.Size = new Size(213, 34);
            Difficulty_Display_Label.TabIndex = 18;
            Difficulty_Display_Label.Text = "Difficulty Display";
            // 
            // time_limit_Timer
            // 
            time_limit_Timer.Enabled = true;
            time_limit_Timer.Interval = 1000;
            // 
            // Input_Box
            // 
            Input_Box.Anchor = AnchorStyles.Top;
            Input_Box.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            Input_Box.Location = new Point(422, 132);
            Input_Box.Name = "Input_Box";
            Input_Box.Size = new Size(98, 41);
            Input_Box.TabIndex = 19;
            // 
            // Enter_Button
            // 
            Enter_Button.Anchor = AnchorStyles.Top;
            Enter_Button.AutoSize = true;
            Enter_Button.BackColor = Color.Silver;
            Enter_Button.FlatAppearance.BorderColor = SystemColors.ControlText;
            Enter_Button.FlatStyle = FlatStyle.Flat;
            Enter_Button.Location = new Point(542, 132);
            Enter_Button.Name = "Enter_Button";
            Enter_Button.Size = new Size(103, 41);
            Enter_Button.TabIndex = 21;
            Enter_Button.Text = "Enter";
            Enter_Button.UseVisualStyleBackColor = false;
            Enter_Button.Click += Enter_Button_Click;
            // 
            // Hidden_Word_Label
            // 
            Hidden_Word_Label.Anchor = AnchorStyles.Top;
            Hidden_Word_Label.AutoSize = true;
            Hidden_Word_Label.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            Hidden_Word_Label.Location = new Point(422, 59);
            Hidden_Word_Label.Name = "Hidden_Word_Label";
            Hidden_Word_Label.Size = new Size(98, 45);
            Hidden_Word_Label.TabIndex = 22;
            Hidden_Word_Label.Text = "Word\r\n";
            Hidden_Word_Label.Visible = false;
            // 
            // Word_Limit_Label
            // 
            Word_Limit_Label.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Word_Limit_Label.AutoSize = true;
            Word_Limit_Label.BackColor = SystemColors.ControlLight;
            Word_Limit_Label.BorderStyle = BorderStyle.FixedSingle;
            Word_Limit_Label.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            Word_Limit_Label.Location = new Point(720, 14);
            Word_Limit_Label.Name = "Word_Limit_Label";
            Word_Limit_Label.Size = new Size(201, 37);
            Word_Limit_Label.TabIndex = 23;
            Word_Limit_Label.Text = "Word limit:         ";
            // 
            // Statistics_Display_Label
            // 
            Statistics_Display_Label.AutoSize = true;
            Statistics_Display_Label.BackColor = SystemColors.ControlLight;
            Statistics_Display_Label.BorderStyle = BorderStyle.FixedSingle;
            Statistics_Display_Label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Statistics_Display_Label.Location = new Point(10, 9);
            Statistics_Display_Label.Name = "Statistics_Display_Label";
            Statistics_Display_Label.Size = new Size(288, 30);
            Statistics_Display_Label.TabIndex = 25;
            Statistics_Display_Label.Text = "Statistics Display:                         ";
            // 
            // Hint_Display_Label
            // 
            Hint_Display_Label.Anchor = AnchorStyles.Left;
            Hint_Display_Label.AutoSize = true;
            Hint_Display_Label.BackColor = SystemColors.Control;
            Hint_Display_Label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Hint_Display_Label.Location = new Point(12, 162);
            Hint_Display_Label.Name = "Hint_Display_Label";
            Hint_Display_Label.Size = new Size(61, 28);
            Hint_Display_Label.TabIndex = 26;
            Hint_Display_Label.Text = "Hints:";
            // 
            // Reveal_Hint_Button
            // 
            Reveal_Hint_Button.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Reveal_Hint_Button.AutoSize = true;
            Reveal_Hint_Button.BackColor = Color.Silver;
            Reveal_Hint_Button.FlatAppearance.BorderColor = SystemColors.ControlText;
            Reveal_Hint_Button.FlatStyle = FlatStyle.Flat;
            Reveal_Hint_Button.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Reveal_Hint_Button.Location = new Point(12, 400);
            Reveal_Hint_Button.Name = "Reveal_Hint_Button";
            Reveal_Hint_Button.Size = new Size(121, 61);
            Reveal_Hint_Button.TabIndex = 27;
            Reveal_Hint_Button.Text = "Reveal Hint";
            Reveal_Hint_Button.UseVisualStyleBackColor = false;
            Reveal_Hint_Button.Click += Reveal_Hint_Button_Click;
            // 
            // Hint_Number_Selector
            // 
            Hint_Number_Selector.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Hint_Number_Selector.BackColor = SystemColors.Window;
            Hint_Number_Selector.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Hint_Number_Selector.FormattingEnabled = true;
            Hint_Number_Selector.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "Random" });
            Hint_Number_Selector.Location = new Point(154, 415);
            Hint_Number_Selector.Name = "Hint_Number_Selector";
            Hint_Number_Selector.Size = new Size(94, 31);
            Hint_Number_Selector.TabIndex = 28;
            Hint_Number_Selector.Text = "Hint No.";
            // 
            // Correct_Error_Label
            // 
            Correct_Error_Label.Anchor = AnchorStyles.Top;
            Correct_Error_Label.AutoSize = true;
            Correct_Error_Label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Correct_Error_Label.Location = new Point(550, 72);
            Correct_Error_Label.Name = "Correct_Error_Label";
            Correct_Error_Label.Size = new Size(95, 28);
            Correct_Error_Label.TabIndex = 33;
            Correct_Error_Label.Text = "Incorrect!";
            Correct_Error_Label.Visible = false;
            // 
            // RandomWord_Label
            // 
            RandomWord_Label.AutoSize = true;
            RandomWord_Label.Location = new Point(645, 312);
            RandomWord_Label.Name = "RandomWord_Label";
            RandomWord_Label.Size = new Size(114, 20);
            RandomWord_Label.TabIndex = 34;
            RandomWord_Label.Text = "temporaryWord";
            // 
            // Continue_Button
            // 
            Continue_Button.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Continue_Button.BackColor = Color.LimeGreen;
            Continue_Button.FlatAppearance.BorderColor = SystemColors.ControlText;
            Continue_Button.FlatStyle = FlatStyle.Flat;
            Continue_Button.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Continue_Button.ForeColor = SystemColors.ControlText;
            Continue_Button.Location = new Point(819, 335);
            Continue_Button.Name = "Continue_Button";
            Continue_Button.Size = new Size(121, 61);
            Continue_Button.TabIndex = 35;
            Continue_Button.Text = "Continue";
            Continue_Button.UseVisualStyleBackColor = false;
            Continue_Button.Visible = false;
            Continue_Button.Click += Continue_Button_Click;
            // 
            // Hint1_Label
            // 
            Hint1_Label.Anchor = AnchorStyles.Left;
            Hint1_Label.AutoSize = true;
            Hint1_Label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Hint1_Label.Location = new Point(12, 190);
            Hint1_Label.Name = "Hint1_Label";
            Hint1_Label.Size = new Size(27, 28);
            Hint1_Label.TabIndex = 36;
            Hint1_Label.Text = "1.";
            // 
            // Hint2_Label
            // 
            Hint2_Label.Anchor = AnchorStyles.Left;
            Hint2_Label.AutoSize = true;
            Hint2_Label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Hint2_Label.Location = new Point(12, 218);
            Hint2_Label.Name = "Hint2_Label";
            Hint2_Label.Size = new Size(27, 28);
            Hint2_Label.TabIndex = 37;
            Hint2_Label.Text = "2.";
            // 
            // Hint3_Label
            // 
            Hint3_Label.Anchor = AnchorStyles.Left;
            Hint3_Label.AutoSize = true;
            Hint3_Label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Hint3_Label.Location = new Point(12, 246);
            Hint3_Label.Name = "Hint3_Label";
            Hint3_Label.Size = new Size(27, 28);
            Hint3_Label.TabIndex = 38;
            Hint3_Label.Text = "3.";
            // 
            // Hint4_Label
            // 
            Hint4_Label.Anchor = AnchorStyles.Left;
            Hint4_Label.AutoSize = true;
            Hint4_Label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Hint4_Label.Location = new Point(12, 274);
            Hint4_Label.Name = "Hint4_Label";
            Hint4_Label.Size = new Size(27, 28);
            Hint4_Label.TabIndex = 39;
            Hint4_Label.Text = "4.";
            // 
            // Hint5_Label
            // 
            Hint5_Label.Anchor = AnchorStyles.Left;
            Hint5_Label.AutoSize = true;
            Hint5_Label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Hint5_Label.Location = new Point(12, 302);
            Hint5_Label.Name = "Hint5_Label";
            Hint5_Label.Size = new Size(27, 28);
            Hint5_Label.TabIndex = 40;
            Hint5_Label.Text = "5.";
            // 
            // SecretHintTitle_Label
            // 
            SecretHintTitle_Label.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SecretHintTitle_Label.AutoSize = true;
            SecretHintTitle_Label.BackColor = SystemColors.ControlLight;
            SecretHintTitle_Label.BorderStyle = BorderStyle.FixedSingle;
            SecretHintTitle_Label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SecretHintTitle_Label.Location = new Point(720, 132);
            SecretHintTitle_Label.Name = "SecretHintTitle_Label";
            SecretHintTitle_Label.Size = new Size(116, 30);
            SecretHintTitle_Label.TabIndex = 41;
            SecretHintTitle_Label.Text = "Secret Hint!";
            SecretHintTitle_Label.Visible = false;
            // 
            // secretHint_Label
            // 
            secretHint_Label.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            secretHint_Label.AutoSize = true;
            secretHint_Label.BackColor = SystemColors.ControlLight;
            secretHint_Label.BorderStyle = BorderStyle.FixedSingle;
            secretHint_Label.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            secretHint_Label.Location = new Point(720, 164);
            secretHint_Label.Name = "secretHint_Label";
            secretHint_Label.Size = new Size(160, 27);
            secretHint_Label.TabIndex = 48;
            secretHint_Label.Text = "secretHintDisplay";
            secretHint_Label.Visible = false;
            // 
            // Error_Length_Label
            // 
            Error_Length_Label.Anchor = AnchorStyles.Top;
            Error_Length_Label.AutoSize = true;
            Error_Length_Label.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Error_Length_Label.Location = new Point(190, 138);
            Error_Length_Label.Name = "Error_Length_Label";
            Error_Length_Label.Size = new Size(212, 25);
            Error_Length_Label.TabIndex = 49;
            Error_Length_Label.Text = "Word is too short / long";
            Error_Length_Label.Visible = false;
            // 
            // Hint6_Label
            // 
            Hint6_Label.Anchor = AnchorStyles.Left;
            Hint6_Label.AutoSize = true;
            Hint6_Label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Hint6_Label.Location = new Point(12, 330);
            Hint6_Label.Name = "Hint6_Label";
            Hint6_Label.Size = new Size(27, 28);
            Hint6_Label.TabIndex = 51;
            Hint6_Label.Text = "6.";
            // 
            // FullDisplayButton
            // 
            FullDisplayButton.FlatAppearance.BorderColor = SystemColors.ControlText;
            FullDisplayButton.FlatStyle = FlatStyle.Flat;
            FullDisplayButton.Location = new Point(181, 12);
            FullDisplayButton.Name = "FullDisplayButton";
            FullDisplayButton.Size = new Size(112, 38);
            FullDisplayButton.TabIndex = 53;
            FullDisplayButton.Text = "Full Stats";
            FullDisplayButton.UseVisualStyleBackColor = true;
            FullDisplayButton.Click += FullDisplayButton_Click;
            // 
            // Hint7_Label
            // 
            Hint7_Label.Anchor = AnchorStyles.Left;
            Hint7_Label.AutoSize = true;
            Hint7_Label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Hint7_Label.Location = new Point(12, 358);
            Hint7_Label.Name = "Hint7_Label";
            Hint7_Label.Size = new Size(27, 28);
            Hint7_Label.TabIndex = 54;
            Hint7_Label.Text = "7.";
            // 
            // Timer_Count_Label
            // 
            Timer_Count_Label.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Timer_Count_Label.AutoSize = true;
            Timer_Count_Label.BackColor = SystemColors.ControlLight;
            Timer_Count_Label.BorderStyle = BorderStyle.FixedSingle;
            Timer_Count_Label.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Timer_Count_Label.Location = new Point(792, 59);
            Timer_Count_Label.Name = "Timer_Count_Label";
            Timer_Count_Label.Size = new Size(34, 27);
            Timer_Count_Label.TabIndex = 55;
            Timer_Count_Label.Text = "61";
            // 
            // TimerTitle_Label
            // 
            TimerTitle_Label.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TimerTitle_Label.AutoSize = true;
            TimerTitle_Label.BackColor = SystemColors.ControlLight;
            TimerTitle_Label.BorderStyle = BorderStyle.FixedSingle;
            TimerTitle_Label.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            TimerTitle_Label.Location = new Point(720, 59);
            TimerTitle_Label.Name = "TimerTitle_Label";
            TimerTitle_Label.Size = new Size(66, 27);
            TimerTitle_Label.TabIndex = 56;
            TimerTitle_Label.Text = "Timer:";
            // 
            // VictoryTimer_Label
            // 
            VictoryTimer_Label.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            VictoryTimer_Label.AutoSize = true;
            VictoryTimer_Label.BackColor = SystemColors.ControlLight;
            VictoryTimer_Label.BorderStyle = BorderStyle.FixedSingle;
            VictoryTimer_Label.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            VictoryTimer_Label.Location = new Point(720, 95);
            VictoryTimer_Label.Name = "VictoryTimer_Label";
            VictoryTimer_Label.Size = new Size(110, 27);
            VictoryTimer_Label.TabIndex = 57;
            VictoryTimer_Label.Text = "Time taken:";
            VictoryTimer_Label.Visible = false;
            // 
            // resetRandomWord_Button
            // 
            resetRandomWord_Button.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            resetRandomWord_Button.BackColor = Color.Red;
            resetRandomWord_Button.FlatAppearance.BorderColor = SystemColors.ControlText;
            resetRandomWord_Button.FlatStyle = FlatStyle.Flat;
            resetRandomWord_Button.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            resetRandomWord_Button.ForeColor = SystemColors.ControlText;
            resetRandomWord_Button.Location = new Point(692, 362);
            resetRandomWord_Button.Name = "resetRandomWord_Button";
            resetRandomWord_Button.Size = new Size(248, 34);
            resetRandomWord_Button.TabIndex = 58;
            resetRandomWord_Button.Text = "Reset Random Word";
            resetRandomWord_Button.UseVisualStyleBackColor = false;
            resetRandomWord_Button.Click += resetRandomWord_Button_Click;
            // 
            // Hint8_Label
            // 
            Hint8_Label.Anchor = AnchorStyles.Left;
            Hint8_Label.AutoSize = true;
            Hint8_Label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Hint8_Label.Location = new Point(12, 385);
            Hint8_Label.Name = "Hint8_Label";
            Hint8_Label.Size = new Size(27, 28);
            Hint8_Label.TabIndex = 59;
            Hint8_Label.Text = "8.";
            // 
            // Game_Page
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 475);
            Controls.Add(Hint8_Label);
            Controls.Add(resetRandomWord_Button);
            Controls.Add(VictoryTimer_Label);
            Controls.Add(TimerTitle_Label);
            Controls.Add(Timer_Count_Label);
            Controls.Add(Hint7_Label);
            Controls.Add(FullDisplayButton);
            Controls.Add(Hint6_Label);
            Controls.Add(Error_Length_Label);
            Controls.Add(secretHint_Label);
            Controls.Add(SecretHintTitle_Label);
            Controls.Add(Hint5_Label);
            Controls.Add(Hint4_Label);
            Controls.Add(Hint3_Label);
            Controls.Add(Hint2_Label);
            Controls.Add(Hint1_Label);
            Controls.Add(Continue_Button);
            Controls.Add(RandomWord_Label);
            Controls.Add(Correct_Error_Label);
            Controls.Add(Hint_Number_Selector);
            Controls.Add(Reveal_Hint_Button);
            Controls.Add(Hint_Display_Label);
            Controls.Add(Statistics_Display_Label);
            Controls.Add(Word_Limit_Label);
            Controls.Add(Hidden_Word_Label);
            Controls.Add(Enter_Button);
            Controls.Add(Input_Box);
            Controls.Add(Difficulty_Display_Label);
            Controls.Add(Quit_Button);
            Controls.Add(Main_Menu_Button);
            Controls.Add(Title_Label);
            Name = "Game_Page";
            Text = "Game_Page";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title_Label;
        private Button Main_Menu_Button;
        private Button Quit_Button;
        private Label Difficulty_Display_Label;
        private System.Windows.Forms.Timer time_limit_Timer;
        private TextBox Input_Box;
        private Button Enter_Button;
        private Label Hidden_Word_Label;
        private Label Word_Limit_Label;
        private Label Statistics_Display_Label;
        private Label Hint_Display_Label;
        private Button Reveal_Hint_Button;
        private ComboBox Hint_Number_Selector;
        private Label Correct_Error_Label;
        private Label RandomWord_Label;
        private Button Continue_Button;
        private Label Hint1_Label;
        private Label Hint2_Label;
        private Label Hint3_Label;
        private Label Hint4_Label;
        private Label Hint5_Label;
        private Label SecretHintTitle_Label;
        private Label secretHint_Label;
        private Label Error_Length_Label;
        private Label Hint6_Label;
        private Button FullDisplayButton;
        private Label Hint7_Label;
        private Label Timer_Count_Label;
        private Label TimerTitle_Label;
        private Label VictoryTimer_Label;
        private Button resetRandomWord_Button;
        private Label Hint8_Label;
    }
}