using System;
using System.Collections.Generic;

namespace Restaurant
{
    class Program
    {
        static void Main()
        {
            List<Comanda> comenzi = new List<Comanda>();
            string optiune;

            do
            {
                Console.WriteLine("C. Creare comanda");
                Console.WriteLine("A. Afisare comenzi");
                Console.WriteLine("F. Cautare comanda după ID");
                Console.WriteLine("X. Iesire");
                Console.Write("Alegeti o optiune: ");
                optiune = Console.ReadLine().ToUpper();

                switch (optiune)
                {
                    case "C":
                        Comanda nouaComanda = CitireComandaTastatura();
                        comenzi.Add(nouaComanda);
                        Console.WriteLine("Comanda a fost adaugata!");
                        break;

                    case "A":
                        AfisareComenzi(comenzi);
                        break;

                    case "F":
                        Console.Write("Introduceti ID-ul comenzii: ");
                        int idCautat = int.Parse(Console.ReadLine());
                        CautareComanda(comenzi, idCautat);
                        break;

                    case "X":
                        return;

                    default:
                        Console.WriteLine("Optoine invalida!");
                        break;
                }
            } while (optiune != "X");
        }

        public static Comanda CitireComandaTastatura()
        {
            Console.Write("Introducei ID-ul comenzii: ");
            int id = int.Parse(Console.ReadLine());
            Comanda comanda = new Comanda(id);

            while (true)
            {
                Console.Write("Introduceti numele produsului (sau 'stop' pentru a termina): ");
                string nume = Console.ReadLine();
                if (nume.ToLower() == "stop") break;

                Console.Write("Introduceti pretul produsului: ");
                double pret = double.Parse(Console.ReadLine());
                Console.Write("Introduceti categoria produsului: ");
                string categorie = Console.ReadLine();

                Produs produs = new Produs(nume, pret, categorie);
                comanda.AdaugaProdus(produs);
            }

            return comanda;
        }

        public static void AfisareComenzi(List<Comanda> comenzi)
        {
            foreach (var comanda in comenzi)
            {
                Console.WriteLine(comanda.Info());
            }
        }

        public static void CautareComanda(List<Comanda> comenzi, int id)
        {
            Comanda gasita = comenzi.Find(c => c.Id == id);
            if (gasita != null)
            {
                Console.WriteLine("Comanda gasita: " + gasita.Info());
            }
            else
            {
                Console.WriteLine("Comanda nu a fost gasita.");
            }
        }
    }
}