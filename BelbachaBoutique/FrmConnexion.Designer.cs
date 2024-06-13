namespace BelbachaBoutique
{
    partial class FrmConnexion
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
            this.lblConnection = new MaterialSkin.Controls.MaterialLabel();
            this.txtIdentifiant = new MaterialSkin.Controls.MaterialTextBox();
            this.txtMdp = new MaterialSkin.Controls.MaterialTextBox();
            this.btnConnection = new MaterialSkin.Controls.MaterialButton();
            this.pbConnexion = new System.Windows.Forms.PictureBox();
            this.erpErrorConnexion = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblMessageErreur = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbConnexion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpErrorConnexion)).BeginInit();
            this.SuspendLayout();
            // 
            // lblConnection
            // 
            this.lblConnection.AutoSize = true;
            this.lblConnection.Depth = 0;
            this.lblConnection.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblConnection.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lblConnection.Location = new System.Drawing.Point(218, 99);
            this.lblConnection.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblConnection.Name = "lblConnection";
            this.lblConnection.Size = new System.Drawing.Size(145, 24);
            this.lblConnection.TabIndex = 0;
            this.lblConnection.Text = "Connectez-vous";
            // 
            // txtIdentifiant
            // 
            this.txtIdentifiant.AnimateReadOnly = false;
            this.txtIdentifiant.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdentifiant.Depth = 0;
            this.txtIdentifiant.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtIdentifiant.Hint = "Identifiant";
            this.txtIdentifiant.LeadingIcon = null;
            this.txtIdentifiant.Location = new System.Drawing.Point(129, 235);
            this.txtIdentifiant.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdentifiant.MaxLength = 50;
            this.txtIdentifiant.MouseState = MaterialSkin.MouseState.OUT;
            this.txtIdentifiant.Multiline = false;
            this.txtIdentifiant.Name = "txtIdentifiant";
            this.txtIdentifiant.Size = new System.Drawing.Size(316, 50);
            this.txtIdentifiant.TabIndex = 57;
            this.txtIdentifiant.Text = "";
            this.txtIdentifiant.TrailingIcon = null;
            // 
            // txtMdp
            // 
            this.txtMdp.AnimateReadOnly = false;
            this.txtMdp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMdp.Depth = 0;
            this.txtMdp.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtMdp.Hint = "Mot de passe";
            this.txtMdp.LeadingIcon = null;
            this.txtMdp.Location = new System.Drawing.Point(129, 340);
            this.txtMdp.Margin = new System.Windows.Forms.Padding(4);
            this.txtMdp.MaxLength = 50;
            this.txtMdp.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMdp.Multiline = false;
            this.txtMdp.Name = "txtMdp";
            this.txtMdp.Password = true;
            this.txtMdp.Size = new System.Drawing.Size(316, 50);
            this.txtMdp.TabIndex = 58;
            this.txtMdp.Text = "";
            this.txtMdp.TrailingIcon = null;
            // 
            // btnConnection
            // 
            this.btnConnection.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConnection.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnConnection.Depth = 0;
            this.btnConnection.HighEmphasis = true;
            this.btnConnection.Icon = null;
            this.btnConnection.Location = new System.Drawing.Point(211, 466);
            this.btnConnection.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnConnection.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConnection.Name = "btnConnection";
            this.btnConnection.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnConnection.Size = new System.Drawing.Size(105, 36);
            this.btnConnection.TabIndex = 59;
            this.btnConnection.Text = "Connexion";
            this.btnConnection.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnConnection.UseAccentColor = false;
            this.btnConnection.UseVisualStyleBackColor = true;
            this.btnConnection.Click += new System.EventHandler(this.btnConnection_Click);
            // 
            // pbConnexion
            // 
            this.pbConnexion.Image = global::BelbachaBoutique.Properties.Resources.icons8_user_52;
            this.pbConnexion.Location = new System.Drawing.Point(263, 154);
            this.pbConnexion.Name = "pbConnexion";
            this.pbConnexion.Size = new System.Drawing.Size(100, 74);
            this.pbConnexion.TabIndex = 60;
            this.pbConnexion.TabStop = false;
            // 
            // erpErrorConnexion
            // 
            this.erpErrorConnexion.ContainerControl = this;
            // 
            // lblMessageErreur
            // 
            this.lblMessageErreur.AutoSize = true;
            this.lblMessageErreur.Depth = 0;
            this.lblMessageErreur.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblMessageErreur.Location = new System.Drawing.Point(109, 550);
            this.lblMessageErreur.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblMessageErreur.Name = "lblMessageErreur";
            this.lblMessageErreur.Size = new System.Drawing.Size(1, 0);
            this.lblMessageErreur.TabIndex = 61;
            // 
            // FrmConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 611);
            this.Controls.Add(this.lblMessageErreur);
            this.Controls.Add(this.pbConnexion);
            this.Controls.Add(this.btnConnection);
            this.Controls.Add(this.txtMdp);
            this.Controls.Add(this.txtIdentifiant);
            this.Controls.Add(this.lblConnection);
            this.Name = "FrmConnexion";
            this.Text = "Connexion";
            this.Load += new System.EventHandler(this.FrmConnexion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbConnexion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpErrorConnexion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblConnection;
        private MaterialSkin.Controls.MaterialTextBox txtIdentifiant;
        private MaterialSkin.Controls.MaterialTextBox txtMdp;
        private MaterialSkin.Controls.MaterialButton btnConnection;
        private System.Windows.Forms.PictureBox pbConnexion;
        private System.Windows.Forms.ErrorProvider erpErrorConnexion;
        private MaterialSkin.Controls.MaterialLabel lblMessageErreur;
    }
}