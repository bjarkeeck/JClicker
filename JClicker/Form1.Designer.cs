namespace JClicker
{
    partial class JClicker
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblLeftClicks = new System.Windows.Forms.Label();
            this.lblRightClicks = new System.Windows.Forms.Label();
            this.numClickSpeed = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.numDelay = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.checkEnable = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numClickSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDelay)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total left clicls:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total right clicks:";
            // 
            // lblLeftClicks
            // 
            this.lblLeftClicks.AutoSize = true;
            this.lblLeftClicks.Location = new System.Drawing.Point(147, 27);
            this.lblLeftClicks.Name = "lblLeftClicks";
            this.lblLeftClicks.Size = new System.Drawing.Size(13, 13);
            this.lblLeftClicks.TabIndex = 3;
            this.lblLeftClicks.Text = "0";
            // 
            // lblRightClicks
            // 
            this.lblRightClicks.AutoSize = true;
            this.lblRightClicks.Location = new System.Drawing.Point(147, 63);
            this.lblRightClicks.Name = "lblRightClicks";
            this.lblRightClicks.Size = new System.Drawing.Size(13, 13);
            this.lblRightClicks.TabIndex = 4;
            this.lblRightClicks.Text = "0";
            // 
            // numClickSpeed
            // 
            this.numClickSpeed.Location = new System.Drawing.Point(150, 100);
            this.numClickSpeed.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numClickSpeed.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numClickSpeed.Name = "numClickSpeed";
            this.numClickSpeed.Size = new System.Drawing.Size(104, 20);
            this.numClickSpeed.TabIndex = 5;
            this.numClickSpeed.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Delay (ms)";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // numDelay
            // 
            this.numDelay.Location = new System.Drawing.Point(150, 138);
            this.numDelay.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numDelay.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numDelay.Name = "numDelay";
            this.numDelay.Size = new System.Drawing.Size(104, 20);
            this.numDelay.TabIndex = 7;
            this.numDelay.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "ClickSpeed (ms)";
            // 
            // checkEnable
            // 
            this.checkEnable.AutoSize = true;
            this.checkEnable.Checked = true;
            this.checkEnable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkEnable.Location = new System.Drawing.Point(150, 178);
            this.checkEnable.Name = "checkEnable";
            this.checkEnable.Size = new System.Drawing.Size(59, 17);
            this.checkEnable.TabIndex = 9;
            this.checkEnable.Text = "Enable";
            this.checkEnable.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Shortcut (F3)";
            // 
            // JClicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 223);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkEnable);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numDelay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numClickSpeed);
            this.Controls.Add(this.lblRightClicks);
            this.Controls.Add(this.lblLeftClicks);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "JClicker";
            this.Text = "JClicker";
            ((System.ComponentModel.ISupportInitialize)(this.numClickSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDelay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblLeftClicks;
        private System.Windows.Forms.Label lblRightClicks;
        private System.Windows.Forms.NumericUpDown numClickSpeed;
        private System.Windows.Forms.Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.NumericUpDown numDelay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkEnable;
        private System.Windows.Forms.Label label5;
    }
}

