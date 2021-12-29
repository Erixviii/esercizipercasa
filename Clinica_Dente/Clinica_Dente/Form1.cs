using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinica_Dente
{
    public partial class Form1 : Form
    {

        private List<Paziente> LSTpazienti;
        private List<Medico> LSTmedici;
        private List<Patologia> LSTpatologie;
        private List<Specializzazione> LSTspecializzazioni;
        private List<Appuntamento> LSTappuntamenti;

        public Form1()
        {
            InitializeComponent();
        }

        public void PazientiDaFile()
        {
            
            string[] pazienticsv = File.ReadAllLines("pazienti.csv");
            foreach (string riga in pazienticsv)
            {

                int l = 0;
                Paziente paziente = new Paziente();
                for (int i = 0; i < 7; i++)
                {

                    string parola = "";
                    while (riga[l].ToString() != ";")
                    {
                        parola += riga[l];
                        l++;
                    }

                    switch (i)
                    {
                        case 0:
                            paziente.Nome = parola;
                            break;
                        case 1:
                            paziente.Cognome = parola;
                            break;
                        case 2:
                            paziente.email = parola;
                            break;
                        case 5:
                            paziente.Patologia = parola;
                            break;
                        case 6:

                            paziente.Id = int.Parse(parola);
                            break;
                    }
                    l++;
                }
                LSTpazienti.Add(paziente);
            }
        }

        public void MediciDaFile()
        {

            string[] medicicsv = File.ReadAllLines("medici.csv");
            foreach (string riga in medicicsv)
            {

                int l = 0;
                Medico medico = new Medico();
                for (int i = 0; i < 5; i++)
                {

                    string parola = "";
                    while (riga[l].ToString() != ";")
                    {
                        parola += riga[l];
                        l++;
                    }

                    switch (i)
                    {
                        case 0:
                            medico.Nome = parola;
                            break;
                        case 1:
                            medico.Cognome = parola;
                            break;
                        case 2:
                            medico.email = parola;
                            break;
                        case 4:
                            medico.Patologia = parola;
                            break;
                        case 3:
                            medico.Id = int.Parse(parola);
                            break;
                    }
                    l++;
                }
                LSTmedici.Add(medico);
            }
        }

        public void PatologieDaFile()
        {

            string[] patologiecsv = File.ReadAllLines("patologie.csv");
            foreach (string riga in patologiecsv)
            {

                int l = 0;
                Patologia patologia = new Patologia();
                for (int i = 0; i < 2; i++)
                {

                    string parola = "";
                    while (riga[l].ToString() != ";")
                    {
                        parola += riga[l];
                        l++;
                    }

                    switch (i)
                    {
                        case 1:
                            patologia.Nome = parola;
                            break;
                        case 0:
                            patologia.Id = int.Parse(parola);
                            break;
                    }
                    l++;
                }
                LSTpatologie.Add(patologia);
            }
        }

        public void SpecializzazioniDaFile()
        {

            string[] specializzazionicsv = File.ReadAllLines("specializzazioni.csv");
            foreach (string riga in specializzazionicsv)
            {

                int l = 0;
                Specializzazione specializzazione = new Specializzazione();
                for (int i = 0; i < 2; i++)
                {

                    string parola = "";
                    while (riga[l].ToString() != ";")
                    {
                        parola += riga[l];
                        l++;
                    }

                    switch (i)
                    {
                        case 1:
                            specializzazione.Nome = parola;
                            break;
                        case 0:
                            specializzazione.Id = int.Parse(parola);
                            break;
                    }
                    l++;
                }
                LSTspecializzazioni.Add(specializzazione);
            }
        }

        public void AppuntamentiDaFile()
        {

            foreach (string riga in File.ReadAllLines("appuntamenti.csv"))
            {

                int l = 0;
                Appuntamento appuntamenti = new Appuntamento();
                for (int i = 0; i < 3; i++)
                {

                    string parola = "";
                    while (riga[l].ToString() != ";")
                    {
                        parola += riga[l];
                        l++;
                    }

                    switch (i)
                    {
                        case 0:
                            appuntamenti.Data = DateTime.Parse(parola);
                            break;
                        case 1:
                            appuntamenti.Paziente = TrovailPaziente(int.Parse(parola), 1);
                            break;
                        case 2:
                            appuntamenti.Medico = TrovailPaziente(int.Parse(parola), 2);
                            break;
                    }
                    l++;
                }
                LSTappuntamenti.Add(appuntamenti);
            }
        }

        private string TrovailPaziente(int id, int type)
        {
            if (type == 1)
            {
                foreach (Paziente i in LSTpazienti)
                {
                    if (i.Id==id)
                    {

                        return i.Nome + " " + i.Cognome;
                    }
                }
            }
            else
            {
                foreach (Medico i in LSTmedici)
                {
                    if (i.Id == id)
                    {

                        return i.Nome + " " + i.Cognome;
                    }
                }
            }

            return null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            CaricaDGV();
            CaricaCMB();
        }

        private void CaricaCMB()
        {

            foreach (Paziente p in LSTpazienti)
            {
                CMBPazienti.Items.Add(p.Nome + " "+ p.Cognome);
            }

            foreach (Medico m in LSTmedici)
            {
                CMBMedici.Items.Add(m.Nome + " " + m.Cognome);
            }

            CMBPazienti.Sorted = true;
            CMBMedici.Sorted = true;
        }

        private void CaricaDGV()
        {

            LSTpazienti = new List<Paziente>();
            LSTmedici = new List<Medico>();
            LSTpatologie = new List<Patologia>();
            LSTspecializzazioni = new List<Specializzazione>();
            LSTappuntamenti= new List<Appuntamento>();

            PazientiDaFile();
            MediciDaFile();
            PatologieDaFile();
            SpecializzazioniDaFile();
            AppuntamentiDaFile();

            DGVPazienti.DataSource = null;
            DGVMedici.DataSource = null;
            DGVPatologie.DataSource = null;
            DGVSpecializzazioni.DataSource = null;
            DGVAppuntamenti.DataSource = null;

            DGVPazienti.DataSource = LSTpazienti;
            DGVMedici.DataSource = LSTmedici;
            DGVPatologie.DataSource = LSTpatologie;
            DGVSpecializzazioni.DataSource = LSTspecializzazioni;
            DGVAppuntamenti.DataSource = LSTappuntamenti;

            DGVMedici.Columns[0].Visible = false;
            DGVMedici.Columns.Add((DataGridViewColumn)DGVMedici.Columns[1].Clone());
            DGVMedici.Columns.RemoveAt(1);
        }

        private void CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox)==checkBox1)
                TimePicker.Enabled = (sender as CheckBox).Checked;
            else if ((sender as CheckBox)==checkBox2)
                CMBPazienti.Enabled = (sender as CheckBox).Checked;
            else if ((sender as CheckBox) == checkBox3)
                CMBMedici.Enabled = (sender as CheckBox).Checked;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            DGVAppuntamenti.DataSource = null;

            DGVAppuntamenti.DataSource = LSTappuntamenti;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            List<Appuntamento> LSThelp_appuntamenti = new List<Appuntamento>();

            foreach(Appuntamento apt in LSTappuntamenti)
            {
                if (CMBMedici.Enabled)
                    if (apt.Medico == CMBMedici.Text)
                        LSThelp_appuntamenti.Add(apt);

                if (CMBPazienti.Enabled)
                    if (apt.Paziente == CMBPazienti.Text)
                        LSThelp_appuntamenti.Add(apt);

                if (TimePicker.Enabled)
                    if (apt.Data.Year == TimePicker.Value.Year && apt.Data.Month == TimePicker.Value.Month && apt.Data.Day == TimePicker.Value.Day)
                        LSThelp_appuntamenti.Add(apt);
            }

            DGVAppuntamenti.DataSource = null;
            DGVAppuntamenti.DataSource = LSThelp_appuntamenti;
        }
    }
}
