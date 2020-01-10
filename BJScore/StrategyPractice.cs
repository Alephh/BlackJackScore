using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BJScore
{
    public partial class StrategyPractice : Form
    {
        Bitmap[] ImageArray;
        StrategyScenario[] ScenarioArray;

        StrategyScenario CurrentScenario;
        StrategyScenario PreviousScenario;

        int NCorrect = 0;
        int NTotal = 0;

        Random random = new Random();

        public StrategyPractice()
        {
            InitializeComponent();
            ImageArray = new Bitmap[] {new Bitmap(BJScore.Properties.Resources.Ace), new Bitmap(BJScore.Properties.Resources.Two),
            new Bitmap(BJScore.Properties.Resources.Three), new Bitmap(BJScore.Properties.Resources.Four), new Bitmap(BJScore.Properties.Resources.Five),
            new Bitmap(BJScore.Properties.Resources.Six), new Bitmap(BJScore.Properties.Resources.Seven), new Bitmap(BJScore.Properties.Resources.Eight),
            new Bitmap(BJScore.Properties.Resources.Nine), new Bitmap(BJScore.Properties.Resources.Ten), new Bitmap(BJScore.Properties.Resources.Jack),
            new Bitmap(BJScore.Properties.Resources.King), new Bitmap(BJScore.Properties.Resources.Queen)};

            //ScenarioArray = new StrategyScenario[] { new StrategyScenario(Card.Three, Card.Ace, Card.Seven, Action.DoubleDown) };
            ScenarioArray = TextImport.Read();
            CurrentScenario = ScenarioArray[0];
        }

        public string StringFromAction(int action)
        {
            switch(action)
            {
                case 1:
                    return "Hit";
                case 2:
                    return "Stay";
                case 3:
                    return "Double Down";
                case 4:
                    return "Split";
                default:
                    return "Error";
            }
        }

        private void UpdateText(bool correct)
        {
            if (NTotal == 0)
            {
                Accuracy_Label.Text = "Accuracy: N/A";
                Status_Label.Text = "N/A";
                Status_Label.ForeColor = Color.Black;
                return;
            }
            Accuracy_Label.Text = "Accuracy: " + (((decimal)NCorrect / NTotal) * 100).ToString("#.##") + "%";
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
            Accuracy_Label.Text = "Accuracy: N/A";
            Status_Label.Text = "N/A";
            Status_Label.ForeColor = Color.Black;
        }

        public void ShowRandomScenario()
        {
            CurrentScenario = ScenarioArray[random.Next(ScenarioArray.Length)];
            DealerUp_Image.Image = ImageArray[(int)CurrentScenario.DealerCard];
            YourCardA.Image = ImageArray[(int)CurrentScenario.CardA];
            YourCardB.Image = ImageArray[(int)CurrentScenario.CardB];
        }

        private void StrategyPractice_Load(object sender, EventArgs e)
        {
            Correction_Label.Text = "";
            View_Label.Text = "";
            ShowRandomScenario();
        }

        private void ActionButton_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse((sender as Button).Tag.ToString());
            PreviousScenario = new StrategyScenario(CurrentScenario.DealerCard, CurrentScenario.CardA,
                CurrentScenario.CardB, CurrentScenario.Answer);
            if (id == (int)CurrentScenario.Answer)
            {
                //Correct Answer
                NCorrect++;
                NTotal++;
                UpdateText(true);
                Correction_Label.Text = "";
                View_Label.Text = "";
            } else
            {
                NTotal++;
                UpdateText(false);
                Correction_Label.Text = "Correction: " + StringFromAction((int)CurrentScenario.Answer);
                View_Label.Text = "View";
                View_Label.Tag = "" + CurrentScenario.DealerCard + " " + CurrentScenario.CardA + " " +
                    CurrentScenario.CardB + " " + CurrentScenario.Answer;
            }
            ShowRandomScenario();
        }

        private void Reset_Button_Click(object sender, EventArgs e)
        {
            NCorrect = 0;
            NTotal = 0;
            Correction_Label.Text = "";
            View_Label.Text = "";
            UpdateText();
            ShowRandomScenario();
        }

        private void View_Label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkLabel l = (LinkLabel)sender;
            string[] strings = (l.Tag as String).Split(' ');
            StrategyReview sr = new StrategyReview(new StrategyScenario(PreviousScenario.DealerCard,
                PreviousScenario.CardA, PreviousScenario.CardB, PreviousScenario.Answer), this);
            sr.Show();
        }
    }

    public enum Card
    {
        Ace = 0,
        Two = 1,
        Three = 2,
        Four = 3,
        Five = 4,
        Six = 5,
        Seven = 6,
        Eight = 7,
        Nine = 8,
        Ten = 9,
        Jack = 10,
        Queen = 11,
        King = 12
    }

    public enum Action
    {
        Hit = 1,
        Stay = 2,
        DoubleDown = 3,
        Split = 4
    }

    public class StrategyScenario
    {
        public Card DealerCard { get; set; }
        public Card CardA { get; set; }
        public Card CardB { get; set; }
        public Action Answer { get; set; }

        public StrategyScenario(Card DealerCard, Card CardA, Card CardB, Action Answer)
        {
            this.DealerCard = DealerCard;
            this.CardA = CardA;
            this.CardB = CardB;
            this.Answer = Answer;
        }
    }

    public static class TextImport
    {
        public static StrategyScenario[] Read()
        {
            List<StrategyScenario> strategyScenarios = new List<StrategyScenario>();

            using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("BJScore.Resources.StrategyScenarios.txt"))
            {
                TextReader tr = new StreamReader(stream);
                string whole = tr.ReadToEnd();
                string[] l = whole.Split('\n');
                foreach (string s in l)
                {
                    string[] separated = s.Split(' ');
                    strategyScenarios.Add(new StrategyScenario((Card)Int32.Parse(separated[0]), (Card)Int32.Parse(separated[1]),
                    (Card)Int32.Parse(separated[2]), (Action)Int32.Parse(separated[3])));
                }
            }

            /*
            string[] lines = File.ReadAllLines(Properties.Resources.TestImports);
            foreach (string s in lines)
            {
                string[] separated = s.Split(' ');
                strategyScenarios.Add(new StrategyScenario((Card)Int32.Parse(separated[0]), (Card)Int32.Parse(separated[1]),
                    (Card)Int32.Parse(separated[2]), (Action)Int32.Parse(separated[3])));
            }
            */
            return strategyScenarios.ToArray();
        }
    }
}
