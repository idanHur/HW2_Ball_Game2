namespace HW2
{
    partial class NameForm
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
            NameButton = new Button();
            playerNameTextBox = new TextBox();
            EnterNameLabel = new Label();
            ErrorNameLabel = new Label();
            SuspendLayout();
            // 
            // NameButton
            // 
            NameButton.Location = new Point(138, 73);
            NameButton.Name = "NameButton";
            NameButton.Size = new Size(75, 23);
            NameButton.TabIndex = 0;
            NameButton.Text = "OK";
            NameButton.UseVisualStyleBackColor = true;
            NameButton.Click += button1_Click;
            // 
            // playerNameTextBox
            // 
            playerNameTextBox.Location = new Point(64, 44);
            playerNameTextBox.Name = "playerNameTextBox";
            playerNameTextBox.Size = new Size(224, 23);
            playerNameTextBox.TabIndex = 1;
            playerNameTextBox.TextChanged += textBox1_TextChanged;
            // 
            // EnterNameLabel
            // 
            EnterNameLabel.AutoSize = true;
            EnterNameLabel.Location = new Point(112, 26);
            EnterNameLabel.Name = "EnterNameLabel";
            EnterNameLabel.Size = new Size(130, 15);
            EnterNameLabel.TabIndex = 2;
            EnterNameLabel.Text = "Please enter your name";
            EnterNameLabel.Click += EnterNameLabel_Click;
            // 
            // ErrorNameLabel
            // 
            ErrorNameLabel.AutoSize = true;
            ErrorNameLabel.Location = new Point(12, 113);
            ErrorNameLabel.Name = "ErrorNameLabel";
            ErrorNameLabel.Size = new Size(0, 15);
            ErrorNameLabel.TabIndex = 3;
            // 
            // NameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(343, 144);
            Controls.Add(NameButton);
            Controls.Add(playerNameTextBox);
            Controls.Add(EnterNameLabel);
            Controls.Add(ErrorNameLabel);
            Name = "NameForm";
            Text = "NameForm";
            Load += NameForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button NameButton;
        private TextBox playerNameTextBox;
        private Label EnterNameLabel;
        private Label ErrorNameLabel;
    }
}