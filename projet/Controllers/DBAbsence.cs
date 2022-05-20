using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace projet.Controllers
{
    class DBAbsence
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

        public static void AjoutAbsence()
        {

        }
    }
}
