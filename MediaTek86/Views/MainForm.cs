using MediaTek86.Controllers;
using MediaTek86.Models;
using System;
using System.Data;
using System.Windows.Forms;

namespace MediaTek86.Views
{
    public partial class MainForm : Form
    {
        private DataController dataController = new DataController();
        private Personnel selectedPersonnel;
        private Absence selectedAbsence;

        public MainForm()
        {
            InitializeComponent();
            LoadData();
            dataGridView.SelectionChanged += DataGridView_SelectionChanged;
        }

        private void LoadData()
        {
            string personnelQuery = "SELECT idpersonnel, nom, prenom, tel, mail, profil FROM personnel";
            string absenceQuery = "SELECT idabsence, idpersonnel, datedebut, datefin, motif FROM absence";
            var personnelData = dataController.GetData(personnelQuery);
            var absenceData = dataController.GetData(absenceQuery);

            // Объединение данных в одну таблицу
            var combinedData = new DataTable();
            combinedData.Columns.Add("idpersonnel", typeof(int));
            combinedData.Columns.Add("nom", typeof(string));
            combinedData.Columns.Add("prenom", typeof(string));
            combinedData.Columns.Add("tel", typeof(string));
            combinedData.Columns.Add("mail", typeof(string));
            combinedData.Columns.Add("profil", typeof(string));
            combinedData.Columns.Add("idabsence", typeof(int));
            combinedData.Columns.Add("datedebut", typeof(DateTime));
            combinedData.Columns.Add("datefin", typeof(DateTime));
            combinedData.Columns.Add("motif", typeof(string));

            foreach (DataRow personnelRow in personnelData.Rows)
            {
                var absenceRows = absenceData.Select($"idpersonnel = {personnelRow["idpersonnel"]}");
                if (absenceRows.Length > 0)
                {
                    foreach (var absenceRow in absenceRows)
                    {
                        var newRow = combinedData.NewRow();
                        newRow["idpersonnel"] = personnelRow["idpersonnel"];
                        newRow["nom"] = personnelRow["nom"];
                        newRow["prenom"] = personnelRow["prenom"];
                        newRow["tel"] = personnelRow["tel"];
                        newRow["mail"] = personnelRow["mail"];
                        newRow["profil"] = personnelRow["profil"];
                        newRow["idabsence"] = absenceRow["idabsence"];
                        newRow["datedebut"] = absenceRow["datedebut"];
                        newRow["datefin"] = absenceRow["datefin"];
                        newRow["motif"] = absenceRow["motif"];
                        combinedData.Rows.Add(newRow);
                    }
                }
                else
                {
                    var newRow = combinedData.NewRow();
                    newRow["idpersonnel"] = personnelRow["idpersonnel"];
                    newRow["nom"] = personnelRow["nom"];
                    newRow["prenom"] = personnelRow["prenom"];
                    newRow["tel"] = personnelRow["tel"];
                    newRow["mail"] = personnelRow["mail"];
                    newRow["profil"] = personnelRow["profil"];
                    combinedData.Rows.Add(newRow);
                }
            }

            dataGridView.DataSource = combinedData;

            // Скрытие ID колонок
            dataGridView.Columns["idpersonnel"].Visible = false;
            dataGridView.Columns["idabsence"].Visible = false;
        }

