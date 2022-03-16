using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace delegates5
{
    public partial class Form1 : Form
    {
        bool verifica = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnEsegui_Click(object sender, EventArgs e)
        {
            Persona per1;
            per1 = new Persona();
            //non può essere usato il costruttore ma solo la proprietà set in quanto l'evento
            //deve essere associato al sottoprogramma prima che nella classe sia generato 
            //l'evento.
            per1.Errore += GestisciErrore; //associo l'evento errore ad un sottoprogramma
                                           // con += (nel nostro caso a GestisciErrore)
            per1.nome = txtNome.Text;
            per1.eta = txtEta.Text; //nell'esecuzione della proprietà set viene eventualmente generato l'evento
            if (verifica)
                MessageBox.Show(per1.nome + " - " + per1.eta);


        }
        private void GestisciErrore(object sender, System.EventArgs e)
        {
            //sottoprogramma di errore. In questo caso ho deciso di inviare una MessageBox
            MessageBox.Show("Errore: Età non numerica");
            verifica = false;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
