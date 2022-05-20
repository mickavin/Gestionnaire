
namespace projet.Views
{
    partial class ListMiss
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
            this.button1 = new System.Windows.Forms.Button();
            this.absenceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.absenceBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.startDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Motif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDMOTIF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.see = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.absenceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.absenceBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(945, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ajouter absence";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // absenceBindingSource
            // 
            this.absenceBindingSource.DataMember = "absence";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.startDate,
            this.endDate,
            this.Motif,
            this.IDMOTIF,
            this.see});
            this.dataGridView1.DataSource = this.absenceBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1075, 536);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // startDate
            // 
            this.startDate.DataPropertyName = "DATEDEBUT";
            this.startDate.HeaderText = "Date de début";
            this.startDate.MinimumWidth = 6;
            this.startDate.Name = "startDate";
            this.startDate.ReadOnly = true;
            this.startDate.Width = 125;
            // 
            // endDate
            // 
            this.endDate.DataPropertyName = "DATEFIN";
            this.endDate.HeaderText = "Date de fin";
            this.endDate.MinimumWidth = 6;
            this.endDate.Name = "endDate";
            this.endDate.ReadOnly = true;
            this.endDate.Width = 125;
            // 
            // Motif
            // 
            this.Motif.DataPropertyName = "LIBELLE";
            this.Motif.HeaderText = "Motif";
            this.Motif.MinimumWidth = 6;
            this.Motif.Name = "Motif";
            this.Motif.ReadOnly = true;
            this.Motif.Width = 125;
            // 
            // IDMOTIF
            // 
            this.IDMOTIF.DataPropertyName = "IDMOTIF";
            this.IDMOTIF.HeaderText = "ID du motif";
            this.IDMOTIF.MinimumWidth = 6;
            this.IDMOTIF.Name = "IDMOTIF";
            this.IDMOTIF.ReadOnly = true;
            this.IDMOTIF.Visible = false;
            this.IDMOTIF.Width = 125;
            // 
            // see
            // 
            this.see.HeaderText = "Voir absence";
            this.see.MinimumWidth = 6;
            this.see.Name = "see";
            this.see.Text = "Voir absence";
            this.see.UseColumnTextForButtonValue = true;
            this.see.Width = 125;
            // 
            // ListMiss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 628);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "ListMiss";
            this.Text = "Liste des absences";
            this.Shown += new System.EventHandler(this.ListMiss_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.absenceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.absenceBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource absenceBindingSource;
        private System.Windows.Forms.BindingSource absenceBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Motif;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDMOTIF;
        private System.Windows.Forms.DataGridViewButtonColumn see;
    }
}