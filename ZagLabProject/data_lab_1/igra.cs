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
    public partial class igra : Form
    {
        Random random = new Random();
        public igra()
        {
            
            InitializeComponent();


            for (int i = 0; i < 42+2; i++) {
                flowLayoutPanel1.Controls.Add(new Button()
                {
                    Text = $"{i.ToString()}",
                    Name = $"btn{i.ToString()}",
                    Size = button1.Size
                }) ;
                flowLayoutPanel1.Controls[$"btn{i.ToString()}"].Click += button1_Click;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < random.Next(Convert.ToInt32(((Button)sender).Name)) -1; i++)
            {
                flowLayoutPanel1.Controls[$"btn{i.ToString()}"].Enabled = false;
            }
        }
    }
}
