namespace Clinica_Dente
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPazienti = new System.Windows.Forms.TabPage();
            this.DGVPazienti = new System.Windows.Forms.DataGridView();
            this.tabMedici = new System.Windows.Forms.TabPage();
            this.DGVMedici = new System.Windows.Forms.DataGridView();
            this.tabPatologie = new System.Windows.Forms.TabPage();
            this.DGVPatologie = new System.Windows.Forms.DataGridView();
            this.tabSpecializzazioni = new System.Windows.Forms.TabPage();
            this.DGVSpecializzazioni = new System.Windows.Forms.DataGridView();
            this.tabAppuntamenti = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.DGVAppuntamenti = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPazienti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPazienti)).BeginInit();
            this.tabMedici.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMedici)).BeginInit();
            this.tabPatologie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPatologie)).BeginInit();
            this.tabSpecializzazioni.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSpecializzazioni)).BeginInit();
            this.tabAppuntamenti.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAppuntamenti)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPazienti);
            this.tabControl1.Controls.Add(this.tabMedici);
            this.tabControl1.Controls.Add(this.tabPatologie);
            this.tabControl1.Controls.Add(this.tabSpecializzazioni);
            this.tabControl1.Controls.Add(this.tabAppuntamenti);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(934, 640);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPazienti
            // 
            this.tabPazienti.Controls.Add(this.DGVPazienti);
            this.tabPazienti.Location = new System.Drawing.Point(4, 28);
            this.tabPazienti.Margin = new System.Windows.Forms.Padding(4);
            this.tabPazienti.Name = "tabPazienti";
            this.tabPazienti.Padding = new System.Windows.Forms.Padding(4);
            this.tabPazienti.Size = new System.Drawing.Size(1051, 880);
            this.tabPazienti.TabIndex = 0;
            this.tabPazienti.Text = "Pazienti";
            this.tabPazienti.UseVisualStyleBackColor = true;
            // 
            // DGVPazienti
            // 
            this.DGVPazienti.AllowUserToAddRows = false;
            this.DGVPazienti.AllowUserToDeleteRows = false;
            this.DGVPazienti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVPazienti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPazienti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVPazienti.Location = new System.Drawing.Point(4, 4);
            this.DGVPazienti.Name = "DGVPazienti";
            this.DGVPazienti.ReadOnly = true;
            this.DGVPazienti.Size = new System.Drawing.Size(1043, 872);
            this.DGVPazienti.TabIndex = 0;
            // 
            // tabMedici
            // 
            this.tabMedici.Controls.Add(this.DGVMedici);
            this.tabMedici.Location = new System.Drawing.Point(4, 28);
            this.tabMedici.Name = "tabMedici";
            this.tabMedici.Padding = new System.Windows.Forms.Padding(3);
            this.tabMedici.Size = new System.Drawing.Size(1051, 880);
            this.tabMedici.TabIndex = 1;
            this.tabMedici.Text = "Medici";
            this.tabMedici.UseVisualStyleBackColor = true;
            // 
            // DGVMedici
            // 
            this.DGVMedici.AllowUserToAddRows = false;
            this.DGVMedici.AllowUserToDeleteRows = false;
            this.DGVMedici.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVMedici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVMedici.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVMedici.Location = new System.Drawing.Point(3, 3);
            this.DGVMedici.Name = "DGVMedici";
            this.DGVMedici.ReadOnly = true;
            this.DGVMedici.Size = new System.Drawing.Size(1045, 874);
            this.DGVMedici.TabIndex = 1;
            // 
            // tabPatologie
            // 
            this.tabPatologie.Controls.Add(this.DGVPatologie);
            this.tabPatologie.Location = new System.Drawing.Point(4, 28);
            this.tabPatologie.Name = "tabPatologie";
            this.tabPatologie.Padding = new System.Windows.Forms.Padding(3);
            this.tabPatologie.Size = new System.Drawing.Size(926, 608);
            this.tabPatologie.TabIndex = 2;
            this.tabPatologie.Text = "Patologie";
            this.tabPatologie.UseVisualStyleBackColor = true;
            // 
            // DGVPatologie
            // 
            this.DGVPatologie.AllowUserToAddRows = false;
            this.DGVPatologie.AllowUserToDeleteRows = false;
            this.DGVPatologie.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVPatologie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPatologie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVPatologie.Location = new System.Drawing.Point(3, 3);
            this.DGVPatologie.Name = "DGVPatologie";
            this.DGVPatologie.ReadOnly = true;
            this.DGVPatologie.Size = new System.Drawing.Size(920, 602);
            this.DGVPatologie.TabIndex = 1;
            // 
            // tabSpecializzazioni
            // 
            this.tabSpecializzazioni.Controls.Add(this.DGVSpecializzazioni);
            this.tabSpecializzazioni.Location = new System.Drawing.Point(4, 28);
            this.tabSpecializzazioni.Name = "tabSpecializzazioni";
            this.tabSpecializzazioni.Padding = new System.Windows.Forms.Padding(3);
            this.tabSpecializzazioni.Size = new System.Drawing.Size(1051, 880);
            this.tabSpecializzazioni.TabIndex = 3;
            this.tabSpecializzazioni.Text = "Specializzazioni";
            this.tabSpecializzazioni.UseVisualStyleBackColor = true;
            // 
            // DGVSpecializzazioni
            // 
            this.DGVSpecializzazioni.AllowUserToAddRows = false;
            this.DGVSpecializzazioni.AllowUserToDeleteRows = false;
            this.DGVSpecializzazioni.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVSpecializzazioni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVSpecializzazioni.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVSpecializzazioni.Location = new System.Drawing.Point(3, 3);
            this.DGVSpecializzazioni.Name = "DGVSpecializzazioni";
            this.DGVSpecializzazioni.ReadOnly = true;
            this.DGVSpecializzazioni.Size = new System.Drawing.Size(1045, 874);
            this.DGVSpecializzazioni.TabIndex = 1;
            // 
            // tabAppuntamenti
            // 
            this.tabAppuntamenti.Controls.Add(this.tableLayoutPanel1);
            this.tabAppuntamenti.Location = new System.Drawing.Point(4, 28);
            this.tabAppuntamenti.Name = "tabAppuntamenti";
            this.tabAppuntamenti.Padding = new System.Windows.Forms.Padding(3);
            this.tabAppuntamenti.Size = new System.Drawing.Size(926, 608);
            this.tabAppuntamenti.TabIndex = 4;
            this.tabAppuntamenti.Text = "Appuntamenti";
            this.tabAppuntamenti.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.67391F));
            this.tableLayoutPanel1.Controls.Add(this.DGVAppuntamenti, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.04984F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.95016F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(920, 602);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // DGVAppuntamenti
            // 
            this.DGVAppuntamenti.AllowUserToAddRows = false;
            this.DGVAppuntamenti.AllowUserToDeleteRows = false;
            this.DGVAppuntamenti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVAppuntamenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVAppuntamenti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVAppuntamenti.Location = new System.Drawing.Point(3, 214);
            this.DGVAppuntamenti.Name = "DGVAppuntamenti";
            this.DGVAppuntamenti.ReadOnly = true;
            this.DGVAppuntamenti.Size = new System.Drawing.Size(914, 385);
            this.DGVAppuntamenti.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 640);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPazienti.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVPazienti)).EndInit();
            this.tabMedici.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVMedici)).EndInit();
            this.tabPatologie.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVPatologie)).EndInit();
            this.tabSpecializzazioni.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVSpecializzazioni)).EndInit();
            this.tabAppuntamenti.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVAppuntamenti)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPazienti;
        private System.Windows.Forms.TabPage tabMedici;
        private System.Windows.Forms.TabPage tabPatologie;
        private System.Windows.Forms.TabPage tabSpecializzazioni;
        private System.Windows.Forms.TabPage tabAppuntamenti;
        private System.Windows.Forms.DataGridView DGVPazienti;
        private System.Windows.Forms.DataGridView DGVMedici;
        private System.Windows.Forms.DataGridView DGVPatologie;
        private System.Windows.Forms.DataGridView DGVSpecializzazioni;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView DGVAppuntamenti;
    }
}

