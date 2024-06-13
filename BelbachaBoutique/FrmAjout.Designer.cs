namespace BelbachaBoutique
{
    partial class FrmAjout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAjout));
            this.lstImgAjoutIcon = new System.Windows.Forms.ImageList(this.components);
            this.tbcAjout = new MaterialSkin.Controls.MaterialTabControl();
            this.tbpAjoutClient = new System.Windows.Forms.TabPage();
            this.btnAjoutClient = new MaterialSkin.Controls.MaterialButton();
            this.txtBxEmail = new MaterialSkin.Controls.MaterialTextBox();
            this.txtBxTel = new MaterialSkin.Controls.MaterialTextBox();
            this.txtBxVille = new MaterialSkin.Controls.MaterialTextBox();
            this.txtBxCp = new MaterialSkin.Controls.MaterialTextBox();
            this.txtBxAdr = new MaterialSkin.Controls.MaterialTextBox();
            this.txtBxPrenom = new MaterialSkin.Controls.MaterialTextBox();
            this.txtBxNom = new MaterialSkin.Controls.MaterialTextBox();
            this.tbpAjoutGestProduitFourni = new System.Windows.Forms.TabPage();
            this.lblLivraison = new MaterialSkin.Controls.MaterialLabel();
            this.lblProduitFourniName = new MaterialSkin.Controls.MaterialLabel();
            this.lblProduitFourniNameValue = new MaterialSkin.Controls.MaterialLabel();
            this.cbFournisseurDuProduit = new MaterialSkin.Controls.MaterialComboBox();
            this.txtQuantiteProduitLivre = new MaterialSkin.Controls.MaterialTextBox();
            this.txtPrixLivraison = new MaterialSkin.Controls.MaterialTextBox();
            this.tbcAjout.SuspendLayout();
            this.tbpAjoutClient.SuspendLayout();
            this.tbpAjoutGestProduitFourni.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstImgAjoutIcon
            // 
            this.lstImgAjoutIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("lstImgAjoutIcon.ImageStream")));
            this.lstImgAjoutIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.lstImgAjoutIcon.Images.SetKeyName(0, "icons8-supplier-64.png");
            this.lstImgAjoutIcon.Images.SetKeyName(1, "icons8-user-52.png");
            // 
            // tbcAjout
            // 
            this.tbcAjout.Controls.Add(this.tbpAjoutClient);
            this.tbcAjout.Controls.Add(this.tbpAjoutGestProduitFourni);
            this.tbcAjout.Depth = 0;
            this.tbcAjout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcAjout.ImageList = this.lstImgAjoutIcon;
            this.tbcAjout.Location = new System.Drawing.Point(3, 64);
            this.tbcAjout.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbcAjout.Multiline = true;
            this.tbcAjout.Name = "tbcAjout";
            this.tbcAjout.SelectedIndex = 0;
            this.tbcAjout.Size = new System.Drawing.Size(668, 658);
            this.tbcAjout.TabIndex = 0;
            // 
            // tbpAjoutClient
            // 
            this.tbpAjoutClient.BackColor = System.Drawing.Color.White;
            this.tbpAjoutClient.Controls.Add(this.btnAjoutClient);
            this.tbpAjoutClient.Controls.Add(this.txtBxEmail);
            this.tbpAjoutClient.Controls.Add(this.txtBxTel);
            this.tbpAjoutClient.Controls.Add(this.txtBxVille);
            this.tbpAjoutClient.Controls.Add(this.txtBxCp);
            this.tbpAjoutClient.Controls.Add(this.txtBxAdr);
            this.tbpAjoutClient.Controls.Add(this.txtBxPrenom);
            this.tbpAjoutClient.Controls.Add(this.txtBxNom);
            this.tbpAjoutClient.ImageKey = "icons8-user-52.png";
            this.tbpAjoutClient.Location = new System.Drawing.Point(4, 25);
            this.tbpAjoutClient.Name = "tbpAjoutClient";
            this.tbpAjoutClient.Padding = new System.Windows.Forms.Padding(3);
            this.tbpAjoutClient.Size = new System.Drawing.Size(660, 629);
            this.tbpAjoutClient.TabIndex = 0;
            this.tbpAjoutClient.Text = "Ajouter un client";
            // 
            // btnAjoutClient
            // 
            this.btnAjoutClient.AutoSize = false;
            this.btnAjoutClient.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAjoutClient.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAjoutClient.Depth = 0;
            this.btnAjoutClient.HighEmphasis = true;
            this.btnAjoutClient.Icon = null;
            this.btnAjoutClient.Location = new System.Drawing.Point(168, 534);
            this.btnAjoutClient.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAjoutClient.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAjoutClient.Name = "btnAjoutClient";
            this.btnAjoutClient.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAjoutClient.Size = new System.Drawing.Size(249, 57);
            this.btnAjoutClient.TabIndex = 16;
            this.btnAjoutClient.Text = "Ajouter";
            this.btnAjoutClient.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAjoutClient.UseAccentColor = false;
            this.btnAjoutClient.UseVisualStyleBackColor = true;
            this.btnAjoutClient.Click += new System.EventHandler(this.btnAjoutClient_Click);
            // 
            // txtBxEmail
            // 
            this.txtBxEmail.AnimateReadOnly = false;
            this.txtBxEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBxEmail.Depth = 0;
            this.txtBxEmail.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBxEmail.Hint = "Entrez votre Email";
            this.txtBxEmail.LeadingIcon = null;
            this.txtBxEmail.Location = new System.Drawing.Point(51, 431);
            this.txtBxEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtBxEmail.MaxLength = 50;
            this.txtBxEmail.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBxEmail.Multiline = false;
            this.txtBxEmail.Name = "txtBxEmail";
            this.txtBxEmail.Size = new System.Drawing.Size(483, 50);
            this.txtBxEmail.TabIndex = 15;
            this.txtBxEmail.Text = "";
            this.txtBxEmail.TrailingIcon = null;
            // 
            // txtBxTel
            // 
            this.txtBxTel.AnimateReadOnly = false;
            this.txtBxTel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBxTel.Depth = 0;
            this.txtBxTel.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBxTel.Hint = "N° de télephone";
            this.txtBxTel.LeadingIcon = null;
            this.txtBxTel.Location = new System.Drawing.Point(51, 334);
            this.txtBxTel.Margin = new System.Windows.Forms.Padding(4);
            this.txtBxTel.MaxLength = 50;
            this.txtBxTel.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBxTel.Multiline = false;
            this.txtBxTel.Name = "txtBxTel";
            this.txtBxTel.Size = new System.Drawing.Size(483, 50);
            this.txtBxTel.TabIndex = 14;
            this.txtBxTel.Text = "";
            this.txtBxTel.TrailingIcon = null;
            // 
            // txtBxVille
            // 
            this.txtBxVille.AnimateReadOnly = false;
            this.txtBxVille.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBxVille.Depth = 0;
            this.txtBxVille.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBxVille.Hint = "Ville";
            this.txtBxVille.LeadingIcon = null;
            this.txtBxVille.Location = new System.Drawing.Point(51, 238);
            this.txtBxVille.Margin = new System.Windows.Forms.Padding(4);
            this.txtBxVille.MaxLength = 50;
            this.txtBxVille.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBxVille.Multiline = false;
            this.txtBxVille.Name = "txtBxVille";
            this.txtBxVille.Size = new System.Drawing.Size(220, 50);
            this.txtBxVille.TabIndex = 13;
            this.txtBxVille.Text = "";
            this.txtBxVille.TrailingIcon = null;
            // 
            // txtBxCp
            // 
            this.txtBxCp.AnimateReadOnly = false;
            this.txtBxCp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBxCp.Depth = 0;
            this.txtBxCp.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBxCp.Hint = "Code postal";
            this.txtBxCp.LeadingIcon = null;
            this.txtBxCp.Location = new System.Drawing.Point(314, 238);
            this.txtBxCp.Margin = new System.Windows.Forms.Padding(4);
            this.txtBxCp.MaxLength = 50;
            this.txtBxCp.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBxCp.Multiline = false;
            this.txtBxCp.Name = "txtBxCp";
            this.txtBxCp.Size = new System.Drawing.Size(220, 50);
            this.txtBxCp.TabIndex = 12;
            this.txtBxCp.Text = "";
            this.txtBxCp.TrailingIcon = null;
            // 
            // txtBxAdr
            // 
            this.txtBxAdr.AnimateReadOnly = false;
            this.txtBxAdr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBxAdr.Depth = 0;
            this.txtBxAdr.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBxAdr.Hint = "Entrez votre adresse";
            this.txtBxAdr.LeadingIcon = null;
            this.txtBxAdr.Location = new System.Drawing.Point(51, 157);
            this.txtBxAdr.Margin = new System.Windows.Forms.Padding(4);
            this.txtBxAdr.MaxLength = 50;
            this.txtBxAdr.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBxAdr.Multiline = false;
            this.txtBxAdr.Name = "txtBxAdr";
            this.txtBxAdr.Size = new System.Drawing.Size(483, 50);
            this.txtBxAdr.TabIndex = 11;
            this.txtBxAdr.Text = "";
            this.txtBxAdr.TrailingIcon = null;
            // 
            // txtBxPrenom
            // 
            this.txtBxPrenom.AnimateReadOnly = false;
            this.txtBxPrenom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBxPrenom.Depth = 0;
            this.txtBxPrenom.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBxPrenom.Hint = "Entrez votre prenom";
            this.txtBxPrenom.LeadingIcon = null;
            this.txtBxPrenom.Location = new System.Drawing.Point(314, 68);
            this.txtBxPrenom.Margin = new System.Windows.Forms.Padding(4);
            this.txtBxPrenom.MaxLength = 50;
            this.txtBxPrenom.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBxPrenom.Multiline = false;
            this.txtBxPrenom.Name = "txtBxPrenom";
            this.txtBxPrenom.Size = new System.Drawing.Size(220, 50);
            this.txtBxPrenom.TabIndex = 10;
            this.txtBxPrenom.Text = "";
            this.txtBxPrenom.TrailingIcon = null;
            // 
            // txtBxNom
            // 
            this.txtBxNom.AnimateReadOnly = false;
            this.txtBxNom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBxNom.Depth = 0;
            this.txtBxNom.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBxNom.Hint = "Entrez votre nom";
            this.txtBxNom.LeadingIcon = null;
            this.txtBxNom.Location = new System.Drawing.Point(51, 68);
            this.txtBxNom.Margin = new System.Windows.Forms.Padding(4);
            this.txtBxNom.MaxLength = 50;
            this.txtBxNom.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBxNom.Multiline = false;
            this.txtBxNom.Name = "txtBxNom";
            this.txtBxNom.Size = new System.Drawing.Size(220, 50);
            this.txtBxNom.TabIndex = 9;
            this.txtBxNom.Text = "";
            this.txtBxNom.TrailingIcon = null;
            // 
            // tbpAjoutGestProduitFourni
            // 
            this.tbpAjoutGestProduitFourni.BackColor = System.Drawing.Color.White;
            this.tbpAjoutGestProduitFourni.Controls.Add(this.txtPrixLivraison);
            this.tbpAjoutGestProduitFourni.Controls.Add(this.txtQuantiteProduitLivre);
            this.tbpAjoutGestProduitFourni.Controls.Add(this.cbFournisseurDuProduit);
            this.tbpAjoutGestProduitFourni.Controls.Add(this.lblProduitFourniNameValue);
            this.tbpAjoutGestProduitFourni.Controls.Add(this.lblProduitFourniName);
            this.tbpAjoutGestProduitFourni.Controls.Add(this.lblLivraison);
            this.tbpAjoutGestProduitFourni.ImageKey = "icons8-supplier-64.png";
            this.tbpAjoutGestProduitFourni.Location = new System.Drawing.Point(4, 25);
            this.tbpAjoutGestProduitFourni.Name = "tbpAjoutGestProduitFourni";
            this.tbpAjoutGestProduitFourni.Padding = new System.Windows.Forms.Padding(3);
            this.tbpAjoutGestProduitFourni.Size = new System.Drawing.Size(660, 629);
            this.tbpAjoutGestProduitFourni.TabIndex = 1;
            this.tbpAjoutGestProduitFourni.Text = "Ajouter un Fournisseur";
            this.tbpAjoutGestProduitFourni.Click += new System.EventHandler(this.tbpAjoutGestProduitFourni_Click);
            // 
            // lblLivraison
            // 
            this.lblLivraison.AutoSize = true;
            this.lblLivraison.Depth = 0;
            this.lblLivraison.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblLivraison.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.lblLivraison.Location = new System.Drawing.Point(125, 25);
            this.lblLivraison.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblLivraison.Name = "lblLivraison";
            this.lblLivraison.Size = new System.Drawing.Size(236, 29);
            this.lblLivraison.TabIndex = 0;
            this.lblLivraison.Text = "Gestion des livraisons";
            this.lblLivraison.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblProduitFourniName
            // 
            this.lblProduitFourniName.AutoSize = true;
            this.lblProduitFourniName.Depth = 0;
            this.lblProduitFourniName.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblProduitFourniName.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.lblProduitFourniName.Location = new System.Drawing.Point(46, 143);
            this.lblProduitFourniName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblProduitFourniName.Name = "lblProduitFourniName";
            this.lblProduitFourniName.Size = new System.Drawing.Size(106, 17);
            this.lblProduitFourniName.TabIndex = 1;
            this.lblProduitFourniName.Text = "Nom du produit :";
            this.lblProduitFourniName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblProduitFourniNameValue
            // 
            this.lblProduitFourniNameValue.AutoSize = true;
            this.lblProduitFourniNameValue.Depth = 0;
            this.lblProduitFourniNameValue.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblProduitFourniNameValue.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.lblProduitFourniNameValue.Location = new System.Drawing.Point(195, 143);
            this.lblProduitFourniNameValue.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblProduitFourniNameValue.Name = "lblProduitFourniNameValue";
            this.lblProduitFourniNameValue.Size = new System.Drawing.Size(1, 0);
            this.lblProduitFourniNameValue.TabIndex = 2;
            this.lblProduitFourniNameValue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.cbFournisseurDuProduit.Location = new System.Drawing.Point(49, 222);
            this.cbFournisseurDuProduit.MaxDropDownItems = 4;
            this.cbFournisseurDuProduit.MouseState = MaterialSkin.MouseState.OUT;
            this.cbFournisseurDuProduit.Name = "cbFournisseurDuProduit";
            this.cbFournisseurDuProduit.Size = new System.Drawing.Size(402, 49);
            this.cbFournisseurDuProduit.StartIndex = 0;
            this.cbFournisseurDuProduit.TabIndex = 39;
            // 
            // txtQuantiteProduitLivre
            // 
            this.txtQuantiteProduitLivre.AnimateReadOnly = false;
            this.txtQuantiteProduitLivre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQuantiteProduitLivre.Depth = 0;
            this.txtQuantiteProduitLivre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtQuantiteProduitLivre.Hint = "Quantité";
            this.txtQuantiteProduitLivre.LeadingIcon = null;
            this.txtQuantiteProduitLivre.Location = new System.Drawing.Point(49, 327);
            this.txtQuantiteProduitLivre.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuantiteProduitLivre.MaxLength = 50;
            this.txtQuantiteProduitLivre.MouseState = MaterialSkin.MouseState.OUT;
            this.txtQuantiteProduitLivre.Multiline = false;
            this.txtQuantiteProduitLivre.Name = "txtQuantiteProduitLivre";
            this.txtQuantiteProduitLivre.Size = new System.Drawing.Size(184, 50);
            this.txtQuantiteProduitLivre.TabIndex = 40;
            this.txtQuantiteProduitLivre.Text = "";
            this.txtQuantiteProduitLivre.TrailingIcon = null;
            // 
            // txtPrixLivraison
            // 
            this.txtPrixLivraison.AnimateReadOnly = false;
            this.txtPrixLivraison.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrixLivraison.Depth = 0;
            this.txtPrixLivraison.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPrixLivraison.Hint = "Quantité";
            this.txtPrixLivraison.LeadingIcon = null;
            this.txtPrixLivraison.Location = new System.Drawing.Point(280, 327);
            this.txtPrixLivraison.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrixLivraison.MaxLength = 50;
            this.txtPrixLivraison.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPrixLivraison.Multiline = false;
            this.txtPrixLivraison.Name = "txtPrixLivraison";
            this.txtPrixLivraison.Size = new System.Drawing.Size(171, 50);
            this.txtPrixLivraison.TabIndex = 41;
            this.txtPrixLivraison.Text = "";
            this.txtPrixLivraison.TrailingIcon = null;
            // 
            // FrmAjout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 725);
            this.Controls.Add(this.tbcAjout);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.tbcAjout;
            this.HelpButton = true;
            this.Name = "FrmAjout";
            this.Text = "Ajouter un client";
            this.Load += new System.EventHandler(this.FrmAjout_Load);
            this.tbcAjout.ResumeLayout(false);
            this.tbpAjoutClient.ResumeLayout(false);
            this.tbpAjoutGestProduitFourni.ResumeLayout(false);
            this.tbpAjoutGestProduitFourni.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList lstImgAjoutIcon;
        private MaterialSkin.Controls.MaterialTabControl tbcAjout;
        private System.Windows.Forms.TabPage tbpAjoutClient;
        private MaterialSkin.Controls.MaterialTextBox txtBxEmail;
        private MaterialSkin.Controls.MaterialTextBox txtBxTel;
        private MaterialSkin.Controls.MaterialTextBox txtBxVille;
        private MaterialSkin.Controls.MaterialTextBox txtBxCp;
        private MaterialSkin.Controls.MaterialTextBox txtBxAdr;
        private MaterialSkin.Controls.MaterialTextBox txtBxPrenom;
        private MaterialSkin.Controls.MaterialTextBox txtBxNom;
        private MaterialSkin.Controls.MaterialButton btnAjoutClient;
        private MaterialSkin.Controls.MaterialLabel lblProduitFourniName;
        private MaterialSkin.Controls.MaterialLabel lblLivraison;
        private MaterialSkin.Controls.MaterialLabel lblProduitFourniNameValue;
        public System.Windows.Forms.TabPage tbpAjoutGestProduitFourni;
        private MaterialSkin.Controls.MaterialComboBox cbFournisseurDuProduit;
        private MaterialSkin.Controls.MaterialTextBox txtPrixLivraison;
        private MaterialSkin.Controls.MaterialTextBox txtQuantiteProduitLivre;
    }
}