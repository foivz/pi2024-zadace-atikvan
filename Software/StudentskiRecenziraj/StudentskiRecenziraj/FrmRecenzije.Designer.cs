namespace StudentskiRecenziraj
{
    partial class FrmRecenzije
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
            this.dgvRecenzije = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRecenziraj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecenzije)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRecenzije
            // 
            this.dgvRecenzije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecenzije.Location = new System.Drawing.Point(85, 75);
            this.dgvRecenzije.Name = "dgvRecenzije";
            this.dgvRecenzije.RowHeadersWidth = 51;
            this.dgvRecenzije.RowTemplate.Height = 24;
            this.dgvRecenzije.Size = new System.Drawing.Size(663, 258);
            this.dgvRecenzije.TabIndex = 0;
            this.dgvRecenzije.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(206, 405);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(97, 33);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Ažuriraj";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(30, 404);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 34);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Obriši";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnRecenziraj
            // 
            this.btnRecenziraj.Location = new System.Drawing.Point(610, 404);
            this.btnRecenziraj.Name = "btnRecenziraj";
            this.btnRecenziraj.Size = new System.Drawing.Size(138, 34);
            this.btnRecenziraj.TabIndex = 3;
            this.btnRecenziraj.Text = "Nova recenzija";
            this.btnRecenziraj.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(344, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "StudentskiRecenziraj";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FrmRecenzije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRecenziraj);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dgvRecenzije);
            this.Name = "FrmRecenzije";
            this.Text = "Recenzije";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecenzije)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRecenzije;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRecenziraj;
        private System.Windows.Forms.Label label1;
    }
}