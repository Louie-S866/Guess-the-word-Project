namespace Guess_the_Word___Y13_Programming_Project
{
    partial class Play_Game_Menu
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
            Title = new Label();
            Play_Game_Button = new Button();
            Settings_Menu_Button = new Button();
            Back_Button = new Button();
            enableSecretHint_Button = new Button();
            customise_Button = new Button();
            SuspendLayout();
            // 
            // Title
            // 
            Title.Anchor = AnchorStyles.Top;
            Title.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            Title.Location = new Point(-32, 0);
            Title.Name = "Title";
            Title.Size = new Size(800, 50);
            Title.TabIndex = 5;
            Title.Text = "Guess the Word";
            Title.TextAlign = ContentAlignment.MiddleCenter;
            Title.Click += Title_Click;
            // 
            // Play_Game_Button
            // 
            Play_Game_Button.Anchor = AnchorStyles.Top;
            Play_Game_Button.BackColor = Color.LimeGreen;
            Play_Game_Button.FlatAppearance.BorderColor = SystemColors.ControlText;
            Play_Game_Button.FlatStyle = FlatStyle.Flat;
            Play_Game_Button.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Play_Game_Button.ForeColor = SystemColors.ControlText;
            Play_Game_Button.Location = new Point(48, 210);
            Play_Game_Button.Name = "Play_Game_Button";
            Play_Game_Button.Size = new Size(121, 61);
            Play_Game_Button.TabIndex = 6;
            Play_Game_Button.Text = "Play Game";
            Play_Game_Button.UseVisualStyleBackColor = false;
            Play_Game_Button.Click += Play_Game_Button_Click;
            // 
            // Settings_Menu_Button
            // 
            Settings_Menu_Button.Anchor = AnchorStyles.Top;
            Settings_Menu_Button.BackColor = Color.Blue;
            Settings_Menu_Button.FlatAppearance.BorderColor = SystemColors.ControlText;
            Settings_Menu_Button.FlatStyle = FlatStyle.Flat;
            Settings_Menu_Button.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Settings_Menu_Button.ForeColor = SystemColors.ControlText;
            Settings_Menu_Button.Location = new Point(302, 210);
            Settings_Menu_Button.Name = "Settings_Menu_Button";
            Settings_Menu_Button.Size = new Size(121, 61);
            Settings_Menu_Button.TabIndex = 7;
            Settings_Menu_Button.Text = "Settings Menu";
            Settings_Menu_Button.UseVisualStyleBackColor = false;
            Settings_Menu_Button.Click += Settings_Menu_Button_Click;
            // 
            // Back_Button
            // 
            Back_Button.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Back_Button.BackColor = Color.Silver;
            Back_Button.FlatAppearance.BorderColor = SystemColors.ControlText;
            Back_Button.FlatStyle = FlatStyle.Flat;
            Back_Button.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Back_Button.Location = new Point(12, 430);
            Back_Button.Name = "Back_Button";
            Back_Button.Size = new Size(121, 61);
            Back_Button.TabIndex = 8;
            Back_Button.Text = "Back";
            Back_Button.UseVisualStyleBackColor = false;
            Back_Button.Click += Back_Button_Click;
            // 
            // enableSecretHint_Button
            // 
            enableSecretHint_Button.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            enableSecretHint_Button.BackColor = Color.LimeGreen;
            enableSecretHint_Button.FlatAppearance.BorderColor = SystemColors.ControlText;
            enableSecretHint_Button.FlatStyle = FlatStyle.Flat;
            enableSecretHint_Button.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            enableSecretHint_Button.Location = new Point(603, 430);
            enableSecretHint_Button.Name = "enableSecretHint_Button";
            enableSecretHint_Button.Size = new Size(121, 61);
            enableSecretHint_Button.TabIndex = 9;
            enableSecretHint_Button.Text = "Secret Hint:\r\nEnabled";
            enableSecretHint_Button.UseVisualStyleBackColor = false;
            enableSecretHint_Button.Click += enableSecretHint_Button_Click;
            // 
            // customise_Button
            // 
            customise_Button.Anchor = AnchorStyles.Top;
            customise_Button.BackColor = Color.LimeGreen;
            customise_Button.FlatAppearance.BorderColor = SystemColors.ControlText;
            customise_Button.FlatStyle = FlatStyle.Flat;
            customise_Button.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            customise_Button.ForeColor = SystemColors.ControlText;
            customise_Button.Location = new Point(556, 210);
            customise_Button.Name = "customise_Button";
            customise_Button.Size = new Size(121, 61);
            customise_Button.TabIndex = 10;
            customise_Button.Text = "Customise Game";
            customise_Button.UseVisualStyleBackColor = false;
            customise_Button.Click += customise_Button_Click;
            // 
            // Play_Game_Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(736, 503);
            Controls.Add(customise_Button);
            Controls.Add(enableSecretHint_Button);
            Controls.Add(Back_Button);
            Controls.Add(Settings_Menu_Button);
            Controls.Add(Play_Game_Button);
            Controls.Add(Title);
            Name = "Play_Game_Menu";
            Text = "Play_Game_Menu";
            Load += Play_Game_Menu_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label Title;
        private Button Play_Game_Button;
        private Button Settings_Menu_Button;
        private Button Back_Button;
        private Button enableSecretHint_Button;
        private Button customise_Button;
    }
}