using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using projet.Controllers;

namespace projet.Views
{
    public partial class ListUser : Form
    {
        frmEditUser1 form;
        public ListUser()
        {
            InitializeComponent();
            form = new frmEditUser1(this);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if(e.ColumnIndex == 7)
            {
                form.Clear();
                form.id = dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                form.firstName = dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                form.lastName = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                form.tel = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                form.mail = dataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                form.idService = (int)dataGridView.Rows[e.RowIndex].Cells[6].Value;
                form.idPersonnel = (int)dataGridView.Rows[e.RowIndex].Cells[0].Value;
                form.init();
                form.ShowDialog();
                return;
            }
            if(e.ColumnIndex == 1)
            {

            }
        }

        public void getList()
        {
            DBPersonnel.ListePersonnel("SELECT personnel.IDPERSONNEL, personnel.IDSERVICE, personnel.NOM, personnel.PRENOM, personnel.TEL, personnel.MAIL, service.IDSERVICE AS IDSERV, service.NOM AS NOMSERV FROM personnel INNER JOIN service ON personnel.IDSERVICE = service.IDSERVICE;", dataGridView);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmEditUser1 form = new frmEditUser1(this);
            form.Clear();
            form.ChangeLabel();
            form.ShowDialog();
        }

        private void ListUser_Shown(object sender, EventArgs e)
        {
            getList();
        }

        private void ListUser_Load(object sender, EventArgs e)
        {


        }
    }
}
