namespace TxtEditor
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
            this.File = new System.Windows.Forms.ToolStrip();
            this.boldButton = new System.Windows.Forms.ToolStripButton();
            this.italicButton = new System.Windows.Forms.ToolStripButton();
            this.underlineButton = new System.Windows.Forms.ToolStripButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.New = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Open = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.File.SuspendLayout();
            this.SuspendLayout();
            // 
            // File
            // 
            this.File.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.boldButton,
            this.italicButton,
            this.underlineButton});
            this.File.Location = new System.Drawing.Point(0, 0);
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(800, 25);
            this.File.TabIndex = 3;
            this.File.Text = "toolStrip1";
            // 
            // boldButton
            // 
            this.boldButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.boldButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.boldButton.Name = "boldButton";
            this.boldButton.Size = new System.Drawing.Size(35, 22);
            this.boldButton.Text = "Bold";
            this.boldButton.Click += new System.EventHandler(this.boldButton_Click);
            // 
            // italicButton
            // 
            this.italicButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.italicButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.italicButton.Name = "italicButton";
            this.italicButton.Size = new System.Drawing.Size(41, 22);
            this.italicButton.Text = "Italics";
            this.italicButton.Click += new System.EventHandler(this.italicButton_Click);
            // 
            // underlineButton
            // 
            this.underlineButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.underlineButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.underlineButton.Name = "underlineButton";
            this.underlineButton.Size = new System.Drawing.Size(62, 22);
            this.underlineButton.Text = "Underline";
            this.underlineButton.Click += new System.EventHandler(this.underlineButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // New
            // 
            this.New.Location = new System.Drawing.Point(13, 359);
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(75, 23);
            this.New.TabIndex = 4;
            this.New.Text = "New";
            this.New.UseVisualStyleBackColor = true;
            this.New.Click += new System.EventHandler(this.New_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(115, 359);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 5;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(217, 359);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(75, 23);
            this.Open.TabIndex = 6;
            this.Open.Text = "Open\r\n";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(13, 29);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(748, 324);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.New);
            this.Controls.Add(this.File);
            this.Name = "Form1";
            this.Text = "Form1";
            this.File.ResumeLayout(false);
            this.File.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip File;
        private System.Windows.Forms.ToolStripButton boldButton;
        private System.Windows.Forms.ToolStripButton italicButton;
        private System.Windows.Forms.ToolStripButton underlineButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button New;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

