using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Assemblies;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magazian_de_vêtement
{
    public partial class AjouterArticle : Form
    {
        private VêtEments _Vêtements;
        private Tshirt _tshirt;
        private Chaussures _chaussures;
        private Pantalons _pantalons;
        private Pull _pull;




        public AjouterArticle()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.png;*.bmp;*.gif";
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string refimage = openFileDialog.FileName;
                this.pictureBox1.ImageLocation= refimage;
            }
        }
        private void Engéristere_Click(object sender, EventArgs e)
        {
            if (this.pictureBox1.Image == null)
            {
                this.textBox.Text="SVP ajouter une photo";
                return;
            }
            if (string.IsNullOrEmpty(comboBox1.Text))
            {
                this.Sortelabel.ForeColor= System.Drawing.Color.Red;
                this.textBox.Text="SVP ajouter une Sorte";
                return;
            }
            if (string.IsNullOrEmpty(coleurBox.Text))
            {
                this.ColeurLabel.ForeColor= System.Drawing.Color.Red;
                this.textBox.Text="SVP ajouter un color";

                return;
            }
            if (string.IsNullOrEmpty(Size2()))
            {
                this.Sizelabel.ForeColor= System.Drawing.Color.Red;
                this.textBox.Text="SVP ajouter un size";
                return;
            }
            if (string.IsNullOrEmpty(sexeBox.Text))
            {
                this.sexelabel.ForeColor= System.Drawing.Color.Red;
                this.textBox.Text="SVP intaliser le SEX";
                return;
            }
            if (string.IsNullOrEmpty(pointurBox.Text)&& comboBox1.Text=="Chaussures")
            {
                this.Euro_Label.ForeColor= System.Drawing.Color.Red;
                this.textBox.Text="SVP ajouter un pointur";
                return;
            }
            if (string.IsNullOrEmpty(modeleBox.Text))
            {
                this.Modele.ForeColor= System.Drawing.Color.Red;
                this.textBox.Text="SVP ajouter un Modele";
                return;
            }
            if (string.IsNullOrEmpty(prixtextBox.Text))
            {
                this.Prix.ForeColor= System.Drawing.Color.Red;
                this.textBox.Text="SVP ajouter un Prix";
                return;
            }
            if (!IsNumber(prixtextBox.Text))
            {
                this.Prix.ForeColor= System.Drawing.Color.Red;
                this.textBox.Text="Ce n'est pas un Numbre";
                return;
            }
            if (string.IsNullOrEmpty(longeurBox.Text)&& comboBox1.Text =="Pantalon")
            {
                this.Longeur_label.ForeColor= System.Drawing.Color.Red;
                this.textBox.Text="SVP ajouter un longeur";
                return;
            }
            if (string.IsNullOrEmpty(Nom.Text))
            {
                this.NomL.ForeColor= System.Drawing.Color.Red;
                this.textBox.Text="SVP ajouter un NOM";
                return;
            }
            if (string.IsNullOrEmpty(tailleBox.Text)&&comboBox1.Text=="Pantalon")
            {
                this.tailleLabel.ForeColor= System.Drawing.Color.Red;
                this.textBox.Text="SVP ajouter un Taille";
                return;
            }
            if (string.IsNullOrEmpty(Checkedpull())&&comboBox1.Text=="Pull")
            {
                this.capuche.ForeColor= System.Drawing.Color.Red;
                this.textBox.Text="SVP remplier si la pull Avec capuche ou Sans";
                return;
            }
            if (numericUpDown1.Value==0)
            {
                this.quantity.ForeColor= System.Drawing.Color.Red;
                this.textBox.Text="SVP ajouter le quantité";
                return;
            }

            Classer(comboBox1.Text, Size2(), coleurBox.Text, this.pictureBox1.ImageLocation, pointurBox.Text, sexeBox.Text, prixtextBox.Text, modeleBox.Text, longeurBox.Text, Nom.Text, tailleBox.Text, Checkedpull(), numericUpDown1.Value);

            DialogResult=DialogResult.OK;

            Close();
        }
        private bool IsNumber(string text)
        {
            bool isNumber = false;
            isNumber=int.TryParse(text, out int N);
            return isNumber;
        }
        public Tshirt GetTshirt()
        {
            return this._tshirt;
        }
        public Chaussures GetChaussures()
        {
            return this._chaussures;
        }
        public Pantalons GetPantalon()
        {
            return this._pantalons;
        }
        public Pull GetPull()
        {
            return this._pull;
        }

        public VêtEments GetVêtements()
        {
            return this._Vêtements;
        }
        private void Classer(string type, string size, string color, string photo, string pointur, string sexe, string prix, string modele, string longeur, string nom, string taille, string Avecbonner, decimal quantité)
        {
            _Vêtements=new VêtEments(color, size, type, photo, sexe, prix, nom, quantité);
            if (type=="Pull")
            {
                _pull=new Pull(color, size, type, photo, sexe, prix, nom, quantité, modele, Avecbonner);
            }
            else if (type=="Pantalon")
            {
                _pantalons=new Pantalons(color, size, type, photo, sexe, prix, nom, quantité, modele, longeur, taille);
            }
            else if (type=="T-shirt")
            {
                _tshirt=new Tshirt(color, size, type, photo, sexe, prix, nom, quantité, modele);
            }
            else if (type=="Chaussures")
            {
                _chaussures=new Chaussures(color, size, type, photo, sexe, prix, nom, quantité, pointur, modele);
            }

        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // Uncheck the other two checkboxes if this checkbox is checked
            if (LargecheckBox.Checked)
            {
                MediumcheckBox.Checked = false;
                SmallcheckBox.Checked = false;
            }
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            // Uncheck the other two checkboxes if this checkbox is checked
            if (MediumcheckBox.Checked)
            {
                LargecheckBox.Checked = false;
                SmallcheckBox.Checked = false;
            }
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            // Uncheck the other two checkboxes if this checkbox is checked
            if (SmallcheckBox.Checked)
            {
                LargecheckBox.Checked = false;
                MediumcheckBox.Checked = false;
            }
        }
        private string Size2()
        {
            string Size;

            if (LargecheckBox.Checked==true)
            {
                Size="Large";
            }
            else if (MediumcheckBox.Checked==true)
            {
                Size="Medium";
            }
            else if (SmallcheckBox.Checked==true)
            {
                Size = "Small";

            }
            else if (LargecheckBox.Enabled==false &&
                MediumcheckBox.Enabled==false && SmallcheckBox.Enabled==false &&
                pointurBox!=null&&comboBox1.Text=="Pantalon"||comboBox1.Text=="Chaussures")
            {
                Size = "Rien";
            }
            else
            {
                Size = "";
            }
            return Size;

        }
        private void Annuler_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            tailleBox.Enabled=false;
            longeurBox.Enabled=false;
            ouicheckBox.Visible=false;
            nonCheckBox.Visible=false;
            capuche.Visible=false;
            LargecheckBox.Enabled=false;
            MediumcheckBox.Enabled=false;
            SmallcheckBox.Enabled=false;
            pointurBox.Enabled=false;

            modeleBox.Items.Clear();
            longeurBox.Items.Clear();
            tailleBox.Items.Clear();


            try
            {
                switch (comboBox1.Text)
                {
                    case "Chaussures":
                        pointurBox.Enabled=true;
                        pointurBox.Items.AddRange(new object[] { "36", "37", "38", "39", "40", "41", "42", "43", "44", "45" });
                        modeleBox.Items.AddRange(new object[] { "Ballerines", "Baskets", "Bottes", "Bottines", "Chaussons", "Chaussures de sport", "Chaussures de ville", "Compensées", "Escarpins", "Mocassins", "Mules", "Sandales", "Tongs" });
                        break;
                    case "Pantalon":
                        tailleBox.Enabled=true;
                        longeurBox.Enabled=true;

                        tailleBox.Items.AddRange(new object[] { "28", "30", "32", "34", "36", "38", "40", "42", "44", "46", "48", "50", "52", "54" });
                        longeurBox.Items.AddRange(new object[] { "Court", "Moyen", "Longe" });
                        modeleBox.Items.AddRange(new object[] { "Slim", "Droit", "Large", "Taille haute", "Taille basse", "Taille mi-haute", "Taille mi-basse", "Taille élastique", "Taille froncée", "Taille froncée élastique", "Taille" });

                        break;
                    case "T-shirt":
                        LargecheckBox.Enabled=true;
                        MediumcheckBox.Enabled=true;
                        SmallcheckBox.Enabled=true;
                        modeleBox.Enabled=true;
                        modeleBox.Items.AddRange(new object[] { "rond", "V", "roulé", "cheminée", "Mao", "Claudine", "officier", "châle", "tailleur", "lavallière", "jabot" });
                        break;
                    case "Pull":
                        capuche.Visible=true;
                        ouicheckBox.Visible=true;
                        nonCheckBox.Visible=true;
                        LargecheckBox.Enabled=true;
                        MediumcheckBox.Enabled=true;
                        SmallcheckBox.Enabled=true;
                        modeleBox.Enabled=true;
                        modeleBox.Items.AddRange(new object[] { "rond", "V", "roulé", "cheminée", "Mao", "Claudine", "officier", "châle", "tailleur", "lavallière", "jabot" });
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }




        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (nonCheckBox.Checked)
            {
                ouicheckBox.Checked=false;
            }

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (ouicheckBox.Checked)
            {
                nonCheckBox.Checked=false;
            }

        }
        public string Checkedpull()
        {
            if (ouicheckBox.Checked)
            {
                return "Oui";
            }
            else if (nonCheckBox.Checked)
            {
                return "Non";
            }
            else
            {
                return "";
            }

        }

    }
}
