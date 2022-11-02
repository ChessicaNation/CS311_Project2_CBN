namespace CS311_Project2_CBN
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
            this.lblDiceValue1 = new System.Windows.Forms.Label();
            this.lblDiceValue2 = new System.Windows.Forms.Label();
            this.txtEnterBet = new System.Windows.Forms.TextBox();
            this.lblBankBalance = new System.Windows.Forms.Label();
            this.btnRoll = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.picDice = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picDice)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDiceValue1
            // 
            this.lblDiceValue1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDiceValue1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDiceValue1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDiceValue1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDiceValue1.Location = new System.Drawing.Point(208, 306);
            this.lblDiceValue1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDiceValue1.Name = "lblDiceValue1";
            this.lblDiceValue1.Size = new System.Drawing.Size(94, 102);
            this.lblDiceValue1.TabIndex = 0;
            this.lblDiceValue1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDiceValue2
            // 
            this.lblDiceValue2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDiceValue2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDiceValue2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDiceValue2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDiceValue2.Location = new System.Drawing.Point(333, 306);
            this.lblDiceValue2.Margin = new System.Windows.Forms.Padding(0);
            this.lblDiceValue2.Name = "lblDiceValue2";
            this.lblDiceValue2.Size = new System.Drawing.Size(94, 102);
            this.lblDiceValue2.TabIndex = 1;
            this.lblDiceValue2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtEnterBet
            // 
            this.txtEnterBet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEnterBet.Location = new System.Drawing.Point(208, 130);
            this.txtEnterBet.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtEnterBet.Name = "txtEnterBet";
            this.txtEnterBet.Size = new System.Drawing.Size(217, 45);
            this.txtEnterBet.TabIndex = 2;
            this.txtEnterBet.Text = "Enter your bet";
            this.txtEnterBet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblBankBalance
            // 
            this.lblBankBalance.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBankBalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBankBalance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBankBalance.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblBankBalance.Location = new System.Drawing.Point(208, 43);
            this.lblBankBalance.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblBankBalance.Name = "lblBankBalance";
            this.lblBankBalance.Size = new System.Drawing.Size(219, 58);
            this.lblBankBalance.TabIndex = 3;
            this.lblBankBalance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRoll
            // 
            this.btnRoll.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRoll.Location = new System.Drawing.Point(208, 447);
            this.btnRoll.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(220, 62);
            this.btnRoll.TabIndex = 4;
            this.btnRoll.Text = "Roll";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // lblResult
            // 
            this.lblResult.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblResult.Location = new System.Drawing.Point(2, 224);
            this.lblResult.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(652, 52);
            this.lblResult.TabIndex = 5;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picDice
            // 
            this.picDice.Image = global::CS311_Project2_CBN.Properties.Resources.dice_transparent_png_9;
            this.picDice.Location = new System.Drawing.Point(208, 553);
            this.picDice.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.picDice.Name = "picDice";
            this.picDice.Size = new System.Drawing.Size(217, 181);
            this.picDice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDice.TabIndex = 6;
            this.picDice.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 784);
            this.Controls.Add(this.picDice);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnRoll);
            this.Controls.Add(this.lblBankBalance);
            this.Controls.Add(this.txtEnterBet);
            this.Controls.Add(this.lblDiceValue2);
            this.Controls.Add(this.lblDiceValue1);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Craps";
            ((System.ComponentModel.ISupportInitialize)(this.picDice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblDiceValue1;
        private Label lblDiceValue2;
        private TextBox txtEnterBet;
        private Label lblBankBalance;
        private Button btnRoll;
        private Label lblResult;
        private PictureBox picDice;
    }
}