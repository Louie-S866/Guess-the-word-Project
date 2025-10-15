namespace Guess_the_Word___Y13_Programming_Project
{
    partial class Victory_Page
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
            Victory_Label = new Label();
            Play_Again_Button = new Button();
            Main_Menu_Button = new Button();
            All_Stats_Label = new Label();
            Last_Three_Guesses_Label = new Label();
            First_Three_Guesses_Label = new Label();
            Quit_Button = new Button();
            HiddenWord_Label = new Label();
            SuspendLayout();
            // 
            // Victory_Label
            // 
            Victory_Label.Anchor = AnchorStyles.Top;
            Victory_Label.AutoSize = true;
            Victory_Label.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            Victory_Label.ForeColor = Color.Gold;
            Victory_Label.Location = new Point(393, 9);
            Victory_Label.Name = "Victory_Label";
            Victory_Label.Size = new Size(147, 46);
            Victory_Label.TabIndex = 1;
            Victory_Label.Text = "Victory!";
            Victory_Label.Click += Victory_Label_Click;
            // 
            // Play_Again_Button
            // 
            Play_Again_Button.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Play_Again_Button.BackColor = Color.LimeGreen;
            Play_Again_Button.FlatAppearance.BorderColor = SystemColors.ControlText;
            Play_Again_Button.FlatStyle = FlatStyle.Flat;
            Play_Again_Button.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Play_Again_Button.ForeColor = SystemColors.ControlText;
            Play_Again_Button.Location = new Point(778, 421);
            Play_Again_Button.Name = "Play_Again_Button";
            Play_Again_Button.Size = new Size(121, 61);
            Play_Again_Button.TabIndex = 11;
            Play_Again_Button.Text = "Play Again";
            Play_Again_Button.UseVisualStyleBackColor = false;
            Play_Again_Button.Click += Play_Again_Button_Click;
            // 
            // Main_Menu_Button
            // 
            Main_Menu_Button.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Main_Menu_Button.BackColor = Color.Silver;
            Main_Menu_Button.FlatAppearance.BorderColor = SystemColors.ControlText;
            Main_Menu_Button.FlatStyle = FlatStyle.Flat;
            Main_Menu_Button.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Main_Menu_Button.Location = new Point(12, 421);
            Main_Menu_Button.Name = "Main_Menu_Button";
            Main_Menu_Button.Size = new Size(121, 61);
            Main_Menu_Button.TabIndex = 12;
            Main_Menu_Button.Text = "Main Menu";
            Main_Menu_Button.UseVisualStyleBackColor = false;
            Main_Menu_Button.Click += Main_Menu_Button_Click;
            // 
            // All_Stats_Label
            // 
            All_Stats_Label.AutoSize = true;
            All_Stats_Label.BackColor = SystemColors.ControlLight;
            All_Stats_Label.BorderStyle = BorderStyle.FixedSingle;
            All_Stats_Label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            All_Stats_Label.Location = new Point(72, 111);
            All_Stats_Label.Name = "All_Stats_Label";
            All_Stats_Label.Size = new Size(263, 226);
            All_Stats_Label.TabIndex = 15;
            All_Stats_Label.Text = "All Statistics:\r\n- Total Wins\r\n- Total Games Played\r\n- % of games won\r\n- Most successful letter word\r\n- Total guesses\r\n- Total hints used\r\n...";
            // 
            // Last_Three_Guesses_Label
            // 
            Last_Three_Guesses_Label.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Last_Three_Guesses_Label.AutoSize = true;
            Last_Three_Guesses_Label.BackColor = SystemColors.ControlLight;
            Last_Three_Guesses_Label.BorderStyle = BorderStyle.FixedSingle;
            Last_Three_Guesses_Label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Last_Three_Guesses_Label.Location = new Point(627, 251);
            Last_Three_Guesses_Label.Name = "Last_Three_Guesses_Label";
            Last_Three_Guesses_Label.Size = new Size(179, 30);
            Last_Three_Guesses_Label.TabIndex = 20;
            Last_Three_Guesses_Label.Text = "Last Three Guesses:";
            // 
            // First_Three_Guesses_Label
            // 
            First_Three_Guesses_Label.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            First_Three_Guesses_Label.AutoSize = true;
            First_Three_Guesses_Label.BackColor = SystemColors.ControlLight;
            First_Three_Guesses_Label.BorderStyle = BorderStyle.FixedSingle;
            First_Three_Guesses_Label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            First_Three_Guesses_Label.Location = new Point(624, 111);
            First_Three_Guesses_Label.Name = "First_Three_Guesses_Label";
            First_Three_Guesses_Label.Size = new Size(182, 30);
            First_Three_Guesses_Label.TabIndex = 19;
            First_Three_Guesses_Label.Text = "First Three Guesses:";
            // 
            // Quit_Button
            // 
            Quit_Button.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Quit_Button.BackColor = Color.Red;
            Quit_Button.FlatAppearance.BorderColor = SystemColors.ControlText;
            Quit_Button.FlatStyle = FlatStyle.Flat;
            Quit_Button.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Quit_Button.ForeColor = SystemColors.ControlText;
            Quit_Button.Location = new Point(139, 421);
            Quit_Button.Name = "Quit_Button";
            Quit_Button.Size = new Size(121, 61);
            Quit_Button.TabIndex = 29;
            Quit_Button.Text = "Quit";
            Quit_Button.UseVisualStyleBackColor = false;
            Quit_Button.Click += Quit_Button_Click;
            // 
            // HiddenWord_Label
            // 
            HiddenWord_Label.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            HiddenWord_Label.AutoSize = true;
            HiddenWord_Label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            HiddenWord_Label.Location = new Point(624, 72);
            HiddenWord_Label.Name = "HiddenWord_Label";
            HiddenWord_Label.Size = new Size(144, 28);
            HiddenWord_Label.TabIndex = 30;
            HiddenWord_Label.Text = "Hidden Word:  ";
            // 
            // Victory_Page
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(911, 494);
            Controls.Add(HiddenWord_Label);
            Controls.Add(Quit_Button);
            Controls.Add(Last_Three_Guesses_Label);
            Controls.Add(First_Three_Guesses_Label);
            Controls.Add(All_Stats_Label);
            Controls.Add(Main_Menu_Button);
            Controls.Add(Play_Again_Button);
            Controls.Add(Victory_Label);
            Name = "Victory_Page";
            Text = "Victory_Page";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Victory_Label;
        private Button Play_Again_Button;
        private Button Main_Menu_Button;
        private Label All_Stats_Label;
        private Label Last_Three_Guesses_Label;
        private Label First_Three_Guesses_Label;
        private Button Quit_Button;
        private Label HiddenWord_Label;

        private Label First_Guess_Label;
        private Label Second_Guess_Label;
        private Label Third_Guess_label;
        private Label Third_Last_Guess_Label;
        private Label Second_Last_Guess_Label;
        private Label Last_Guess_Label;
    }
}