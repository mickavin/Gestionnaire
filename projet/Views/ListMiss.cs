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
    /// <summary>
    /// Classe liée à la fenêtre ListMiss, la fenêtre d'affichage des absences d'un personnel. 
    /// </summary>
    public partial class ListMiss : Form
    {
        frmEditMiss form;
        public int idPersonnel;
        public ListMiss()
        {
            InitializeComponent();
            form = new frmEditMiss(this);
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        /// <summary>
        /// Ouvre le formulaire frmEditMiss pour ajouter une absence
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            frmEditMiss form = new frmEditMiss(this);
            form.idPersonnel = idPersonnel;
            form.ChangeLabel();
            form.ShowDialog();
        }

        /// <summary>
        /// Initialise la liste des absences
        /// </summary>
        public void getList()
        {
            DBAbsence.ListeAbsence("SELECT absence.DATEDEBUT, absence.DATEFIN, absence.IDMOTIF, absence.IDPERSONNEL, motif.LIBELLE FROM absence INNER JOIN motif ON absence.IDMOTIF = motif.IDMOTIF WHERE absence.IDPERSONNEL = " + idPersonnel + ";", dataGridView1);
        }

        /// <summary>
        /// Event qui initialise la liste des absences
        /// </summary>
        private void ListMiss_Shown(object sender, EventArgs e)
        {
            getList();
        }

        /// <summary>
        /// Initialise et ouvre la fenêtre frmEditMiss pour la modification ou la suppression d'une absence sélectionnée.
        /// </summary>
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                form.dateDebut = (DateTime)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                form.dateFin = (DateTime)dataGridView1.Rows[e.RowIndex].Cells[1].Value;
                form.idMotif = (int)dataGridView1.Rows[e.RowIndex].Cells[3].Value;
                form.idPersonnel = idPersonnel;
                form.init();
                form.ShowDialog();
                return;
            }
        }
    }
}
