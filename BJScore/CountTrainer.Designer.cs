namespace BJScore
{
    partial class CountTrainer
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
            this.CardBox = new System.Windows.Forms.PictureBox();
            this.Minus_Button = new System.Windows.Forms.Button();
            this.Zero_Button = new System.Windows.Forms.Button();
            this.Plus_Button = new System.Windows.Forms.Button();
            this.Accuracy_Label = new System.Windows.Forms.Label();
            this.Reset_Button = new System.Windows.Forms.Button();
            this.Status_Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CardBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CardBox
            // 
            this.CardBox.Location = new System.Drawing.Point(91, 98);
            this.CardBox.Name = "CardBox";
            this.CardBox.Size = new System.Drawing.Size(173, 264);
            this.CardBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CardBox.TabIndex = 0;
            this.CardBox.TabStop = false;
            // 
            // Minus_Button
            // 
            this.Minus_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minus_Button.Location = new System.Drawing.Point(29, 368);
            this.Minus_Button.Name = "Minus_Button";
            this.Minus_Button.Size = new System.Drawing.Size(95, 190);
            this.Minus_Button.TabIndex = 1;
            this.Minus_Button.Tag = "-1";
            this.Minus_Button.Text = "-1";
            this.Minus_Button.UseVisualStyleBackColor = true;
            this.Minus_Button.Click += new System.EventHandler(this.ScoreButton_Click);
            // 
            // Zero_Button
            // 
            this.Zero_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Zero_Button.Location = new System.Drawing.Point(130, 368);
            this.Zero_Button.Name = "Zero_Button";
            this.Zero_Button.Size = new System.Drawing.Size(95, 190);
            this.Zero_Button.TabIndex = 2;
            this.Zero_Button.Tag = "0";
            this.Zero_Button.Text = "0";
            this.Zero_Button.UseVisualStyleBackColor = true;
            this.Zero_Button.Click += new System.EventHandler(this.ScoreButton_Click);
            // 
            // Plus_Button
            // 
            this.Plus_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Plus_Button.Location = new System.Drawing.Point(231, 368);
            this.Plus_Button.Name = "Plus_Button";
            this.Plus_Button.Size = new System.Drawing.Size(95, 190);
            this.Plus_Button.TabIndex = 3;
            this.Plus_Button.Tag = "1";
            this.Plus_Button.Text = "+1";
            this.Plus_Button.UseVisualStyleBackColor = true;
            this.Plus_Button.Click += new System.EventHandler(this.ScoreButton_Click);
            // 
            // Accuracy_Label
            // 
            this.Accuracy_Label.AutoSize = true;
            this.Accuracy_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Accuracy_Label.Location = new System.Drawing.Point(68, 9);
            this.Accuracy_Label.Name = "Accuracy_Label";
            this.Accuracy_Label.Size = new System.Drawing.Size(222, 37);
            this.Accuracy_Label.TabIndex = 5;
            this.Accuracy_Label.Text = "Accuracy: N/A";
            // 
            // Reset_Button
            // 
            this.Reset_Button.BackColor = System.Drawing.Color.Red;
            this.Reset_Button.Location = new System.Drawing.Point(75, 49);
            this.Reset_Button.Name = "Reset_Button";
            this.Reset_Button.Size = new System.Drawing.Size(200, 27);
            this.Reset_Button.TabIndex = 6;
            this.Reset_Button.Text = "Reset";
            this.Reset_Button.UseVisualStyleBackColor = false;
            this.Reset_Button.Click += new System.EventHandler(this.Reset_Button_Click);
            // 
            // Status_Label
            // 
            this.Status_Label.AutoSize = true;
            this.Status_Label.Location = new System.Drawing.Point(156, 79);
            this.Status_Label.Name = "Status_Label";
            this.Status_Label.Size = new System.Drawing.Size(27, 13);
            this.Status_Label.TabIndex = 7;
            this.Status_Label.Text = "N/A";
            // 
            // CountTrainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 576);
            this.Controls.Add(this.Status_Label);
            this.Controls.Add(this.Reset_Button);
            this.Controls.Add(this.Accuracy_Label);
            this.Controls.Add(this.Plus_Button);
            this.Controls.Add(this.Zero_Button);
            this.Controls.Add(this.Minus_Button);
            this.Controls.Add(this.CardBox);
            this.Name = "CountTrainer";
            this.Text = "CountTrainer";
            this.Load += new System.EventHandler(this.CountTrainer_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CountTrainer_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.CardBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox CardBox;
        private System.Windows.Forms.Button Minus_Button;
        private System.Windows.Forms.Button Zero_Button;
        private System.Windows.Forms.Button Plus_Button;
        private System.Windows.Forms.Label Accuracy_Label;
        private System.Windows.Forms.Button Reset_Button;
        private System.Windows.Forms.Label Status_Label;
    }
}