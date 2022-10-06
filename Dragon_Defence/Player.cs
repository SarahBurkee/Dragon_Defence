using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dragon_Defence
{
    public partial class Player : Form
    {
        public Player()
        {
            InitializeComponent();
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            FormStartup form = new FormStartup();
            form.Show();
            this.Hide();
        }
    }
}
