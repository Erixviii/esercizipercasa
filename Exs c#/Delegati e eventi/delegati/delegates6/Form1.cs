using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace delegates6
{
    public partial class Form1 : Form
    {
        Cliente C1;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnNewCliente_Click(object sender, EventArgs e)
        {
            //crea l'istanza C1 - nota è qui che si deve associare l'evento al sottoprogramma delegato
            C1 = new Cliente(txtNome.Text, txtCognome.Text, txtIndirizzo.Text);
            C1.Errore += GestisciErrore;

            lblSaldo.Text = C1.VisualizzaSaldo().ToString();
        }

        private void btnVersamento_Click(object sender, EventArgs e)
        {
            //Versamento
            double importo;
            bool vb = double.TryParse(txtImporto.Text, out importo);
            if (!vb)
            {
                MessageBox.Show("Campo non numerico!");
                return;
            }
            C1.Versamento(importo);
            lblSaldo.Text = C1.VisualizzaSaldo().ToString();
        }

        private void btnPrelevamento_Click(object sender, EventArgs e)
        {
            //Prelevamento
            double importo;
            bool vb = double.TryParse(txtImporto.Text, out importo);
            if (!vb)
            {
                MessageBox.Show("Campo non numerico!");
                return;
            }
            C1.Prelevamento(importo);
            lblSaldo.Text = C1.VisualizzaSaldo().ToString();
        }
        private void GestisciErrore(object sender, EventArgs e)
        {
            //Sottoprogramma delegato.
            MessageBox.Show("Prelievo non disponibile");
        }

        //sottoprogramma di errore. In questo caso ho deciso di inviare una MessageBox

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
