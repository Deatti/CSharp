namespace WarGUI
{
    partial class Betting
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
            this.lblBalance = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numBet = new System.Windows.Forms.NumericUpDown();
            this.cmdBet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numBet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblBalance.Location = new System.Drawing.Point(72, 20);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(107, 13);
            this.lblBalance.TabIndex = 0;
            this.lblBalance.Text = "Balance: $500.00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Current bet:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "$";
            // 
            // numBet
            // 
            this.numBet.Location = new System.Drawing.Point(137, 56);
            this.numBet.Name = "numBet";
            this.numBet.Size = new System.Drawing.Size(72, 21);
            this.numBet.TabIndex = 3;
            this.numBet.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // cmdBet
            // 
            this.cmdBet.Location = new System.Drawing.Point(86, 91);
            this.cmdBet.Name = "cmdBet";
            this.cmdBet.Size = new System.Drawing.Size(93, 25);
            this.cmdBet.TabIndex = 4;
            this.cmdBet.Text = "&Bet";
            this.cmdBet.UseVisualStyleBackColor = true;
            this.cmdBet.Click += new System.EventHandler(this.cmdBet_Click);
            // 
            // Betting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 132);
            this.Controls.Add(this.cmdBet);
            this.Controls.Add(this.numBet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBalance);
            this.Name = "Betting";
            this.Text = "Betting";
            this.Load += new System.EventHandler(this.Betting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numBet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numBet;
        private System.Windows.Forms.Button cmdBet;
    }
}