using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet.Views
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            ListUser page = new ListUser();
            page.ShowDialog();
            this.Close();
        }
        public void Login()
        {
            
        }

        private void Clear()
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListUser page = new ListUser();
            page.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
