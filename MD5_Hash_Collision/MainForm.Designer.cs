namespace MD5_Hash_Collision
{
    partial class MainForm
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
            this.originalFileInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.evilFileInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.resultBox = new System.Windows.Forms.RichTextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // originalFileInput
            // 
            this.originalFileInput.Location = new System.Drawing.Point(215, 63);
            this.originalFileInput.Name = "originalFileInput";
            this.originalFileInput.Size = new System.Drawing.Size(281, 20);
            this.originalFileInput.TabIndex = 5;
            this.originalFileInput.TextChanged += new System.EventHandler(this.OriginalFileInput_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(335, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Good File";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(335, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Evil File";
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.Teal;
            this.startButton.ForeColor = System.Drawing.Color.White;
            this.startButton.Location = new System.Drawing.Point(215, 151);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(281, 73);
            this.startButton.TabIndex = 9;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // evilFileInput
            // 
            this.evilFileInput.Location = new System.Drawing.Point(215, 294);
            this.evilFileInput.Name = "evilFileInput";
            this.evilFileInput.Size = new System.Drawing.Size(281, 20);
            this.evilFileInput.TabIndex = 10;
            this.evilFileInput.TextChanged += new System.EventHandler(this.EvilFileInput_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(335, 482);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Result:";
            // 
            // resultBox
            // 
            this.resultBox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.resultBox.Location = new System.Drawing.Point(86, 498);
            this.resultBox.Name = "resultBox";
            this.resultBox.ReadOnly = true;
            this.resultBox.Size = new System.Drawing.Size(532, 25);
            this.resultBox.TabIndex = 13;
            this.resultBox.Text = "";
            // 
            // progressBar
            // 
            this.progressBar.ForeColor = System.Drawing.Color.Blue;
            this.progressBar.Location = new System.Drawing.Point(195, 420);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(323, 23);
            this.progressBar.TabIndex = 14;
            this.progressBar.Click += new System.EventHandler(this.ProgressBar1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 557);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.evilFileInput);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.originalFileInput);
            this.Name = "MainForm";
            this.Text = "MD5 Hash Collision Demonstration";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox originalFileInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox evilFileInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox resultBox;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}

