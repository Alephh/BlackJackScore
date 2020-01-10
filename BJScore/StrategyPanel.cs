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
    public partial class StrategyPanel : Form
    {
        public StrategyPanel()
        {
            InitializeComponent();
        }

        private void StrategyPanel_Load(object sender, EventArgs e)
        {
            ImageBox.Image = new Bitmap(BJScore.Properties.Resources.strategy);
        }
    }
}
