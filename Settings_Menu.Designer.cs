namespace Guess_the_Word___Y13_Programming_Project
{
    partial class Settings_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings_Menu));
            Settings_Menu_Label = new Label();
            Difficulty_Label = new Label();
            Back_Button = new Button();
            Continue_Button = new Button();
            Difficulty_Selector_Label = new Label();
            Total_Letters_Selector = new ComboBox();
            Difficulty_Selector = new ComboBox();
            Total_Letters_Selector_Label = new Label();
            SuspendLayout();
            // 
            // Settings_Menu_Label
            // 
            Settings_Menu_Label.AutoSize = true;
            Settings_Menu_Label.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            Settings_Menu_Label.Location = new Point(12, 9);
            Settings_Menu_Label.Name = "Settings_Menu_Label";
            Settings_Menu_Label.Size = new Size(252, 46);
            Settings_Menu_Label.TabIndex = 0;
            Settings_Menu_Label.Text = "Settings Menu";
            // 
            // Difficulty_Label
            // 
            Difficulty_Label.AutoSize = true;
            Difficulty_Label.BackColor = SystemColors.ControlLight;
            Difficulty_Label.BorderStyle = BorderStyle.FixedSingle;
            Difficulty_Label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Difficulty_Label.Location = new Point(43, 90);
            Difficulty_Label.Name = "Difficulty_Label";
            Difficulty_Label.Size = new Size(467, 254);
            Difficulty_Label.TabIndex = 1;
            Difficulty_Label.Text = resources.GetString("Difficulty_Label.Text");
            Difficulty_Label.Click += Difficulty_Label_Click;
            // 
            // Back_Button
            // 
            Back_Button.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Back_Button.BackColor = Color.Silver;
            Back_Button.FlatAppearance.BorderColor = SystemColors.ControlText;
            Back_Button.FlatStyle = FlatStyle.Flat;
            Back_Button.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Back_Button.Location = new Point(12, 376);
            Back_Button.Name = "Back_Button";
            Back_Button.Size = new Size(121, 61);
            Back_Button.TabIndex = 9;
            Back_Button.Text = "Back";
            Back_Button.UseVisualStyleBackColor = false;
            Back_Button.Click += Back_Button_Click;
            // 
            // Continue_Button
            // 
            Continue_Button.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Continue_Button.BackColor = Color.LimeGreen;
            Continue_Button.FlatAppearance.BorderColor = SystemColors.ControlText;
            Continue_Button.FlatStyle = FlatStyle.Flat;
            Continue_Button.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Continue_Button.ForeColor = SystemColors.ControlText;
            Continue_Button.Location = new Point(738, 376);
            Continue_Button.Name = "Continue_Button";
            Continue_Button.Size = new Size(121, 61);
            Continue_Button.TabIndex = 10;
            Continue_Button.Text = "Continue";
            Continue_Button.UseVisualStyleBackColor = false;
            Continue_Button.Click += Continue_Button_Click;
            // 
            // Difficulty_Selector_Label
            // 
            Difficulty_Selector_Label.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Difficulty_Selector_Label.AutoSize = true;
            Difficulty_Selector_Label.BackColor = SystemColors.ControlLight;
            Difficulty_Selector_Label.BorderStyle = BorderStyle.FixedSingle;
            Difficulty_Selector_Label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Difficulty_Selector_Label.Location = new Point(566, 256);
            Difficulty_Selector_Label.Name = "Difficulty_Selector_Label";
            Difficulty_Selector_Label.Size = new Size(92, 30);
            Difficulty_Selector_Label.TabIndex = 12;
            Difficulty_Selector_Label.Text = "Difficulty\r\n";
            // 
            // Total_Letters_Selector
            // 
            Total_Letters_Selector.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Total_Letters_Selector.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Total_Letters_Selector.FormattingEnabled = true;
            Total_Letters_Selector.Items.AddRange(new object[] { "3", "4", "5", "7", "Random" });
            Total_Letters_Selector.Location = new Point(566, 121);
            Total_Letters_Selector.Name = "Total_Letters_Selector";
            Total_Letters_Selector.Size = new Size(171, 36);
            Total_Letters_Selector.TabIndex = 13;
            // 
            // Difficulty_Selector
            // 
            Difficulty_Selector.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Difficulty_Selector.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Difficulty_Selector.FormattingEnabled = true;
            Difficulty_Selector.Items.AddRange(new object[] { "Easy", "Medium", "Hard", "Extremely Hard", "Impossible", "Random" });
            Difficulty_Selector.Location = new Point(566, 287);
            Difficulty_Selector.Name = "Difficulty_Selector";
            Difficulty_Selector.Size = new Size(171, 36);
            Difficulty_Selector.TabIndex = 14;
            // 
            // Total_Letters_Selector_Label
            // 
            Total_Letters_Selector_Label.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Total_Letters_Selector_Label.AutoSize = true;
            Total_Letters_Selector_Label.BackColor = SystemColors.ControlLight;
            Total_Letters_Selector_Label.BorderStyle = BorderStyle.FixedSingle;
            Total_Letters_Selector_Label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Total_Letters_Selector_Label.Location = new Point(566, 90);
            Total_Letters_Selector_Label.Name = "Total_Letters_Selector_Label";
            Total_Letters_Selector_Label.Size = new Size(119, 30);
            Total_Letters_Selector_Label.TabIndex = 15;
            Total_Letters_Selector_Label.Text = "Total Letters";
            // 
            // Settings_Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(871, 449);
            Controls.Add(Total_Letters_Selector_Label);
            Controls.Add(Difficulty_Selector);
            Controls.Add(Total_Letters_Selector);
            Controls.Add(Difficulty_Selector_Label);
            Controls.Add(Continue_Button);
            Controls.Add(Back_Button);
            Controls.Add(Difficulty_Label);
            Controls.Add(Settings_Menu_Label);
            Name = "Settings_Menu";
            Text = "Settings_Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Settings_Menu_Label;
        private Label Difficulty_Label;
        private Button Back_Button;
        private Button Continue_Button;
        private Label Difficulty_Selector_Label;
        private ComboBox Total_Letters_Selector;
        private ComboBox Difficulty_Selector;
        private Label Total_Letters_Selector_Label;
    }
}