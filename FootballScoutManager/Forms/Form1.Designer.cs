
namespace FootballScoutManager
{
    partial class Form1
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
            this.ExitButton = new System.Windows.Forms.Label();
            this.TitleText = new System.Windows.Forms.Label();
            this.SubTitleText = new System.Windows.Forms.Label();
            this.NameText = new System.Windows.Forms.Label();
            this.AgeText = new System.Windows.Forms.Label();
            this.UserNameTextbox = new System.Windows.Forms.TextBox();
            this.UserAgeTextbox = new System.Windows.Forms.TextBox();
            this.GamePhilosophyText = new System.Windows.Forms.Label();
            this.PurchasingPurposeText = new System.Windows.Forms.Label();
            this.GamePhilosophyComboBox = new System.Windows.Forms.ComboBox();
            this.PurchasingPurposeComboBox = new System.Windows.Forms.ComboBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.AutoSize = true;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.Color.Green;
            this.ExitButton.Location = new System.Drawing.Point(813, -1);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(28, 31);
            this.ExitButton.TabIndex = 19;
            this.ExitButton.Text = "x";
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // TitleText
            // 
            this.TitleText.AutoSize = true;
            this.TitleText.Font = new System.Drawing.Font("Century Gothic", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleText.ForeColor = System.Drawing.Color.DarkGreen;
            this.TitleText.Location = new System.Drawing.Point(12, 18);
            this.TitleText.Name = "TitleText";
            this.TitleText.Size = new System.Drawing.Size(313, 39);
            this.TitleText.TabIndex = 20;
            this.TitleText.Text = "Hello Mr. Manager";
            // 
            // SubTitleText
            // 
            this.SubTitleText.AutoSize = true;
            this.SubTitleText.Font = new System.Drawing.Font("Century Gothic", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubTitleText.ForeColor = System.Drawing.Color.DarkGreen;
            this.SubTitleText.Location = new System.Drawing.Point(14, 57);
            this.SubTitleText.Name = "SubTitleText";
            this.SubTitleText.Size = new System.Drawing.Size(776, 27);
            this.SubTitleText.TabIndex = 21;
            this.SubTitleText.Text = "In order to suit you players, we will need some information about you";
            // 
            // NameText
            // 
            this.NameText.AutoSize = true;
            this.NameText.Font = new System.Drawing.Font("Century Gothic", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameText.ForeColor = System.Drawing.Color.DarkGreen;
            this.NameText.Location = new System.Drawing.Point(132, 122);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(87, 27);
            this.NameText.TabIndex = 22;
            this.NameText.Text = "Name:";
            // 
            // AgeText
            // 
            this.AgeText.AutoSize = true;
            this.AgeText.Font = new System.Drawing.Font("Century Gothic", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgeText.ForeColor = System.Drawing.Color.DarkGreen;
            this.AgeText.Location = new System.Drawing.Point(134, 160);
            this.AgeText.Name = "AgeText";
            this.AgeText.Size = new System.Drawing.Size(65, 27);
            this.AgeText.TabIndex = 23;
            this.AgeText.Text = "Age:";
            // 
            // UserNameTextbox
            // 
            this.UserNameTextbox.Location = new System.Drawing.Point(225, 130);
            this.UserNameTextbox.Name = "UserNameTextbox";
            this.UserNameTextbox.Size = new System.Drawing.Size(100, 20);
            this.UserNameTextbox.TabIndex = 24;
            // 
            // UserAgeTextbox
            // 
            this.UserAgeTextbox.Location = new System.Drawing.Point(225, 168);
            this.UserAgeTextbox.Name = "UserAgeTextbox";
            this.UserAgeTextbox.Size = new System.Drawing.Size(100, 20);
            this.UserAgeTextbox.TabIndex = 25;
            this.UserAgeTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UserAgeTextbox_KeyPress);
            // 
            // GamePhilosophyText
            // 
            this.GamePhilosophyText.AutoSize = true;
            this.GamePhilosophyText.Font = new System.Drawing.Font("Century Gothic", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GamePhilosophyText.ForeColor = System.Drawing.Color.DarkGreen;
            this.GamePhilosophyText.Location = new System.Drawing.Point(14, 246);
            this.GamePhilosophyText.Name = "GamePhilosophyText";
            this.GamePhilosophyText.Size = new System.Drawing.Size(216, 27);
            this.GamePhilosophyText.TabIndex = 26;
            this.GamePhilosophyText.Text = "Game Philosophy:";
            // 
            // PurchasingPurposeText
            // 
            this.PurchasingPurposeText.AutoSize = true;
            this.PurchasingPurposeText.Font = new System.Drawing.Font("Century Gothic", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PurchasingPurposeText.ForeColor = System.Drawing.Color.DarkGreen;
            this.PurchasingPurposeText.Location = new System.Drawing.Point(377, 246);
            this.PurchasingPurposeText.Name = "PurchasingPurposeText";
            this.PurchasingPurposeText.Size = new System.Drawing.Size(236, 27);
            this.PurchasingPurposeText.TabIndex = 27;
            this.PurchasingPurposeText.Text = "Purchasing Purpose:";
            // 
            // GamePhilosophyComboBox
            // 
            this.GamePhilosophyComboBox.FormattingEnabled = true;
            this.GamePhilosophyComboBox.Items.AddRange(new object[] {
            "High Pressuere",
            "Possesion",
            "Long Ball"});
            this.GamePhilosophyComboBox.Location = new System.Drawing.Point(19, 276);
            this.GamePhilosophyComboBox.Name = "GamePhilosophyComboBox";
            this.GamePhilosophyComboBox.Size = new System.Drawing.Size(207, 21);
            this.GamePhilosophyComboBox.TabIndex = 28;
            this.GamePhilosophyComboBox.SelectedIndexChanged += new System.EventHandler(this.GamePhilosophyComboBox_SelectedIndexChanged);
            // 
            // PurchasingPurposeComboBox
            // 
            this.PurchasingPurposeComboBox.FormattingEnabled = true;
            this.PurchasingPurposeComboBox.Items.AddRange(new object[] {
            "Star Player",
            "Rotation Player",
            "Young Player"});
            this.PurchasingPurposeComboBox.Location = new System.Drawing.Point(382, 276);
            this.PurchasingPurposeComboBox.Name = "PurchasingPurposeComboBox";
            this.PurchasingPurposeComboBox.Size = new System.Drawing.Size(231, 21);
            this.PurchasingPurposeComboBox.TabIndex = 29;
            this.PurchasingPurposeComboBox.SelectedIndexChanged += new System.EventHandler(this.PurchasingPurposeComboBox_SelectedIndexChanged);
            // 
            // SubmitButton
            // 
            this.SubmitButton.BackColor = System.Drawing.Color.DarkGreen;
            this.SubmitButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.SubmitButton.ForeColor = System.Drawing.Color.White;
            this.SubmitButton.Location = new System.Drawing.Point(727, 345);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(91, 32);
            this.SubmitButton.TabIndex = 30;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = false;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(841, 411);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.PurchasingPurposeComboBox);
            this.Controls.Add(this.GamePhilosophyComboBox);
            this.Controls.Add(this.PurchasingPurposeText);
            this.Controls.Add(this.GamePhilosophyText);
            this.Controls.Add(this.UserAgeTextbox);
            this.Controls.Add(this.UserNameTextbox);
            this.Controls.Add(this.AgeText);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.SubTitleText);
            this.Controls.Add(this.TitleText);
            this.Controls.Add(this.ExitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ExitButton;
        private System.Windows.Forms.Label TitleText;
        private System.Windows.Forms.Label SubTitleText;
        private System.Windows.Forms.Label NameText;
        private System.Windows.Forms.Label AgeText;
        private System.Windows.Forms.TextBox UserNameTextbox;
        private System.Windows.Forms.TextBox UserAgeTextbox;
        private System.Windows.Forms.Label GamePhilosophyText;
        private System.Windows.Forms.Label PurchasingPurposeText;
        private System.Windows.Forms.ComboBox GamePhilosophyComboBox;
        private System.Windows.Forms.ComboBox PurchasingPurposeComboBox;
        private System.Windows.Forms.Button SubmitButton;
    }
}

