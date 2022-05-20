using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using projet.Models;
using projet.Controllers;

namespace projet.Views
{
    public partial class frmEditUser1 : Form
    {
        private readonly ListUser _parent;
        public string id, firstName, lastName, mail, tel, service;
        public int idService, idPersonnel;
        public frmEditUser1(ListUser parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        public void ChangeLabel()
        {
            this.Text = "Ajouter un utilisateur";
            button3.Visible = false;
            button1.Text = "Ajouter l'utilisateur";
        }

        public void Clear()
        {
            txtFirstName.Text = txtMail.Text = txtName.Text = txtTel.Text = string.Empty;
            idService = idPersonnel = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Êtes-vous sûre de vouloir supprimer ce personnel ?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                DBPersonnel.SupprimerPersonnel(idPersonnel);
                _parent.getList();
                this.Close();
            }
        }

        private void frmEditUser1_Shown(object sender, EventArgs e)
        {
            getList();
            comboBox1.SelectedValue = idService;
        }

        public void getList()
        {
            DBPersonnel.ListeService("SELECT IDSERVICE, NOM FROM service", comboBox1);
        }

        public void init()
        {
            txtFirstName.Text = firstName;
            txtName.Text = lastName;
            txtMail.Text = mail;
            txtTel.Text = tel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            idService = (int)comboBox1.SelectedValue;
            if(txtFirstName.Text.Length < 3)
            {
                MessageBox.Show("Le prénom doit contenir plus de 3 caractères.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtName.Text.Length < 3)
            {
                MessageBox.Show("Le nom doit contenir plus de 3 caractères.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtMail.Text.Length < 3)
            {
                MessageBox.Show("L'adresse mail doit contenir plus de 3 caractères.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!txtMail.Text.Contains("@"))
            {
                MessageBox.Show("L'adresse mail doit contenir le symbole @.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (button1.Text == "Ajouter l'utilisateur")
            {
                Personnel perso = new Personnel(txtName.Text.Trim(), txtFirstName.Text.Trim(), txtTel.Text.Trim(), txtMail.Text.Trim(), idService);
                DBPersonnel.AjoutPersonnel(perso);
            }
            if (button1.Text == "Modifier l'utilisateur")
            {
                Personnel perso = new Personnel(txtName.Text.Trim(), txtFirstName.Text.Trim(), txtTel.Text.Trim(), txtMail.Text.Trim(), idService);
                DBPersonnel.ModifPersonnel(perso, idPersonnel);
            }
            Clear();
            _parent.getList();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmEditUser_Load(object sender, EventArgs e)
        {

        }
    }
}
