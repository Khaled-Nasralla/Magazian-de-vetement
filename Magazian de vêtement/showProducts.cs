
namespace Magazian_de_vêtement
{
    public partial class showProducts : Form
    {
        private ListVêtements Vêtements;
        private Show _show;
        private leMenuActual _leMenuActual;

        public showProducts(ListVêtements listTshirt)
        {
            InitializeComponent();
            this.Vêtements = listTshirt;
            _show = new Show();


        }
        private void ShowProductsForm_Load(object sender, EventArgs e)
        {
            flowLayoutPanel.Controls.Clear();
            ListCompter();
            label2.BackColor=System.Drawing.Color.LightBlue;
            _show.Showlistoflist(Vêtements, flowLayoutPanel, Picture_Click);

        }
        private void ListCompter()
        {
            int count = 0;
            for (int comp = 0; comp < Vêtements._Listvêtmenets.Count; comp++)
            {

                count = Vêtements._Listvêtmenets[comp].Count+count;

                label2.Text = $"Vêtements ({count})";
            }
            label1.Text=$"T-shirt ({Vêtements._Listvêtmenets[0].Count})";
            label3.Text=$"Chaussures ({Vêtements._Listvêtmenets[1].Count})";
            label4.Text=$"Pantalons ({Vêtements._Listvêtmenets[2].Count})";
            label6.Text=$"Pull ({Vêtements._Listvêtmenets[3].Count})";
        }
        private void GererLAffichage()
        {
            label1.BackColor=System.Drawing.Color.Empty;
            label3.BackColor=System.Drawing.Color.Empty;
            label4.BackColor=System.Drawing.Color.Empty;
            label6.BackColor=System.Drawing.Color.Empty;
            label2.BackColor=System.Drawing.Color.Empty;
            flowLayoutPanel.Controls.Clear();
            panel.Controls.Clear();
            panel.Visible = false;

            if (_leMenuActual == leMenuActual.tout)
            {
                label2.BackColor= System.Drawing.Color.LightBlue;
                _show.Showlistoflist(Vêtements, flowLayoutPanel, Picture_Click);
            }
            else if (_leMenuActual == leMenuActual.tshirt)
            {
                label1.BackColor= System.Drawing.Color.LightBlue;
                _show.ShowArticle(Vêtements._Listvêtmenets[0], flowLayoutPanel, Picture_Click);
            }
            else if (_leMenuActual == leMenuActual.chaussure)
            {
                label3.BackColor= System.Drawing.Color.LightBlue;
                _show.ShowArticle(Vêtements._Listvêtmenets[1], flowLayoutPanel, Picture_Click);
            }
            else if (_leMenuActual == leMenuActual.pantalon)
            {
                label4.BackColor= System.Drawing.Color.LightBlue;
                _show.ShowArticle(Vêtements._Listvêtmenets[2], flowLayoutPanel, Picture_Click);
            }
            else if (_leMenuActual == leMenuActual.pull)
            {
                label6.BackColor= System.Drawing.Color.LightBlue;
                _show.ShowArticle(Vêtements._Listvêtmenets[3], flowLayoutPanel, Picture_Click);
            }
        }
        private void Picture_Click(object sender, EventArgs e)
        {
            PictureBox? pictureBox = sender as PictureBox;



            if (pictureBox != null)
            {
                object? clothing = pictureBox.Tag;
        

                foreach (PictureBox pb in flowLayoutPanel.Controls.OfType<PictureBox>())
                {
                    pb.BackColor = System.Drawing.Color.White;
                }
                pictureBox.BackColor = System.Drawing.Color.LightBlue;
               
                if (clothing != null)
                {

                    panel.Visible = false;
                    panel.Controls.Clear();
                    _show.ShowProductDetails(clothing,leMenuActual.panel_showproduct);
                    panel=_show.GetPanel();
                    Controls.Add(panel);
                    panel.Visible = true;
                    panel.Tag = clothing;

                }

            }
        }
        private void AllVêtements_Click(object sender, EventArgs e)
        {
            _leMenuActual = leMenuActual.tout;
            GererLAffichage();
        }
        private void Tshirt_Click(object sender, EventArgs e)
        {
            _leMenuActual = leMenuActual.tshirt;
            GererLAffichage();
        }
        private void Pull_Click(object sender, EventArgs e)
        {
            _leMenuActual = leMenuActual.pull;
            GererLAffichage();
        }
        private void Pantalon_Click(object sender, EventArgs e)
        {
            _leMenuActual = leMenuActual.pantalon;
            GererLAffichage();
        }
        private void Chaussure(object sender, EventArgs e)
        {
            _leMenuActual = leMenuActual.chaussure;
            GererLAffichage();
        }
        public void Delete_Click(object sender, EventArgs e)
        {
            if (panel.Visible==true)
            {
                AreYouSure sure = new AreYouSure();
                sure.ShowDialog();

                if (sure.getSure())
                {
                    object? selectedItem = panel.Tag;

                    if (selectedItem != null)
                    {

                        if (selectedItem is Pantalons pantalons)
                        {

                            Vêtements.ListSupprimer(pantalons);
                            panel.Controls.Clear();
                            panel.Visible = false;
                            flowLayoutPanel.Controls.Clear();
                            if (label2.BackColor==System.Drawing.Color.LightBlue)
                            {
                                _show.Showlistoflist(Vêtements, flowLayoutPanel, Picture_Click);
                            }
                            else
                            {
                                _show.ShowArticle(Vêtements._Listvêtmenets[2], flowLayoutPanel, Picture_Click);
                            }

                        }
                        else if (selectedItem is Pull pull)
                        {
                            Vêtements.ListSupprimer(pull);
                            panel.Controls.Clear();
                            panel.Visible = false;
                            flowLayoutPanel.Controls.Clear();

                            if (label2.BackColor==System.Drawing.Color.LightBlue)
                            {
                                _show.Showlistoflist(Vêtements, flowLayoutPanel, Picture_Click);
                            }
                            else
                            {
                                _show.ShowArticle(Vêtements._Listvêtmenets[3], flowLayoutPanel, Picture_Click);
                            }

                        }
                        else if (selectedItem is Tshirt clothing)
                        {

                            Vêtements.ListSupprimer(clothing);

                            panel.Controls.Clear();
                            panel.Visible = false;
                            flowLayoutPanel.Controls.Clear();
                            if (label2.BackColor==System.Drawing.Color.LightBlue)
                            {
                                _show.Showlistoflist(Vêtements, flowLayoutPanel, Picture_Click);
                            }
                            else
                            {
                                _show.ShowArticle(Vêtements._Listvêtmenets[0], flowLayoutPanel, Picture_Click);
                            }
                        }

                        else if (selectedItem is Chaussures chaussures)
                        {
                            Vêtements.ListSupprimer(chaussures);

                            panel.Controls.Clear();
                            panel.Visible = false;
                            flowLayoutPanel.Controls.Clear();
                            if (label2.BackColor==System.Drawing.Color.LightBlue)
                            {
                                _show.Showlistoflist(Vêtements, flowLayoutPanel, Picture_Click);
                            }
                            else
                            {
                                _show.ShowArticle(Vêtements._Listvêtmenets[1], flowLayoutPanel, Picture_Click);
                            }
                        }

                        ListCompter();

                    }
                }

            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un article à supprimer");
            }
        }
        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}







