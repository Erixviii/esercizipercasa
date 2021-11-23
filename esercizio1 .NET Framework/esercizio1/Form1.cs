using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace esercizio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

    public class Cfrazione
    {
        private int _numeratore;
        private int _denominatore;

        public Cfrazione()
        {
            _numeratore=0;
            _denominatore=0;
        }

        public Cfrazione(int numeratore, int denominatore)
        {
            Numeratore = numeratore;
            Denominatore = denominatore;
        }

        public int Numeratore { get => _numeratore; set => _numeratore = value; }
        public int Denominatore { get => _denominatore; set => _denominatore = value; }
    }
}
