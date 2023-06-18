using DocumentFormat.OpenXml.Drawing;
using OpenXmlPowerTools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magazian_de_vêtement
{
    public partial class Vendre : Form
    {
        private ListVêtements Lists;
        private Show _show;
        Panel panel = new Panel();
        public string prix;
        bool isClicked;
     

        public Vendre(ListVêtements _vendu)
        {
            InitializeComponent();
            this.Lists = _vendu;
            _show = new Show();


        }

        private void Rechercher_Click(object sender, EventArgs e)
        {
            ArticleLoad(Lists, textBox1.Text,typecompoBox1);
         
        }

        private void ArticleLoad(ListVêtements Listes, string Nom,ComboBox comboBox)
        {
            panel.Controls.Clear();
            panel.Visible = false;
            flowLayoutPanel1.Controls.Clear();
            isClicked = true;
            foreach (var innerlist in Listes._Listvêtmenets)
            {
                foreach (var item in innerlist)
                {
                 
                        if (item is VêtEments vêtementes)
                    {

                        if (vêtementes.Nom == Nom && vêtementes.Type==typecompoBox1.Text)
                        {
                            if (Lists.isExist(vêtementes))
                            {                                 
                                PictureBox picture = new PictureBox();
                                picture.ImageLocation = vêtementes.PhotoPath;
                                picture.SizeMode = PictureBoxSizeMode.StretchImage;
                                picture.Size = new Size(270, 260);
                                picture.Padding = new Padding(10);
                                _show.ShowProductDetails(vêtementes, leMenuActual.panel_showVendre);
                                panel=_show.GetPanel();
                                Controls.Add(panel);
                                flowLayoutPanel1.AutoScroll = true;
                                flowLayoutPanel1.Controls.Add(picture);
                                
                            }
                            else
                            {
                                MessageBox.Show("Article n'existe pas");
                                isClicked = false;
                            }
                        }                       
                        else if (vêtementes.Nom != Nom && vêtementes.Type==typecompoBox1.Text)
                        {
                            MessageBox.Show("Le nom ne corespend pas à aucune article");
                            isClicked = false;
                        }
                        else if (vêtementes.Type != typecompoBox1.Text && vêtementes.Nom==Nom)
                        {
                            MessageBox.Show("le type ne corpsend pas à l'nom d'article");
                            isClicked = false;
                         
                        }
                        break;
                    }
                       
                       
                }
               
            }
        }

        private void Vendre_Click(object sender, EventArgs e)
        {


            foreach (var innerlist in Lists._Listvêtmenets)
            {

                foreach (var item in innerlist)
                {

                    if (item is VêtEments vêtementes)
                    {
                        if (isClicked)
                        {
                            if (vêtementes.Type==typecompoBox1.Text && vêtementes.Nom==textBox1.Text)
                            {
                                Lists.VerfieDeActvicité.Add($"Un article a été vendu {vêtementes.Type} {vêtementes.Nom}");
                                Lists.Vendre(vêtementes);
                                flowLayoutPanel1.Controls.Clear();
                                panel.Visible = false;
                                MessageBox.Show("Vendu");

                            }
                        }
                        else
                        {
                            MessageBox.Show("Veuillez d'abord rechercher l'article");
                        }

                    }

                    break;
                }

            }       
            isClicked = false;
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = "";
        }


    }
}


