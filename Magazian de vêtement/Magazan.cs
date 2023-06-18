namespace Magazian_de_vêtement
{
    public partial class Magazan : Form
    {

        private showProducts showProductsForm;
        private ListVêtements ListesMagazan;
        public Magazan()
        {
            InitializeComponent();
            ListesMagazan = new ListVêtements();

        }
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            AjouterArticle AjouterVêtements = new AjouterArticle();
            AjouterVêtements.ShowDialog();
            if (AjouterVêtements.DialogResult == DialogResult.OK)
            {
                Tshirt tshirt1 = AjouterVêtements.GetTshirt();
                Chaussures chaussures = AjouterVêtements.GetChaussures();
                Pantalons pantalons = AjouterVêtements.GetPantalon();
                Pull pull = AjouterVêtements.GetPull();
                VêtEments vêtementes = AjouterVêtements.GetVêtements();

                if (tshirt1!=null)
                {
                    ListesMagazan.AjouterToMagazan(tshirt1, "ajoute", leMenuActual.Ajouter_au_magazin);
                }
                else if (pantalons!=null)
                {
                    ListesMagazan.AjouterToMagazan(pantalons, "ajoute", leMenuActual.Ajouter_au_magazin);
                }
                else if (chaussures!=null)
                {
                    ListesMagazan.AjouterToMagazan(chaussures, "ajoute", leMenuActual.Ajouter_au_magazin);
                }
                else if (pull!=null)
                {
                    ListesMagazan.AjouterToMagazan(pull, "ajoute", leMenuActual.Ajouter_au_magazin);
                }
            }
        }

        private void btnShowProducts_Click(object sender, EventArgs e)
        {
            showProductsForm = new showProducts(ListesMagazan);
            showProductsForm.ShowDialog();
        }

        private void btnActivité_Click(object sender, EventArgs e)
        {
            Activité delete = new Activité(ListesMagazan);
            delete.ShowDialog();
        }

        private void btnVendre(object sender, EventArgs e)
        {
            Vendre vendre = new Vendre(ListesMagazan);
            vendre.ShowDialog();
        }
    }
}
