using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using projet.Models;
using System.Data;

namespace projet.Controllers
{
    /// <summary>
    ///  Classe de connexion à la base de données pour la table Absence et motif d'absences
    /// </summary>
    class DBAbsence
    {
        /// <summary>
        /// Méthode qui initialise la connexion à la base de données
        /// </summary>
        public static MySqlConnection GetConnection()
        {
            string sql = "datasource=localhost;port=3306;username=root;password=;database=gestionnaire";
            MySqlConnection connexion = new MySqlConnection(sql);
            try
            {
                connexion.Open();
            }
            catch (MySqlException exception)
            {
                MessageBox.Show(exception.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return connexion;
        }

        /// <summary>
        /// Une méthode qui ajoute une absence dans la base de données
        /// </summary>
        /// <param name=absence> Une instance de Absence</param>
        public static void AjoutAbsence(Absence absence)
        {
            string sql = "INSERT INTO absence VALUES (@PersonnelID, @DateDebut, @MotifID, @DateFin)";
            MySqlConnection connexion = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, connexion);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@PersonnelID", MySqlDbType.Int32).Value = absence.PersonnelID;
            cmd.Parameters.Add("@DateDebut", MySqlDbType.DateTime).Value = absence.DateDebut;
            cmd.Parameters.Add("@MotifID", MySqlDbType.Int32).Value = absence.MotifID;
            cmd.Parameters.Add("@DateFin", MySqlDbType.DateTime).Value = absence.DateFin;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("L'absence a bien été ajoutée.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            connexion.Close();
        }

        /// <summary>
        /// Une méthode qui modifie une absence dans la base de données
        /// </summary>
        /// <param name=absence> Une instance de Absence</param>
        /// <param name=id> ID de l'absence a modifié</param>
        /// <param name=date>L'ancienne date de l'absence a modifié</param>
        public static void ModifAbsence(Absence absence, int id, DateTime date)
        {
            string sql = "UPDATE absence SET DATEDEBUT = @DateDebut , IDMOTIF = @MotifID , DATEFIN = @DateFin WHERE IDPERSONNEL = @PersonnelID AND DATEDEBUT = @NewDate";
            MySqlConnection connexion = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, connexion);
            cmd.CommandType = System.Data.CommandType.Text;
            Console.WriteLine(date);
            Console.WriteLine(absence.DateDebut);
            Console.WriteLine(absence.DateFin);
            Console.ReadLine();
            cmd.Parameters.Add("@PersonnelID", MySqlDbType.Int32).Value = absence.PersonnelID;
            cmd.Parameters.Add("@DateDebut", MySqlDbType.DateTime).Value = absence.DateDebut;
            cmd.Parameters.Add("@MotifID", MySqlDbType.Int32).Value = absence.MotifID;
            cmd.Parameters.Add("@DateFin", MySqlDbType.DateTime).Value = absence.DateFin;
            cmd.Parameters.Add("@NewDate", MySqlDbType.DateTime).Value = date;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("L'absence a bien été modifiée.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            connexion.Close();
        }

        /// <summary>
        /// Une méthode qui supprime une absence dans la base de données
        /// </summary>
        /// <param name=id> ID de l'absence à supprimer</param>
        /// <param name=date>La date de l'absence a supprimé</param>
        public static void SupprimerAbsence(int id, DateTime debut)
        {
            string sql = "DELETE FROM absence WHERE IDPERSONNEL = @PersonnelID AND DATEDEBUT = @DateDebut";
            MySqlConnection connexion = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, connexion);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@PersonnelID", MySqlDbType.Int32).Value = id;
            cmd.Parameters.Add("@DateDebut", MySqlDbType.DateTime).Value = debut;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("L'absence a bien été supprimée.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            connexion.Close();
        }

        /// <summary>
        /// Une méthode qui récupère des données dans la base de données et qui les injecte dans un tableau
        /// </summary>
        /// <param name=query>Requête SQL de la liste</param>
        /// <param name=grid>Objet graphique du tableau a modifié</param>
        public static void ListeAbsence(string query, DataGridView grid)
        {
            string sql = query;
            MySqlConnection connexion = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, connexion);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            grid.DataSource = table;
            connexion.Close();
        }

        /// <summary>
        /// Une méthode qui récupère des données dans la base de données et qui les injecte dans un menu déroulant
        /// </summary>
        /// <param name=query>Requête SQL de la liste</param>
        /// <param name=grid>Objet graphique du menu déroulant a modifié</param>
        public static void ListeMotif(string query, ComboBox cbx)
        {
            string sql = query;
            MySqlConnection connexion = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, connexion);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            cbx.DataSource = table;
            connexion.Close();
        }
    }
}
