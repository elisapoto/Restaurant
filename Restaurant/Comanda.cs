using System.Collections.Generic;

namespace Restaurant
{
    public class Comanda
    {
        public int Id { get; set; }
        public List<Produs> Produse { get; set; } = new List<Produs>();
        public double Total => CalculeazaTotal();

        public Comanda(int id)
        {
            Id = id;
        }

        public void AdaugaProdus(Produs produs)
        {
            Produse.Add(produs);
        }

        private double CalculeazaTotal()
        {
            double suma = 0;
            foreach (var produs in Produse)
            {
                suma += produs.Pret;
            }
            return suma;
        }

        public string Info()
        {
            string produseInfo = string.Join(", ", Produse);
            return $"Comanda #{Id}: {produseInfo} | Total: {Total} RON";
        }
    }
}