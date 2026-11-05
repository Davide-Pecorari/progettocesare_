namespace Progettocesare
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_stringa = new System.Windows.Forms.Button();
            this.txt_stringa4 = new System.Windows.Forms.TextBox();
            this.txt_stringa5 = new System.Windows.Forms.TextBox();
            this.btn_stringa1 = new System.Windows.Forms.Button();
            this.lbl_n1 = new System.Windows.Forms.Label();
            this.lbl_stringa = new System.Windows.Forms.Label();
            this.lbl_stringa2 = new System.Windows.Forms.Label();
            this.txt_stringa2 = new System.Windows.Forms.TextBox();
            this.txt_stringa = new System.Windows.Forms.TextBox();
            this.txt_stringa3 = new System.Windows.Forms.TextBox();
            this.txt_stringa1 = new System.Windows.Forms.TextBox();
            this.lbl_stringa3 = new System.Windows.Forms.Label();
            this.lbl_stringa1 = new System.Windows.Forms.Label();
            this.lbl_n6 = new System.Windows.Forms.Label();
            this.lbl_n7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_stringa
            // 
            this.btn_stringa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stringa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_stringa.Location = new System.Drawing.Point(60, 315);
            this.btn_stringa.Name = "btn_stringa";
            this.btn_stringa.Size = new System.Drawing.Size(88, 30);
            this.btn_stringa.TabIndex = 0;
            this.btn_stringa.Text = "CRIPTA";
            this.btn_stringa.UseVisualStyleBackColor = true;
            this.btn_stringa.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_stringa4
            // 
            this.txt_stringa4.Location = new System.Drawing.Point(181, 322);
            this.txt_stringa4.Name = "txt_stringa4";
            this.txt_stringa4.Size = new System.Drawing.Size(100, 20);
            this.txt_stringa4.TabIndex = 1;
            // 
            // txt_stringa5
            // 
            this.txt_stringa5.Location = new System.Drawing.Point(605, 318);
            this.txt_stringa5.Name = "txt_stringa5";
            this.txt_stringa5.Size = new System.Drawing.Size(100, 20);
            this.txt_stringa5.TabIndex = 2;
            // 
            // btn_stringa1
            // 
            this.btn_stringa1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stringa1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_stringa1.Location = new System.Drawing.Point(470, 311);
            this.btn_stringa1.Name = "btn_stringa1";
            this.btn_stringa1.Size = new System.Drawing.Size(85, 30);
            this.btn_stringa1.TabIndex = 3;
            this.btn_stringa1.Text = "CRIPTA";
            this.btn_stringa1.UseVisualStyleBackColor = true;
            // 
            // lbl_n1
            // 
            this.lbl_n1.AutoSize = true;
            this.lbl_n1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl_n1.Location = new System.Drawing.Point(276, 29);
            this.lbl_n1.Name = "lbl_n1";
            this.lbl_n1.Size = new System.Drawing.Size(219, 24);
            this.lbl_n1.TabIndex = 4;
            this.lbl_n1.Text = "CIFRARIO DI CESARE";
            // 
            // lbl_stringa
            // 
            this.lbl_stringa.AutoSize = true;
            this.lbl_stringa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stringa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl_stringa.Location = new System.Drawing.Point(57, 133);
            this.lbl_stringa.Name = "lbl_stringa";
            this.lbl_stringa.Size = new System.Drawing.Size(102, 16);
            this.lbl_stringa.TabIndex = 5;
            this.lbl_stringa.Text = "inserisci stringa:";
            // 
            // lbl_stringa2
            // 
            this.lbl_stringa2.AutoSize = true;
            this.lbl_stringa2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stringa2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl_stringa2.Location = new System.Drawing.Point(57, 222);
            this.lbl_stringa2.Name = "lbl_stringa2";
            this.lbl_stringa2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_stringa2.Size = new System.Drawing.Size(102, 16);
            this.lbl_stringa2.TabIndex = 6;
            this.lbl_stringa2.Text = "inserisci chiave:";
            // 
            // txt_stringa2
            // 
            this.txt_stringa2.Location = new System.Drawing.Point(181, 222);
            this.txt_stringa2.Name = "txt_stringa2";
            this.txt_stringa2.Size = new System.Drawing.Size(100, 20);
            this.txt_stringa2.TabIndex = 7;
            // 
            // txt_stringa
            // 
            this.txt_stringa.Location = new System.Drawing.Point(181, 129);
            this.txt_stringa.Name = "txt_stringa";
            this.txt_stringa.Size = new System.Drawing.Size(100, 20);
            this.txt_stringa.TabIndex = 8;
            // 
            // txt_stringa3
            // 
            this.txt_stringa3.Location = new System.Drawing.Point(605, 222);
            this.txt_stringa3.Name = "txt_stringa3";
            this.txt_stringa3.Size = new System.Drawing.Size(100, 20);
            this.txt_stringa3.TabIndex = 9;
            // 
            // txt_stringa1
            // 
            this.txt_stringa1.Location = new System.Drawing.Point(605, 129);
            this.txt_stringa1.Name = "txt_stringa1";
            this.txt_stringa1.Size = new System.Drawing.Size(100, 20);
            this.txt_stringa1.TabIndex = 10;
            // 
            // lbl_stringa3
            // 
            this.lbl_stringa3.AutoSize = true;
            this.lbl_stringa3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stringa3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl_stringa3.Location = new System.Drawing.Point(470, 228);
            this.lbl_stringa3.Name = "lbl_stringa3";
            this.lbl_stringa3.Size = new System.Drawing.Size(102, 16);
            this.lbl_stringa3.TabIndex = 11;
            this.lbl_stringa3.Text = "inserisci chiave:";
            // 
            // lbl_stringa1
            // 
            this.lbl_stringa1.AutoSize = true;
            this.lbl_stringa1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stringa1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl_stringa1.Location = new System.Drawing.Point(470, 129);
            this.lbl_stringa1.Name = "lbl_stringa1";
            this.lbl_stringa1.Size = new System.Drawing.Size(102, 16);
            this.lbl_stringa1.TabIndex = 12;
            this.lbl_stringa1.Text = "inserisci stringa:";
            // 
            // lbl_n6
            // 
            this.lbl_n6.AutoSize = true;
            this.lbl_n6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl_n6.Location = new System.Drawing.Point(117, 88);
            this.lbl_n6.Name = "lbl_n6";
            this.lbl_n6.Size = new System.Drawing.Size(80, 16);
            this.lbl_n6.TabIndex = 13;
            this.lbl_n6.Text = "decodifica";
            // 
            // lbl_n7
            // 
            this.lbl_n7.AutoSize = true;
            this.lbl_n7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl_n7.Location = new System.Drawing.Point(563, 90);
            this.lbl_n7.Name = "lbl_n7";
            this.lbl_n7.Size = new System.Drawing.Size(62, 16);
            this.lbl_n7.TabIndex = 14;
            this.lbl_n7.Text = "codifica";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_n7);
            this.Controls.Add(this.lbl_n6);
            this.Controls.Add(this.lbl_stringa1);
            this.Controls.Add(this.lbl_stringa3);
            this.Controls.Add(this.txt_stringa1);
            this.Controls.Add(this.txt_stringa3);
            this.Controls.Add(this.txt_stringa);
            this.Controls.Add(this.txt_stringa2);
            this.Controls.Add(this.lbl_stringa2);
            this.Controls.Add(this.lbl_stringa);
            this.Controls.Add(this.lbl_n1);
            this.Controls.Add(this.btn_stringa1);
            this.Controls.Add(this.txt_stringa5);
            this.Controls.Add(this.txt_stringa4);
            this.Controls.Add(this.btn_stringa);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_stringa;
        private System.Windows.Forms.TextBox txt_stringa4;
        private System.Windows.Forms.TextBox txt_stringa5;
        private System.Windows.Forms.Button btn_stringa1;
        private System.Windows.Forms.Label lbl_n1;
        private System.Windows.Forms.Label lbl_stringa;
        private System.Windows.Forms.Label lbl_stringa2;
        private System.Windows.Forms.TextBox txt_stringa2;
        private System.Windows.Forms.TextBox txt_stringa;
        private System.Windows.Forms.TextBox txt_stringa3;
        private System.Windows.Forms.TextBox txt_stringa1;
        private System.Windows.Forms.Label lbl_stringa3;
        private System.Windows.Forms.Label lbl_stringa1;
        private System.Windows.Forms.Label lbl_n6;
        private System.Windows.Forms.Label lbl_n7;
    }
}

