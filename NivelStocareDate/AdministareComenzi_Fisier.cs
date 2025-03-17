using System;
using System.Collections.Generic;
using System.IO;
using NivelModele;

namespace NivelStocareDate
{
    public class AdministrareComenzi_Fisier
    {
        private string numeFisier;

        public AdministrareComenzi_Fisier(string numeFisier)
        {
            this.numeFisier = numeFisier;
            if (!File.Exists(numeFisier))
            {
                File.Create(numeFisier).Close();
            }
        }

        public void AddComanda(Comanda comanda)
        {
            using (StreamWriter sw = new StreamWriter(numeFisier, true))
            {
                foreach (Produs produs in comanda.Produse)
                {
                    sw.WriteLine($"{comanda.Id};{produs.Nume};{produs.Pret};{produs.Categorie}");
                }
            }
        }

        public List<Comanda> GetComenzi()
        {
            List<Comanda> comenzi = new List<Comanda>();
            Dictionary<int, Comanda> comenziTemp = new Dictionary<int, Comanda>();

            using (StreamReader sr = new StreamReader(numeFisier))
            {
                string linie;
                while ((linie = sr.ReadLine()) != null)
                {
                    string[] valori = linie.Split(';');

                    if (valori.Length == 4) // ID, Nume, Pret, Categorie
                    {
                        int id = int.Parse(valori[0]);
                        string nume = valori[1];
                        double pret = double.Parse(valori[2]);
                        string categorie = valori[3];

                        Produs produs = new Produs(nume, pret, categorie);

                        if (!comenziTemp.ContainsKey(id))
                        {
                            comenziTemp[id] = new Comanda(id);
                        }

                        comenziTemp[id].AdaugaProdus(produs);
                    }
                }
            }

            comenzi.AddRange(comenziTemp.Values);
            return comenzi;
        }
    }
}