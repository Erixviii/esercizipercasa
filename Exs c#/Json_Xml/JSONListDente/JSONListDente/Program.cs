using System;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;


namespace JSONListDente
{
    class Program
    {
         static void Main(string[] args)
         {
            var cliente = new List<Clienti>
                {
                    new Clienti
                    {
                        Nome="Antonella Turso",
                        Email="aturso@itisrossi.vi.it",
                        DataDiAcquisto = new DateTime(2021, 3, 29),
                        TotaleVendite=1000000,
                        Eta=52
                    },
                     new Clienti
                    {
                        Nome="Alberto Costa",
                        Email="acosta@itisrossi.vi.it",
                        DataDiAcquisto = new DateTime(2021, 8, 24),
                        TotaleVendite=250000,
                        Eta=36
                    },
                      new Clienti
                    {
                        Nome="Daniel Colla",
                        Email="dani77.costa77@77gmail77.com77",
                        DataDiAcquisto = new DateTime(2021, 5, 31),
                        TotaleVendite=0,
                        Eta=14
                    }
                };
            
            Console.WriteLine("ora  stampo la lista clienti");
            Console.WriteLine(JsonConvert.SerializeObject(JsonConvert.SerializeObject(cliente)));
            Console.ReadKey();
            Console.WriteLine("ora creo e stampo altri due clienti aggiunti");
            
            var jsonString = "[{\"Nome\":\"Franco Baggio\",\"Email\":\"baggiofranco@gmail.vi.it\",\"DataDiAcquisto\":\"2021 - 04 - 16T00: 00:00\",\"TotaleVendite\":1200.0,\"Eta\":22}," +
                "{\"Nome\":\"Alberto Giannini\",\"Email\":\"agiannini@itisrossi.vi.it\",\"DataDiAcquisto\":\"2021 - 08 - 24T00: 00:00\",\"TotaleVendite\":2500.0,\"Eta\":36}]";
            var ClientiList2 = JsonConvert.DeserializeObject<List<Clienti>>(jsonString);
            File.WriteAllText("C:\\Users\\anton\\OneDrive\\Desktop\\provaJsonListe\\Clienti1.json", jsonString);
            var clientiList3 = JsonConvert.SerializeObject(ClientiList2);
            Console.WriteLine(clientiList3);

            
            var jsonString3 = File.ReadAllText("C:\\Users\\anton\\OneDrive\\Desktop\\provaJsonListe\\Clienti1.json");
            Console.ReadKey();
            Console.WriteLine("stampo ora la stessa stringa che ho salvato nel file Clienti1.JSON");
            Console.WriteLine(jsonString3);
            Console.ReadKey();
            Console.WriteLine("lista completa");
            Console.WriteLine(clienteJson + "\n" + jsonString3);
            Console.WriteLine("inserisci un nuovo record");
            var jsonString1 = Console.ReadLine();
            File.WriteAllText("C:\\Users\\anton\\OneDrive\\Desktop\\provaJsonListe\\Clienti2.json", jsonString1);
            Console.ReadKey();
            Console.WriteLine("leggo e Stampo il nuovo record che ho salvato");
            var jsonString2 = File.ReadAllText("C:\\Users\\anton\\OneDrive\\Desktop\\provaJsonListe\\Clienti2.json");
            Console.WriteLine(jsonString2);
            Console.ReadKey();


        }


        [Serializable]
        public class Clienti
        {

            public string Nome { get; set; }
            public string Email { get; set; }
            public DateTime DataDiAcquisto { get; set; }
            public decimal TotaleVendite { get; set; }
            public int Eta { get; set; }

        }

    }
}
