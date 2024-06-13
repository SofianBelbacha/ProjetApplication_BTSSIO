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
using System.Reflection;
using System.Globalization;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Diagnostics;
using Image = iTextSharp.text.Image;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using GestionBD;

namespace BelbachaBoutique
{
    public partial class FrmDemarrage : MaterialForm
    {
        #region champs
        private string message;
        private string cheminImageComplet;
        private const string cheminRelatifImages = "../../../images/img_product/";
        private const string cheminRelatifPdf = "../../../PDF/";
        private const string cheminRelatifIcon = "../../../images/icon/";
        List<MaterialTextBox> champsNonValides = new List<MaterialTextBox>();
        private string nomImage;
        private string cheminImage;
        private const string MESSAGE_CONFIRMATION_SUPPR = " Etes vous sure de vouloir supprimer le client '#valeur#' de votre base";
        private const string MESSAGE_CONFIRMATION_SUPPR_COMMANDE = " Etes vous sure de vouloir supprimer la commande n° '#valeur#' de votre base";
        private const string MESSAGE_CONFIRMATION_SUPPR_PRODUIT = " Etes vous sure de vouloir supprimer le produit '#valeur#' de votre base";
        private const string MESSAGE_SUPPRESSION = " Vous avez bien supprimer la commande '#valeur#' de votre base";

        private const string MESSAGE_CONFIRMATION_AJOUT = " Etes vous sure de vouloir ajouter la commande '#valeur#' à votre base";
        private const string MESSAGE_AJOUT = " Vous avez bien ajouter la commande '#valeur#' à votre base";

        private const string MESSAGE_CONFIRMATION_MODIF = " Etes vous sure de vouloir modifier la commande '#valeur#' à votre base";
        private const string MESSAGE_MODIF = " Vous avez bien modifier la commande '#valeur#' de votre base";


        #endregion

