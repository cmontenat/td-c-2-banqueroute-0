using libBanque;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppWindoBanque
{
    public partial class BanqueForm : Form
    {
        //Variable globales au formulaire = Propriétés du formulaire
        private AgenceBancaire MonAgence;
        public BanqueForm()
        {
            InitializeComponent();
            
        }
        public FrmBanque()
        {
            InitializeComponent();
            InitializeLaBanque();
        }

        private void InitializeLaBanque()
        {
            //Instenciation de l'objet MonAgence, en passant en paramètre le nom de l'agence
            MonAgence = new AgenceBancaire("MENTA");
            //Modification du titre de l'onglet
            lbl_ac_Titre.Text = "AGENCE de" + MonAgence.NomAgence;

            //Appel d'un sous-programme générant le jeu d'essai, autrement dit créant les comptes de l'agence
            GenererJeuDessai();
            //Appeld'un sous-programme remplissant le DataGridView avec la liste des compte de l'agence
            RemplirListeCompte();

            throw new NotImplementedException();
        }

        private void GenererJeuDessai()
        {
            CompteBancaire cbPatrick = new CompteBancaire("0211651079JP", "M. JANE Patrick");
            CompteBancaire cbTeresa = new CompteBancaire("1231212312LT", "Mle LISBON Teresa", 1500.00m);
            CompteBancaire cbCho = new CompteBancaire("9173826431KC", "M. KIMBALL Cho", 5050.00m);

            MonAgence.AjouterCompte(cbPatrick);
            MonAgence.AjouterCompte(cbTeresa);
            MonAgence.AjouterCompte(cbCho);
        }
        private void RemplirListeCompte()
        {
            //on indique tout simplement que la source des donnée  de la DataGridViewest une collection
            // -> La DataGridView contiendra autant de lignes que la collection contient d'objet
            // -> La DataGridView contiendra autant de colonnes que le type d'objet contient de property
            dvg_ListeComptes.Datasource = MonAgence.LesComptes;
            //On peut eventuellement adapter la mise en forme, icic en redimentionnant automatique 
            //la largeur des colonnes
            dvg_ListeComptes.AutoResizeColumns();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
