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
    public partial class TurnCounter : Form
    {
        int turnCount = 0;

        public TurnCounter()
        {
            InitializeComponent();
        }

        private void TurnCounter_Load(object sender, EventArgs e)
        {

        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            turnCount++;
            Count_Label.Text = turnCount + "";
        }

        private void Reset_Button_Click(object sender, EventArgs e)
        {
            turnCount = 0;
            Count_Label.Text = turnCount + "";
        }
    }
}