        #region Méthodes
        [Obsolete]
        public static List<MaterialTextBox> CollectTextboxes(TabPage tabPage)
        {
            List<MaterialTextBox> textBoxes = new List<MaterialTextBox>();
            CollectTextboxesRecursive(tabPage, textBoxes);
            return textBoxes;
        }
        [Obsolete]
        private static void CollectTextboxesRecursive(Control control, List<MaterialTextBox> textBoxes)
        {
            foreach (Control childControl in control.Controls)
            {
                if (childControl is MaterialTextBox)
                {
                    textBoxes.Add((MaterialTextBox)childControl);
                }
                else if (childControl.HasChildren) // Vérifiez si le contrôle a des enfants
                {
                    // Si le contrôle a des enfants, appelez récursivement la méthode CollectTextboxesRecursive
                    CollectTextboxesRecursive(childControl, textBoxes);
                }
            }
        }
        private void DeplacerImage(string cheminSource, string cheminDestination)
        {
            try
            {
                // Vérifier si le fichier source existe
                if (File.Exists(cheminSource))
                {
                    ptrImgProduit.Image.Dispose();
                    // Déplacer le fichier vers le nouveau chemin
                    File.Copy(cheminSource, cheminDestination, true);
                    Console.WriteLine("L'image a été déplacée avec succès vers : " + cheminDestination);
                }
                else
                {
                    Console.WriteLine("Le fichier source n'existe pas.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Une erreur s'est produite lors du déplacement de l'image : " + ex.Message);
            }
        }
        private void FrmAjoutClosedEventHandler(object sender, EventArgs e)
        {
            dgvClient.DataSource = GestionClients.getTuples();
        }
        private void FrmGestLivraisonClosedEventHandler(object sender, EventArgs e)
        {
            dgvProduit.DataSource = GestionProduit.getTuples();
        }
        private void GestionFrmFournisseur()
        {
            lstFournisseur.Columns.Add("Nom de société", 200);
            lstFournisseur.Columns.Add("Adresse", 250);
            lstFournisseur.Columns.Add("Code Postale", 150);
            lstFournisseur.Columns.Add("Ville", 200);
            lstFournisseur.Columns.Add("Telephone", 150);
            lstFournisseur.Columns.Add("Email", 200);
            lstFournisseur.Columns.Add("Nbre de produit livrés", 170);
            lstFournisseur.Columns.Add("ID", 0);
            DataTable dataTableFournisseur = GestionFournisseur.getTuples();

            // Parcourir les lignes de la DataTable et ajouter les valeurs à la ListView
            foreach (DataRow rowFournisseur in dataTableFournisseur.Rows)
            {
                ListViewItem item = new ListViewItem(rowFournisseur["nomSociete"].ToString());
                item.SubItems.Add(rowFournisseur["rue"].ToString()); // Deuxième colonne
                item.SubItems.Add(rowFournisseur["codePostal"].ToString()); // Troisième colonne
                item.SubItems.Add(rowFournisseur["ville"].ToString()); // Quatrième colonne
                item.SubItems.Add(rowFournisseur["telephone"].ToString()); // Cinquième colonne
                item.SubItems.Add(rowFournisseur["email"].ToString()); // Sixième colonne
                item.SubItems.Add(rowFournisseur["NombreDeProduits"].ToString()); // Sixième colonne
                item.SubItems.Add(rowFournisseur["idFournisseur"].ToString()); // Sixième colonne

                // Ajouter l'élément ListViewItem à la ListView
                lstFournisseur.Items.Add(item);
            }
        }
        private void GestionFrmProduit()
        {
            dgvProduit.DataSource = GestionProduit.getTuples();
            cbCategorieProduit.DataSource = GestionCategorie.getTuples();
            cbCategorieProduit.DisplayMember = "libelle";
            cbFournisseurProduit.DataSource = GestionFournisseur.getTuples();
            cbFournisseurProduit.DisplayMember = "nomSociete";
        }
        private void GestionFrmClient()
        {
            dgvClient.DataSource = GestionClients.getTuples();
        }
        private void GestionFrmCommande()
        {
            lstProduit.Columns.Add("Nom du Produit", 350);
            lstProduit.Columns.Add("Categorie", 150);
            lstProduit.Columns.Add("Prix", 100);
            lstProduit.Columns.Add("Stock", 100);
            DataTable dataTableProduit = GestionCommande.getInfoProduit();

            // Parcourir les lignes de la DataTable et ajouter les valeurs à la ListView
            foreach (DataRow rowProduit in dataTableProduit.Rows)
            {
                ListViewItem item = new ListViewItem(rowProduit["nom"].ToString());
                item.SubItems.Add(rowProduit["libelle"].ToString()); // Quatrième colonne
                item.SubItems.Add(rowProduit["prix"].ToString()); // Troisième colonne
                item.SubItems.Add(rowProduit["qte"].ToString()); // Deuxième colonne
                // Ajouter l'élément ListViewItem à la ListView
                lstProduit.Items.Add(item);
            }
            cbProduitCmmde.DataSource = GestionProduit.getTuplesNom();
            cbProduitCmmde.DisplayMember = "nom";
            cbClientCmmde.DataSource = GestionClients.getPatronymes();
            cbClientCmmde.DisplayMember = "Patronyme";
            dgvCmmde.DataSource = GestionCommande.getTuplesCommande();
        }
        private void GestionstyleFrm()
        {

            txtDescriptionProduit.Width = 301;
            pnlControlProduit.BackColor = Color.WhiteSmoke;
            GestionInterface.coloriserDataGrid(dgvClient);
            dgvProduit.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvProduit.RowTemplate.Height = 50;
            dgvProduit.Columns[0].Visible = false;
            dgvProduit.Columns[1].Width = 250;
            dgvProduit.Columns[2].Width = 250;
            dgvProduit.Columns[3].Visible = false;
            lblLastPrix.Font = new System.Drawing.Font(lblLastPrix.Font, FontStyle.Bold);
            lblLastclient.Font = new System.Drawing.Font(lblLastclient.Font, FontStyle.Bold);
            lblLastProduitPrice.Font = new System.Drawing.Font(lblLastProduitPrice.Font, FontStyle.Bold);
            lblGetLastInfoCmmde.Font = new System.Drawing.Font(lblGetLastInfoCmmde.Font, FontStyle.Bold);
        }
        private void AddHeader(Document document)
        {
            //iTextSharp.text.Image logo = Image.GetInstance("D:\\Nouveaux_AP\\windows\\BelbachaBoutique\\images\\icon\\B.Sofian.png");
            iTextSharp.text.Image logo = Image.GetInstance(Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), cheminRelatifIcon, "B.Sofian.png"));
            logo.ScaleAbsolute(100, 100);

