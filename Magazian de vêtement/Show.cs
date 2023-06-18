using DocumentFormat.OpenXml.Spreadsheet;

namespace Magazian_de_vêtement
{
    class Show
    {
        private Panel? paneldetail;
        private Panel? TotalDeVente;
   
        public void ShowProductDetails(object clothing1,leMenuActual leMenuActual)
        {
            paneldetail = new Panel
            {
                Location = new Point(339, 12),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = System.Drawing.Color.White,
                AutoSize = true,
            };

            int y = 10; 

            if (clothing1 is VêtEments clothing)
            {

                // Add labels with clothing details
                y = AddLabel("Nom: " + clothing.Nom, new Point(10, y), GetPanel()).Bottom + 5;
                y = AddLabel("Type: " + clothing.Type, new Point(10, y), GetPanel()).Bottom + 5;
                y = AddLabel("Color: " + clothing.Couleur, new Point(10, y), GetPanel()).Bottom + 5;
                y = AddLabel("Sizes: " + clothing.Size, new Point(10, y), GetPanel()).Bottom + 5;
                y = AddLabel("Sexe: " + clothing.Sexe, new Point(10, y), GetPanel()).Bottom + 5;

                if (clothing.Type == "T-shirt")
                {
                    if (clothing is Tshirt clothing3)
                    {
                        y = AddLabel("Col: " + clothing3.Modele, new Point(10, y), GetPanel()).Bottom + 5;
                    }
                }
                else if (clothing.Type == "Pantalon")
                {
                    if (clothing1 is Pantalons clothing6)
                    {
                        y = AddLabel("Style: " + clothing6.Modele, new Point(10, y), GetPanel()).Bottom + 5;
                        y = AddLabel("Longueur: " + clothing6.Longeur, new Point(10, y), GetPanel()).Bottom + 5;
                        y = AddLabel("Taille: " + clothing6.taille, new Point(10, y), GetPanel()).Bottom + 5;
                    }
                }
                else if (clothing.Type == "Chaussures")
                {
                    if (clothing1 is Chaussures clothing5)
                    {
                        y = AddLabel("Pointure: " + clothing5.pointur, new Point(10, y), GetPanel()).Bottom + 5;
                    }
                }
                else if (clothing.Type == "Pull")
                {
                    if (clothing1 is Pull clothing4)
                    {
                        y = AddLabel("Col: " + clothing4.Modele, new Point(10, y), GetPanel()).Bottom + 5;
                        y = AddLabel("Capuche: " + clothing4.Capuche, new Point(10, y), GetPanel()).Bottom + 5;
                    }
                }
               
                Label prixLabel = AddLabel("Prix: " + clothing.Prix + "€", new Point(10, 0), GetPanel());

                if (leMenuActual==leMenuActual.panel_showproduct)
                {
                    Label quantiteLabel = AddLabel("Quantité: " + clothing.Quantité, new Point(10, 0), GetPanel());
                    quantiteLabel.Location = new Point(10, y);
                    prixLabel.Location = new Point(10, quantiteLabel.Bottom + 5);
                    paneldetail.Size = new Size(120, prixLabel.Bottom + 10);
                }else if (leMenuActual==leMenuActual.panel_showActivité)
                {

                    prixLabel.Location = new Point(10, y);
                    paneldetail.Size = new Size(120, prixLabel.Bottom + 10);
                }
                else if (leMenuActual == leMenuActual.panel_showVendre)
                {
                    paneldetail.Location=new Point(300, 12);
                    Label quantiteLabel = AddLabel("Quantité: " + clothing.Quantité, new Point(10, 0), GetPanel());
                    quantiteLabel.Location = new Point(10, y);
                    prixLabel.Location = new Point(10, quantiteLabel.Bottom + 5);
                    paneldetail.Size = new Size(120, prixLabel.Bottom + 10);
                }

            }

        }
        public Panel GetPanel()
        {
            return paneldetail;
        }
        private Label AddLabel(string text, Point location, Panel panel)
        {
            Label label = new Label
            {
                Text = text,
                Location = location
            };
            panel.Controls.Add(label);
            return label;
        }   
        public void ShowArticleActivite(List<string> _Actitvite, FlowLayoutPanel flowLayoutPanel)
        {

            foreach (string Text_Activite in _Actitvite)
            {
                Label label = new Label
                {
                    Text = Text_Activite,

                    AutoSize = true

                };
                flowLayoutPanel.Controls.Add(label);
            }

        }
        public Panel GetTotalDeVente()
        {
            return TotalDeVente;
        }
        public void ShowTotalPrix(List<object> list)
        {

            int Totalprix = 0;

            foreach (VêtEments clothing in list)
            {
                Totalprix += int.Parse(clothing.Prix);
            }
            TotalDeVente = new Panel
            {
                Location=new Point(211, 262),
                Name="totalDeVente",
                Size=new Size(106, 123),
                TabIndex=7,
                BackColor=System.Drawing.Color.White,
                BorderStyle=BorderStyle.FixedSingle
            };

            AddLabel("Article Vendu : " + list.Count, new Point(10, 10), GetTotalDeVente());
            AddLabel("Total: " + Totalprix + "€", new Point(10, 40), GetTotalDeVente());
            AddLabel("TVA: " + (Totalprix * 0.2) + "€", new Point(10, 70), GetTotalDeVente());
            AddLabel("Total TTC: " + (Totalprix + (Totalprix * 0.2)) + "€", new Point(10, 100), GetTotalDeVente());


        }
        public void ShowArticle(List<object> list, FlowLayoutPanel flowLayoutPanel, EventHandler pictureClick)
        {
            foreach (var item in list)
            {
                Pic(item, flowLayoutPanel, pictureClick);
            }
        }
        private void Pic(object clothing1, FlowLayoutPanel flowLayoutPanel, EventHandler PictureClick)
        {
            if (clothing1 is VêtEments clothing)
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Width = 150;
                pictureBox.Height = 150;
                pictureBox.ImageLocation = clothing.PhotoPath;
                pictureBox.BorderStyle = BorderStyle.FixedSingle;
                pictureBox.Padding = new Padding(5);
                pictureBox.Tag = clothing;
                pictureBox.Click += PictureClick;
                flowLayoutPanel.Controls.Add(pictureBox);
            }
        }
        public void Showlistoflist(ListVêtements Vêtements, FlowLayoutPanel flowLayoutPanel, EventHandler PictureClick)
        {
            foreach (var innerlist in Vêtements._Listvêtmenets)
            {
                foreach (var item in innerlist)
                {
                    Pic(item, flowLayoutPanel, PictureClick);
                }
            }
        }

    }
}


