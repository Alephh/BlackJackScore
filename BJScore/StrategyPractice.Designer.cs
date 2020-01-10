namespace BJScore
{
    partial class StrategyPractice
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
            this.DealerUp_Image = new System.Windows.Forms.PictureBox();
            this.YourCardA = new System.Windows.Forms.PictureBox();
            this.YourCardB = new System.Windows.Forms.PictureBox();
            this.Hit_Button = new System.Windows.Forms.Button();
            this.Stay_Button = new System.Windows.Forms.Button();
            this.Double_Button = new System.Windows.Forms.Button();
            this.Split_Button = new System.Windows.Forms.Button();
            this.Accuracy_Label = new System.Windows.Forms.Label();
            this.Reset_Button = new System.Windows.Forms.Button();
            this.Status_Label = new System.Windows.Forms.Label();
            this.Correction_Label = new System.Windows.Forms.Label();
            this.View_Label = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.DealerUp_Image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YourCardA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YourCardB)).BeginInit();
            this.SuspendLayout();
            // 
            // DealerUp_Image
            // 
            this.DealerUp_Image.Location = new System.Drawing.Point(221, 12);
            this.DealerUp_Image.Name = "DealerUp_Image";
            this.DealerUp_Image.Size = new System.Drawing.Size(173, 264);
            this.DealerUp_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DealerUp_Image.TabIndex = 0;
            this.DealerUp_Image.TabStop = false;
            // 
            // YourCardA
            // 
            this.YourCardA.Location = new System.Drawing.Point(177, 298);
            this.YourCardA.Name = "YourCardA";
            this.YourCardA.Size = new System.Drawing.Size(173, 264);
            this.YourCardA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.YourCardA.TabIndex = 1;
            this.YourCardA.TabStop = false;
            // 
            // YourCardB
            // 
            this.YourCardB.Location = new System.Drawing.Point(259, 298);
            this.YourCardB.Name = "YourCardB";
            this.YourCardB.Size = new System.Drawing.Size(173, 264);
            this.YourCardB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.YourCardB.TabIndex = 2;
            this.YourCardB.TabStop = false;
            // 
            // Hit_Button
            // 
            this.Hit_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Hit_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hit_Button.Location = new System.Drawing.Point(12, 576);
            this.Hit_Button.Name = "Hit_Button";
            this.Hit_Button.Size = new System.Drawing.Size(231, 122);
            this.Hit_Button.TabIndex = 3;
            this.Hit_Button.Tag = "1";
            this.Hit_Button.Text = "Hit";
            this.Hit_Button.UseVisualStyleBackColor = false;
            this.Hit_Button.Click += new System.EventHandler(this.ActionButton_Click);
            // 
            // Stay_Button
            // 
            this.Stay_Button.BackColor = System.Drawing.Color.PaleGreen;
            this.Stay_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stay_Button.Location = new System.Drawing.Point(377, 576);
            this.Stay_Button.Name = "Stay_Button";
            this.Stay_Button.Size = new System.Drawing.Size(231, 122);
            this.Stay_Button.TabIndex = 4;
            this.Stay_Button.Tag = "2";
            this.Stay_Button.Text = "Stay";
            this.Stay_Button.UseVisualStyleBackColor = false;
            this.Stay_Button.Click += new System.EventHandler(this.ActionButton_Click);
            // 
            // Double_Button
            // 
            this.Double_Button.BackColor = System.Drawing.Color.Red;
            this.Double_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Double_Button.Location = new System.Drawing.Point(249, 576);
            this.Double_Button.Name = "Double_Button";
            this.Double_Button.Size = new System.Drawing.Size(122, 59);
            this.Double_Button.TabIndex = 5;
            this.Double_Button.Tag = "3";
            this.Double_Button.Text = "Double Down";
            this.Double_Button.UseVisualStyleBackColor = false;
            this.Double_Button.Click += new System.EventHandler(this.ActionButton_Click);
            // 
            // Split_Button
            // 
            this.Split_Button.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Split_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Split_Button.Location = new System.Drawing.Point(249, 639);
            this.Split_Button.Name = "Split_Button";
            this.Split_Button.Size = new System.Drawing.Size(122, 59);
            this.Split_Button.TabIndex = 6;
            this.Split_Button.Tag = "4";
            this.Split_Button.Text = "Split";
            this.Split_Button.UseVisualStyleBackColor = false;
            this.Split_Button.Click += new System.EventHandler(this.ActionButton_Click);
            // 
            // Accuracy_Label
            // 
            this.Accuracy_Label.AutoSize = true;
            this.Accuracy_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Accuracy_Label.Location = new System.Drawing.Point(12, 9);
            this.Accuracy_Label.Name = "Accuracy_Label";
            this.Accuracy_Label.Size = new System.Drawing.Size(148, 25);
            this.Accuracy_Label.TabIndex = 7;
            this.Accuracy_Label.Text = "Accuracy: N/A";
            // 
            // Reset_Button
            // 
            this.Reset_Button.BackColor = System.Drawing.Color.Red;
            this.Reset_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset_Button.Location = new System.Drawing.Point(17, 38);
            this.Reset_Button.Name = "Reset_Button";
            this.Reset_Button.Size = new System.Drawing.Size(143, 27);
            this.Reset_Button.TabIndex = 8;
            this.Reset_Button.Text = "Reset";
            this.Reset_Button.UseVisualStyleBackColor = false;
            this.Reset_Button.Click += new System.EventHandler(this.Reset_Button_Click);
            // 
            // Status_Label
            // 
            this.Status_Label.AutoSize = true;
            this.Status_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status_Label.Location = new System.Drawing.Point(482, 9);
            this.Status_Label.Name = "Status_Label";
            this.Status_Label.Size = new System.Drawing.Size(47, 25);
            this.Status_Label.TabIndex = 9;
            this.Status_Label.Text = "N/A";
            // 
            // Correction_Label
            // 
            this.Correction_Label.AutoSize = true;
            this.Correction_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Correction_Label.Location = new System.Drawing.Point(463, 43);
            this.Correction_Label.Name = "Correction_Label";
            this.Correction_Label.Size = new System.Drawing.Size(91, 16);
            this.Correction_Label.TabIndex = 10;
            this.Correction_Label.Text = "Correction: Hit";
            // 
            // View_Label
            // 
            this.View_Label.AutoSize = true;
            this.View_Label.Location = new System.Drawing.Point(513, 59);
            this.View_Label.Name = "View_Label";
            this.View_Label.Size = new System.Drawing.Size(30, 13);
            this.View_Label.TabIndex = 11;
            this.View_Label.TabStop = true;
            this.View_Label.Text = "View";
            this.View_Label.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.View_Label_LinkClicked);
            // 
            // StrategyPractice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 708);
            this.Controls.Add(this.View_Label);
            this.Controls.Add(this.Correction_Label);
            this.Controls.Add(this.Status_Label);
            this.Controls.Add(this.Reset_Button);
            this.Controls.Add(this.Accuracy_Label);
            this.Controls.Add(this.Split_Button);
            this.Controls.Add(this.Double_Button);
            this.Controls.Add(this.Stay_Button);
            this.Controls.Add(this.Hit_Button);
            this.Controls.Add(this.YourCardB);
            this.Controls.Add(this.YourCardA);
            this.Controls.Add(this.DealerUp_Image);
            this.Name = "StrategyPractice";
            this.Text = "Strategy Practice";
            this.Load += new System.EventHandler(this.StrategyPractice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DealerUp_Image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YourCardA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YourCardB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox DealerUp_Image;
        private System.Windows.Forms.PictureBox YourCardA;
        private System.Windows.Forms.PictureBox YourCardB;
        private System.Windows.Forms.Button Hit_Button;
        private System.Windows.Forms.Button Stay_Button;
        private System.Windows.Forms.Button Double_Button;
        private System.Windows.Forms.Button Split_Button;
        private System.Windows.Forms.Label Accuracy_Label;
        private System.Windows.Forms.Button Reset_Button;
        private System.Windows.Forms.Label Status_Label;
        private System.Windows.Forms.Label Correction_Label;
        private System.Windows.Forms.LinkLabel View_Label;
    }
}