            PdfPTable headerTable = new PdfPTable(2);
            headerTable.WidthPercentage = 100;

            PdfPCell logoCell = new PdfPCell(logo);
            logoCell.HorizontalAlignment = Element.ALIGN_LEFT;
            logoCell.Border = PdfPCell.NO_BORDER;
            headerTable.AddCell(logoCell);

            PdfPCell contactCell = new PdfPCell();
            contactCell.HorizontalAlignment = Element.ALIGN_RIGHT;
            contactCell.Border = PdfPCell.NO_BORDER;

            Paragraph contactInfo = new Paragraph();
            contactInfo.Add(new Chunk("Nom de l'entreprise\n", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12)));
            contactInfo.Add(new Chunk("Adresse de l'entreprise\n", FontFactory.GetFont(FontFactory.HELVETICA, 10)));
            contactInfo.Add(new Chunk("Téléphone : 123-456-789\n", FontFactory.GetFont(FontFactory.HELVETICA, 10)));
            contactInfo.Add(new Chunk("Email : contact@example.com\n", FontFactory.GetFont(FontFactory.HELVETICA, 10)));
            contactCell.AddElement(contactInfo);

            headerTable.AddCell(contactCell);
            document.Add(headerTable);
            document.Add(new Paragraph("\n"));
            document.Add(new Paragraph("\n"));
            document.Add(new Paragraph("\n"));
        }

        private void AddDataTable(Document document, DataTable data)
        {
            PdfPTable table = new PdfPTable(data.Columns.Count);
            table.WidthPercentage = 100;
            table.DefaultCell.Padding = 3;
            table.DefaultCell.BackgroundColor = new BaseColor(240, 240, 240);
            table.DefaultCell.BorderWidth = 1;
            table.DefaultCell.BorderColor = BaseColor.BLACK;

            foreach (DataColumn column in data.Columns)
            {
                PdfPCell headerCell = new PdfPCell(new Phrase(column.ColumnName));
                headerCell.BackgroundColor = new BaseColor(200, 200, 200);
                headerCell.BorderColor = BaseColor.BLACK;
                headerCell.BorderWidth = 1;
                table.AddCell(headerCell);
            }

            foreach (DataRow row in data.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    PdfPCell dataCell = new PdfPCell(new Phrase(item.ToString()));
                    table.AddCell(dataCell);
                }
            }

            document.Add(table);
        }

        private void GestionFrmDemmarrage()
        {
            DataTable dataLastInfoProduit = GestionProduit.getLastProduit();
            string lastInfoProduitName = dataLastInfoProduit.Rows[0][0].ToString();
            string lastInfoProduitPrice = dataLastInfoProduit.Rows[0][1].ToString();
            nomImage = dataLastInfoProduit.Rows[0][2].ToString();
            cheminImageComplet = Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), cheminRelatifImages, nomImage);
            imgLastProduit.Image = System.Drawing.Image.FromFile(cheminImageComplet);
            imgLastProduit.SizeMode = PictureBoxSizeMode.Zoom;
            lblLastPrix.Text = lastInfoProduitName;
            lblLastProduitPrice.Text = lastInfoProduitPrice + " €";
            DataTable dataLastInfoClient = GestionClients.getLastIdClient();
            string lastInfoClient = dataLastInfoClient.Rows[0][1].ToString();
            lblLastclient.Text = lastInfoClient;
            DataTable dataLastInfoCommande = GestionCommande.getLastCommande();
            string lastInfoCommande = dataLastInfoCommande.Rows[0][4].ToString() + "\n\n" + dataLastInfoCommande.Rows[0][2].ToString() + "\n\n" + dataLastInfoCommande.Rows[0][3].ToString();
            lblGetLastInfoCmmde.Text = lastInfoCommande;


        }

        [Obsolete]
        private void expressionRegClient()
        {
            champsNonValides.Clear();
            MaterialTextBox[] textBoxes = { txtBxNom, txtBxPrenom, txtBxVille, txtBxEmail };
            MaterialTextBox[] textBoxesNumber = { txtBxTel, txtBxCp };
            string i = txtBxEmail.Text;
            foreach (MaterialTextBox textBox in textBoxes)
            {
                if (textBox.Name == "txtBxEmail")
                {
                    if (!GestionInterface.isEmailValide(textBox.Text) && textBox.Text != "")
                    {
                        champsNonValides.Add(textBox);
                    }
                }
                else if (!GestionInterface.isChaineValide(textBox.Text) && textBox.Text != "")
                {
                    champsNonValides.Add(textBox);
                }
            }
            // Vérification des champs de numéro de téléphone
            foreach (MaterialTextBox textBox in textBoxesNumber)
            {
                if (!GestionInterface.isChaineChiffres(textBox.Text) && textBox.Text != "")
                {
                    champsNonValides.Add(textBox);
                }
            }

        }
        #endregion

        public FrmDemarrage()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey900, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Blue400, TextShade.WHITE);
            this.Width = 1300;
            this.Load += FrmDemarrage_Load;
        }

        private void FrmDemarrage_Load(object sender, EventArgs e)
        {
            //GestionBoutique.seConnecter();
            GestionFrmDemmarrage();
            GestionFrmFournisseur();
            GestionFrmClient();
            GestionFrmProduit();
            GestionstyleFrm();
            GestionFrmCommande();
        }

        [Obsolete]
        private void btnEnvoieRcheClient_Click(object sender, EventArgs e)
        {
            expressionRegClient();

            if (champsNonValides.Count == 0)
            {
                dgvClient.DataSource = GestionClients.getClientBySearch(txtBxNom.Text, txtBxPrenom.Text, txtBxAdr.Text, txtBxCp.Text, txtBxVille.Text, txtBxTel.Text, txtBxEmail.Text);
            }
            else
            {
                string message = "Les champs suivants contiennent des caractères invalides :\n";
                foreach (MaterialTextBox textBox in champsNonValides)
                {
                    message += $"- {textBox.Name}\n";
                }
                MessageBox.Show(message);
            }
        }

        [Obsolete]
        private void btnReinitialDgvClient_Click(object sender, EventArgs e)
        {
            List<MaterialTextBox> textBoxesInTabPage = CollectTextboxes(tbpClient); 
            foreach (MaterialTextBox textBox in textBoxesInTabPage)
            {
                textBox.Text = string.Empty;
            }
            dgvClient.DataSource = GestionClients.getTuples();

        }

        private void btnSuprr_Click(object sender, EventArgs e)
        {
            if (dgvClient.CurrentRow != null && dgvClient.CurrentRow.Cells[0].Value != null)
            {
                int currentCellClient;
                if (int.TryParse(dgvClient.CurrentRow.Cells[0].Value.ToString(), out currentCellClient))
                {
                    DataTable dataPatronyme = GestionPS.getPatronymeById(currentCellClient);
                    if (dataPatronyme.Rows.Count > 0 && dataPatronyme.Rows[0][0] != null)
                    {
                        string patronymeClient = dataPatronyme.Rows[0][0].ToString();

                        message = MESSAGE_CONFIRMATION_SUPPR.Replace("#valeur#", patronymeClient);

                        if (MessageBox.Show(message, "Confirmation", MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            GestionClients.supprimer(currentCellClient);
                            dgvClient.DataSource = GestionClients.getTuples();
                            erpDgvGestion.SetError(btnSuprr, string.Empty);
                        }
                    }
                    else
                    {
                        MessageBox.Show("La première colonne de la ligne sélectionnée ne contient pas de valeur valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("La première colonne de la ligne sélectionnée ne contient pas une valeur numérique valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                erpDgvGestion.SetError(btnSuprr, "Vous devez d'abord sélectionner un client à supprimer");
                erpDgvGestion.SetIconAlignment(btnSuprr, ErrorIconAlignment.MiddleLeft);
            }
        }

        private void btnNewClient_Click(object sender, EventArgs e)
        {
            FrmAjout frmAjout = new FrmAjout();
            frmAjout.FormClosedEvent += FrmAjoutClosedEventHandler; // Abonnement à l'événement
            frmAjout.Show();
        }

        private void btnModifClient_Click(object sender, EventArgs e)
        {
            txtBxNom.Text = dgvClient.CurrentRow.Cells["nom"].Value.ToString();
            txtBxPrenom.Text = dgvClient.CurrentRow.Cells["prenom"].Value.ToString();
            txtBxAdr.Text = dgvClient.CurrentRow.Cells["rue"].Value.ToString();
            txtBxCp.Text = dgvClient.CurrentRow.Cells["codePostal"].Value.ToString();
            txtBxVille.Text = dgvClient.CurrentRow.Cells["ville"].Value.ToString();
            txtBxTel.Text = dgvClient.CurrentRow.Cells["telephone"].Value.ToString();
            txtBxEmail.Text = dgvClient.CurrentRow.Cells["email"].Value.ToString();
            btnEnvoiModifClient.Visible = true;
        }

        private void btnEnvoiModifClient_Click(object sender, EventArgs e)
        {
            expressionRegClient();
            if (champsNonValides.Count == 0)
            {

                int id = (int)dgvClient.CurrentRow.Cells["idClient"].Value;
                GestionClients.modifier(id, txtBxNom.Text, txtBxPrenom.Text, txtBxAdr.Text, Convert.ToInt32(txtBxCp.Text), txtBxVille.Text, txtBxTel.Text, txtBxEmail.Text);
                btnEnvoiModifClient.Visible = false;
                dgvClient.DataSource = GestionClients.getTuples();
            }
            else
            {
                string message = "Les champs suivants contiennent des caractères invalides :\n";
                foreach (MaterialTextBox textBox in champsNonValides)
                {
                    message += $"- {textBox.Name}\n";
                }
                MessageBox.Show(message);
            }
        }

        private void lstFournisseur_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(ListViewItem item in lstFournisseur.SelectedItems) 
            {
                lblNomFourniValue.Text = item.SubItems[0].Text;
                lblRueFourniValue.Text = item.SubItems[1].Text;
                lblCpFourniValue.Text = item.SubItems[2].Text;
                lblVilleFourniValue.Text = item.SubItems[3].Text;
                lblTelephoneFourniValue.Text = item.SubItems[4].Text;
                lblEmailFourniValue.Text = item.SubItems[5].Text;
                lblNbProduitValue.Text = item.SubItems[6].Text;
                lblIdFourniValue.Text = item.SubItems[7].Text;

            }
            // Supposons que GestionFournisseur.getTuplesProduitByFournisseur(5) renvoie une DataTable
            DataTable dataProduitFournisseur = GestionFournisseur.getTuplesProduitByFournisseur(Convert.ToInt32(lblIdFourniValue.Text));
            lstProduitFourni.Clear();
            // Parcourez les lignes de la DataTable et ajoutez les noms des produits à votre ListBox
            foreach (DataRow row in dataProduitFournisseur.Rows)
            {
                // Supposons que le nom du produit soit dans la première colonne de la DataTable
                string nomProduit = row[0].ToString();

                // Créez un nouvel élément MaterialListBoxItem avec le nom du produit
                MaterialListBoxItem item = new MaterialListBoxItem(nomProduit);

                // Ajoutez l'élément à votre collection ListBox
                lstProduitFourni.Items.Add(item);
            }

        }

        private void txtDescription_Click(object sender, EventArgs e)
        {
            MaterialMultiLineTextBox2 txtDescription = new MaterialMultiLineTextBox2();
        }

        [Obsolete]
        private void btnReinitialControlProduit_Click(object sender, EventArgs e)
        {
            List<MaterialTextBox> textBoxesInTabPage = CollectTextboxes(tbpProduit);
            foreach (MaterialTextBox textBox in textBoxesInTabPage)
            {
                textBox.Text = string.Empty;
            }
            txtDescriptionProduit.Text = string.Empty;
            ptrImgProduit.Image = null;
            dtpDateLivraison.Text = string.Empty;
            btnGestionInfoProduiFourni.Visible = false;
        }
        private void btnDeleteProduit_Click(object sender, EventArgs e)
        {
            if (txtIdProduit.Text != "")
            {
                string idProduit = txtIdProduit.Text;
                DataTable dataProduitName = GestionProduit.getProduitById(Convert.ToInt32(idProduit));
                string NomProduit = dataProduitName.Rows[0][0].ToString();

                message = MESSAGE_CONFIRMATION_SUPPR_PRODUIT.Replace("#valeur#", NomProduit);

                if (MessageBox.Show(message, "Confirmation", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    GestionProduit.supprimer(Convert.ToInt32(idProduit));
                    dgvProduit.DataSource = GestionProduit.getTuples();
                    erpGestProduitSuppr.SetError(btnDeleteProduit, string.Empty);
                    dgvProduit.DataSource = GestionProduit.getTuples();
                    List<MaterialTextBox> textBoxesInTabPage = CollectTextboxes(tbpProduit);
                    foreach (MaterialTextBox textBox in textBoxesInTabPage)
                    {
                        textBox.Text = string.Empty;
                    }
                    txtDescriptionProduit.Text = string.Empty;
                    ptrImgProduit.Image.Dispose();
                    ptrImgProduit.Image = null;
                    dtpDateLivraison.Text = string.Empty;
                    File.Delete(cheminImageComplet);
                    btnGestionInfoProduiFourni.Visible = false;
                }
            }
            else
            {
                erpGestProduitSuppr.SetError(btnDeleteProduit, "Vous devez d'abord sélectionner un produit à supprimer");
                erpGestProduitSuppr.SetIconAlignment(btnDeleteProduit, ErrorIconAlignment.MiddleLeft);
            }
        }

        private void dgvProduit_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtIdProduit.Text = dgvProduit.CurrentRow.Cells["idProduit"].Value.ToString();
            txtNomProduit.Text = dgvProduit.CurrentRow.Cells["nom"].Value.ToString();
            txtDescriptionProduit.Text = dgvProduit.CurrentRow.Cells["description"].Value.ToString();
            txtCouleur.Text = dgvProduit.CurrentRow.Cells["couleur"].Value.ToString();
            txtPrix.Text = dgvProduit.CurrentRow.Cells["prix"].Value.ToString();
            txtQuantiteProduit.Text = dgvProduit.CurrentRow.Cells["quantite"].Value.ToString();
            dtpDateLivraison.Text = dgvProduit.CurrentRow.Cells["dateLivraison"].Value.ToString();
            cbFournisseurProduit.Text = dgvProduit.CurrentRow.Cells["fournisseur"].Value.ToString();
            cbCategorieProduit.Text = dgvProduit.CurrentRow.Cells["categorie"].Value.ToString();
            string nomImage = dgvProduit.CurrentRow.Cells["image"].Value.ToString();

            // Chemin complet vers le fichier image en combinant le chemin relatif et le nom de l'image
            cheminImageComplet = Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), cheminRelatifImages, nomImage);

            // Vérifier si le fichier image existe avant de charger l'image
            if (System.IO.File.Exists(cheminImageComplet))
            {
                // Charger l'image dans la PictureBox à partir du chemin complet
                ptrImgProduit.Image = System.Drawing.Image.FromFile(cheminImageComplet);
                ptrImgProduit.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                // Gérer le cas où le fichier image n'existe pas
                MessageBox.Show("L'image n'existe pas à l'emplacement spécifié.");
            }
            btnGestionInfoProduiFourni.Visible = true;
        }

        private void btnModifProduit_Click(object sender, EventArgs e)
        {
            if (txtIdProduit.Text != "")
            {
                DataTable DataidCatergorie = GestionCategorie.getIdCategorieByLibelle(cbCategorieProduit.Text);
                int idCateg = (int)DataidCatergorie.Rows[0][0];
                //DataTable DataidFournisseur = GestionFournisseur.getFournisseurByName(cbFournisseurProduit.Text);
                //int idFournisseur = (int)DataidFournisseur.Rows[0][0];
                string imgDefault = dgvProduit.CurrentRow.Cells["image"].Value.ToString();
                string cheminImage = string.IsNullOrEmpty(nomImage) ? imgDefault : nomImage;
                GestionProduit.modifier(txtIdProduit.Text, txtNomProduit.Text, txtDescriptionProduit.Text, cheminImage, txtCouleur.Text, idCateg);
                GestionProduit.modifierPrix(Convert.ToInt32(txtIdProduit.Text), txtPrix.Text);
                DeplacerImage(this.cheminImage, cheminImageComplet);
                List<MaterialTextBox> textBoxesInTabPage = CollectTextboxes(tbpProduit);
                foreach (MaterialTextBox textBox in textBoxesInTabPage)
                {
                    textBox.Text = string.Empty;
                }
                txtDescriptionProduit.Text = null;
                ptrImgProduit.Image.Dispose();
                ptrImgProduit.Image = null;
                dgvProduit.DataSource = GestionProduit.getTuples();
                cbCategorieProduit.DataSource = GestionCategorie.getTuples();
                cbCategorieProduit.DisplayMember = "libelle";
                erpGestProduitSuppr.SetError(btnModifProduit, string.Empty);
                btnGestionInfoProduiFourni.Visible = false;

            }
            else
            {
                erpGestProduitSuppr.SetError(btnModifProduit, "Vous devez d'abord sélectionner un produit à modifier");
                erpGestProduitSuppr.SetIconAlignment(btnModifProduit, ErrorIconAlignment.MiddleLeft);
            }
        }

        private void ptrImgProduit_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Images (*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedImagePath = openFileDialog.FileName;
                // Assignez le chemin de l'image sélectionnée à votre contrôle PictureBox ou à toute autre variable où vous stockez l'image.
                ptrImgProduit.Image = System.Drawing.Image.FromFile(selectedImagePath);
                cheminImage = selectedImagePath;
                nomImage = Path.GetFileName(cheminImage);
                // Chemin relatif vers le dossier des images à partir du dossier du fichier .cs
                cheminImageComplet = Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), cheminRelatifImages, nomImage);
                ptrImgProduit.SizeMode = PictureBoxSizeMode.Zoom;
            }

        }

        private void btnGestionInfoProduiFourni_Click(object sender, EventArgs e)
        {
            FrmGesLivraison frmLivraison = new FrmGesLivraison();
            frmLivraison.IdProduitText = txtIdProduit.Text;
            frmLivraison.FrmGestLivraisonClosedEvent += FrmGestLivraisonClosedEventHandler; // Abonnement à l'événement
            frmLivraison.Show();
        }

        private void btnAddProduit_Click(object sender, EventArgs e)
        {
            if (txtIdProduit.Text == "")
            {
                DataTable DataidCatergorie = GestionCategorie.getIdCategorieByLibelle(cbCategorieProduit.Text);
                int idCateg = (int)DataidCatergorie.Rows[0][0];
                string imgDefault = dgvProduit.CurrentRow.Cells["image"].Value.ToString();
                string cheminImage = string.IsNullOrEmpty(nomImage) ? imgDefault : nomImage;
                GestionProduit.ajouter(txtNomProduit.Text, txtDescriptionProduit.Text, cheminImage, txtCouleur.Text, idCateg);
                int idProduit = GestionProduit.getPrimayKeyProduit();
                GestionProduit.ajouterPrix(idProduit, txtPrix.Text);
                DeplacerImage(this.cheminImage, cheminImageComplet);
                List<MaterialTextBox> textBoxesInTabPage = CollectTextboxes(tbpProduit);
                foreach (MaterialTextBox textBox in textBoxesInTabPage)
                {
                    textBox.Text = string.Empty;
                }
                txtDescriptionProduit.Text = null;
                ptrImgProduit.Image.Dispose();
                ptrImgProduit.Image = null;
                dgvProduit.DataSource = GestionProduit.getTuples();
                cbCategorieProduit.DataSource = GestionCategorie.getTuples();
                cbCategorieProduit.DisplayMember = "libelle";
                erpGestProduitSuppr.SetError(btnAddProduit, string.Empty);
                btnGestionInfoProduiFourni.Visible = false;

            }
            else
            {
                erpGestProduitSuppr.SetError(btnAddProduit, "Vous devez d'abord vider les champs avant d'ajouter un produit.");
                erpGestProduitSuppr.SetIconAlignment(btnAddProduit, ErrorIconAlignment.MiddleLeft);
            }

        }

        private void btnSupprCmmde_Click(object sender, EventArgs e)
        {
            if (dgvCmmde.CurrentRow != null)
            {
                message = MESSAGE_CONFIRMATION_SUPPR.Replace("#valeur#", dgvCmmde.CurrentRow.Cells["Commande n°"].Value.ToString());

                if (MessageBox.Show(message, "Confirmation", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    GestionCommande.supprimer(Convert.ToInt32(dgvCmmde.CurrentRow.Cells["Commande n°"].Value));
                    dgvCmmde.DataSource = GestionCommande.getTuplesCommande();
                    erpDgvGestion.SetError(btnSupprCmmde, string.Empty);
                }
            }
            else
            {
                erpDgvGestion.SetError(btnSupprCmmde, "Vous devez d'abord sélectionner une commande à supprimer");
                erpDgvGestion.SetIconAlignment(btnSupprCmmde, ErrorIconAlignment.MiddleLeft);
            }

        }
        private void dgvCmmde_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCmmde.CurrentRow != null && dgvCmmde.CurrentRow.Cells["nom du produit"].Value != null)
            {
                cbProduitCmmde.Text = dgvCmmde.CurrentRow.Cells["nom du produit"].Value.ToString();
                cbClientCmmde.Text = dgvCmmde.CurrentRow.Cells["nom du client"].Value.ToString();
                txtQteCmmde.Text = dgvCmmde.CurrentRow.Cells["quantite"].Value.ToString();
                dtpDateCmmde.Text = dgvCmmde.CurrentRow.Cells["date de commande"].Value.ToString();
            }
            else
            {
                cbProduitCmmde.Text = cbProduitCmmde.Items[0].ToString();
                cbClientCmmde.Text = cbClientCmmde.Items[0].ToString();
                txtQteCmmde.Text = "";

            }
        }

        private void btnModifCmmde_Click(object sender, EventArgs e)
        {
            DataTable dataIdClient = GestionClients.getIdByPatronymes(cbClientCmmde.Text);
            int idClient = (int)dataIdClient.Rows[0][0];
            DataTable dataIdProduit = GestionProduit.getIdProduitByName(cbProduitCmmde.Text);
            int idProduit = (int)dataIdProduit.Rows[0][0];
            int idCommande = (int)dgvCmmde.CurrentRow.Cells["Commande n°"].Value;
            string date = DateTime.Parse(dtpDateCmmde.Text).ToString("yyyy-MM-dd");
            GestionCommande.modifier(idCommande, date, idClient);
            GestionCommande.modifierLigneCommande(idCommande, idProduit, Convert.ToInt32(txtQteCmmde.Text));
            dgvCmmde.DataSource = GestionCommande.getTuplesCommande();
            txtQteCmmde.Text = "";
            
        }

        private void btnAjoutCmmde_Click(object sender, EventArgs e)
        {
            DataTable dataIdClient = GestionPS.getIdByPatronymes(cbClientCmmde.Text);
            int idClient = (int)dataIdClient.Rows[0][0];
            DataTable dataIdProduit = GestionProduit.getIdProduitByName(cbProduitCmmde.Text);
            int idProduit = (int)dataIdProduit.Rows[0][0];
            DataTable dataIdCommande = GestionCommande.getPrimaryKeyCommande();
            int idCommande = (int)dataIdCommande.Rows[0][0] + 1;
            string date = DateTime.Parse(dtpDateCmmde.Text).ToString("yyyy-MM-dd");
            GestionCommande.ajouter(date, idClient);
            GestionCommande.ajouterLigneCommande(idProduit, idCommande, Convert.ToInt32(txtQteCmmde.Text));
            dgvCmmde.DataSource = GestionCommande.getTuplesCommande();
            txtQteCmmde.Text = "";

        }

        private void FrmDemarrage_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void btnDownloadPdf_Click(object sender, EventArgs e)
        {
            DataTable data = GestionCommande.getTuplesCommande();
            string outputFile = Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), cheminRelatifPdf, "recapitulatif-commande.pdf");
            Document document = new Document();

            try
            {
                PdfWriter.GetInstance(document, new FileStream(outputFile, FileMode.Create));
                document.Open();
                AddHeader(document);
                AddDataTable(document, data);
                Process.Start(outputFile);
            }
            catch (DocumentException de)
            {
                Console.Error.WriteLine("Erreur lors de la création du document: " + de.Message);
            }
            catch (IOException ioe)
            {
                Console.Error.WriteLine("Erreur d'entrée/sortie: " + ioe.Message);
            }
            finally
            {
                document.Close();
            }

            Console.WriteLine("Le fichier PDF avec le tableau de données a été créé avec succès à l'emplacement : " + outputFile);
            Console.ReadLine();
        }
    }
}
