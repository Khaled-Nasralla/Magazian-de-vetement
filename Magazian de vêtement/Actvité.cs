namespace Magazian_de_vêtement
{
    public partial class Activité : Form
    {
        private ListVêtements Activty;
        private Show _show;
        private leMenuActual _leMenuActual;
        public Activité(ListVêtements Supprission)
        {
            InitializeComponent();
            this.Activty = Supprission;
            _show = new Show();
        }
        private void Activité_Load(object sender, EventArgs e)
        {
            _show.ShowArticleActivite(Activty.VerfieDeActvicité, flowLayoutPanel1);

        }
        private void Picture_Click(object sender, EventArgs e)
        {
            PictureBox? pictureBox = sender as PictureBox;      
            if (pictureBox != null)
            {
                object? clothing = pictureBox.Tag;
       
                foreach (PictureBox pb in flowLayoutPanel1.Controls.OfType<PictureBox>())
                {
                    pb.BackColor = Color.White;
                }
                pictureBox.BackColor = Color.LightBlue;
                if (clothing != null)
                {
                    panel.Controls.Clear();
                    panel.Visible = false;                              
                    _show.ShowProductDetails(clothing, leMenuActual.panel_showActivité);
                    panel = _show.GetPanel();
                    Controls.Add(panel);
                    panel.Tag = clothing;
                    panel.Visible = true;
                }
            }
        }
        private void Supprimer_button(object sender, EventArgs e)
        {

            _leMenuActual=leMenuActual.Supprimer;
            Activty.GetLeMenuActual(leMenuActual.Supprimer);
            GereLAffichage();
        }
        public void GereLAffichage()
        {
            panel.Controls.Clear();
            panel.Visible = false;
            totalDeVente.Controls.Clear();
            totalDeVente.Visible = false;
            flowLayoutPanel1.Controls.Clear();
            if (_leMenuActual==leMenuActual.Supprimer)
            {
                _show.ShowArticle(Activty.Supprimer, flowLayoutPanel1, Picture_Click);
            }
            else if (_leMenuActual==leMenuActual.Vendu)
            {
                _show.ShowTotalPrix(Activty.Vendu);
                totalDeVente = _show.GetTotalDeVente();
                Controls.Add(totalDeVente);
                totalDeVente.Visible = true;
                _show.ShowArticle(Activty.Vendu, flowLayoutPanel1, Picture_Click);

            }
            else if (_leMenuActual==leMenuActual.Activité)
            {
                _show.ShowArticleActivite(Activty.VerfieDeActvicité, flowLayoutPanel1);
            }
        }
        private void Activite_Click(object sender, EventArgs e)
        {
            _leMenuActual = leMenuActual.Activité;
            GereLAffichage();
        }
        private void Vendu_Click(object sender, EventArgs e)
        {
            _leMenuActual = leMenuActual.Vendu;
            Activty.GetLeMenuActual(leMenuActual.Vendu);
            GereLAffichage();
        }
        private void Rendre_Click(object sender, EventArgs e)
        {
            if (panel.Visible)
            {
                object? ArticleDestiné = panel.Tag;

                if (ArticleDestiné != null)
                {

                    if (ArticleDestiné is Chaussures chaussures)
                    {
                        Activty.AjouterToMagazan(chaussures, "Rendre",leMenuActual.list_rendre);
                    }
                    else if (ArticleDestiné is Tshirt tshirt)
                    {
                        Activty.AjouterToMagazan(tshirt, "Rendre",leMenuActual.list_rendre);
                    }
                    else if (ArticleDestiné is Pantalons pantalon)
                    {
                        Activty.AjouterToMagazan(pantalon, "Rendre", leMenuActual.list_rendre);
                    }
                    else if (ArticleDestiné is Pull pull)
                    {
                        Activty.AjouterToMagazan(pull, "Rendre", leMenuActual.list_rendre);
                    }
                    MessageBox.Show("Article rendu avec succès.");

                    GereLAffichage();
                }
            }
            else
            {
                MessageBox.Show("Aucun article sélectionné.");
            }
        }
        private void Fermer_Click(object sender, EventArgs e)
        {
            Close();
        }

      
    }
}
