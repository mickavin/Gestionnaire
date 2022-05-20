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
    class DBPersonnel
    {
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

        public static void ModifPersonnel(Personnel personnel, int id)
        {
            string sql = "UPDATE personnel SET IDSERVICE = @ServiceID NOM = @PersonnelNom PRENOM = @PersonnelPrenom TEL = @PersonnelTel MAIL = @PersonnelMail WHERE IDPERSONNEL = @PersonnelID";
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
                MessageBox.Show("Le personnel a bien été ajouté.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            connexion.Close();
        }
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
