namespace NivelModele
{
    public class Produs
    {
        public string Nume { get; set; }
        public double Pret { get; set; }
        public string Categorie { get; set; }

        public Produs() { }

        public Produs(string nume, double pret, string categorie)
        {
            Nume = nume;
            Pret = pret;
            Categorie = categorie;
        }

        public override string ToString()
        {
            return $"{Nume} - {Pret} RON ({Categorie})";
        }
    }
}