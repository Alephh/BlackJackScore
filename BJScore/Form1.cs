using System;
using System.Collections;
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
    public partial class Form1 : Form
    {
        private int LiveCount = 0;
        private int TrueCount = 0;
        private int DecksRemaining = 6;
        private int CardsRemaining = 312;

        private ArrayList HistoryLabels_List;

        public Form1()
        {
            InitializeComponent();
            LiveCount_Label.ForeColor = Color.Green;

            DecksRemaining_Value.Text = "Decks Remaining: " + DecksRemaining;
            CardsRemaining_Value.Text = "Cards Remaining: " + CardsRemaining;

            LiveCount_Update_Button.Enabled = false;

            HistoryLabels_List = new ArrayList();
        }

        private void UpdateLabels()
        {
            LiveCount_Value.Text = "Live Count: " + LiveCount;
            TrueCount_Value.Text = "True Count: " + TrueCount;
            DecksRemaining_Value.Text = "Decks Remaining: " + DecksRemaining;
            CardsRemaining_Value.Text = "Cards Remaining: " + CardsRemaining;
        }

        public void CardButtons_Click(object sender, EventArgs e)
        {
            //LiveCount_Label.Text = "THE TRUE COUNT IS NOT UP TO DATE!";
            //LiveCount_Label.ForeColor = Color.Red;

            Button b = (Button)sender;
            int value = Int32.Parse(b.Tag.ToString());
            LiveCount += value;

            CardsRemaining--;
            if (CardsRemaining % 52 == 0)
                DecksRemaining--;

            TrueCount = LiveCount / DecksRemaining;

            UpdateLabels();

            //Add to history box
            LinkLabel l = new LinkLabel();
            l.Text = b.Text;
            l.Tag = value + "";
            l.Click += new EventHandler(historyObject_Clicked);
            if (CardHistory_Box.Controls.Count > 8)
            {
                foreach (Control c in CardHistory_Box.Controls)//Disgusting
                {
                    CardHistory_Box.Controls.Remove(c);
                    break;
                }
            }
            CardHistory_Box.Controls.Add(l);
        }

        private void LiveCount_Update_Button_Click(object sender, EventArgs e)//Actually updates true count
        {
            TrueCount = LiveCount / DecksRemaining;
            TrueCount_Value.Text = "True Count: " + TrueCount;

            LiveCount_Label.Text = "TRUE COUNT UP TO DATE";
            LiveCount_Label.ForeColor = Color.Green;
        }

        private void NewShoe_Button_Click(object sender, EventArgs e)
        {
            TrueCount = 0;

            LiveCount_Label.Text = "TRUE COUNT UP TO DATE";
            LiveCount_Label.ForeColor = Color.Green;

            LiveCount = 0;
            DecksRemaining = 6;
            CardsRemaining = 312;

            CardHistory_Box.Controls.Clear();

            UpdateLabels();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CardInfo info = new CardInfo();
            info.Show();
        }

        private void historyObject_Clicked(object sender, EventArgs e)
        {
            LinkLabel l = (LinkLabel)sender;
            int value = Int32.Parse(l.Tag.ToString());

            LiveCount -= value;
            if (CardsRemaining % 52 == 0 && DecksRemaining < 6)//TODO might need to be fixed ==============
                DecksRemaining++;
            CardsRemaining++;

            TrueCount = LiveCount / DecksRemaining;

            UpdateLabels();

            CardHistory_Box.Controls.Remove((LinkLabel)sender);
        }

        private void MenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void turnCounterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TurnCounter tc = new TurnCounter();
            tc.Show();
        }

        private void notesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NoteTool nt = new NoteTool();
            nt.Show();
        }

        private void countTrainerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CountTrainer ct = new CountTrainer();
            ct.Show();
        }

        private void strategyChartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StrategyPanel sp = new StrategyPanel();
            sp.Show();
        }

        private void strategyPracticeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StrategyPractice sp = new StrategyPractice();
            sp.Show();
        }
    }

    enum EnumeratedNumber
    {
        ACE = 1,
        TWO = 2,
        THREE = 3,
        FOUR = 4,
        FIVE = 5,
        SIX = 6,
        SEVEN = 7,
        EIGHT = 8,
        NINE = 9,
        TEN = 10
    }
}
