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
    public partial class zadanieForm10 : Form
    {
        public zadanieForm10()
        {
            InitializeComponent();
            label1.Text = "";
        }

        private void button59_MouseClick(object sender, MouseEventArgs e)
        {
            label1.Text = ((Button)sender).Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Clipboard.SetData(DataFormats.Text, ((Label)sender).Text);

        }
    }
}
