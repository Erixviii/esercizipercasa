using System;

namespace delegates5
{
    class Persona
    {
        private string _nome;
        private string _eta;
        //definisco il metodo evento che chiamo Errore
        public event EventHandler Errore;

        public string nome
        {
            set { _nome = value; }
            get { return _nome; }
        }
        public string eta
        {
            set
            {
                int num;
                bool ver;
                ver = int.TryParse(value, out num);
                if (!ver)
                    Errore(this, new EventArgs());
                //se si verifica un errore creo l'evento che ha come parametri l'oggetto 
                //creato (this = Errore) e un oggetto EventArgs che serve per passare 
                //informazioni.... (in questo caso nessuno). I due parametri sono OBBLIGATORI
                else
                    _eta = num.ToString();
            }
            get { return _eta; }
        }

    }
}
