using MySql.Data.MySqlClient;
using System;
using System.Data;
using MediaTek86.Models;

namespace MediaTek86.Controllers
{
    public class DataController
    {
        private string connectionString = "server=localhost;database=mediatek86;user=mediatek_user;password=secure_password;";

        public DataTable GetData(string query)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }

        public void ExecuteQuery(string query)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void AddPersonnel(Personnel personnel)
        {
            string query = $"INSERT INTO personnel (nom, prenom, tel, mail, profil) VALUES ('{personnel.Nom}', '{personnel.Prenom}', '{personnel.Tel}', '{personnel.Mail}', '{personnel.Profil}')";
            ExecuteQuery(query);
        }

        public void UpdatePersonnel(Personnel personnel)
        {
            string query = $"UPDATE personnel SET nom = '{personnel.Nom}', prenom = '{personnel.Prenom}', tel = '{personnel.Tel}', mail = '{personnel.Mail}', profil = '{personnel.Profil}' WHERE idpersonnel = {personnel.IdPersonnel}";
            ExecuteQuery(query);
        }

        public void DeletePersonnel(int idPersonnel)
        {
            string query = $"DELETE FROM personnel WHERE idpersonnel = {idPersonnel}";
            ExecuteQuery(query);
        }

        public void AddAbsence(Absence absence)
        {
            string query = $"INSERT INTO absence (idpersonnel, datedebut, datefin, motif) VALUES ({absence.IdPersonnel}, '{absence.DateDebut:yyyy-MM-dd}', '{absence.DateFin:yyyy-MM-dd}', '{absence.Motif}')";
            ExecuteQuery(query);
        }

        public void UpdateAbsence(Absence absence)
        {
            string query = $"UPDATE absence SET datedebut = '{absence.DateDebut:yyyy-MM-dd}', datefin = '{absence.DateFin:yyyy-MM-dd}', motif = '{absence.Motif}' WHERE idabsence = {absence.IdAbsence}";
            ExecuteQuery(query);
        }

        public void DeleteAbsence(int idAbsence)
        {
            string query = $"DELETE FROM absence WHERE idabsence = {idAbsence}";
            ExecuteQuery(query);
        }
    }
}
