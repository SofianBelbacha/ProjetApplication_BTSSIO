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

namespace BelbachaBoutique
{
    public partial class FrmAjout : MaterialForm
    {
        #region Champs
        public event EventHandler FormClosedEvent;
        #endregion
        #region Propriété
        public string IdProduitText { get; set; }
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
            }
        }
        #endregion

        public FrmAjout()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey900, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Blue400, TextShade.WHITE);
        }

        private void FrmAjout_Load(object sender, EventArgs e)
        {
        }

        [Obsolete]
        private void btnAjoutClient_Click(object sender, EventArgs e)
        {
            GestionClients.ajouter(txtBxNom.Text, txtBxPrenom.Text, txtBxAdr.Text, txtBxCp.Text, txtBxVille.Text, txtBxTel.Text, txtBxEmail.Text);
            FormClosedEvent?.Invoke(this, EventArgs.Empty); // Déclenche l'événement lorsque le formulaire est fermé
            this.Close();
        }

        private void tbpAjoutGestProduitFourni_Click(object sender, EventArgs e)
        {

        }
    }
}
