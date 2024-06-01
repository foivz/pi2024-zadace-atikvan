namespace StudentskiRecenziraj
{
    partial class FrmUpdate
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKolNovo = new System.Windows.Forms.TextBox();
            this.txtOkusNovo = new System.Windows.Forms.TextBox();
            this.txtKomNovo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.txtNaslov = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(313, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nova ocjena za količinu ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nova ocjena za okus";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Novi komentar";
            // 
            // txtKolNovo
            // 
            this.txtKolNovo.Location = new System.Drawing.Point(332, 188);
            this.txtKolNovo.Name = "txtKolNovo";
            this.txtKolNovo.Size = new System.Drawing.Size(100, 22);
            this.txtKolNovo.TabIndex = 3;
            // 
            // txtOkusNovo
            // 
            this.txtOkusNovo.Location = new System.Drawing.Point(63, 188);
            this.txtOkusNovo.Name = "txtOkusNovo";
            this.txtOkusNovo.Size = new System.Drawing.Size(100, 22);
            this.txtOkusNovo.TabIndex = 4;
            // 
            // txtKomNovo
            // 
            this.txtKomNovo.Location = new System.Drawing.Point(149, 313);
            this.txtKomNovo.Name = "txtKomNovo";
            this.txtKomNovo.Size = new System.Drawing.Size(183, 22);
            this.txtKomNovo.TabIndex = 5;
            this.txtKomNovo.TextChanged += new System.EventHandler(this.txtKomNovo_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(169, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Promjena recenzije za ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancel.Location = new System.Drawing.Point(12, 12);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(103, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Odustani";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnChange
            // 
            this.btnChange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnChange.Location = new System.Drawing.Point(343, 397);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(102, 27);
            this.btnChange.TabIndex = 8;
            this.btnChange.Text = "Promjeni";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // txtNaslov
            // 
            this.txtNaslov.Location = new System.Drawing.Point(168, 93);
            this.txtNaslov.Name = "txtNaslov";
            this.txtNaslov.Size = new System.Drawing.Size(143, 22);
            this.txtNaslov.TabIndex = 9;
            // 
            // FrmUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(493, 450);
            this.Controls.Add(this.txtNaslov);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtKomNovo);
            this.Controls.Add(this.txtOkusNovo);
            this.Controls.Add(this.txtKolNovo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmUpdate";
            this.Text = "FrmUpdate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKolNovo;
        private System.Windows.Forms.TextBox txtOkusNovo;
        private System.Windows.Forms.TextBox txtKomNovo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.TextBox txtNaslov;
    }
}