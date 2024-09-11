using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS203
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }        

        private void btnBFS_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void btnDFS_Click(object sender, EventArgs e)
        {
            DFS d = new DFS();
            d.Show();
        }

        private void btnUCS_Click(object sender, EventArgs e)
        {
            USC usc = new USC();
            usc.Show();
        }
    }
}
