
namespace projet.Views
{
    partial class ListUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.absenceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.service = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDService = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Actions = new System.Windows.Forms.DataGridViewButtonColumn();
            this.absences = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.absenceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.firstName,
            this.lastName,
            this.tel,
            this.mail,
            this.service,
            this.IDService,
            this.Actions,
            this.absences});
            this.dataGridView.DataSource = this.absenceBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(12, 63);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(1439, 636);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // absenceBindingSource
            // 
            this.absenceBindingSource.DataMember = "absence";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(1242, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ajouter utilisateur";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "IDPERSONNEL";
            this.Id.HeaderText = "ID du personnel";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 125;
            // 
            // firstName
            // 
            this.firstName.DataPropertyName = "PRENOM";
            this.firstName.HeaderText = "Prénom";
            this.firstName.MinimumWidth = 6;
            this.firstName.Name = "firstName";
            this.firstName.ReadOnly = true;
            this.firstName.Width = 125;
            // 
            // lastName
            // 
            this.lastName.DataPropertyName = "NOM";
            this.lastName.HeaderText = "Nom";
            this.lastName.MinimumWidth = 6;
            this.lastName.Name = "lastName";
            this.lastName.ReadOnly = true;
            this.lastName.Width = 125;
            // 
            // tel
            // 
            this.tel.DataPropertyName = "TEL";
            this.tel.HeaderText = "Téléphone";
            this.tel.MinimumWidth = 6;
            this.tel.Name = "tel";
            this.tel.ReadOnly = true;
            this.tel.Width = 125;
            // 
            // mail
            // 
            this.mail.DataPropertyName = "MAIL";
            this.mail.HeaderText = "Adresse mail";
            this.mail.MinimumWidth = 6;
            this.mail.Name = "mail";
            this.mail.ReadOnly = true;
            this.mail.Width = 125;
            // 
            // service
            // 
            this.service.DataPropertyName = "NOMSERV";
            this.service.HeaderText = "Service";
            this.service.MinimumWidth = 6;
            this.service.Name = "service";
            this.service.ReadOnly = true;
            this.service.Width = 125;
            // 
            // IDService
            // 
            this.IDService.DataPropertyName = "IDSERV";
            this.IDService.HeaderText = "ID du service";
            this.IDService.MinimumWidth = 6;
            this.IDService.Name = "IDService";
            this.IDService.ReadOnly = true;
            this.IDService.Visible = false;
            this.IDService.Width = 125;
            // 
            // Actions
            // 
            this.Actions.HeaderText = "Voir infos";
            this.Actions.MinimumWidth = 6;
            this.Actions.Name = "Actions";
            this.Actions.Text = "Voir infos";
            this.Actions.UseColumnTextForButtonValue = true;
            this.Actions.Width = 125;
            // 
            // absences
            // 
            this.absences.HeaderText = "Voir absences";
            this.absences.MinimumWidth = 6;
            this.absences.Name = "absences";
            this.absences.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.absences.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.absences.Text = "Voir absences";
            this.absences.UseColumnTextForButtonValue = true;
            this.absences.Width = 125;
            // 
            // ListUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1456, 723);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView);
            this.Name = "ListUser";
            this.Text = "Liste utilisateur";
            this.Load += new System.EventHandler(this.ListUser_Load);
            this.Shown += new System.EventHandler(this.ListUser_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.absenceBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource absenceBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn service;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDService;
        private System.Windows.Forms.DataGridViewButtonColumn Actions;
        private System.Windows.Forms.DataGridViewButtonColumn absences;
    }
}