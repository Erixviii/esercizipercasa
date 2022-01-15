using System;
using System.Xml;
using static System.Console;
using System.Collections.Generic;

namespace XML_dente
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("vuoi leggere(1) o scrivere(2)");
            string rs = ReadLine();
            if (rs == "2")
            {
                XmlTextWriter writer = new XmlTextWriter("C:\\Users\\4079753\\Documents\\GitHub\\esercizipercasa\\XML_Dente\\XMLstudenti.xml", null);
                writer.WriteStartDocument();
                writer.WriteStartElement("Studenti");

                List<string> nomi = new List<string>();
                string nome = "";
                string eta = "";

                for (int i = 0; i < 3; i++)
                {
                    switch (i)
                    {
                        case 0:
                            nome = "Daniele";
                            eta = "17";
                            break;
                        case 1:
                            nome = "Eric";
                            eta = "18";
                            break;
                        case 2:
                            nome = "Enrico";
                            eta = "17";
                            break;

                    }
                    writer.WriteStartElement("Studente");
                    writer.WriteStartElement("Nome");
                    writer.WriteString(nome);
                    writer.WriteEndElement();
                    writer.WriteStartElement("Età");
                    writer.WriteString(eta);
                    writer.WriteEndElement();
                    writer.WriteEndElement();
                }

                writer.WriteEndDocument();
                char[] logo = new char[3];
                logo[0] = 'D';
                logo[1] = 'E';
                logo[2] = 'E';
                writer.Close();
            }
            else if(rs == "1")
            {
                XmlTextReader reader = new XmlTextReader("C:\\Users\\4079753\\Documents\\GitHub\\esercizipercasa\\XML_Dente\\XMLstudenti.xml");

                while (reader.Read())
                {
                    if (reader.IsStartElement())
                    {
                        Write(reader.Name + " ");

                        if (reader.Name != "Studente" && reader.Name != "Studenti")
                            Write(" : "+reader.ReadString() + "\n");
                        else
                            Write("\n");
                    }
                }

                reader.Close();
            }
        }
    }
}
