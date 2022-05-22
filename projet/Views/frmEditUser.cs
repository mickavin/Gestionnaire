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
    /// <summary>
    /// Classe liée au formulaire frmEditUser1 le formulaire d'ajout, de modification et de suppression d'un personnel. 
    /// </summary>
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

        /// <summary>
        /// Change les informations de la fenêtre frmEditUser1
        /// </summary>
        public void ChangeLabel()
        {
            this.Text = "Ajouter un utilisateur";
            button3.Visible = false;
            button1.Text = "Ajouter l'utilisateur";
        }

        /// <summary>
        /// Réinitialise les informations du formulaire
        /// </summary>
        public void Clear()
        {
            txtFirstName.Text = txtMail.Text = txtName.Text = txtTel.Text = string.Empty;
            idService = idPersonnel = 0;
        }

        /// <summary>
        /// Ferme le formulaire
        /// </summary>
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Supprime un personnel sous confirmation
        /// </summary>
        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Êtes-vous sûre de vouloir supprimer ce personnel ?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                DBPersonnel.SupprimerPersonnel(idPersonnel);
                _parent.getList();
                this.Close();
            }
        }

        /// <summary>
        /// Initialise les informations du formulaire
        /// </summary>
        private void frmEditUser1_Shown(object sender, EventArgs e)
        {
            getList();
            comboBox1.SelectedValue = idService;
        }

        private void frmEditUser1_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Récupère et injecte dans un menu déroulant l'ID et le LIBELLE des motifs
        /// </summary>
        public void getList()
        {
            DBPersonnel.ListeService("SELECT IDSERVICE, NOM FROM service", comboBox1);
        }

        /// <summary>
        /// Initialise les informations du formulaire
        /// </summary>
        public void init()
        {
            txtFirstName.Text = firstName;
            txtName.Text = lastName;
            txtMail.Text = mail;
            txtTel.Text = tel;
        }

        /// <summary>
        /// Event du bouton modifier/ ajouter le personnel. Valide les données avant de les injecter dans la base de données 
        /// </summary>
        /// <param name=sender> </param>
        /// <param name=e> </param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Un service doit être sélectionné.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtFirstName.Text.Length < 3)
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
            if (txtTel.Text.Length < 3)
            {
                MessageBox.Show("Le numéro de téléphone doit contenir plus de 3 caractères.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!txtMail.Text.Contains("@"))
            {
                MessageBox.Show("L'adresse mail doit contenir le symbole @.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            idService = (int)comboBox1.SelectedValue;
            if (button1.Text == "Ajouter l'utilisateur")
            {
                Personnel perso = new Personnel(txtName.Text.Trim(), txtFirstName.Text.Trim(), txtTel.Text.Trim(), txtMail.Text.Trim(), idService);
                DBPersonnel.AjoutPersonnel(perso);
                this.Close();
            }
            if (button1.Text == "Modifier l'utilisateur")
            {
                if (MessageBox.Show("Êtes-vous sûre de vouloir modifier ce personnel ?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    Personnel perso = new Personnel(txtName.Text.Trim(), txtFirstName.Text.Trim(), txtTel.Text.Trim(), txtMail.Text.Trim(), idService);
                    DBPersonnel.ModifPersonnel(perso, idPersonnel);
                    this.Close();
                } else
                {
                    return;
                }
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
