using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using projet.Models;
using System.Security.Cryptography;

namespace projet.Controllers
{
    /// <summary>
    ///  Classe de connexion à la base de données pour la table Responsable
    /// </summary>
    class DBResponsable
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
        /// Une méthode qui ajoute un responsable dans la base de données
        /// </summary>
        /// <param name=responsable> Une instance de la classe Responsable</param>
        public static void AjoutResponsable(Responsable responsable)
        {
            string sql = "INSERT INTO responsable VALUES (@login, @password)";
            MySqlConnection connexion = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, connexion);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@password", MySqlDbType.VarChar).Value = responsable.Password;
            cmd.Parameters.Add("@login", MySqlDbType.VarChar).Value = responsable.Login;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Le responsable a bien été ajouté.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            connexion.Close();
        }

        /// <summary>
        /// Une méthode qui vérifie si les coordonnées de l'utilisateur sont dans la base de données
        /// </summary>
        /// <param name=responsable> Une instance de la classe Responsable</param>
        /// <returns>true ou false.</returns>
        public static bool GetResponsable(Responsable responsable)
        {
            string sql = "SELECT pwd, login FROM responsable WHERE login = @login AND pwd = @password";
            MySqlConnection connexion = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, connexion);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@login", MySqlDbType.VarChar).Value = responsable.Login;
            cmd.Parameters.Add("@password", MySqlDbType.VarChar).Value = responsable.Password;
            MySqlDataReader reader = cmd.ExecuteReader();
            bool exist = false;
            while (reader.Read())
            {
                Console.WriteLine(reader.GetString("login"));
                Console.ReadLine();
                exist = true;
                MessageBox.Show("Vous êtes connectés.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (!exist)
            {
                MessageBox.Show("Le mot de passe ou le nom d'utilisateur sont incorrects.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return exist;
        }
    }
}
