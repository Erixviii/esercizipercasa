namespace delegates6
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
            this.txtImporto = new System.Windows.Forms.TextBox();
            this.txtIndirizzo = new System.Windows.Forms.TextBox();
            this.txtCognome = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnNewCliente = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrelevamento = new System.Windows.Forms.Button();
            this.btnVersamento = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtImporto
            // 
            this.txtImporto.Location = new System.Drawing.Point(136, 255);
            this.txtImporto.Name = "txtImporto";
            this.txtImporto.Size = new System.Drawing.Size(100, 20);
            this.txtImporto.TabIndex = 25;
            // 
            // txtIndirizzo
            // 
            this.txtIndirizzo.Location = new System.Drawing.Point(145, 179);
            this.txtIndirizzo.Name = "txtIndirizzo";
            this.txtIndirizzo.Size = new System.Drawing.Size(100, 20);
            this.txtIndirizzo.TabIndex = 24;
            // 
            // txtCognome
            // 
            this.txtCognome.Location = new System.Drawing.Point(145, 149);
            this.txtCognome.Name = "txtCognome";
            this.txtCognome.Size = new System.Drawing.Size(100, 20);
            this.txtCognome.TabIndex = 23;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(145, 117);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "IMPORTO:";
            // 
            // btnNewCliente
            // 
            this.btnNewCliente.Location = new System.Drawing.Point(268, 137);
            this.btnNewCliente.Name = "btnNewCliente";
            this.btnNewCliente.Size = new System.Drawing.Size(75, 37);
            this.btnNewCliente.TabIndex = 20;
            this.btnNewCliente.Text = "NUOVO CLIENTE";
            this.btnNewCliente.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "INDIRIZZO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "COGNOME:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "NOME:";
            // 
            // lblSaldo
            // 
            this.lblSaldo.BackColor = System.Drawing.Color.White;
            this.lblSaldo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSaldo.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lblSaldo.Location = new System.Drawing.Point(250, 311);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(93, 14);
            this.lblSaldo.TabIndex = 16;
            this.lblSaldo.Text = "label2";
            this.lblSaldo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "SALDO DISPONIBILE:";
            // 
            // btnPrelevamento
            // 
            this.btnPrelevamento.Location = new System.Drawing.Point(268, 267);
            this.btnPrelevamento.Name = "btnPrelevamento";
            this.btnPrelevamento.Size = new System.Drawing.Size(108, 23);
            this.btnPrelevamento.TabIndex = 14;
            this.btnPrelevamento.Text = "PRELEVAMENTO";
            this.btnPrelevamento.UseVisualStyleBackColor = true;
            // 
            // btnVersamento
            // 
            this.btnVersamento.Location = new System.Drawing.Point(268, 238);
            this.btnVersamento.Name = "btnVersamento";
            this.btnVersamento.Size = new System.Drawing.Size(113, 23);
            this.btnVersamento.TabIndex = 13;
            this.btnVersamento.Text = "VERSAMENTO";
            this.btnVersamento.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 453);
            this.Controls.Add(this.txtImporto);
            this.Controls.Add(this.txtIndirizzo);
            this.Controls.Add(this.txtCognome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnNewCliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPrelevamento);
            this.Controls.Add(this.btnVersamento);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtImporto;
        private System.Windows.Forms.TextBox txtIndirizzo;
        private System.Windows.Forms.TextBox txtCognome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnNewCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrelevamento;
        private System.Windows.Forms.Button btnVersamento;
    }
}

