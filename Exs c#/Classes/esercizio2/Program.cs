using System;
using static System.Console;

namespace esercizio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona eric = new Persona();

            WriteLine("Inserisci nome:");       
            eric.Nome = ReadLine();
            WriteLine("Inserisci cognome:");
            eric.Cognome = ReadLine();
            WriteLine("Inserisci sesso:");
            eric.Sesso = ReadLine();
            
            WriteLine("prova_Classi.Persona");
            WriteLine(eric.ToString());
            WriteLine("prova_Classi.Persona");
            WriteLine("Ora utilizzo la proprietà per modificare il nome");
            eric.Nome = "";
            WriteLine($"Nuovo nome: {eric.Nome}");
            eric.Nome = "Eric";
            WriteLine($"Nuovo nome: {eric.Nome}");
            eric.Eta = 120;
            WriteLine($"eta: {eric.Eta}");
            eric.Eta = 0;
            WriteLine($"eta: {eric.Eta}");
            eric.Eta = -5;
            WriteLine($"eta: {eric.Eta}");
            eric.Eta = 20;
            WriteLine($"eta: {eric.Eta}");
            eric.StampaMessaggio();
            eric.Saluti();
        }
    }
}
