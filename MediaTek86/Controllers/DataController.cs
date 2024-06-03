using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace MediaTek86.Controllers
{
    public class DataController
    {
        // Chaîne de connexion à la base de données
        private readonly string connectionString = "server=localhost;database=mediatek86;user=root;password=yourpassword";

        // Méthode pour récupérer des données depuis la base de données
        public DataTable GetData(string query)
        {
            DataTable dataTable = new DataTable();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        dataTable.Load(reader);
                    }
                }
            }
            return dataTable;
        }

        // Méthode pour ajouter du personnel
        public void AddPersonnel(Personnel personnel)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO personnel (nom, prenom, tel, mail, profil) VALUES (@Nom, @Prenom, @Tel, @Mail, @Profil)";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nom", personnel.Nom);
                    command.Parameters.AddWithValue("@Prenom", personnel.Prenom);
                    command.Parameters.AddWithValue("@Tel", personnel.Tel);
                    command.Parameters.AddWithValue("@Mail", personnel.Mail);
                    command.Parameters.AddWithValue("@Profil", personnel.Profil);
                    command.ExecuteNonQuery();
                }
            }
        }

        // Méthode pour mettre à jour du personnel
        public void UpdatePersonnel(Personnel personnel)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE personnel SET nom = @Nom, prenom = @Prenom, tel = @Tel, mail = @Mail, profil = @Profil WHERE idpersonnel = @IdPersonnel";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nom", personnel.Nom);
                    command.Parameters.AddWithValue("@Prenom", personnel.Prenom);
                    command.Parameters.AddWithValue("@Tel", personnel.Tel);
                    command.Parameters.AddWithValue("@Mail", personnel.Mail);
                    command.Parameters.AddWithValue("@Profil", personnel.Profil);
                    command.Parameters.AddWithValue("@IdPersonnel", personnel.IdPersonnel);
                    command.ExecuteNonQuery();
                }
            }
        }

        // Méthode pour supprimer du personnel
        public void DeletePersonnel(int idPersonnel)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM personnel WHERE idpersonnel = @IdPersonnel";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IdPersonnel", idPersonnel);
                    command.ExecuteNonQuery();
                }
            }
        }

        // Méthode pour ajouter une absence
        public void AddAbsence(Absence absence)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO absence (idpersonnel, datedebut, datefin, motif) VALUES (@IdPersonnel, @DateDebut, @DateFin, @Motif)";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IdPersonnel", absence.IdPersonnel);
                    command.Parameters.AddWithValue("@DateDebut", absence.DateDebut);
                    command.Parameters.AddWithValue("@DateFin", absence.DateFin);
                    command.Parameters.AddWithValue("@Motif", absence.Motif);
                    command.ExecuteNonQuery();
                }
            }
        }

        // Méthode pour mettre à jour une absence
        public void UpdateAbsence(Absence absence)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE absence SET idpersonnel = @IdPersonnel, datedebut = @DateDebut, datefin = @DateFin, motif = @Motif WHERE idabsence = @IdAbsence";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IdPersonnel", absence.IdPersonnel);
                    command.Parameters.AddWithValue("@DateDebut", absence.DateDebut);
                    command.Parameters.AddWithValue("@DateFin", absence.DateFin);
                    command.Parameters.AddWithValue("@Motif", absence.Motif);
                    command.Parameters.AddWithValue("@IdAbsence", absence.IdAbsence);
                    command.ExecuteNonQuery();
                }
            }
        }

        // Méthode pour supprimer une absence
        public void DeleteAbsence(int idAbsence)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM absence WHERE idabsence = @IdAbsence";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IdAbsence", idAbsence);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
