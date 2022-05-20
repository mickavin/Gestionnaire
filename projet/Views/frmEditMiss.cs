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
    /// Classe liée au formulaire frmEditMiss le formulaire d'ajout, de modification et de suppression d'une absence. 
    /// </summary>
    public partial class frmEditMiss : Form
    {
        private readonly ListMiss _parent;
        public DateTime dateDebut, dateFin;
        public int idMotif, idPersonnel;
        public frmEditMiss(ListMiss parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        /// <summary>
        /// Initialise les dates du formulaire
        /// </summary>
        public void init()
        {
            dateTimePicker1.Value = dateDebut; 
            dateTimePicker2.Value = dateFin;
        }

        /// <summary>
        /// Supprime une absence sous confirmation
        /// </summary>
        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Êtes-vous sûre de vouloir supprimer cette absence ?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                DBAbsence.SupprimerAbsence(idPersonnel, dateDebut);
                _parent.getList();
                this.Close();
            }
        }

        /// <summary>
        /// Initialise les informations du formulaire
        /// </summary>
        private void frmEditMiss_Shown(object sender, EventArgs e)
        {
            getList();
            comboBox1.SelectedValue = idMotif;
        }

        /// <summary>
        /// Récupère et injecte dans un menu déroulant l'ID et le LIBELLE des motifs
        /// </summary>
        public void getList()
        {
            DBAbsence.ListeMotif("SELECT IDMOTIF, LIBELLE FROM motif", comboBox1);
        }

        /// <summary>
        /// Change les informations de la fenêtre frmEditMiss
        /// </summary>
        public void ChangeLabel()
        {
            this.Text = "Ajouter une absence";
            button2.Visible = false;
            button1.Text = "Ajouter l'absence";
        }
        /// <summary>
        /// Event du bouton modifier/ ajouter l'absence. Valide les données avant de les injecter dans la base de données 
        /// </summary>
        /// <param name=sender> </param>
        /// <param name=e> </param>
        private void button1_Click(object sender, EventArgs e)
        {
            int result = DateTime.Compare(dateTimePicker1.Value, dateTimePicker2.Value);
            if (result >=0)
            {
                MessageBox.Show("La date de début doit être strictement inférieur à la date de fin.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Un motif doit être sélectionné.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            idMotif = (int)comboBox1.SelectedValue;
            if (button1.Text == "Ajouter l'absence")
            {
                Absence absence = new Absence(dateTimePicker1.Value, dateTimePicker2.Value, idMotif,idPersonnel);
                DBAbsence.AjoutAbsence(absence);
                _parent.getList();
            }
            if (button1.Text == "Modifier l'absence")
            {
                if (MessageBox.Show("Êtes-vous sûre de vouloir modifier cette absence ?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    Absence absence = new Absence(dateTimePicker1.Value, dateTimePicker2.Value, idMotif, idPersonnel);
                    DBAbsence.ModifAbsence(absence, idPersonnel, dateDebut);
                    _parent.getList();
                }
                else
                {
                    return;
                }
            }
            _parent.getList();
        }
      

    }
}
