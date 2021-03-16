namespace Craps
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Panel();
            this.errorLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.output = new System.Windows.Forms.Panel();
            this.textFileButton = new System.Windows.Forms.Button();
            this.equalLossLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.totalSim = new System.Windows.Forms.Label();
            this.dPasserTLabel = new System.Windows.Forms.Label();
            this.passerTLabel = new System.Windows.Forms.Label();
            this.retryButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.start.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.output.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(356, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(18, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(97, 370);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(27, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(331, 52);
            this.panel2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Broadway", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(320, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Craps Simulation";
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.DimGray;
            this.start.Controls.Add(this.errorLabel);
            this.start.Controls.Add(this.submitButton);
            this.start.Controls.Add(this.numericUpDown1);
            this.start.Controls.Add(this.label1);
            this.start.Location = new System.Drawing.Point(121, 105);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(419, 277);
            this.start.TabIndex = 4;
            // 
            // errorLabel
            // 
            this.errorLabel.AllowDrop = true;
            this.errorLabel.AutoSize = true;
            this.errorLabel.BackColor = System.Drawing.Color.Black;
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(62, 163);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(304, 19);
            this.errorLabel.TabIndex = 3;
            this.errorLabel.Text = "Error: Input Value Greater Than 0";
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.submitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.submitButton.Location = new System.Drawing.Point(104, 108);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(207, 31);
            this.submitButton.TabIndex = 2;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.numericUpDown1.Location = new System.Drawing.Point(140, 56);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of Simulations";
            // 
            // output
            // 
            this.output.BackColor = System.Drawing.Color.DimGray;
            this.output.Controls.Add(this.textFileButton);
            this.output.Controls.Add(this.equalLossLabel);
            this.output.Controls.Add(this.label7);
            this.output.Controls.Add(this.totalSim);
            this.output.Controls.Add(this.dPasserTLabel);
            this.output.Controls.Add(this.passerTLabel);
            this.output.Controls.Add(this.retryButton);
            this.output.Controls.Add(this.label6);
            this.output.Controls.Add(this.label5);
            this.output.Controls.Add(this.label4);
            this.output.Controls.Add(this.label3);
            this.output.Location = new System.Drawing.Point(121, 105);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(448, 277);
            this.output.TabIndex = 4;
            // 
            // textFileButton
            // 
            this.textFileButton.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.textFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.textFileButton.Location = new System.Drawing.Point(266, 238);
            this.textFileButton.Name = "textFileButton";
            this.textFileButton.Size = new System.Drawing.Size(170, 30);
            this.textFileButton.TabIndex = 15;
            this.textFileButton.Text = "View Text File";
            this.textFileButton.UseVisualStyleBackColor = false;
            this.textFileButton.Click += new System.EventHandler(this.textFileButton_Click);
            // 
            // equalLossLabel
            // 
            this.equalLossLabel.AutoSize = true;
            this.equalLossLabel.Location = new System.Drawing.Point(231, 121);
            this.equalLossLabel.Name = "equalLossLabel";
            this.equalLossLabel.Size = new System.Drawing.Size(33, 19);
            this.equalLossLabel.TabIndex = 13;
            this.equalLossLabel.Text = "NA";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(19, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "Equal Loss:";
            // 
            // totalSim
            // 
            this.totalSim.AutoSize = true;
            this.totalSim.Location = new System.Drawing.Point(231, 169);
            this.totalSim.Name = "totalSim";
            this.totalSim.Size = new System.Drawing.Size(33, 19);
            this.totalSim.TabIndex = 7;
            this.totalSim.Text = "NA";
            // 
            // dPasserTLabel
            // 
            this.dPasserTLabel.AutoSize = true;
            this.dPasserTLabel.Location = new System.Drawing.Point(231, 89);
            this.dPasserTLabel.Name = "dPasserTLabel";
            this.dPasserTLabel.Size = new System.Drawing.Size(33, 19);
            this.dPasserTLabel.TabIndex = 6;
            this.dPasserTLabel.Text = "NA";
            // 
            // passerTLabel
            // 
            this.passerTLabel.AutoSize = true;
            this.passerTLabel.Location = new System.Drawing.Point(231, 61);
            this.passerTLabel.Name = "passerTLabel";
            this.passerTLabel.Size = new System.Drawing.Size(33, 19);
            this.passerTLabel.TabIndex = 5;
            this.passerTLabel.Text = "NA";
            // 
            // retryButton
            // 
            this.retryButton.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.retryButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.retryButton.Location = new System.Drawing.Point(7, 238);
            this.retryButton.Name = "retryButton";
            this.retryButton.Size = new System.Drawing.Size(170, 30);
            this.retryButton.TabIndex = 4;
            this.retryButton.Text = "Retry";
            this.retryButton.UseVisualStyleBackColor = false;
            this.retryButton.Click += new System.EventHandler(this.retryButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(19, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 19);
            this.label6.TabIndex = 3;
            this.label6.Text = "Total:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(19, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "Don\'t Passer Wins:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(18, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Passer Wins:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Broadway", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(18, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Output Wins";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Broadway", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(531, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 15);
            this.label8.TabIndex = 5;
            this.label8.Text = "GeolUread";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(625, 401);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.output);
            this.Controls.Add(this.start);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "Form1";
            this.Text = "Craps Simulation";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.start.ResumeLayout(false);
            this.start.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.output.ResumeLayout(false);
            this.output.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Panel output;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button retryButton;
        private System.Windows.Forms.Label totalSim;
        private System.Windows.Forms.Label dPasserTLabel;
        private System.Windows.Forms.Label passerTLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label equalLossLabel;
        private System.Windows.Forms.Button textFileButton;
        private System.Windows.Forms.Label label8;
    }
}

