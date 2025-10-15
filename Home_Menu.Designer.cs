namespace Guess_the_Word___Y13_Programming_Project
{
    partial class Home_Menu
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
            QuitGame = new Button();
            Statistics_Button = new Button();
            Play_Button = new Button();
            Title = new Label();
            SuspendLayout();
            // 
            // QuitGame
            // 
            QuitGame.Anchor = AnchorStyles.Top;
            QuitGame.BackColor = Color.Red;
            QuitGame.FlatAppearance.BorderColor = SystemColors.ControlText;
            QuitGame.FlatStyle = FlatStyle.Flat;
            QuitGame.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            QuitGame.ForeColor = SystemColors.ControlText;
            QuitGame.Location = new Point(253, 417);
            QuitGame.Name = "QuitGame";
            QuitGame.Size = new Size(121, 61);
            QuitGame.TabIndex = 7;
            QuitGame.Text = "Quit Game";
            QuitGame.UseVisualStyleBackColor = false;
            QuitGame.Click += QuitGame_Click;
            // 
            // Statistics_Button
            // 
            Statistics_Button.Anchor = AnchorStyles.Top;
            Statistics_Button.BackColor = Color.Blue;
            Statistics_Button.FlatAppearance.BorderColor = SystemColors.ControlText;
            Statistics_Button.FlatStyle = FlatStyle.Flat;
            Statistics_Button.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Statistics_Button.ForeColor = SystemColors.ControlText;
            Statistics_Button.Location = new Point(253, 329);
            Statistics_Button.Name = "Statistics_Button";
            Statistics_Button.Size = new Size(121, 61);
            Statistics_Button.TabIndex = 6;
            Statistics_Button.Text = "Statistics";
            Statistics_Button.UseVisualStyleBackColor = false;
            Statistics_Button.Click += Statistics_Button_Click;
            // 
            // Play_Button
            // 
            Play_Button.Anchor = AnchorStyles.Top;
            Play_Button.BackColor = Color.LimeGreen;
            Play_Button.FlatAppearance.BorderColor = Color.Black;
            Play_Button.FlatStyle = FlatStyle.Flat;
            Play_Button.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Play_Button.ForeColor = SystemColors.ControlText;
            Play_Button.Location = new Point(253, 243);
            Play_Button.Name = "Play_Button";
            Play_Button.Size = new Size(121, 61);
            Play_Button.TabIndex = 5;
            Play_Button.Text = "Play";
            Play_Button.UseVisualStyleBackColor = false;
            Play_Button.Click += Play_Button_Click;
            // 
            // Title
            // 
            Title.Anchor = AnchorStyles.Top;
            Title.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            Title.Location = new Point(10, 0);
            Title.Name = "Title";
            Title.Size = new Size(613, 50);
            Title.TabIndex = 4;
            Title.Text = "Guess the Word";
            Title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Home_Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(632, 514);
            Controls.Add(QuitGame);
            Controls.Add(Statistics_Button);
            Controls.Add(Play_Button);
            Controls.Add(Title);
            Name = "Home_Menu";
            Text = "Home_Menu";
            ResumeLayout(false);
        }

        #endregion

        private Button QuitGame;
        private Button Statistics_Button;
        private Button Play_Button;
        private Label Title;
    }
}