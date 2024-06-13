using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using System.IO;
using System.Xml.Linq;
using GestionBD.MySQL;
using System.Globalization;

namespace BelbachaBoutique
{
    public partial class FrmGesLivraison : MaterialForm
    {
        #region Champs
        public event EventHandler FrmGestLivraisonClosedEvent;
        private string message;
        private const string MESSAGE_CONFIRMATION_SUPPR_LIVRAISON = " Etes vous sure de vouloir supprimer le produit '#valeur#' de la livraison";
        #endregion
        #region Propriété
        public string IdProduitText { get; set; }
        #endregion
        #region Méthodes
        private void GestiontabModif()
        {
            DataTable dataProduitName = GestionProduit.getProduitById(Convert.ToInt32(IdProduitText));
            string NomProduit = dataProduitName.Rows[0][0].ToString();
            lblProduitFourniNameValue.Text = NomProduit;
            cbFournisseurDuProduit.DataSource = GestionLivraison.getFournisseurProduit(Convert.ToInt32(IdProduitText));
            cbFournisseurDuProduit.DisplayMember = "nomSociete";
            DataTable DataidFournisseur = GestionFournisseur.getFournisseurByName(cbFournisseurDuProduit.Text);
            int idFournisseur = (int)DataidFournisseur.Rows[0][0];
            cbDateLivraison.DataSource = GestionLivraison.getDateLivraisonProduitByFournisseur(Convert.ToInt32(IdProduitText), idFournisseur);
            cbDateLivraison.DisplayMember = "dateLivraison";
        }
        private void GestiontabAjout()
        {
            cbFournisseurProduitAjout.DataSource = GestionFournisseur.getTuplesNom();
            cbFournisseurProduitAjout.DisplayMember = "nomSociete";
            cbProduitAjout.DataSource = GestionProduit.getTuplesNom();
            cbProduitAjout.DisplayMember = "nom";
        }

