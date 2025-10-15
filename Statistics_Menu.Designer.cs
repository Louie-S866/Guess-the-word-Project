namespace Guess_the_Word___Y13_Programming_Project
{
    partial class Statistics_Menu
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
            Last_Three_Guesses_Label = new Label();
            First_Three_Guesses_Label = new Label();
            Reset_Statistics_Button = new Button();
            Back_Button = new Button();
            All_Stats_Label = new Label();
            Statistics_Menu_Label = new Label();
            SuspendLayout();
            // 
            // Last_Three_Guesses_Label
            // 
            Last_Three_Guesses_Label.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Last_Three_Guesses_Label.AutoSize = true;
            Last_Three_Guesses_Label.BackColor = SystemColors.ControlLight;
            Last_Three_Guesses_Label.BorderStyle = BorderStyle.FixedSingle;
            Last_Three_Guesses_Label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Last_Three_Guesses_Label.Location = new Point(486, 254);
            Last_Three_Guesses_Label.Name = "Last_Three_Guesses_Label";
            Last_Three_Guesses_Label.Size = new Size(218, 58);
            Last_Three_Guesses_Label.TabIndex = 18;
            Last_Three_Guesses_Label.Text = "Last Three Guesses\r\n(Previous game played)";
            // 
            // First_Three_Guesses_Label
            // 
            First_Three_Guesses_Label.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            First_Three_Guesses_Label.AutoSize = true;
            First_Three_Guesses_Label.BackColor = SystemColors.ControlLight;
            First_Three_Guesses_Label.BorderStyle = BorderStyle.FixedSingle;
            First_Three_Guesses_Label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            First_Three_Guesses_Label.Location = new Point(486, 127);
            First_Three_Guesses_Label.Name = "First_Three_Guesses_Label";
            First_Three_Guesses_Label.Size = new Size(218, 58);
            First_Three_Guesses_Label.TabIndex = 17;
            First_Three_Guesses_Label.Text = "First Three Guesses \r\n(Previous game played)";
            // 
            // Reset_Statistics_Button
            // 
            Reset_Statistics_Button.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Reset_Statistics_Button.BackColor = Color.Red;
            Reset_Statistics_Button.FlatAppearance.BorderColor = SystemColors.ControlText;
            Reset_Statistics_Button.FlatStyle = FlatStyle.Flat;
            Reset_Statistics_Button.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Reset_Statistics_Button.ForeColor = SystemColors.ControlText;
            Reset_Statistics_Button.Location = new Point(667, 377);
            Reset_Statistics_Button.Name = "Reset_Statistics_Button";
            Reset_Statistics_Button.Size = new Size(121, 61);
            Reset_Statistics_Button.TabIndex = 16;
            Reset_Statistics_Button.Text = "Reset Statistics";
            Reset_Statistics_Button.UseVisualStyleBackColor = false;
            Reset_Statistics_Button.Click += Reset_Statistics_Button_Click;
            // 
            // Back_Button
            // 
            Back_Button.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Back_Button.BackColor = Color.Silver;
            Back_Button.FlatAppearance.BorderColor = SystemColors.ControlText;
            Back_Button.FlatStyle = FlatStyle.Flat;
            Back_Button.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Back_Button.Location = new Point(12, 377);
            Back_Button.Name = "Back_Button";
            Back_Button.Size = new Size(121, 61);
            Back_Button.TabIndex = 15;
            Back_Button.Text = "Back";
            Back_Button.UseVisualStyleBackColor = false;
            Back_Button.Click += Back_Button_Click;
            // 
            // All_Stats_Label
            // 
            All_Stats_Label.AutoSize = true;
            All_Stats_Label.BackColor = SystemColors.ControlLight;
            All_Stats_Label.BorderStyle = BorderStyle.FixedSingle;
            All_Stats_Label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            All_Stats_Label.Location = new Point(90, 127);
            All_Stats_Label.Name = "All_Stats_Label";
            All_Stats_Label.Size = new Size(122, 30);
            All_Stats_Label.TabIndex = 14;
            All_Stats_Label.Text = "All Statistics:";
            // 
            // Statistics_Menu_Label
            // 
            Statistics_Menu_Label.AutoSize = true;
            Statistics_Menu_Label.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            Statistics_Menu_Label.Location = new Point(12, 11);
            Statistics_Menu_Label.Name = "Statistics_Menu_Label";
            Statistics_Menu_Label.Size = new Size(263, 46);
            Statistics_Menu_Label.TabIndex = 13;
            Statistics_Menu_Label.Text = "Statistics Menu";
            Statistics_Menu_Label.Click += Statistics_Menu_Label_Click;
            // 
            // Statistics_Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Last_Three_Guesses_Label);
            Controls.Add(First_Three_Guesses_Label);
            Controls.Add(Reset_Statistics_Button);
            Controls.Add(Back_Button);
            Controls.Add(All_Stats_Label);
            Controls.Add(Statistics_Menu_Label);
            Name = "Statistics_Menu";
            Text = "Statistics_Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Last_Three_Guesses_Label;
        private Label First_Three_Guesses_Label;
        private Button Reset_Statistics_Button;
        private Button Back_Button;
        private Label All_Stats_Label;
        private Label Statistics_Menu_Label;
    }
}