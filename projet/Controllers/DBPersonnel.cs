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
    ///  Classe de connexion à la base de données pour la table Personnel et service lié au personnel
    /// </summary>
    class DBPersonnel
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
        /// Une méthode qui ajoute un personnel dans la base de données
        /// </summary>
        /// <param name=personnel> Une instance de la classe Personnel</param>
        public static void AjoutPersonnel(Personnel personnel)
        {
            string sql = "INSERT INTO personnel VALUES (NULL, @ServiceID, @PersonnelNom, @PersonnelPrenom, @PersonnelTel, @PersonnelMail)";
            MySqlConnection connexion = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, connexion);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@ServiceID", MySqlDbType.Int32).Value = personnel.Service;
            cmd.Parameters.Add("@PersonnelNom", MySqlDbType.VarChar).Value = personnel.Nom;
            cmd.Parameters.Add("@PersonnelPrenom", MySqlDbType.VarChar).Value = personnel.Prenom;
            cmd.Parameters.Add("@PersonnelTel", MySqlDbType.VarChar).Value = personnel.Tel; 
            cmd.Parameters.Add("@PersonnelMail", MySqlDbType.VarChar).Value = personnel.Mail;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Le personnel a bien été ajouté.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            connexion.Close();
        }

        /// <summary>
        /// Une méthode qui ajoute un personnel dans la base de données
        /// </summary>
        /// <param name=personnel> Une instance de la classe Personnel</param>
        /// <param name=id> ID du personnel à modifier</param>
        public static void ModifPersonnel(Personnel personnel, int id)
        {
            string sql = "UPDATE personnel SET IDSERVICE = @ServiceID , NOM = @PersonnelNom , PRENOM = @PersonnelPrenom , TEL = @PersonnelTel , MAIL = @PersonnelMail WHERE IDPERSONNEL = @PersonnelID";
            MySqlConnection connexion = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, connexion);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@PersonnelID", MySqlDbType.Int32).Value = id;
            cmd.Parameters.Add("@ServiceID", MySqlDbType.Int32).Value = personnel.Service;
            cmd.Parameters.Add("@PersonnelNom", MySqlDbType.VarChar).Value = personnel.Nom;
            cmd.Parameters.Add("@PersonnelPrenom", MySqlDbType.VarChar).Value = personnel.Prenom;
            cmd.Parameters.Add("@PersonnelTel", MySqlDbType.VarChar).Value = personnel.Tel;
            cmd.Parameters.Add("@PersonnelMail", MySqlDbType.VarChar).Value = personnel.Mail;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Le personnel a bien été modifié.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            connexion.Close();
        }

        /// <summary>
        /// Une méthode qui supprime un personnel dans la base de données
        /// </summary>
        /// <param name=id> ID du personnel à supprimer</param>
        public static void SupprimerPersonnel(int id)
        {
            string sql = "DELETE FROM personnel WHERE IDPERSONNEL = @PersonnelID";
            MySqlConnection connexion = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, connexion);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@PersonnelID", MySqlDbType.Int32).Value = id;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Le personnel a bien été supprimé.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        public static void ListePersonnel(string query, DataGridView grid)
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
        public static void ListeService(string query, ComboBox cbx)
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
