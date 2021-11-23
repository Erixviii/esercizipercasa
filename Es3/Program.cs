using System;
using static System.Console;

namespace esercizio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona eric = new Persona();

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

            Studente eric2 = new Studente("4079753");
            eric2.Nome = "Eric";
            WriteLine($"nome studente: {eric2.Nome}");
            eric2.Cognome = "Dente";
            WriteLine($"cognome studente: {eric2.Cognome}");
            eric2.Eta = 18;
            WriteLine($"età studente: {eric2.Eta}");
            WriteLine($"età studente: {eric2.Matricola}");
        }
    }
}