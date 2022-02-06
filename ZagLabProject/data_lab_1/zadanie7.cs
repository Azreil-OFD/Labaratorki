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
    public partial class zadanie7 : Form
    {
        String defolt;
        public zadanie7()
        {
            InitializeComponent();
            defolt = "Ы";
        }
        public zadanie7(string s)
        {
            InitializeComponent();
            defolt = s;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Text = defolt;
        }
    }
}
