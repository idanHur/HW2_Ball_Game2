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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            toolStrip1 = new ToolStrip();
            toolStripSeparator1 = new ToolStripSeparator();
            AddBallButton = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            RemoveBallButton = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            StopLastButton = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            AboutButton = new ToolStripButton();
            toolStripSeparator5 = new ToolStripSeparator();
            EndGameButton = new ToolStripButton();
            toolStripSeparator6 = new ToolStripSeparator();
            DBButton = new ToolStripButton();
            toolStripSeparator7 = new ToolStripSeparator();
            EndProgramButton = new ToolStripButton();
            label1 = new Label();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripSeparator1, AddBallButton, toolStripSeparator2, RemoveBallButton, toolStripSeparator3, StopLastButton, toolStripSeparator4, AboutButton, toolStripSeparator5, EndGameButton, toolStripSeparator6, DBButton, toolStripSeparator7, EndProgramButton });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 32);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            toolStrip1.ItemClicked += toolStrip1_ItemClicked;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 32);
            // 
            // AddBallButton
            // 
            AddBallButton.BackColor = SystemColors.ButtonHighlight;
            AddBallButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            AddBallButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            AddBallButton.ImageTransparentColor = Color.Transparent;
            AddBallButton.Name = "AddBallButton";
            AddBallButton.Size = new Size(29, 29);
            AddBallButton.Text = "+";
            AddBallButton.Click += AddBallButton_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 32);
            // 
            // RemoveBallButton
            // 
            RemoveBallButton.BackColor = SystemColors.ButtonHighlight;
            RemoveBallButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            RemoveBallButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            RemoveBallButton.ImageTransparentColor = Color.Transparent;
            RemoveBallButton.Name = "RemoveBallButton";
            RemoveBallButton.Size = new Size(24, 29);
            RemoveBallButton.Text = "-";
            RemoveBallButton.Click += RemoveBallButton_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 32);
            // 
            // StopLastButton
            // 
            StopLastButton.BackColor = Color.Red;
            StopLastButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            StopLastButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            StopLastButton.Image = (Image)resources.GetObject("StopLastButton.Image");
            StopLastButton.ImageTransparentColor = Color.Magenta;
            StopLastButton.Name = "StopLastButton";
            StopLastButton.Size = new Size(27, 29);
            StopLastButton.Text = "S";
            StopLastButton.Click += StopLastButton_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 32);
            // 
            // AboutButton
            // 
            AboutButton.BackColor = SystemColors.ButtonHighlight;
            AboutButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            AboutButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            AboutButton.Image = (Image)resources.GetObject("AboutButton.Image");
            AboutButton.ImageTransparentColor = Color.Magenta;
            AboutButton.Name = "AboutButton";
            AboutButton.Size = new Size(29, 29);
            AboutButton.Text = "A";
            AboutButton.Click += AboutButton_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(6, 32);
            // 
            // EndGameButton
            // 
            EndGameButton.BackColor = Color.FromArgb(255, 255, 128);
            EndGameButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            EndGameButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            EndGameButton.Image = (Image)resources.GetObject("EndGameButton.Image");
            EndGameButton.ImageTransparentColor = Color.Magenta;
            EndGameButton.Name = "EndGameButton";
            EndGameButton.Size = new Size(106, 29);
            EndGameButton.Text = "End Game";
            EndGameButton.Click += EndGameButton_Click;
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(6, 32);
            // 
            // DBButton
            // 
            DBButton.BackColor = Color.FromArgb(192, 255, 192);
            DBButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            DBButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            DBButton.Image = (Image)resources.GetObject("DBButton.Image");
            DBButton.ImageTransparentColor = Color.Magenta;
            DBButton.Name = "DBButton";
            DBButton.Size = new Size(42, 29);
            DBButton.Text = "DB";
            DBButton.Click += DBButton_Click;
            // 
            // toolStripSeparator7
            // 
            toolStripSeparator7.Name = "toolStripSeparator7";
            toolStripSeparator7.Size = new Size(6, 32);
            // 
            // EndProgramButton
            // 
            EndProgramButton.BackColor = Color.Red;
            EndProgramButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            EndProgramButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            EndProgramButton.Image = (Image)resources.GetObject("EndProgramButton.Image");
            EndProgramButton.ImageTransparentColor = Color.Magenta;
            EndProgramButton.Name = "EndProgramButton";
            EndProgramButton.Size = new Size(26, 29);
            EndProgramButton.Text = "E";
            EndProgramButton.Click += EndProgramButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(274, 113);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(toolStrip1);
            Name = "Form1";
            Text = "Form1";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private Label label1;
    }
}