        private void btnAddPersonnel_Click(object sender, EventArgs e)
        {
            ClearFields();
            EnableEditing(true);
            selectedPersonnel = null;
            selectedAbsence = null;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedPersonnel != null)
            {
                EnableEditing(true);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedPersonnel != null)
            {
                dataController.DeletePersonnel(selectedPersonnel.IdPersonnel);
                LoadData();
                ClearFields();
            }
            if (selectedAbsence != null)
            {
                dataController.DeleteAbsence(selectedAbsence.IdAbsence);
                LoadData();
                ClearFields();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (selectedPersonnel == null)
            {
                Personnel personnel = new Personnel
                {
                    Nom = txtNom.Text,
                    Prenom = txtPrenom.Text,
                    Tel = txtTel.Text,
                    Mail = txtMail.Text,
                    Profil = txtProfil.Text
                };
                dataController.AddPersonnel(personnel);
            }
            else
            {
                selectedPersonnel.Nom = txtNom.Text;
                selectedPersonnel.Prenom = txtPrenom.Text;
                selectedPersonnel.Tel = txtTel.Text;
                selectedPersonnel.Mail = txtMail.Text;
                selectedPersonnel.Profil = txtProfil.Text;
                dataController.UpdatePersonnel(selectedPersonnel);
            }

            if (selectedAbsence == null && txtDateDebut.Text != string.Empty && txtDateFin.Text != string.Empty && txtMotif.Text != string.Empty)
            {
                Absence absence = new Absence
                {
                    IdPersonnel = Convert.ToInt32(txtIdPersonnel.Text),
                    DateDebut = Convert.ToDateTime(txtDateDebut.Text),
                    DateFin = Convert.ToDateTime(txtDateFin.Text),
                    Motif = txtMotif.Text
                };
                dataController.AddAbsence(absence);
            }
            else if (selectedAbsence != null)
            {
                selectedAbsence.IdPersonnel = Convert.ToInt32(txtIdPersonnel.Text);
                selectedAbsence.DateDebut = Convert.ToDateTime(txtDateDebut.Text);
                selectedAbsence.DateFin = Convert.ToDateTime(txtDateFin.Text);
                selectedAbsence.Motif = txtMotif.Text;
                dataController.UpdateAbsence(selectedAbsence);
            }

            LoadData();
            ClearFields();
            EnableEditing(false);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearFields();
            EnableEditing(false);
        }

        private void DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView.SelectedRows[0];
                selectedPersonnel = new Personnel
                {
                    IdPersonnel = Convert.ToInt32(row.Cells["idpersonnel"].Value),
                    Nom = row.Cells["nom"].Value.ToString(),
                    Prenom = row.Cells["prenom"].Value.ToString(),
                    Tel = row.Cells["tel"].Value.ToString(),
                    Mail = row.Cells["mail"].Value.ToString(),
                    Profil = row.Cells["profil"].Value.ToString()
                };

                txtIdPersonnel.Text = selectedPersonnel.IdPersonnel.ToString();
                txtNom.Text = selectedPersonnel.Nom;
                txtPrenom.Text = selectedPersonnel.Prenom;
                txtTel.Text = selectedPersonnel.Tel;
                txtMail.Text = selectedPersonnel.Mail;
                txtProfil.Text = selectedPersonnel.Profil;

                if (row.Cells["idabsence"].Value != DBNull.Value)
                {
                    selectedAbsence = new Absence
                    {
                        IdAbsence = Convert.ToInt32(row.Cells["idabsence"].Value),
                        IdPersonnel = Convert.ToInt32(row.Cells["idpersonnel"].Value),
                        DateDebut = Convert.ToDateTime(row.Cells["datedebut"].Value),
                        DateFin = Convert.ToDateTime(row.Cells["datefin"].Value),
                        Motif = row.Cells["motif"].Value.ToString()
                    };

                    txtDateDebut.Text = selectedAbsence.DateDebut.ToString("yyyy-MM-dd");
                    txtDateFin.Text = selectedAbsence.DateFin.ToString("yyyy-MM-dd");
                    txtMotif.Text = selectedAbsence.Motif;
                }
                else
                {
                    ClearAbsenceFields();
                }
            }
        }

        private void ClearFields()
        {
            txtIdPersonnel.Text = string.Empty;
            txtNom.Text = string.Empty;
            txtPrenom.Text = string.Empty;
            txtTel.Text = string.Empty;
            txtMail.Text = string.Empty;
            txtProfil.Text = string.Empty;
            txtDateDebut.Text = string.Empty;
            txtDateFin.Text = string.Empty;
            txtMotif.Text = string.Empty;
            selectedPersonnel = null;
            selectedAbsence = null;
        }

        private void EnableEditing(bool enable)
        {
            txtNom.Enabled = enable;
            txtPrenom.Enabled = enable;
            txtTel.Enabled = enable;
            txtMail.Enabled = enable;
            txtProfil.Enabled = enable;
            txtDateDebut.Enabled = enable;
            txtDateFin.Enabled = enable;
            txtMotif.Enabled = enable;
            btnSave.Enabled = enable;
            btnCancel.Enabled = enable;
        }

        private void ClearAbsenceFields()
        {
            txtDateDebut.Text = string.Empty;
            txtDateFin.Text = string.Empty;
            txtMotif.Text = string.Empty;
            selectedAbsence = null;
        }
    }
}
