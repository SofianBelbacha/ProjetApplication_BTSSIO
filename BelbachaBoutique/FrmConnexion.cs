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
using System.Security.Cryptography;

namespace BelbachaBoutique
{
    public partial class FrmConnexion : MaterialForm
    {
        Form FrmDemarrage = new FrmDemarrage();

        private string HashPassword(string password)
        {
            using (SHA1 sha1 = SHA1.Create())
            {
                byte[] hashedBytes = sha1.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in hashedBytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }
        public FrmConnexion()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey900, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Blue400, TextShade.WHITE);
        }

        private void FrmConnexion_Load(object sender, EventArgs e)
        {
            GestionBoutique.seConnecter();  
            //FrmDemarrage.Show();
            //FrmDemarrage.Visible = false;
        }

        private void btnConnection_Click(object sender, EventArgs e)
        {
            //string login = txtIdentifiant.Text;
            //string password = HashPassword(txtMdp.Text);
            try{
                GestionBoutique.seConnecter("localhost", "belbachaboutique", txtIdentifiant.Text, txtMdp.Text);
                Form FrmDemmarage = new FrmDemarrage();
                FrmDemarrage.Show();
                lblConnection.Text = "";

            }
            catch 
            {
                erpErrorConnexion.SetError(btnConnection, "Vous devez d'abord sélectionner un client à supprimer");
                erpErrorConnexion.SetIconAlignment(btnConnection, ErrorIconAlignment.MiddleLeft);
                lblMessageErreur.Text = "Identifiant ou mot de passe incorrect";

            }


            // Utilisation de paramètres SQL pour éviter les injections
            //DataTable dataConnexion = UserConnection.getConnexion(login, password);
            //if (dataConnexion.Rows.Count > 0 && (bool)dataConnexion.Rows[0]["isAdmin"])
            //{
            //    FrmDemarrage.Visible = true;
            //    // Connexion réussie
            //    this.Close();

            //}
            //else
            //{
            //    // Échec de la connexion
            //    MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect.", "Erreur de connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    txtIdentifiant.Clear();
            //    txtMdp.Clear();
            //    FrmDemarrage.Visible = false;
            //}
        }
    }
}
