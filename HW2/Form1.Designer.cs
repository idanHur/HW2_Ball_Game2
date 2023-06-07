using System.Drawing;
using System.Windows.Forms;

namespace HW2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.AddBallButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.RemoveBallButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.StopLastButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.AboutButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.EndGameButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.DBButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.EndProgramButton = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.AddBallButton,
            this.toolStripSeparator2,
            this.RemoveBallButton,
            this.toolStripSeparator3,
            this.StopLastButton,
            this.toolStripSeparator4,
            this.AboutButton,
            this.toolStripSeparator5,
            this.EndGameButton,
            this.toolStripSeparator6,
            this.DBButton,
            this.toolStripSeparator7,
            this.EndProgramButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(686, 32);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 32);
            // 
            // AddBallButton
            // 
            this.AddBallButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddBallButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.AddBallButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.AddBallButton.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.AddBallButton.Name = "AddBallButton";
            this.AddBallButton.Size = new System.Drawing.Size(29, 29);
            this.AddBallButton.Text = "+";
            this.AddBallButton.Click += new System.EventHandler(this.AddBallButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 32);
            // 
            // RemoveBallButton
            // 
            this.RemoveBallButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RemoveBallButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.RemoveBallButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.RemoveBallButton.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.RemoveBallButton.Name = "RemoveBallButton";
            this.RemoveBallButton.Size = new System.Drawing.Size(24, 29);
            this.RemoveBallButton.Text = "-";
            this.RemoveBallButton.Click += new System.EventHandler(this.RemoveBallButton_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 32);
            // 
            // StopLastButton
            // 
            this.StopLastButton.BackColor = System.Drawing.Color.Red;
            this.StopLastButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.StopLastButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.StopLastButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.StopLastButton.Name = "StopLastButton";
            this.StopLastButton.Size = new System.Drawing.Size(27, 29);
            this.StopLastButton.Text = "S";
            this.StopLastButton.Click += new System.EventHandler(this.StopLastButton_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 32);
            // 
            // AboutButton
            // 
            this.AboutButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AboutButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.AboutButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.AboutButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(29, 29);
            this.AboutButton.Text = "A";
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 32);
            // 
            // EndGameButton
            // 
            this.EndGameButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.EndGameButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.EndGameButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.EndGameButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EndGameButton.Name = "EndGameButton";
            this.EndGameButton.Size = new System.Drawing.Size(106, 29);
            this.EndGameButton.Text = "End Game";
            this.EndGameButton.Click += new System.EventHandler(this.EndGameButton_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 32);
            // 
            // DBButton
            // 
            this.DBButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.DBButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.DBButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.DBButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DBButton.Name = "DBButton";
            this.DBButton.Size = new System.Drawing.Size(42, 29);
            this.DBButton.Text = "DB";
            this.DBButton.Click += new System.EventHandler(this.DBButton_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 32);
            // 
            // EndProgramButton
            // 
            this.EndProgramButton.BackColor = System.Drawing.Color.Red;
            this.EndProgramButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.EndProgramButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.EndProgramButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EndProgramButton.Name = "EndProgramButton";
            this.EndProgramButton.Size = new System.Drawing.Size(26, 29);
            this.EndProgramButton.Text = "E";
            this.EndProgramButton.Click += new System.EventHandler(this.EndProgramButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton AddBallButton;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton RemoveBallButton;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton StopLastButton;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton AboutButton;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripButton EndGameButton;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripButton DBButton;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripButton EndProgramButton;
    }
}

