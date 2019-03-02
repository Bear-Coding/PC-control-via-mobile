namespace PCcontroller_PC
{
    partial class Main
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
            this.btnListen = new System.Windows.Forms.Button();
            this.btnStopListening = new System.Windows.Forms.Button();
            this.lblStats = new System.Windows.Forms.Label();
            this.lblcmd = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnListen
            // 
            this.btnListen.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListen.Location = new System.Drawing.Point(82, 254);
            this.btnListen.Name = "btnListen";
            this.btnListen.Size = new System.Drawing.Size(209, 176);
            this.btnListen.TabIndex = 0;
            this.btnListen.Text = "Listen";
            this.btnListen.UseVisualStyleBackColor = true;
            this.btnListen.Click += new System.EventHandler(this.btnListen_Click);
            // 
            // btnStopListening
            // 
            this.btnStopListening.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStopListening.Location = new System.Drawing.Point(329, 254);
            this.btnStopListening.Name = "btnStopListening";
            this.btnStopListening.Size = new System.Drawing.Size(230, 176);
            this.btnStopListening.TabIndex = 1;
            this.btnStopListening.Text = "Stop listening";
            this.btnStopListening.UseVisualStyleBackColor = true;
            this.btnStopListening.Click += new System.EventHandler(this.btnStopListening_Click);
            // 
            // lblStats
            // 
            this.lblStats.AutoSize = true;
            this.lblStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStats.ForeColor = System.Drawing.Color.Red;
            this.lblStats.Location = new System.Drawing.Point(191, 445);
            this.lblStats.Name = "lblStats";
            this.lblStats.Size = new System.Drawing.Size(221, 37);
            this.lblStats.TabIndex = 2;
            this.lblStats.Text = "Not listening...";
            // 
            // lblcmd
            // 
            this.lblcmd.AutoSize = true;
            this.lblcmd.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcmd.ForeColor = System.Drawing.Color.Yellow;
            this.lblcmd.Location = new System.Drawing.Point(12, 189);
            this.lblcmd.Name = "lblcmd";
            this.lblcmd.Size = new System.Drawing.Size(154, 29);
            this.lblcmd.TabIndex = 3;
            this.lblcmd.Text = "No CMDs yet";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 46F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(118, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 71);
            this.label1.TabIndex = 4;
            this.label1.Text = "PC controller";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(675, 500);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblcmd);
            this.Controls.Add(this.lblStats);
            this.Controls.Add(this.btnStopListening);
            this.Controls.Add(this.btnListen);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Text = "PC Control Reciever";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListen;
        private System.Windows.Forms.Button btnStopListening;
        private System.Windows.Forms.Label lblStats;
        private System.Windows.Forms.Label lblcmd;
        private System.Windows.Forms.Label label1;
    }
}