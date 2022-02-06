using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZagLabProject.data
{
    public partial class zadanieForm8 : Form
    {
        public String Text;
        public zadanieForm8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            this.BackColor = Color.Orange;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            label1.Visible = false;
        }
    }
}
