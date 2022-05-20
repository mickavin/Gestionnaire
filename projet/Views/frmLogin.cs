using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using projet.Models;
using projet.Controllers;

namespace projet.Views
{
    /// <summary>
    /// Classe liée au formulaire frmLogin le formulaire d'ajout et d'authentification d'un responsable. 
    /// </summary>
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

        /// <summary>
        /// Event du bouton Se connecter. Valide les données avant d'authentifié l'utilisateur
        /// </summary>
        /// <param name=sender> </param>
        /// <param name=e> </param>
        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtusername.Text.Length < 3)
            {
                MessageBox.Show("Le nom d'utilisateur doit contenir plus de 3 caractères.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtpassword.Text.Length < 6)
            {
                MessageBox.Show("Le mot de passe doit contenir plus de 6 caractères.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Responsable responsable = new Responsable(txtusername.Text, txtpassword.Text);


            if (DBResponsable.GetResponsable(responsable))
            {
                ListUser page = new ListUser();
                page.ShowDialog();
                this.Close();
                return;
            }
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        /// <summary>
        /// Ferme le formulaire
        /// </summary>
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Event du bouton S'inscrire. Valide les données avant de les injecter dans la base de données 
        /// </summary>
        /// <param name=sender> </param>
        /// <param name=e> </param>
        private void linkregister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (txtusername.Text.Length < 3)
            {
                MessageBox.Show("Le nom d'utilisateur doit contenir plus de 3 caractères.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtpassword.Text.Length < 6)
            {
                MessageBox.Show("Le mot de passe doit contenir plus de 6 caractères.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Responsable responsable = new Responsable(txtusername.Text, txtpassword.Text);
            DBResponsable.AjoutResponsable(responsable);

        }
    }
}
