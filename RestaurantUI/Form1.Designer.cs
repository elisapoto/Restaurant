namespace RestaurantUI
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.grpActiuni = new System.Windows.Forms.GroupBox();
            this.tblActiuni = new System.Windows.Forms.TableLayoutPanel();
            this.btnFinalizareComanda = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblCautaId = new System.Windows.Forms.Label();
            this.txtCautaId = new System.Windows.Forms.TextBox();
            this.btnCautaId = new System.Windows.Forms.Button();
            this.grpAdaugaProdus = new System.Windows.Forms.GroupBox();
            this.tblProdus = new System.Windows.Forms.TableLayoutPanel();
            this.lblNumeProdus = new System.Windows.Forms.Label();
            this.txtNumeProdus = new System.Windows.Forms.TextBox();
            this.lblPretProdus = new System.Windows.Forms.Label();
            this.txtPretProdus = new System.Windows.Forms.TextBox();
            this.lblCategorie = new System.Windows.Forms.Label();
            this.cmbCategorie = new System.Windows.Forms.ComboBox();
            this.btnAdaugaProdus = new System.Windows.Forms.Button();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.grpComenzi = new System.Windows.Forms.GroupBox();
            this.lstComenzi = new System.Windows.Forms.ListBox();
            this.pnlLeft.SuspendLayout();
            this.grpActiuni.SuspendLayout();
            this.tblActiuni.SuspendLayout();
            this.grpAdaugaProdus.SuspendLayout();
            this.tblProdus.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.grpComenzi.SuspendLayout();
            this.SuspendLayout();

            // pnlLeft
            this.pnlLeft.BackColor = System.Drawing.Color.White;
            this.pnlLeft.Controls.Add(this.grpActiuni);
            this.pnlLeft.Controls.Add(this.grpAdaugaProdus);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Padding = new System.Windows.Forms.Padding(20);
            this.pnlLeft.Size = new System.Drawing.Size(350, 600);
            this.pnlLeft.TabIndex = 0;

            // grpActiuni
            this.grpActiuni.Controls.Add(this.tblActiuni);
            this.grpActiuni.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpActiuni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.grpActiuni.Location = new System.Drawing.Point(20, 270);
            this.grpActiuni.Name = "grpActiuni";
            this.grpActiuni.Size = new System.Drawing.Size(310, 180);
            this.grpActiuni.TabIndex = 1;
            this.grpActiuni.TabStop = false;
            this.grpActiuni.Text = "Acțiuni Comandă";

            // tblActiuni
            this.tblActiuni.ColumnCount = 2;
            this.tblActiuni.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblActiuni.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblActiuni.Controls.Add(this.btnFinalizareComanda, 0, 0);
            this.tblActiuni.Controls.Add(this.btnRefresh, 1, 0);
            this.tblActiuni.Controls.Add(this.lblCautaId, 0, 1);
            this.tblActiuni.Controls.Add(this.txtCautaId, 0, 2);
            this.tblActiuni.Controls.Add(this.btnCautaId, 1, 2);
            this.tblActiuni.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblActiuni.Location = new System.Drawing.Point(3, 19);
            this.tblActiuni.Name = "tblActiuni";
            this.tblActiuni.RowCount = 3;
            this.tblActiuni.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblActiuni.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tblActiuni.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblActiuni.Size = new System.Drawing.Size(304, 158);
            this.tblActiuni.TabIndex = 0;

            // btnFinalizareComanda
            this.btnFinalizareComanda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnFinalizareComanda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFinalizareComanda.FlatAppearance.BorderSize = 0;
            this.btnFinalizareComanda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizareComanda.ForeColor = System.Drawing.Color.White;
            this.btnFinalizareComanda.Location = new System.Drawing.Point(3, 3);
            this.btnFinalizareComanda.Name = "btnFinalizareComanda";
            this.btnFinalizareComanda.Size = new System.Drawing.Size(146, 56);
            this.btnFinalizareComanda.TabIndex = 0;
            this.btnFinalizareComanda.Text = "Finalizează Comanda";
            this.btnFinalizareComanda.UseVisualStyleBackColor = false;

            // btnRefresh
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(155, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(146, 56);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Reîmprospătează Lista";
            this.btnRefresh.UseVisualStyleBackColor = false;

            // lblCautaId
            this.lblCautaId.AutoSize = true;
            this.tblActiuni.SetColumnSpan(this.lblCautaId, 2);
            this.lblCautaId.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCautaId.Location = new System.Drawing.Point(3, 62);
            this.lblCautaId.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.lblCautaId.Name = "lblCautaId";
            this.lblCautaId.Size = new System.Drawing.Size(298, 17);
            this.lblCautaId.TabIndex = 2;
            this.lblCautaId.Text = "Caută comandă după ID:";

            // txtCautaId
            this.tblActiuni.SetColumnSpan(this.txtCautaId, 2);
            this.txtCautaId.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtCautaId.Location = new System.Drawing.Point(3, 84);
            this.txtCautaId.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.txtCautaId.Name = "txtCautaId";
            this.txtCautaId.Size = new System.Drawing.Size(298, 23);
            this.txtCautaId.TabIndex = 3;

            // btnCautaId
            this.btnCautaId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.btnCautaId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCautaId.FlatAppearance.BorderSize = 0;
            this.btnCautaId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCautaId.ForeColor = System.Drawing.Color.White;
            this.btnCautaId.Location = new System.Drawing.Point(155, 112);
            this.btnCautaId.Name = "btnCautaId";
            this.btnCautaId.Size = new System.Drawing.Size(146, 43);
            this.btnCautaId.TabIndex = 4;
            this.btnCautaId.Text = "Caută";
            this.btnCautaId.UseVisualStyleBackColor = false;

            // grpAdaugaProdus
            this.grpAdaugaProdus.Controls.Add(this.tblProdus);
            this.grpAdaugaProdus.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpAdaugaProdus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.grpAdaugaProdus.Location = new System.Drawing.Point(20, 20);
            this.grpAdaugaProdus.Name = "grpAdaugaProdus";
            this.grpAdaugaProdus.Size = new System.Drawing.Size(310, 250);
            this.grpAdaugaProdus.TabIndex = 0;
            this.grpAdaugaProdus.TabStop = false;
            this.grpAdaugaProdus.Text = "Adaugă Produs";

            // tblProdus
            this.tblProdus.ColumnCount = 2;
            this.tblProdus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tblProdus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tblProdus.Controls.Add(this.lblNumeProdus, 0, 0);
            this.tblProdus.Controls.Add(this.txtNumeProdus, 1, 0);
            this.tblProdus.Controls.Add(this.lblPretProdus, 0, 1);
            this.tblProdus.Controls.Add(this.txtPretProdus, 1, 1);
            this.tblProdus.Controls.Add(this.lblCategorie, 0, 2);
            this.tblProdus.Controls.Add(this.cmbCategorie, 1, 2);
            this.tblProdus.Controls.Add(this.btnAdaugaProdus, 0, 3);
            this.tblProdus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblProdus.Location = new System.Drawing.Point(3, 19);
            this.tblProdus.Name = "tblProdus";
            this.tblProdus.RowCount = 4;
            this.tblProdus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblProdus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblProdus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblProdus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblProdus.Size = new System.Drawing.Size(304, 228);
            this.tblProdus.TabIndex = 0;

            // lblNumeProdus
            this.lblNumeProdus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNumeProdus.AutoSize = true;
            this.lblNumeProdus.Location = new System.Drawing.Point(3, 19);
            this.lblNumeProdus.Name = "lblNumeProdus";
            this.lblNumeProdus.Size = new System.Drawing.Size(84, 17);
            this.lblNumeProdus.TabIndex = 0;
            this.lblNumeProdus.Text = "Nume Produs:";

            // txtNumeProdus
            this.txtNumeProdus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNumeProdus.Location = new System.Drawing.Point(94, 3);
            this.txtNumeProdus.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.txtNumeProdus.Name = "txtNumeProdus";
            this.txtNumeProdus.Size = new System.Drawing.Size(207, 23);
            this.txtNumeProdus.TabIndex = 1;

            // lblPretProdus
            this.lblPretProdus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPretProdus.AutoSize = true;
            this.lblPretProdus.Location = new System.Drawing.Point(3, 76);
            this.lblPretProdus.Name = "lblPretProdus";
            this.lblPretProdus.Size = new System.Drawing.Size(72, 17);
            this.lblPretProdus.TabIndex = 2;
            this.lblPretProdus.Text = "Preț Produs:";

            // txtPretProdus
            this.txtPretProdus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPretProdus.Location = new System.Drawing.Point(94, 60);
            this.txtPretProdus.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.txtPretProdus.Name = "txtPretProdus";
            this.txtPretProdus.Size = new System.Drawing.Size(207, 23);
            this.txtPretProdus.TabIndex = 3;

            // lblCategorie
            this.lblCategorie.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCategorie.AutoSize = true;
            this.lblCategorie.Location = new System.Drawing.Point(3, 133);
            this.lblCategorie.Name = "lblCategorie";
            this.lblCategorie.Size = new System.Drawing.Size(63, 17);
            this.lblCategorie.TabIndex = 4;
            this.lblCategorie.Text = "Categorie:";

            // cmbCategorie
            this.cmbCategorie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbCategorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategorie.FormattingEnabled = true;
            this.cmbCategorie.Location = new System.Drawing.Point(94, 117);
            this.cmbCategorie.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.cmbCategorie.Name = "cmbCategorie";
            this.cmbCategorie.Size = new System.Drawing.Size(207, 25);
            this.cmbCategorie.TabIndex = 5;

            // btnAdaugaProdus
            this.btnAdaugaProdus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.tblProdus.SetColumnSpan(this.btnAdaugaProdus, 2);
            this.btnAdaugaProdus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdaugaProdus.FlatAppearance.BorderSize = 0;
            this.btnAdaugaProdus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdaugaProdus.ForeColor = System.Drawing.Color.White;
            this.btnAdaugaProdus.Location = new System.Drawing.Point(3, 174);
            this.btnAdaugaProdus.Name = "btnAdaugaProdus";
            this.btnAdaugaProdus.Size = new System.Drawing.Size(298, 51);
            this.btnAdaugaProdus.TabIndex = 6;
            this.btnAdaugaProdus.Text = "Adaugă Produs";
            this.btnAdaugaProdus.UseVisualStyleBackColor = false;

            // pnlRight
            this.pnlRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.pnlRight.Controls.Add(this.grpComenzi);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Location = new System.Drawing.Point(350, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Padding = new System.Windows.Forms.Padding(20);
            this.pnlRight.Size = new System.Drawing.Size(550, 600);
            this.pnlRight.TabIndex = 1;

            // grpComenzi
            this.grpComenzi.Controls.Add(this.lstComenzi);
            this.grpComenzi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpComenzi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.grpComenzi.Location = new System.Drawing.Point(20, 20);
            this.grpComenzi.Name = "grpComenzi";
            this.grpComenzi.Size = new System.Drawing.Size(510, 560);
            this.grpComenzi.TabIndex = 0;
            this.grpComenzi.TabStop = false;
            this.grpComenzi.Text = "Lista Comenzi";

            // lstComenzi
            this.lstComenzi.BackColor = System.Drawing.Color.White;
            this.lstComenzi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstComenzi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstComenzi.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstComenzi.FormattingEnabled = true;
            this.lstComenzi.ItemHeight = 15;
            this.lstComenzi.Location = new System.Drawing.Point(3, 19);
            this.lstComenzi.Name = "lstComenzi";
            this.lstComenzi.Size = new System.Drawing.Size(504, 538);
            this.lstComenzi.TabIndex = 0;

            // Form1
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restaurant Management System";
            this.pnlLeft.ResumeLayout(false);
            this.grpActiuni.ResumeLayout(false);
            this.tblActiuni.ResumeLayout(false);
            this.tblActiuni.PerformLayout();
            this.grpAdaugaProdus.ResumeLayout(false);
            this.tblProdus.ResumeLayout(false);
            this.tblProdus.PerformLayout();
            this.pnlRight.ResumeLayout(false);
            this.grpComenzi.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.GroupBox grpActiuni;
        private System.Windows.Forms.TableLayoutPanel tblActiuni;
        private System.Windows.Forms.Button btnFinalizareComanda;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblCautaId;
        private System.Windows.Forms.TextBox txtCautaId;
        private System.Windows.Forms.Button btnCautaId;
        private System.Windows.Forms.GroupBox grpAdaugaProdus;
        private System.Windows.Forms.TableLayoutPanel tblProdus;
        private System.Windows.Forms.Label lblNumeProdus;
        private System.Windows.Forms.TextBox txtNumeProdus;
        private System.Windows.Forms.Label lblPretProdus;
        private System.Windows.Forms.TextBox txtPretProdus;
        private System.Windows.Forms.Label lblCategorie;
        private System.Windows.Forms.ComboBox cmbCategorie;
        private System.Windows.Forms.Button btnAdaugaProdus;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.GroupBox grpComenzi;
        private System.Windows.Forms.ListBox lstComenzi;
    }
}