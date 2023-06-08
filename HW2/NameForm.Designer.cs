using System.Drawing;
using System.Windows.Forms;

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
            this.NameButton = new System.Windows.Forms.Button();
            this.playerNameTextBox = new System.Windows.Forms.TextBox();
            this.EnterNameLabel = new System.Windows.Forms.Label();
            this.ErrorNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameButton
            // 
            this.NameButton.Location = new System.Drawing.Point(118, 63);
            this.NameButton.Name = "NameButton";
            this.NameButton.Size = new System.Drawing.Size(64, 20);
            this.NameButton.TabIndex = 0;
            this.NameButton.Text = "OK";
            this.NameButton.UseVisualStyleBackColor = true;
            this.NameButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // playerNameTextBox
            // 
            this.playerNameTextBox.Location = new System.Drawing.Point(55, 38);
            this.playerNameTextBox.Name = "playerNameTextBox";
            this.playerNameTextBox.Size = new System.Drawing.Size(193, 20);
            this.playerNameTextBox.TabIndex = 1;
            this.playerNameTextBox.TextChanged += new System.EventHandler(this.playerNameTextBox_TextChanged);
            // 
            // EnterNameLabel
            // 
            this.EnterNameLabel.AutoSize = true;
            this.EnterNameLabel.Location = new System.Drawing.Point(96, 23);
            this.EnterNameLabel.Name = "EnterNameLabel";
            this.EnterNameLabel.Size = new System.Drawing.Size(118, 13);
            this.EnterNameLabel.TabIndex = 2;
            this.EnterNameLabel.Text = "Please enter your name";
            // 
            // ErrorNameLabel
            // 
            this.ErrorNameLabel.AutoSize = true;
            this.ErrorNameLabel.Location = new System.Drawing.Point(10, 98);
            this.ErrorNameLabel.Name = "ErrorNameLabel";
            this.ErrorNameLabel.Size = new System.Drawing.Size(0, 13);
            this.ErrorNameLabel.TabIndex = 3;
            // 
            // NameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 125);
            this.Controls.Add(this.NameButton);
            this.Controls.Add(this.playerNameTextBox);
            this.Controls.Add(this.EnterNameLabel);
            this.Controls.Add(this.ErrorNameLabel);
            this.Name = "NameForm";
            this.Text = "NameForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button NameButton;
        private TextBox playerNameTextBox;
        private Label EnterNameLabel;
        private Label ErrorNameLabel;
    }
}