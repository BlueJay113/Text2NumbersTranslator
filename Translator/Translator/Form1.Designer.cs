namespace Translator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.translateNumbers = new System.Windows.Forms.Button();
            this.translateText = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(800, 397);
            this.textBox1.TabIndex = 0;
            // 
            // translateNumbers
            // 
            this.translateNumbers.Location = new System.Drawing.Point(195, 416);
            this.translateNumbers.Name = "translateNumbers";
            this.translateNumbers.Size = new System.Drawing.Size(189, 35);
            this.translateNumbers.TabIndex = 2;
            this.translateNumbers.Text = "Translate to Numbers";
            this.translateNumbers.UseVisualStyleBackColor = true;
            this.translateNumbers.Click += new System.EventHandler(this.translateButton_Click);
            // 
            // translateText
            // 
            this.translateText.Location = new System.Drawing.Point(395, 416);
            this.translateText.Name = "translateText";
            this.translateText.Size = new System.Drawing.Size(163, 35);
            this.translateText.TabIndex = 3;
            this.translateText.Text = "Translate to Text";
            this.translateText.UseVisualStyleBackColor = true;
            this.translateText.Click += new System.EventHandler(this.translateText_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 400);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(710, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Replace numbers (in integers) to names for it to translate properly. Capitalisati" +
    "on will be lost.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(564, 444);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Translator by BlueJaySoftware";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.translateText);
            this.Controls.Add(this.translateNumbers);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(822, 506);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(822, 506);
            this.Name = "Form1";
            this.Text = "Translator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button translateNumbers;
        private System.Windows.Forms.Button translateText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

