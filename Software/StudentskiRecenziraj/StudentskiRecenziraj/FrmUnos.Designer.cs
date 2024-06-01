namespace StudentskiRecenziraj
{
    partial class FrmUnos
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
            this.txtKomentar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtJelo = new System.Windows.Forms.TextBox();
            this.btnUnos = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.txtOkus = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ocjena za okus";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(304, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ocjena za količinu";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Komentar";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtKomentar
            // 
            this.txtKomentar.Location = new System.Drawing.Point(93, 313);
            this.txtKomentar.Name = "txtKomentar";
            this.txtKomentar.Size = new System.Drawing.Size(266, 22);
            this.txtKomentar.TabIndex = 5;
            this.txtKomentar.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Upišite jelo koje želite recenzirati:";
            // 
            // txtJelo
            // 
            this.txtJelo.Location = new System.Drawing.Point(233, 90);
            this.txtJelo.Name = "txtJelo";
            this.txtJelo.Size = new System.Drawing.Size(162, 22);
            this.txtJelo.TabIndex = 7;
            // 
            // btnUnos
            // 
            this.btnUnos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnUnos.Location = new System.Drawing.Point(344, 369);
            this.btnUnos.Name = "btnUnos";
            this.btnUnos.Size = new System.Drawing.Size(75, 23);
            this.btnUnos.TabIndex = 8;
            this.btnUnos.Text = "Unesi";
            this.btnUnos.UseVisualStyleBackColor = true;
            this.btnUnos.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(165, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "StudentskiRecenziraj";
            // 
            // txtKolicina
            // 
            this.txtKolicina.Location = new System.Drawing.Point(308, 205);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(100, 22);
            this.txtKolicina.TabIndex = 4;
            this.txtKolicina.TextChanged += new System.EventHandler(this.txtKolicina_TextChanged);
            // 
            // txtOkus
            // 
            this.txtOkus.Location = new System.Drawing.Point(52, 205);
            this.txtOkus.Name = "txtOkus";
            this.txtOkus.Size = new System.Drawing.Size(100, 22);
            this.txtOkus.TabIndex = 3;
            this.txtOkus.TextChanged += new System.EventHandler(this.txtOkus_TextChanged);
            // 
            // FrmUnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(468, 421);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnUnos);
            this.Controls.Add(this.txtJelo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtKomentar);
            this.Controls.Add(this.txtKolicina);
            this.Controls.Add(this.txtOkus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FrmUnos";
            this.Text = "Nova recenzija";
            this.Load += new System.EventHandler(this.FrmUnos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKomentar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtJelo;
        private System.Windows.Forms.Button btnUnos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKolicina;
        private System.Windows.Forms.TextBox txtOkus;
    }
}