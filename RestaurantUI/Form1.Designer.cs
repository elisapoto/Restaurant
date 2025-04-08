namespace RestaurantUI
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnAdaugaProdus;
        private System.Windows.Forms.Button btnFinalizareComanda;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox txtNumeProdus;
        private System.Windows.Forms.TextBox txtPretProdus;
        private System.Windows.Forms.ComboBox cmbCategorie;
        private System.Windows.Forms.ListBox lstComenzi;
        private System.Windows.Forms.Label lblNumeProdus;
        private System.Windows.Forms.Label lblPretProdus;
        private System.Windows.Forms.Label lblCategorie;
        private System.Windows.Forms.Label lblComenzi;

        private void InitializeComponent()
        {
            this.btnAdaugaProdus = new System.Windows.Forms.Button();
            this.btnFinalizareComanda = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtNumeProdus = new System.Windows.Forms.TextBox();
            this.txtPretProdus = new System.Windows.Forms.TextBox();
            this.cmbCategorie = new System.Windows.Forms.ComboBox();
            this.lstComenzi = new System.Windows.Forms.ListBox();
            this.lblNumeProdus = new System.Windows.Forms.Label();
            this.lblPretProdus = new System.Windows.Forms.Label();
            this.lblCategorie = new System.Windows.Forms.Label();
            this.lblComenzi = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // btnAdaugaProdus
            this.btnAdaugaProdus.Location = new System.Drawing.Point(50, 150);
            this.btnAdaugaProdus.Name = "btnAdaugaProdus";
            this.btnAdaugaProdus.Size = new System.Drawing.Size(200, 30);
            this.btnAdaugaProdus.Text = "Adaugă Produs";
            this.btnAdaugaProdus.UseVisualStyleBackColor = true;
            this.btnAdaugaProdus.Click += new System.EventHandler(this.btnAdaugaProdus_Click);

            // btnFinalizareComanda
            this.btnFinalizareComanda.Location = new System.Drawing.Point(50, 200);
            this.btnFinalizareComanda.Name = "btnFinalizareComanda";
            this.btnFinalizareComanda.Size = new System.Drawing.Size(200, 30);
            this.btnFinalizareComanda.Text = "Finalizează Comanda";
            this.btnFinalizareComanda.UseVisualStyleBackColor = true;
            this.btnFinalizareComanda.Click += new System.EventHandler(this.btnFinalizareComanda_Click);

            // btnRefresh
            this.btnRefresh.Location = new System.Drawing.Point(50, 250);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(200, 30);
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            // txtNumeProdus
            this.txtNumeProdus.Location = new System.Drawing.Point(50, 50);
            this.txtNumeProdus.Name = "txtNumeProdus";
            this.txtNumeProdus.Size = new System.Drawing.Size(200, 20);

            // txtPretProdus
            this.txtPretProdus.Location = new System.Drawing.Point(50, 100);
            this.txtPretProdus.Name = "txtPretProdus";
            this.txtPretProdus.Size = new System.Drawing.Size(200, 20);

            // cmbCategorie
            this.cmbCategorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategorie.FormattingEnabled = true;
            this.cmbCategorie.Location = new System.Drawing.Point(50, 125);
            this.cmbCategorie.Name = "cmbCategorie";
            this.cmbCategorie.Size = new System.Drawing.Size(200, 21);

            // lstComenzi
            this.lstComenzi.FormattingEnabled = true;
            this.lstComenzi.Location = new System.Drawing.Point(300, 50);
            this.lstComenzi.Name = "lstComenzi";
            this.lstComenzi.Size = new System.Drawing.Size(400, 200);

            // Labels
            this.lblNumeProdus.Text = "Nume Produs";
            this.lblPretProdus.Text = "Preț Produs";
            this.lblCategorie.Text = "Categorie";
            this.lblComenzi.Text = "Lista Comenzi";

            // Layout
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.btnAdaugaProdus);
            this.Controls.Add(this.btnFinalizareComanda);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.txtNumeProdus);
            this.Controls.Add(this.txtPretProdus);
            this.Controls.Add(this.cmbCategorie);
            this.Controls.Add(this.lstComenzi);
            this.Controls.Add(this.lblNumeProdus);
            this.Controls.Add(this.lblPretProdus);
            this.Controls.Add(this.lblCategorie);
            this.Controls.Add(this.lblComenzi);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}