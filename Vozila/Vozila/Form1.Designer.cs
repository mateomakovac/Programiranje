namespace Vozila
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
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtKotaci = new System.Windows.Forms.TextBox();
            this.txtGodina = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtIspis = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(178, 70);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(193, 20);
            this.txtModel.TabIndex = 0;
            // 
            // txtKotaci
            // 
            this.txtKotaci.Location = new System.Drawing.Point(178, 157);
            this.txtKotaci.Name = "txtKotaci";
            this.txtKotaci.Size = new System.Drawing.Size(193, 20);
            this.txtKotaci.TabIndex = 1;
            // 
            // txtGodina
            // 
            this.txtGodina.Location = new System.Drawing.Point(178, 113);
            this.txtGodina.Name = "txtGodina";
            this.txtGodina.Size = new System.Drawing.Size(193, 20);
            this.txtGodina.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Model";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Godina";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kotaci";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(428, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Unesi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(428, 108);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Ispisi";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtIspis
            // 
            this.txtIspis.Location = new System.Drawing.Point(428, 175);
            this.txtIspis.Name = "txtIspis";
            this.txtIspis.Size = new System.Drawing.Size(325, 149);
            this.txtIspis.TabIndex = 8;
            this.txtIspis.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtIspis);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGodina);
            this.Controls.Add(this.txtKotaci);
            this.Controls.Add(this.txtModel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtKotaci;
        private System.Windows.Forms.TextBox txtGodina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox txtIspis;
    }
}

