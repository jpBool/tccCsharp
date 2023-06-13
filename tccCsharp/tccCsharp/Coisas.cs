using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tccCsharp
{
    public partial class Coisas : Form
    {
        public Coisas()
        {
            InitializeComponent();
        }

        private void Coisas_Load(object sender, EventArgs e)
        {

        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            roundButton1.Text = Convert.ToString(Convert.ToInt32(roundButton1.Text) + 1);
        }

        private void roundButton1_MouseEnter(object sender, EventArgs e)
        {
            roundButton1.BorderColor = Color.Green;
        }

        private void roundButton1_MouseLeave(object sender, EventArgs e)
        {
            roundButton1.BorderColor = Color.Black;
        }
    }
}