        private void GestionTapSuppr()
        {
            cbProduitSuppr.DataSource = GestionLivraison.getProduit();
            cbProduitSuppr.DisplayMember = "nom";
            cbFourniSuppr.Enabled = false;
            cbDateLivraisonSuppr.Enabled = false;
            btnSupprimerLivraison.Enabled = false;
            cbProduitSuppr.DropDownClosed += (sender, e) =>
            {
                if (cbProduitSuppr.SelectedItem != null)
                {
                    DataTable DataidProduit = GestionProduit.getIdProduitByName(cbProduitSuppr.Text);
                    int idProduit = (int)DataidProduit.Rows[0][0];
                    cbFourniSuppr.DataSource = GestionLivraison.getFournisseurProduit(idProduit);
                    cbFourniSuppr.DisplayMember = "nomSociete";
                    cbFourniSuppr.Enabled = true;
                    cbDateLivraisonSuppr.Enabled = false;
                    btnSupprimerLivraison.Enabled = false;
                }
            };

            cbFourniSuppr.DropDownClosed += (sender, e) =>
            {
                if (cbFourniSuppr.SelectedItem != null)
                {
                    DataTable DataidProduit = GestionProduit.getIdProduitByName(cbProduitSuppr.Text);
                    int idProduit = (int)DataidProduit.Rows[0][0];
                    DataTable DataidFournisseur = GestionFournisseur.getFournisseurByName(cbFourniSuppr.Text);
                    int idFournisseur = (int)DataidFournisseur.Rows[0][0];
                    cbDateLivraisonSuppr.DataSource = GestionLivraison.getDateLivraisonProduitByFournisseur(idProduit, idFournisseur);
                    cbDateLivraisonSuppr.DisplayMember = "formattedDateLivraison";
                    cbDateLivraisonSuppr.Enabled = true;
                    btnSupprimerLivraison.Enabled = true;
                }
            };
        }
        #endregion
        public FrmGesLivraison()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey900, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Blue400, TextShade.WHITE);
        }

        private void FrmGesLivraison_Load(object sender, EventArgs e)
        {
            GestiontabAjout();
        }
        private void cbFournisseurDuProduit_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void cbFournisseurDuProduit_DropDownClosed(object sender, EventArgs e)
        {
            DataTable DataidFournisseur = GestionFournisseur.getFournisseurByName(cbFournisseurDuProduit.Text);
            int idFournisseur = (int)DataidFournisseur.Rows[0][0];
            DataTable DataQteLivraison = GestionLivraison.getQteProduitLivrés(Convert.ToInt32(IdProduitText), idFournisseur);
            int qteLivraison = (int)DataQteLivraison.Rows[0][0];
            DataTable DataPrixLivraison = GestionLivraison.getprixProduitLivrés(Convert.ToInt32(IdProduitText), idFournisseur);
            string prixLivraison = DataPrixLivraison.Rows[0][0].ToString();
            cbDateLivraison.DataSource = GestionLivraison.getDateLivraisonProduitByFournisseur(Convert.ToInt32(IdProduitText), idFournisseur);
            cbDateLivraison.DisplayMember = "formattedDateLivraison";
            txtPrixLivraison.Text = prixLivraison;
            txtQuantiteProduitLivre.Text =qteLivraison.ToString();

        }

        private void btnModifLivraison_Click(object sender, EventArgs e)
        {
            DataTable DataidFournisseur = GestionFournisseur.getFournisseurByName(cbFournisseurDuProduit.Text);
            int idFournisseur = (int)DataidFournisseur.Rows[0][0];
            GestionLivraison.modifier(Convert.ToInt32(IdProduitText), idFournisseur, Convert.ToDateTime(cbDateLivraison.Text), Convert.ToInt32(txtQuantiteProduitLivre.Text), txtPrixLivraison.Text);
            FrmGestLivraisonClosedEvent?.Invoke(this, EventArgs.Empty);
            this.Close();
        }

        private void btnAjoutLivraison_Click(object sender, EventArgs e)
        {
            DataTable DataidFournisseur = GestionFournisseur.getFournisseurByName(cbFournisseurProduitAjout.Text);
            int idFournisseur = (int)DataidFournisseur.Rows[0][0];
            DataTable DataidProduit = GestionProduit.getIdProduitByName(cbProduitAjout.Text);
            int idProduit = (int)DataidProduit.Rows[0][0];
            GestionLivraison.ajouter(idProduit, idFournisseur, Convert.ToInt32(txtQteLivreAjout.Text), txtPrixLivraisonAjout.Text);
            FrmGestLivraisonClosedEvent?.Invoke(this, EventArgs.Empty);
            this.Close();

        }

        private void cbProduitAjout_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbGestLivraison_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbGestLivraison.SelectedTab == tbpModifLivraison)
            {
                GestiontabModif();
            }
            else if (tbGestLivraison.SelectedTab == tbpAjoutLivraison)
            {
                GestiontabAjout();
            }
            else if (tbGestLivraison.SelectedTab == tbpSupprLivraison)
            {
                GestionTapSuppr();
            }
       
        }

        private void btnSupprimerLivraison_Click(object sender, EventArgs e)
        {
            DataTable DataidProduit = GestionProduit.getIdProduitByName(cbProduitSuppr.Text);
            int idProduit = (int)DataidProduit.Rows[0][0];
            DataTable DataidFournisseur = GestionFournisseur.getFournisseurByName(cbFourniSuppr.Text);
            int idFournisseur = (int)DataidFournisseur.Rows[0][0];
            if (cbFourniSuppr.Enabled == true && cbProduitSuppr.Enabled == true && cbDateLivraisonSuppr.Enabled == true)
            {
                message = MESSAGE_CONFIRMATION_SUPPR_LIVRAISON.Replace("#valeur#", cbProduitSuppr.Text);

                if (MessageBox.Show(message, "Confirmation", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    GestionLivraison.supprimer(idProduit, idFournisseur, Convert.ToDateTime(cbDateLivraisonSuppr.Text));
                }
            }
        }

        private void tbpAjoutLivraison_Click(object sender, EventArgs e)
        {

        }
    }
}
