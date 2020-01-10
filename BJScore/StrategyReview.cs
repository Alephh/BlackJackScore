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
    public partial class StrategyReview : Form
    {
        Bitmap[] ImageArray;
        StrategyScenario strategyScenario;
        StrategyPractice parent;

        public StrategyReview(StrategyScenario sc, StrategyPractice sp)
        {
            InitializeComponent();
            strategyScenario = sc;
            parent = sp;

            ImageArray = new Bitmap[] {new Bitmap(BJScore.Properties.Resources.Ace), new Bitmap(BJScore.Properties.Resources.Two),
            new Bitmap(BJScore.Properties.Resources.Three), new Bitmap(BJScore.Properties.Resources.Four), new Bitmap(BJScore.Properties.Resources.Five),
            new Bitmap(BJScore.Properties.Resources.Six), new Bitmap(BJScore.Properties.Resources.Seven), new Bitmap(BJScore.Properties.Resources.Eight),
            new Bitmap(BJScore.Properties.Resources.Nine), new Bitmap(BJScore.Properties.Resources.Ten), new Bitmap(BJScore.Properties.Resources.Jack),
            new Bitmap(BJScore.Properties.Resources.King), new Bitmap(BJScore.Properties.Resources.Queen)};
        }

        private void StrategyReview_Load(object sender, EventArgs e)
        {
            Dealer_Card.Image = ImageArray[(int)strategyScenario.DealerCard];
            YourCardA.Image = ImageArray[(int)strategyScenario.CardA];
            YourCardB.Image = ImageArray[(int)strategyScenario.CardB];
            Answer_Label.Text = "Correct Move: " + parent.StringFromAction((int)strategyScenario.Answer);

            switch(strategyScenario.Answer)
            {
                case Action.Hit:
                    Answer_Label.ForeColor = Color.Tan;
                    break;
                case Action.Stay:
                    Answer_Label.ForeColor = Color.Green;
                    break;
                case Action.DoubleDown:
                    Answer_Label.ForeColor = Color.Red;
                    break;
                case Action.Split:
                    Answer_Label.ForeColor = Color.DeepSkyBlue;
                    break;
                default:
                    Answer_Label.ForeColor = Color.Black;
                    break;
            }
        }
    }
}
