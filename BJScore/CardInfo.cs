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
    public partial class CardInfo : Form
    {
        public CardInfo()
        {
            InitializeComponent();
        }

        private void CardInfo_Load(object sender, EventArgs e)
        {
            LiveCount_Label.Text = "Live Count Values:\n2-6: +1\n7-9: 0\nAce/10/Face: -1\n\n\n\n\n" +
                "The \"True\" count can be calulated like so:\n\n                Live Count\n          _______________\n\n           Decks Remaining";
        }
    }
}
