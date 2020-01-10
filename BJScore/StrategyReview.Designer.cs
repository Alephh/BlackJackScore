namespace BJScore
{
    partial class StrategyReview
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
            this.Dealer_Card = new System.Windows.Forms.PictureBox();
            this.YourCardA = new System.Windows.Forms.PictureBox();
            this.YourCardB = new System.Windows.Forms.PictureBox();
            this.Answer_Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dealer_Card)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YourCardA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YourCardB)).BeginInit();
            this.SuspendLayout();
            // 
            // Dealer_Card
            // 
            this.Dealer_Card.Location = new System.Drawing.Point(89, 12);
            this.Dealer_Card.Name = "Dealer_Card";
            this.Dealer_Card.Size = new System.Drawing.Size(173, 264);
            this.Dealer_Card.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Dealer_Card.TabIndex = 0;
            this.Dealer_Card.TabStop = false;
            // 
            // YourCardA
            // 
            this.YourCardA.Location = new System.Drawing.Point(56, 282);
            this.YourCardA.Name = "YourCardA";
            this.YourCardA.Size = new System.Drawing.Size(173, 264);
            this.YourCardA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.YourCardA.TabIndex = 1;
            this.YourCardA.TabStop = false;
            // 
            // YourCardB
            // 
            this.YourCardB.Location = new System.Drawing.Point(124, 282);
            this.YourCardB.Name = "YourCardB";
            this.YourCardB.Size = new System.Drawing.Size(173, 264);
            this.YourCardB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.YourCardB.TabIndex = 2;
            this.YourCardB.TabStop = false;
            // 
            // Answer_Label
            // 
            this.Answer_Label.AutoSize = true;
            this.Answer_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Answer_Label.Location = new System.Drawing.Point(12, 572);
            this.Answer_Label.Name = "Answer_Label";
            this.Answer_Label.Size = new System.Drawing.Size(209, 29);
            this.Answer_Label.TabIndex = 3;
            this.Answer_Label.Text = "Correct Move: N/A";
            // 
            // StrategyReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 614);
            this.Controls.Add(this.Answer_Label);
            this.Controls.Add(this.YourCardB);
            this.Controls.Add(this.YourCardA);
            this.Controls.Add(this.Dealer_Card);
            this.Name = "StrategyReview";
            this.Text = "StrategyReview";
            this.Load += new System.EventHandler(this.StrategyReview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dealer_Card)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YourCardA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YourCardB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Dealer_Card;
        private System.Windows.Forms.PictureBox YourCardA;
        private System.Windows.Forms.PictureBox YourCardB;
        private System.Windows.Forms.Label Answer_Label;
    }
}