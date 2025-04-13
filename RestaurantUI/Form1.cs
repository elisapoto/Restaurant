using System;
using System.Windows.Forms;
using NivelStocareDate;
using NvlModele;

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
            var comenzi = adminComenzi.GetComenzi();

            foreach (var comanda in comenzi)
            {
                lstComenzi.Items.Add(comanda.ToString());
            }
        }

        private void btnCautaId_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtCautaId.Text, out int id))
            {
                Comanda comandaGasita = adminComenzi.GetComandaById(id);

                if (comandaGasita != null)
                {
                    lstComenzi.Items.Clear();
                    lstComenzi.Items.Add(comandaGasita.ToString());
                    lstComenzi.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show($"Comanda cu ID-ul {id} nu a fost găsită.", "Căutare",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Introduceți un ID valid (număr întreg).", "Eroare",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdaugaProdus_Click(object sender, EventArgs e)
        {
            if (comandaCurenta == null)
            {
                comandaCurenta = new Comanda(adminComenzi.GetNextComandaId());
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

            txtNumeProdus.Clear();
            txtPretProdus.Clear();
            txtNumeProdus.Focus();
        }

        private void btnFinalizareComanda_Click(object sender, EventArgs e)
        {
            if (comandaCurenta != null && comandaCurenta.Produse.Count > 0)
            {
                adminComenzi.AddComanda(comandaCurenta);
                comandaCurenta = null;
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
            txtCautaId.Clear();
            AfiseazaComenzi();
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
                MessageBox.Show("Preț invalid! Introduceți o valoare pozitivă.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}