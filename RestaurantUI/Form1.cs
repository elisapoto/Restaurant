using System;
using System.Collections.Generic;
using System.Windows.Forms;
using NvlModele;
using Nvlstocaredate;

namespace RestaurantUI
{
    public partial class Form1 : Form
    {
        private AdministrareComenzi_Fisier adminComenzi;
        private Comanda comandaCurenta;
        private const string NUME_FISIER = "comenzi.txt";

        public Form1()
        {
            InitializeComponent();
            adminComenzi = new AdministrareComenzi_Fisier(NUME_FISIER);
            IncarcaCategorii();
            AfiseazaComenzi();
        }

        private void IncarcaCategorii()
        {
            cmbCategorie.DataSource = Enum.GetValues(typeof(CategorieProdus));
        }

        private void AfiseazaComenzi()
        {
            lstComenzi.Items.Clear();
            var comenzi = adminComenzi.GetAllComenzi();

            foreach (var comanda in comenzi)
            {
                lstComenzi.Items.Add($"Comanda #{comanda.Id} - {comanda.Produse.Count} produse");
            }
        }

        private void btnAdaugaProdus_Click(object sender, EventArgs e)
        {
            if (comandaCurenta == null)
            {
                comandaCurenta = new Comanda(GetNextComandaId());
            }

            if (!ValideazaProdus())
                return;

            Produs produs = new Produs(
                txtNumeProdus.Text,
                double.Parse(txtPretProdus.Text),
                (CategorieProdus)cmbCategorie.SelectedItem
            );

            comandaCurenta.AdaugaProdus(produs);
            MessageBox.Show("Produs adăugat la comandă!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Reset form pentru a adăuga alt produs
            txtNumeProdus.Clear();
            txtPretProdus.Clear();
        }

        private void btnFinalizareComanda_Click(object sender, EventArgs e)
        {
            if (comandaCurenta != null && comandaCurenta.Produse.Count > 0)
            {
                adminComenzi.AddComanda(comandaCurenta);
                comandaCurenta = null;  // Resetăm comanda curentă
                AfiseazaComenzi();
                MessageBox.Show("Comanda a fost finalizată și salvată!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Nu ați adăugat niciun produs la comandă!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            AfiseazaComenzi();  // Reîncarcă lista de comenzi
        }

        private bool ValideazaProdus()
        {
            if (string.IsNullOrWhiteSpace(txtNumeProdus.Text))
            {
                MessageBox.Show("Numele produsului nu poate fi gol!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!double.TryParse(txtPretProdus.Text, out double pret) || pret <= 0)
            {
                MessageBox.Show("Preț invalid! Introduceți o valoare validă.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private int GetNextComandaId()
        {
            return adminComenzi.GetAllComenzi().Count + 1;  // Obținem ID-ul următoarei comenzi
        }
    }
}