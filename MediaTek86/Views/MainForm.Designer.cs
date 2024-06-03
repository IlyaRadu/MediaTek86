namespace MediaTek86.Views
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox txtIdPersonnel;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtProfil;
        private System.Windows.Forms.TextBox txtDateDebut;
        private System.Windows.Forms.TextBox txtDateFin;
        private System.Windows.Forms.TextBox txtMotif;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblIdPersonnel;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblProfil;
        private System.Windows.Forms.Label lblDateDebut;
        private System.Windows.Forms.Label lblDateFin;
        private System.Windows.Forms.Label lblMotif;

        private void InitializeComponent()
        {
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.txtIdPersonnel = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtProfil = new System.Windows.Forms.TextBox();
            this.txtDateDebut = new System.Windows.Forms.TextBox();
            this.txtDateFin = new System.Windows.Forms.TextBox();
            this.txtMotif = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblIdPersonnel = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblProfil = new System.Windows.Forms.Label();
            this.lblDateDebut = new System.Windows.Forms.Label();
            this.lblDateFin = new System.Windows.Forms.Label();
            this.lblMotif = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();

            // dataGridView
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(776, 200);
            this.dataGridView.TabIndex = 0;

            // txtIdPersonnel
            this.txtIdPersonnel.Location = new System.Drawing.Point(100, 230);
            this.txtIdPersonnel.Name = "txtIdPersonnel";
            this.txtIdPersonnel.Size = new System.Drawing.Size(100, 20);
            this.txtIdPersonnel.TabIndex = 1;
            this.txtIdPersonnel.Enabled = false;

            // txtNom
            this.txtNom.Location = new System.Drawing.Point(100, 260);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 20);
            this.txtNom.TabIndex = 2;

            // txtPrenom
            this.txtPrenom.Location = new System.Drawing.Point(100, 290);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(100, 20);
            this.txtPrenom.TabIndex = 3;

            // txtTel
            this.txtTel.Location = new System.Drawing.Point(100, 320);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(100, 20);
            this.txtTel.TabIndex = 4;

            // txtMail
            this.txtMail.Location = new System.Drawing.Point(100, 350);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(100, 20);
            this.txtMail.TabIndex = 5;

            // txtProfil
            this.txtProfil.Location = new System.Drawing.Point(100, 380);
            this.txtProfil.Name = "txtProfil";
            this.txtProfil.Size = new System.Drawing.Size(100, 20);
            this.txtProfil.TabIndex = 6;

            // txtDateDebut
            this.txtDateDebut.Location = new System.Drawing.Point(100, 410);
            this.txtDateDebut.Name = "txtDateDebut";
            this.txtDateDebut.Size = new System.Drawing.Size(100, 20);
            this.txtDateDebut.TabIndex = 7;

            // txtDateFin
            this.txtDateFin.Location = new System.Drawing.Point(100, 440);
            this.txtDateFin.Name = "txtDateFin";
            this.txtDateFin.Size = new System.Drawing.Size(100, 20);
            this.txtDateFin.TabIndex = 8;

            // txtMotif
            this.txtMotif.Location = new System.Drawing.Point(100, 470);
            this.txtMotif.Name = "txtMotif";
            this.txtMotif.Size = new System.Drawing.Size(100, 20);
            this.txtMotif.TabIndex = 9;

            // btnAdd
            this.btnAdd.Location = new System.Drawing.Point(220, 230);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAddPersonnel_Click);

            // btnUpdate
            this.btnUpdate.Location = new System.Drawing.Point(220, 260);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

            // btnDelete
            this.btnDelete.Location = new System.Drawing.Point(220, 290);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            // btnSave
            this.btnSave.Location = new System.Drawing.Point(220, 320);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // btnCancel
            this.btnCancel.Location = new System.Drawing.Point(220, 350);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // lblIdPersonnel
            this.lblIdPersonnel.AutoSize = true;
            this.lblIdPersonnel.Location = new System.Drawing.Point(12, 233);
            this.lblIdPersonnel.Name = "lblIdPersonnel";
            this.lblIdPersonnel.Size = new System.Drawing.Size(64, 13);
            this.lblIdPersonnel.TabIndex = 15;
            this.lblIdPersonnel.Text = "ID Personnel";

            // lblNom
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(12, 263);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(29, 13);
            this.lblNom.TabIndex = 16;
            this.lblNom.Text = "Nom";

            // lblPrenom
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(12, 293);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(43, 13);
            this.lblPrenom.TabIndex = 17;
            this.lblPrenom.Text = "Prenom";

            // lblTel
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(12, 323);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(22, 13);
            this.lblTel.TabIndex = 18;
            this.lblTel.Text = "Tel";

            // lblMail
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(12, 353);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(26, 13);
            this.lblMail.TabIndex = 19;
            this.lblMail.Text = "Mail";

            // lblProfil
            this.lblProfil.AutoSize = true;
            this.lblProfil.Location = new System.Drawing.Point(12, 383);
            this.lblProfil.Name = "lblProfil";
            this.lblProfil.Size = new System.Drawing.Size(30, 13);
            this.lblProfil.TabIndex = 20;
            this.lblProfil.Text = "Profil";

            // lblDateDebut
            this.lblDateDebut.AutoSize = true;
            this.lblDateDebut.Location = new System.Drawing.Point(12, 413);
            this.lblDateDebut.Name = "lblDateDebut";
            this.lblDateDebut.Size = new System.Drawing.Size(62, 13);
            this.lblDateDebut.TabIndex = 21;
            this.lblDateDebut.Text = "Date Debut";

            // lblDateFin
            this.lblDateFin.AutoSize = true;
            this.lblDateFin.Location = new System.Drawing.Point(12, 443);
            this.lblDateFin.Name = "lblDateFin";
            this.lblDateFin.Size = new System.Drawing.Size(47, 13);
            this.lblDateFin.TabIndex = 22;
            this.lblDateFin.Text = "Date Fin";

            // lblMotif
            this.lblMotif.AutoSize = true;
            this.lblMotif.Location = new System.Drawing.Point(12, 473);
            this.lblMotif.Name = "lblMotif";
            this.lblMotif.Size = new System.Drawing.Size(30, 13);
            this.lblMotif.TabIndex = 23;
            this.lblMotif.Text = "Motif";

            // MainForm
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.lblMotif);
            this.Controls.Add(this.lblDateFin);
            this.Controls.Add(this.lblDateDebut);
            this.Controls.Add(this.lblProfil);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lblIdPersonnel);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtMotif);
            this.Controls.Add(this.txtDateFin);
            this.Controls.Add(this.txtDateDebut);
            this.Controls.Add(this.txtProfil);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtIdPersonnel);
            this.Controls.Add(this.dataGridView);
            this.Name = "MainForm";
            this.Text = "MediaTek86";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
