namespace BelbachaBoutique
{
    partial class FrmGesLivraison
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGesLivraison));
            this.tbGestLivraison = new MaterialSkin.Controls.MaterialTabControl();
            this.tbpAjoutLivraison = new System.Windows.Forms.TabPage();
            this.cbProduitAjout = new MaterialSkin.Controls.MaterialComboBox();
            this.btnAjoutLivraison = new MaterialSkin.Controls.MaterialButton();
            this.txtPrixLivraisonAjout = new MaterialSkin.Controls.MaterialTextBox();
            this.txtQteLivreAjout = new MaterialSkin.Controls.MaterialTextBox();
            this.cbFournisseurProduitAjout = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.tbpModifLivraison = new System.Windows.Forms.TabPage();
            this.cbDateLivraison = new MaterialSkin.Controls.MaterialComboBox();
            this.btnModifLivraison = new MaterialSkin.Controls.MaterialButton();
            this.txtPrixLivraison = new MaterialSkin.Controls.MaterialTextBox();
            this.txtQuantiteProduitLivre = new MaterialSkin.Controls.MaterialTextBox();
            this.cbFournisseurDuProduit = new MaterialSkin.Controls.MaterialComboBox();
            this.lblProduitFourniNameValue = new MaterialSkin.Controls.MaterialLabel();
            this.lblProduitFourniName = new MaterialSkin.Controls.MaterialLabel();
            this.lblLivraison = new MaterialSkin.Controls.MaterialLabel();
            this.tbpSupprLivraison = new System.Windows.Forms.TabPage();
            this.btnSupprimerLivraison = new MaterialSkin.Controls.MaterialButton();
            this.cbDateLivraisonSuppr = new MaterialSkin.Controls.MaterialComboBox();
            this.cbProduitSuppr = new MaterialSkin.Controls.MaterialComboBox();
            this.cbFourniSuppr = new MaterialSkin.Controls.MaterialComboBox();
            this.lblSupprLivraison = new MaterialSkin.Controls.MaterialLabel();
            this.lstImgAjoutIcon = new System.Windows.Forms.ImageList(this.components);
            this.tbGestLivraison.SuspendLayout();
            this.tbpAjoutLivraison.SuspendLayout();
            this.tbpModifLivraison.SuspendLayout();
            this.tbpSupprLivraison.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbGestLivraison
            // 
            this.tbGestLivraison.Controls.Add(this.tbpAjoutLivraison);
            this.tbGestLivraison.Controls.Add(this.tbpModifLivraison);
            this.tbGestLivraison.Controls.Add(this.tbpSupprLivraison);
            this.tbGestLivraison.Depth = 0;
            this.tbGestLivraison.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbGestLivraison.ImageList = this.lstImgAjoutIcon;
            this.tbGestLivraison.Location = new System.Drawing.Point(3, 64);
            this.tbGestLivraison.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbGestLivraison.Multiline = true;
            this.tbGestLivraison.Name = "tbGestLivraison";
            this.tbGestLivraison.SelectedIndex = 0;
            this.tbGestLivraison.Size = new System.Drawing.Size(794, 542);
            this.tbGestLivraison.TabIndex = 0;
            this.tbGestLivraison.SelectedIndexChanged += new System.EventHandler(this.tbGestLivraison_SelectedIndexChanged);
            // 
            // tbpAjoutLivraison
            // 
            this.tbpAjoutLivraison.BackColor = System.Drawing.Color.White;
            this.tbpAjoutLivraison.Controls.Add(this.cbProduitAjout);
            this.tbpAjoutLivraison.Controls.Add(this.btnAjoutLivraison);
            this.tbpAjoutLivraison.Controls.Add(this.txtPrixLivraisonAjout);
            this.tbpAjoutLivraison.Controls.Add(this.txtQteLivreAjout);
            this.tbpAjoutLivraison.Controls.Add(this.cbFournisseurProduitAjout);
            this.tbpAjoutLivraison.Controls.Add(this.materialLabel3);
            this.tbpAjoutLivraison.Location = new System.Drawing.Point(4, 25);
            this.tbpAjoutLivraison.Name = "tbpAjoutLivraison";
            this.tbpAjoutLivraison.Padding = new System.Windows.Forms.Padding(3);
            this.tbpAjoutLivraison.Size = new System.Drawing.Size(786, 513);
            this.tbpAjoutLivraison.TabIndex = 1;
            this.tbpAjoutLivraison.Text = "Ajouter une livraison";
            this.tbpAjoutLivraison.Click += new System.EventHandler(this.tbpAjoutLivraison_Click);
            // 
            // cbProduitAjout
            // 
            this.cbProduitAjout.AutoResize = false;
            this.cbProduitAjout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbProduitAjout.Depth = 0;
            this.cbProduitAjout.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbProduitAjout.DropDownHeight = 174;
            this.cbProduitAjout.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProduitAjout.DropDownWidth = 121;
            this.cbProduitAjout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbProduitAjout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbProduitAjout.FormattingEnabled = true;
            this.cbProduitAjout.Hint = "Produit";
            this.cbProduitAjout.IntegralHeight = false;
            this.cbProduitAjout.ItemHeight = 43;
            this.cbProduitAjout.Location = new System.Drawing.Point(207, 111);
            this.cbProduitAjout.MaxDropDownItems = 4;
            this.cbProduitAjout.MouseState = MaterialSkin.MouseState.OUT;
            this.cbProduitAjout.Name = "cbProduitAjout";
            this.cbProduitAjout.Size = new System.Drawing.Size(402, 49);
            this.cbProduitAjout.StartIndex = 0;
            this.cbProduitAjout.TabIndex = 58;
            this.cbProduitAjout.SelectedIndexChanged += new System.EventHandler(this.cbProduitAjout_SelectedIndexChanged);
            // 
            // btnAjoutLivraison
            // 
            this.btnAjoutLivraison.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAjoutLivraison.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAjoutLivraison.Depth = 0;
            this.btnAjoutLivraison.HighEmphasis = true;
            this.btnAjoutLivraison.Icon = null;
            this.btnAjoutLivraison.Location = new System.Drawing.Point(364, 450);
            this.btnAjoutLivraison.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAjoutLivraison.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAjoutLivraison.Name = "btnAjoutLivraison";
            this.btnAjoutLivraison.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAjoutLivraison.Size = new System.Drawing.Size(85, 36);
            this.btnAjoutLivraison.TabIndex = 57;
            this.btnAjoutLivraison.Text = "Ajouter";
            this.btnAjoutLivraison.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAjoutLivraison.UseAccentColor = false;
            this.btnAjoutLivraison.UseVisualStyleBackColor = true;
            this.btnAjoutLivraison.Click += new System.EventHandler(this.btnAjoutLivraison_Click);
            // 
            // txtPrixLivraisonAjout
            // 
            this.txtPrixLivraisonAjout.AnimateReadOnly = false;
            this.txtPrixLivraisonAjout.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrixLivraisonAjout.Depth = 0;
            this.txtPrixLivraisonAjout.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPrixLivraisonAjout.Hint = "Prix Unitaire";
            this.txtPrixLivraisonAjout.LeadingIcon = null;
            this.txtPrixLivraisonAjout.Location = new System.Drawing.Point(438, 300);
            this.txtPrixLivraisonAjout.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrixLivraisonAjout.MaxLength = 50;
            this.txtPrixLivraisonAjout.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPrixLivraisonAjout.Multiline = false;
            this.txtPrixLivraisonAjout.Name = "txtPrixLivraisonAjout";
            this.txtPrixLivraisonAjout.Size = new System.Drawing.Size(171, 50);
            this.txtPrixLivraisonAjout.TabIndex = 56;
            this.txtPrixLivraisonAjout.Text = "";
            this.txtPrixLivraisonAjout.TrailingIcon = null;
            // 
            // txtQteLivreAjout
            // 
            this.txtQteLivreAjout.AnimateReadOnly = false;
            this.txtQteLivreAjout.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQteLivreAjout.Depth = 0;
            this.txtQteLivreAjout.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtQteLivreAjout.Hint = "Quantité";
            this.txtQteLivreAjout.LeadingIcon = null;
            this.txtQteLivreAjout.Location = new System.Drawing.Point(207, 300);
            this.txtQteLivreAjout.Margin = new System.Windows.Forms.Padding(4);
            this.txtQteLivreAjout.MaxLength = 50;
            this.txtQteLivreAjout.MouseState = MaterialSkin.MouseState.OUT;
            this.txtQteLivreAjout.Multiline = false;
            this.txtQteLivreAjout.Name = "txtQteLivreAjout";
            this.txtQteLivreAjout.Size = new System.Drawing.Size(184, 50);
            this.txtQteLivreAjout.TabIndex = 55;
            this.txtQteLivreAjout.Text = "";
            this.txtQteLivreAjout.TrailingIcon = null;
            // 
            // cbFournisseurProduitAjout
            // 
            this.cbFournisseurProduitAjout.AutoResize = false;
            this.cbFournisseurProduitAjout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbFournisseurProduitAjout.Depth = 0;
            this.cbFournisseurProduitAjout.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbFournisseurProduitAjout.DropDownHeight = 174;
            this.cbFournisseurProduitAjout.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFournisseurProduitAjout.DropDownWidth = 121;
            this.cbFournisseurProduitAjout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbFournisseurProduitAjout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbFournisseurProduitAjout.FormattingEnabled = true;
            this.cbFournisseurProduitAjout.Hint = "Fournisseur";
            this.cbFournisseurProduitAjout.IntegralHeight = false;
            this.cbFournisseurProduitAjout.ItemHeight = 43;
            this.cbFournisseurProduitAjout.Location = new System.Drawing.Point(207, 196);
            this.cbFournisseurProduitAjout.MaxDropDownItems = 4;
            this.cbFournisseurProduitAjout.MouseState = MaterialSkin.MouseState.OUT;
            this.cbFournisseurProduitAjout.Name = "cbFournisseurProduitAjout";
            this.cbFournisseurProduitAjout.Size = new System.Drawing.Size(402, 49);
            this.cbFournisseurProduitAjout.StartIndex = 0;
            this.cbFournisseurProduitAjout.TabIndex = 54;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel3.Location = new System.Drawing.Point(247, 27);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(232, 29);
            this.materialLabel3.TabIndex = 51;
            this.materialLabel3.Text = "Ajouter des livraisons";
            this.materialLabel3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbpModifLivraison
            // 
            this.tbpModifLivraison.BackColor = System.Drawing.Color.White;
            this.tbpModifLivraison.Controls.Add(this.cbDateLivraison);
            this.tbpModifLivraison.Controls.Add(this.btnModifLivraison);
            this.tbpModifLivraison.Controls.Add(this.txtPrixLivraison);
            this.tbpModifLivraison.Controls.Add(this.txtQuantiteProduitLivre);
            this.tbpModifLivraison.Controls.Add(this.cbFournisseurDuProduit);
            this.tbpModifLivraison.Controls.Add(this.lblProduitFourniNameValue);
            this.tbpModifLivraison.Controls.Add(this.lblProduitFourniName);
            this.tbpModifLivraison.Controls.Add(this.lblLivraison);
            this.tbpModifLivraison.ImageKey = "icons8-supplier-64.png";
            this.tbpModifLivraison.Location = new System.Drawing.Point(4, 25);
            this.tbpModifLivraison.Name = "tbpModifLivraison";
            this.tbpModifLivraison.Padding = new System.Windows.Forms.Padding(3);
            this.tbpModifLivraison.Size = new System.Drawing.Size(786, 513);
            this.tbpModifLivraison.TabIndex = 0;
            this.tbpModifLivraison.Text = "Modifier la livraison";
            // 
            // cbDateLivraison
            // 
            this.cbDateLivraison.AutoResize = false;
            this.cbDateLivraison.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbDateLivraison.Depth = 0;
            this.cbDateLivraison.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbDateLivraison.DropDownHeight = 174;
            this.cbDateLivraison.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDateLivraison.DropDownWidth = 121;
            this.cbDateLivraison.Enabled = false;
            this.cbDateLivraison.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbDateLivraison.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbDateLivraison.FormattingEnabled = true;
            this.cbDateLivraison.Hint = "Date de livraison";
            this.cbDateLivraison.IntegralHeight = false;
            this.cbDateLivraison.ItemHeight = 43;
            this.cbDateLivraison.Location = new System.Drawing.Point(170, 281);
            this.cbDateLivraison.MaxDropDownItems = 4;
            this.cbDateLivraison.MouseState = MaterialSkin.MouseState.OUT;
            this.cbDateLivraison.Name = "cbDateLivraison";
            this.cbDateLivraison.Size = new System.Drawing.Size(402, 49);
            this.cbDateLivraison.StartIndex = 0;
            this.cbDateLivraison.TabIndex = 50;
            // 
            // btnModifLivraison
            // 
            this.btnModifLivraison.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnModifLivraison.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnModifLivraison.Depth = 0;
            this.btnModifLivraison.HighEmphasis = true;
            this.btnModifLivraison.Icon = null;
            this.btnModifLivraison.Location = new System.Drawing.Point(327, 453);
            this.btnModifLivraison.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnModifLivraison.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnModifLivraison.Name = "btnModifLivraison";
            this.btnModifLivraison.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnModifLivraison.Size = new System.Drawing.Size(88, 36);
            this.btnModifLivraison.TabIndex = 48;
            this.btnModifLivraison.Text = "Modifier";
            this.btnModifLivraison.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnModifLivraison.UseAccentColor = false;
            this.btnModifLivraison.UseVisualStyleBackColor = true;
            this.btnModifLivraison.Click += new System.EventHandler(this.btnModifLivraison_Click);
            // 
            // txtPrixLivraison
            // 
            this.txtPrixLivraison.AnimateReadOnly = false;
            this.txtPrixLivraison.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrixLivraison.Depth = 0;
            this.txtPrixLivraison.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPrixLivraison.Hint = "Prix Unitaire";
            this.txtPrixLivraison.LeadingIcon = null;
            this.txtPrixLivraison.Location = new System.Drawing.Point(401, 361);
            this.txtPrixLivraison.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrixLivraison.MaxLength = 50;
            this.txtPrixLivraison.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPrixLivraison.Multiline = false;
            this.txtPrixLivraison.Name = "txtPrixLivraison";
            this.txtPrixLivraison.Size = new System.Drawing.Size(171, 50);
            this.txtPrixLivraison.TabIndex = 47;
            this.txtPrixLivraison.Text = "";
            this.txtPrixLivraison.TrailingIcon = null;
            // 
            // txtQuantiteProduitLivre
            // 
            this.txtQuantiteProduitLivre.AnimateReadOnly = false;
            this.txtQuantiteProduitLivre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQuantiteProduitLivre.Depth = 0;
            this.txtQuantiteProduitLivre.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtQuantiteProduitLivre.Hint = "Quantité";
            this.txtQuantiteProduitLivre.LeadingIcon = null;
            this.txtQuantiteProduitLivre.Location = new System.Drawing.Point(170, 361);
            this.txtQuantiteProduitLivre.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuantiteProduitLivre.MaxLength = 50;
            this.txtQuantiteProduitLivre.MouseState = MaterialSkin.MouseState.OUT;
            this.txtQuantiteProduitLivre.Multiline = false;
            this.txtQuantiteProduitLivre.Name = "txtQuantiteProduitLivre";
            this.txtQuantiteProduitLivre.Size = new System.Drawing.Size(184, 50);
            this.txtQuantiteProduitLivre.TabIndex = 46;
            this.txtQuantiteProduitLivre.Text = "";
            this.txtQuantiteProduitLivre.TrailingIcon = null;
            // 
            // cbFournisseurDuProduit
            // 
            this.cbFournisseurDuProduit.AutoResize = false;
            this.cbFournisseurDuProduit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbFournisseurDuProduit.Depth = 0;
            this.cbFournisseurDuProduit.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbFournisseurDuProduit.DropDownHeight = 174;
            this.cbFournisseurDuProduit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFournisseurDuProduit.DropDownWidth = 121;
            this.cbFournisseurDuProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbFournisseurDuProduit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbFournisseurDuProduit.FormattingEnabled = true;
            this.cbFournisseurDuProduit.Hint = "Fourniseeur";
            this.cbFournisseurDuProduit.IntegralHeight = false;
            this.cbFournisseurDuProduit.ItemHeight = 43;
            this.cbFournisseurDuProduit.Location = new System.Drawing.Point(170, 199);
            this.cbFournisseurDuProduit.MaxDropDownItems = 4;
            this.cbFournisseurDuProduit.MouseState = MaterialSkin.MouseState.OUT;
            this.cbFournisseurDuProduit.Name = "cbFournisseurDuProduit";
            this.cbFournisseurDuProduit.Size = new System.Drawing.Size(402, 49);
            this.cbFournisseurDuProduit.StartIndex = 0;
            this.cbFournisseurDuProduit.TabIndex = 45;
            this.cbFournisseurDuProduit.DropDownClosed += new System.EventHandler(this.cbFournisseurDuProduit_DropDownClosed);
            this.cbFournisseurDuProduit.SelectedValueChanged += new System.EventHandler(this.cbFournisseurDuProduit_SelectedValueChanged);
            // 
            // lblProduitFourniNameValue
            // 
            this.lblProduitFourniNameValue.AutoSize = true;
            this.lblProduitFourniNameValue.Depth = 0;
            this.lblProduitFourniNameValue.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblProduitFourniNameValue.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.lblProduitFourniNameValue.Location = new System.Drawing.Point(289, 142);
            this.lblProduitFourniNameValue.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblProduitFourniNameValue.Name = "lblProduitFourniNameValue";
            this.lblProduitFourniNameValue.Size = new System.Drawing.Size(1, 0);
            this.lblProduitFourniNameValue.TabIndex = 44;
            this.lblProduitFourniNameValue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblProduitFourniName
            // 
            this.lblProduitFourniName.AutoSize = true;
            this.lblProduitFourniName.Depth = 0;
            this.lblProduitFourniName.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblProduitFourniName.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.lblProduitFourniName.Location = new System.Drawing.Point(140, 142);
            this.lblProduitFourniName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblProduitFourniName.Name = "lblProduitFourniName";
            this.lblProduitFourniName.Size = new System.Drawing.Size(106, 17);
            this.lblProduitFourniName.TabIndex = 43;
            this.lblProduitFourniName.Text = "Nom du produit :";
            this.lblProduitFourniName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblLivraison
            // 
            this.lblLivraison.AutoSize = true;
            this.lblLivraison.Depth = 0;
            this.lblLivraison.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblLivraison.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.lblLivraison.Location = new System.Drawing.Point(210, 30);
            this.lblLivraison.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblLivraison.Name = "lblLivraison";
            this.lblLivraison.Size = new System.Drawing.Size(236, 29);
            this.lblLivraison.TabIndex = 42;
            this.lblLivraison.Text = "Gestion des livraisons";
            this.lblLivraison.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbpSupprLivraison
            // 
            this.tbpSupprLivraison.BackColor = System.Drawing.Color.White;
            this.tbpSupprLivraison.Controls.Add(this.btnSupprimerLivraison);
            this.tbpSupprLivraison.Controls.Add(this.cbDateLivraisonSuppr);
            this.tbpSupprLivraison.Controls.Add(this.cbProduitSuppr);
            this.tbpSupprLivraison.Controls.Add(this.cbFourniSuppr);
            this.tbpSupprLivraison.Controls.Add(this.lblSupprLivraison);
            this.tbpSupprLivraison.Location = new System.Drawing.Point(4, 25);
            this.tbpSupprLivraison.Name = "tbpSupprLivraison";
            this.tbpSupprLivraison.Size = new System.Drawing.Size(786, 513);
            this.tbpSupprLivraison.TabIndex = 2;
            this.tbpSupprLivraison.Text = "Supprimer une livraison";
            // 
            // btnSupprimerLivraison
            // 
            this.btnSupprimerLivraison.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSupprimerLivraison.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSupprimerLivraison.Depth = 0;
            this.btnSupprimerLivraison.HighEmphasis = true;
            this.btnSupprimerLivraison.Icon = null;
            this.btnSupprimerLivraison.Location = new System.Drawing.Point(332, 417);
            this.btnSupprimerLivraison.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSupprimerLivraison.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSupprimerLivraison.Name = "btnSupprimerLivraison";
            this.btnSupprimerLivraison.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSupprimerLivraison.Size = new System.Drawing.Size(102, 36);
            this.btnSupprimerLivraison.TabIndex = 63;
            this.btnSupprimerLivraison.Text = "Supprimer";
            this.btnSupprimerLivraison.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSupprimerLivraison.UseAccentColor = false;
            this.btnSupprimerLivraison.UseVisualStyleBackColor = true;
            this.btnSupprimerLivraison.Click += new System.EventHandler(this.btnSupprimerLivraison_Click);
            // 
            // cbDateLivraisonSuppr
            // 
            this.cbDateLivraisonSuppr.AutoResize = false;
            this.cbDateLivraisonSuppr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbDateLivraisonSuppr.Depth = 0;
            this.cbDateLivraisonSuppr.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbDateLivraisonSuppr.DropDownHeight = 174;
            this.cbDateLivraisonSuppr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDateLivraisonSuppr.DropDownWidth = 121;
            this.cbDateLivraisonSuppr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbDateLivraisonSuppr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbDateLivraisonSuppr.FormattingEnabled = true;
            this.cbDateLivraisonSuppr.Hint = "Date de livraison";
            this.cbDateLivraisonSuppr.IntegralHeight = false;
            this.cbDateLivraisonSuppr.ItemHeight = 43;
            this.cbDateLivraisonSuppr.Location = new System.Drawing.Point(184, 311);
            this.cbDateLivraisonSuppr.MaxDropDownItems = 4;
            this.cbDateLivraisonSuppr.MouseState = MaterialSkin.MouseState.OUT;
            this.cbDateLivraisonSuppr.Name = "cbDateLivraisonSuppr";
            this.cbDateLivraisonSuppr.Size = new System.Drawing.Size(402, 49);
            this.cbDateLivraisonSuppr.StartIndex = 0;
            this.cbDateLivraisonSuppr.TabIndex = 62;
            // 
            // cbProduitSuppr
            // 
            this.cbProduitSuppr.AutoResize = false;
            this.cbProduitSuppr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbProduitSuppr.Depth = 0;
            this.cbProduitSuppr.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbProduitSuppr.DropDownHeight = 174;
            this.cbProduitSuppr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProduitSuppr.DropDownWidth = 121;
            this.cbProduitSuppr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbProduitSuppr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbProduitSuppr.FormattingEnabled = true;
            this.cbProduitSuppr.Hint = "Produit";
            this.cbProduitSuppr.IntegralHeight = false;
            this.cbProduitSuppr.ItemHeight = 43;
            this.cbProduitSuppr.Location = new System.Drawing.Point(184, 134);
            this.cbProduitSuppr.MaxDropDownItems = 4;
            this.cbProduitSuppr.MouseState = MaterialSkin.MouseState.OUT;
            this.cbProduitSuppr.Name = "cbProduitSuppr";
            this.cbProduitSuppr.Size = new System.Drawing.Size(402, 49);
            this.cbProduitSuppr.StartIndex = 0;
            this.cbProduitSuppr.TabIndex = 61;
            // 
            // cbFourniSuppr
            // 
            this.cbFourniSuppr.AutoResize = false;
            this.cbFourniSuppr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbFourniSuppr.Depth = 0;
            this.cbFourniSuppr.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbFourniSuppr.DropDownHeight = 174;
            this.cbFourniSuppr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFourniSuppr.DropDownWidth = 121;
            this.cbFourniSuppr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbFourniSuppr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbFourniSuppr.FormattingEnabled = true;
            this.cbFourniSuppr.Hint = "Fournisseur";
            this.cbFourniSuppr.IntegralHeight = false;
            this.cbFourniSuppr.ItemHeight = 43;
            this.cbFourniSuppr.Location = new System.Drawing.Point(184, 219);
            this.cbFourniSuppr.MaxDropDownItems = 4;
            this.cbFourniSuppr.MouseState = MaterialSkin.MouseState.OUT;
            this.cbFourniSuppr.Name = "cbFourniSuppr";
            this.cbFourniSuppr.Size = new System.Drawing.Size(402, 49);
            this.cbFourniSuppr.StartIndex = 0;
            this.cbFourniSuppr.TabIndex = 60;
            // 
            // lblSupprLivraison
            // 
            this.lblSupprLivraison.AutoSize = true;
            this.lblSupprLivraison.Depth = 0;
            this.lblSupprLivraison.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblSupprLivraison.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.lblSupprLivraison.Location = new System.Drawing.Point(224, 50);
            this.lblSupprLivraison.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSupprLivraison.Name = "lblSupprLivraison";
            this.lblSupprLivraison.Size = new System.Drawing.Size(263, 29);
            this.lblSupprLivraison.TabIndex = 59;
            this.lblSupprLivraison.Text = "Supprimer des livraisons";
            this.lblSupprLivraison.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lstImgAjoutIcon
            // 
            this.lstImgAjoutIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("lstImgAjoutIcon.ImageStream")));
            this.lstImgAjoutIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.lstImgAjoutIcon.Images.SetKeyName(0, "icons8-supplier-64.png");
            this.lstImgAjoutIcon.Images.SetKeyName(1, "icons8-user-52.png");
            // 
            // FrmGesLivraison
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 609);
            this.Controls.Add(this.tbGestLivraison);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.tbGestLivraison;
            this.Name = "FrmGesLivraison";
            this.Text = "Gestion des livraisons";
            this.Load += new System.EventHandler(this.FrmGesLivraison_Load);
            this.tbGestLivraison.ResumeLayout(false);
            this.tbpAjoutLivraison.ResumeLayout(false);
            this.tbpAjoutLivraison.PerformLayout();
            this.tbpModifLivraison.ResumeLayout(false);
            this.tbpModifLivraison.PerformLayout();
            this.tbpSupprLivraison.ResumeLayout(false);
            this.tbpSupprLivraison.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl tbGestLivraison;
        private System.Windows.Forms.TabPage tbpModifLivraison;
        private System.Windows.Forms.TabPage tbpAjoutLivraison;
        private System.Windows.Forms.ImageList lstImgAjoutIcon;
        private MaterialSkin.Controls.MaterialTextBox txtPrixLivraison;
        private MaterialSkin.Controls.MaterialTextBox txtQuantiteProduitLivre;
        private MaterialSkin.Controls.MaterialComboBox cbFournisseurDuProduit;
        private MaterialSkin.Controls.MaterialLabel lblProduitFourniNameValue;
        private MaterialSkin.Controls.MaterialLabel lblProduitFourniName;
        private MaterialSkin.Controls.MaterialLabel lblLivraison;
        private MaterialSkin.Controls.MaterialButton btnModifLivraison;
        private MaterialSkin.Controls.MaterialComboBox cbDateLivraison;
        private MaterialSkin.Controls.MaterialButton btnAjoutLivraison;
        private MaterialSkin.Controls.MaterialTextBox txtPrixLivraisonAjout;
        private MaterialSkin.Controls.MaterialTextBox txtQteLivreAjout;
        private MaterialSkin.Controls.MaterialComboBox cbFournisseurProduitAjout;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialComboBox cbProduitAjout;
        private System.Windows.Forms.TabPage tbpSupprLivraison;
        private MaterialSkin.Controls.MaterialButton btnSupprimerLivraison;
        private MaterialSkin.Controls.MaterialComboBox cbDateLivraisonSuppr;
        private MaterialSkin.Controls.MaterialComboBox cbProduitSuppr;
        private MaterialSkin.Controls.MaterialComboBox cbFourniSuppr;
        private MaterialSkin.Controls.MaterialLabel lblSupprLivraison;
    }
}