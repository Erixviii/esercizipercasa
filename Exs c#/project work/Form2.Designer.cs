
namespace project_work
{
    partial class Form2
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TXTname = new System.Windows.Forms.TextBox();
            this.TXTemail = new System.Windows.Forms.TextBox();
            this.TXTpassword = new System.Windows.Forms.TextBox();
            this.TXTcode = new System.Windows.Forms.TextBox();
            this.TXTcity = new System.Windows.Forms.TextBox();
            this.TXTbirth = new System.Windows.Forms.TextBox();
            this.TXTrole = new System.Windows.Forms.TextBox();
            this.TXTsurname = new System.Windows.Forms.TextBox();
            this.GRPinfo = new System.Windows.Forms.GroupBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.GRPinfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(6, 10);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.GRPinfo);
            this.tabPage1.Controls.Add(this.checkBox1);
            this.tabPage1.Controls.Add(this.checkBox2);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.listBox1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 36);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 410);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Users";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 318);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(580, 62);
            this.dataGridView1.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(629, 337);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 26);
            this.button2.TabIndex = 10;
            this.button2.Text = "Add";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(26, 78);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(201, 186);
            this.listBox1.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Tomato;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(629, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 26);
            this.button1.TabIndex = 5;
            this.button1.Text = "Delete";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 36);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 410);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(26, 34);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(60, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "See list";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(164, 34);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(45, 17);
            this.checkBox2.TabIndex = 12;
            this.checkBox2.Text = "Add";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "birth";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "city";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(135, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "role";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(135, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "surname";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "name";
            // 
            // TXTname
            // 
            this.TXTname.Location = new System.Drawing.Point(18, 32);
            this.TXTname.Name = "TXTname";
            this.TXTname.Size = new System.Drawing.Size(93, 20);
            this.TXTname.TabIndex = 29;
            // 
            // TXTemail
            // 
            this.TXTemail.Location = new System.Drawing.Point(18, 77);
            this.TXTemail.Name = "TXTemail";
            this.TXTemail.Size = new System.Drawing.Size(93, 20);
            this.TXTemail.TabIndex = 30;
            // 
            // TXTpassword
            // 
            this.TXTpassword.Location = new System.Drawing.Point(18, 121);
            this.TXTpassword.Name = "TXTpassword";
            this.TXTpassword.Size = new System.Drawing.Size(93, 20);
            this.TXTpassword.TabIndex = 31;
            // 
            // TXTcode
            // 
            this.TXTcode.Location = new System.Drawing.Point(18, 166);
            this.TXTcode.Name = "TXTcode";
            this.TXTcode.Size = new System.Drawing.Size(93, 20);
            this.TXTcode.TabIndex = 32;
            // 
            // TXTcity
            // 
            this.TXTcity.Location = new System.Drawing.Point(138, 166);
            this.TXTcity.Name = "TXTcity";
            this.TXTcity.Size = new System.Drawing.Size(93, 20);
            this.TXTcity.TabIndex = 33;
            // 
            // TXTbirth
            // 
            this.TXTbirth.Location = new System.Drawing.Point(138, 121);
            this.TXTbirth.Name = "TXTbirth";
            this.TXTbirth.Size = new System.Drawing.Size(93, 20);
            this.TXTbirth.TabIndex = 34;
            // 
            // TXTrole
            // 
            this.TXTrole.Location = new System.Drawing.Point(138, 77);
            this.TXTrole.Name = "TXTrole";
            this.TXTrole.Size = new System.Drawing.Size(93, 20);
            this.TXTrole.TabIndex = 35;
            // 
            // TXTsurname
            // 
            this.TXTsurname.Location = new System.Drawing.Point(138, 32);
            this.TXTsurname.Name = "TXTsurname";
            this.TXTsurname.Size = new System.Drawing.Size(93, 20);
            this.TXTsurname.TabIndex = 36;
            // 
            // GRPinfo
            // 
            this.GRPinfo.Controls.Add(this.label6);
            this.GRPinfo.Controls.Add(this.TXTsurname);
            this.GRPinfo.Controls.Add(this.label8);
            this.GRPinfo.Controls.Add(this.TXTrole);
            this.GRPinfo.Controls.Add(this.label7);
            this.GRPinfo.Controls.Add(this.TXTbirth);
            this.GRPinfo.Controls.Add(this.label5);
            this.GRPinfo.Controls.Add(this.TXTcity);
            this.GRPinfo.Controls.Add(this.label4);
            this.GRPinfo.Controls.Add(this.TXTcode);
            this.GRPinfo.Controls.Add(this.label3);
            this.GRPinfo.Controls.Add(this.TXTpassword);
            this.GRPinfo.Controls.Add(this.label2);
            this.GRPinfo.Controls.Add(this.TXTemail);
            this.GRPinfo.Controls.Add(this.label1);
            this.GRPinfo.Controls.Add(this.TXTname);
            this.GRPinfo.Location = new System.Drawing.Point(306, 68);
            this.GRPinfo.Name = "GRPinfo";
            this.GRPinfo.Size = new System.Drawing.Size(243, 196);
            this.GRPinfo.TabIndex = 37;
            this.GRPinfo.TabStop = false;
            this.GRPinfo.Text = "info";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.ShowIcon = false;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.GRPinfo.ResumeLayout(false);
            this.GRPinfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox TXTsurname;
        private System.Windows.Forms.TextBox TXTrole;
        private System.Windows.Forms.TextBox TXTbirth;
        private System.Windows.Forms.TextBox TXTcity;
        private System.Windows.Forms.TextBox TXTcode;
        private System.Windows.Forms.TextBox TXTpassword;
        private System.Windows.Forms.TextBox TXTemail;
        private System.Windows.Forms.TextBox TXTname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox GRPinfo;
    }
}