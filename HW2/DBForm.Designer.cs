namespace HW2
{
    partial class DBForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DBForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.PreviousButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.PageTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.OfLabel = new System.Windows.Forms.ToolStripLabel();
            this.MaxPageLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.NextButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.Q1Button = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.Q2Button = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.AllButton = new System.Windows.Forms.ToolStripButton();
            this.OkButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(390, 143);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PreviousButton,
            this.toolStripSeparator1,
            this.PageTextBox,
            this.OfLabel,
            this.MaxPageLabel,
            this.toolStripSeparator2,
            this.NextButton2,
            this.toolStripSeparator3,
            this.Q1Button,
            this.toolStripSeparator4,
            this.Q2Button,
            this.toolStripSeparator5,
            this.AllButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(389, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // PreviousButton
            // 
            this.PreviousButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PreviousButton.Image = ((System.Drawing.Image)(resources.GetObject("PreviousButton.Image")));
            this.PreviousButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PreviousButton.Name = "PreviousButton";
            this.PreviousButton.Size = new System.Drawing.Size(23, 22);
            this.PreviousButton.Text = "toolStripButton1";
            this.PreviousButton.Click += new System.EventHandler(this.PreviousButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // PageTextBox
            // 
            this.PageTextBox.Name = "PageTextBox";
            this.PageTextBox.Size = new System.Drawing.Size(100, 25);
            this.PageTextBox.Click += new System.EventHandler(this.PageTextBox_Click);
            // 
            // OfLabel
            // 
            this.OfLabel.Name = "OfLabel";
            this.OfLabel.Size = new System.Drawing.Size(20, 22);
            this.OfLabel.Text = "Of";
            // 
            // MaxPageLabel
            // 
            this.MaxPageLabel.Name = "MaxPageLabel";
            this.MaxPageLabel.Size = new System.Drawing.Size(13, 22);
            this.MaxPageLabel.Text = "0";
            this.MaxPageLabel.Click += new System.EventHandler(this.MaxPageLabel_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // NextButton2
            // 
            this.NextButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NextButton2.Image = ((System.Drawing.Image)(resources.GetObject("NextButton2.Image")));
            this.NextButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NextButton2.Name = "NextButton2";
            this.NextButton2.Size = new System.Drawing.Size(23, 22);
            this.NextButton2.Text = "toolStripButton2";
            this.NextButton2.Click += new System.EventHandler(this.NextButton2_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // Q1Button
            // 
            this.Q1Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Q1Button.Image = ((System.Drawing.Image)(resources.GetObject("Q1Button.Image")));
            this.Q1Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Q1Button.Name = "Q1Button";
            this.Q1Button.Size = new System.Drawing.Size(26, 22);
            this.Q1Button.Text = "Q1";
            this.Q1Button.Click += new System.EventHandler(this.Q1Button_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // Q2Button
            // 
            this.Q2Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Q2Button.Image = ((System.Drawing.Image)(resources.GetObject("Q2Button.Image")));
            this.Q2Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Q2Button.Name = "Q2Button";
            this.Q2Button.Size = new System.Drawing.Size(26, 22);
            this.Q2Button.Text = "Q2";
            this.Q2Button.Click += new System.EventHandler(this.Q2Button_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // AllButton
            // 
            this.AllButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.AllButton.Image = ((System.Drawing.Image)(resources.GetObject("AllButton.Image")));
            this.AllButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AllButton.Name = "AllButton";
            this.AllButton.Size = new System.Drawing.Size(25, 22);
            this.AllButton.Text = "All";
            this.AllButton.Click += new System.EventHandler(this.AllButton_Click);
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(137, 222);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(99, 46);
            this.OkButton.TabIndex = 2;
            this.OkButton.Text = "Ok";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // DBForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 280);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DBForm";
            this.Text = "DBForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton PreviousButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox PageTextBox;
        private System.Windows.Forms.ToolStripLabel OfLabel;
        private System.Windows.Forms.ToolStripLabel MaxPageLabel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton NextButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton Q1Button;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton Q2Button;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton AllButton;
        private System.Windows.Forms.Button OkButton;
    }
}