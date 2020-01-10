using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BJScore
{
    public partial class CountTrainer : Form
    {
        private Bitmap[] ImageArray;
        private Random random = new Random();
        private int NCorrect = 0;
        private int NTotal = 0;
        private int cIID = 0;

        public CountTrainer()
        {
            InitializeComponent();
            ImageArray = new Bitmap[] {new Bitmap(BJScore.Properties.Resources.Ace), new Bitmap(BJScore.Properties.Resources.Two),
            new Bitmap(BJScore.Properties.Resources.Three), new Bitmap(BJScore.Properties.Resources.Four), new Bitmap(BJScore.Properties.Resources.Five),
            new Bitmap(BJScore.Properties.Resources.Six), new Bitmap(BJScore.Properties.Resources.Seven), new Bitmap(BJScore.Properties.Resources.Eight),
            new Bitmap(BJScore.Properties.Resources.Nine), new Bitmap(BJScore.Properties.Resources.Ten), new Bitmap(BJScore.Properties.Resources.Jack),
            new Bitmap(BJScore.Properties.Resources.King), new Bitmap(BJScore.Properties.Resources.Queen)};
        }

        private int GetCurrentCountScore()
        {
            if (cIID >= 1 && cIID <= 5)
                return 1;
            else if (cIID >= 6 && cIID <= 8)
                return 0;
            else
                return -1;
        }

        private void SetStatus(bool correct)
        {
            if (correct)
            {
                Status_Label.Text = "Correct";
                Status_Label.ForeColor = Color.Green;
            } else
            {
                Status_Label.Text = "Incorrect";
                Status_Label.ForeColor = Color.Red;
            }
        }

        private void UpdateText()
        {
            if (NTotal == 0)
            {
                Status_Label.Text = "N/A";
                Status_Label.ForeColor = Color.Black;
                Accuracy_Label.Text = "Accuracy: N/A";
                return;
            }
            Accuracy_Label.Text = "Accuracy: " + (((decimal)NCorrect / NTotal) * 100).ToString("#.##") + "%";
        }

        private void ShowRandomCard()
        {
            int rInt = random.Next(13);
            CardBox.Image = ImageArray[rInt];
            cIID = rInt;
        }

        private void CountTrainer_Load(object sender, EventArgs e)
        {
            ShowRandomCard();
        }

        private void ScoreButton_Click(object sender, EventArgs e)
        {
            if (GetCurrentCountScore() == Int32.Parse((sender as Button).Tag.ToString()))
            {
                NCorrect++;
                SetStatus(true);
            }
            else
                SetStatus(false);
            NTotal++;
            UpdateText();
            ShowRandomCard();
        }

        private void Reset_Button_Click(object sender, EventArgs e)
        {
            NCorrect = 0;
            NTotal = 0;
            UpdateText();
            ShowRandomCard();
        }

        private void CountTrainer_KeyPress(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show("Yeet");
        }
    }
}
