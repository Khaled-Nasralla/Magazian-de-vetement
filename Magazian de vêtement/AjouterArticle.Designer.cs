
using System.Windows.Forms;
namespace Magazian_de_vêtement
{
    partial class AjouterArticle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnImporter=new Button();
            pictureBox1=new PictureBox();
            comboBox1=new ComboBox();
            Sortelabel=new Label();
            coleurBox=new ComboBox();
            ColeurLabel=new Label();
            LargecheckBox=new CheckBox();
            MediumcheckBox=new CheckBox();
            SmallcheckBox=new CheckBox();
            Sizelabel=new Label();
            btnsave=new Button();
            textBox=new Label();
            btnAnnuller=new Button();
            Pointeur=new Label();
            sexeBox=new ComboBox();
            sexelabel=new Label();
            pointurBox=new ComboBox();
            Prix=new Label();
            Euro_Label=new Label();
            prixtextBox=new TextBox();
            modeleBox=new ComboBox();
            Modele=new Label();
            longeurBox=new ComboBox();
            Longeur_label=new Label();
            NomL=new Label();
            Nom=new TextBox();
            tailleBox=new ComboBox();
            tailleLabel=new Label();
            ouicheckBox=new CheckBox();
            nonCheckBox=new CheckBox();
            capuche=new Label();
            numericUpDown1=new NumericUpDown();
            quantity=new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // btnImporter
            // 
            btnImporter.Location=new Point(323, 28);
            btnImporter.Name="btnImporter";
            btnImporter.Size=new Size(117, 36);
            btnImporter.TabIndex=0;
            btnImporter.Text="Importer";
            btnImporter.UseVisualStyleBackColor=true;
            btnImporter.Click+=button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor=SystemColors.ControlLightLight;
            pictureBox1.BorderStyle=BorderStyle.Fixed3D;
            pictureBox1.Location=new Point(8, 57);
            pictureBox1.Name="pictureBox1";
            pictureBox1.Size=new Size(237, 321);
            pictureBox1.SizeMode=PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex=1;
            pictureBox1.TabStop=false;
            // 
            // comboBox1
            // 
            comboBox1.DisplayMember="6";
            comboBox1.FormattingEnabled=true;
            comboBox1.Items.AddRange(new object[] { "T-shirt", "Pull", "Pantalon", "Chaussures" });
            comboBox1.Location=new Point(319, 130);
            comboBox1.Name="comboBox1";
            comboBox1.Size=new Size(121, 23);
            comboBox1.TabIndex=2;
            comboBox1.SelectedIndexChanged+=comboBox1_SelectedIndexChanged;
            // 
            // Sortelabel
            // 
            Sortelabel.AutoSize=true;
            Sortelabel.Location=new Point(268, 133);
            Sortelabel.Name="Sortelabel";
            Sortelabel.Size=new Size(34, 15);
            Sortelabel.TabIndex=3;
            Sortelabel.Text="Sorte";
            // 
            // coleurBox
            // 
            coleurBox.FormattingEnabled=true;
            coleurBox.Items.AddRange(new object[] { "Bleu", "Rouge", "Vert", "Jaune", "Noir", "Blanc", "Orange", "Violet", "Rose", "Marron", "Gris", "Beige", "Bordeaux", "Turquoise", "Kaki", "Fuchsia", "Indigo", "Mauve", "Olive", "Saumon", "Sable", "Saphir", "Sienne", "Taupe", "Terre", "Tomate", "Topaze", "Vanille", "Vermillon", "Violet clair", "Violet foncé", "Zinzolin" });
            coleurBox.Location=new Point(319, 168);
            coleurBox.Name="coleurBox";
            coleurBox.Size=new Size(121, 23);
            coleurBox.TabIndex=4;
            // 
            // ColeurLabel
            // 
            ColeurLabel.AutoSize=true;
            ColeurLabel.Location=new Point(260, 171);
            ColeurLabel.Name="ColeurLabel";
            ColeurLabel.Size=new Size(42, 15);
            ColeurLabel.TabIndex=5;
            ColeurLabel.Text="Coleur";
            // 
            // LargecheckBox
            // 
            LargecheckBox.AutoSize=true;
            LargecheckBox.Location=new Point(319, 198);
            LargecheckBox.Name="LargecheckBox";
            LargecheckBox.Size=new Size(32, 19);
            LargecheckBox.TabIndex=6;
            LargecheckBox.Text="L";
            LargecheckBox.UseVisualStyleBackColor=true;
            LargecheckBox.CheckedChanged+=checkBox1_CheckedChanged;
            // 
            // MediumcheckBox
            // 
            MediumcheckBox.AutoSize=true;
            MediumcheckBox.Location=new Point(361, 198);
            MediumcheckBox.Name="MediumcheckBox";
            MediumcheckBox.Size=new Size(37, 19);
            MediumcheckBox.TabIndex=7;
            MediumcheckBox.Text="M";
            MediumcheckBox.UseVisualStyleBackColor=true;
            MediumcheckBox.CheckedChanged+=checkBox2_CheckedChanged;
            // 
            // SmallcheckBox
            // 
            SmallcheckBox.AutoSize=true;
            SmallcheckBox.Location=new Point(408, 198);
            SmallcheckBox.Name="SmallcheckBox";
            SmallcheckBox.Size=new Size(32, 19);
            SmallcheckBox.TabIndex=8;
            SmallcheckBox.Text="S";
            SmallcheckBox.UseVisualStyleBackColor=true;
            SmallcheckBox.CheckedChanged+=checkBox3_CheckedChanged;
            // 
            // Sizelabel
            // 
            Sizelabel.AutoSize=true;
            Sizelabel.Location=new Point(275, 199);
            Sizelabel.Name="Sizelabel";
            Sizelabel.Size=new Size(27, 15);
            Sizelabel.TabIndex=9;
            Sizelabel.Text="Size";
            // 
            // btnsave
            // 
            btnsave.Location=new Point(275, 476);
            btnsave.Name="btnsave";
            btnsave.Size=new Size(90, 33);
            btnsave.TabIndex=10;
            btnsave.Text="Enrgérestré";
            btnsave.UseVisualStyleBackColor=true;
            btnsave.Click+=Engéristere_Click;
            // 
            // textBox
            // 
            textBox.AutoSize=true;
            textBox.Location=new Point(29, 476);
            textBox.Name="textBox";
            textBox.Size=new Size(19, 15);
            textBox.TabIndex=11;
           
            // 
            // btnAnnuller
            // 
            btnAnnuller.Location=new Point(386, 486);
            btnAnnuller.Name="btnAnnuller";
            btnAnnuller.Size=new Size(75, 23);
            btnAnnuller.TabIndex=12;
            btnAnnuller.Text="Annuler";
            btnAnnuller.UseVisualStyleBackColor=true;
            btnAnnuller.Click+=Annuler_Click;
            // 
            // Pointeur
            // 
            Pointeur.AutoSize=true;
            Pointeur.Location=new Point(249, 264);
            Pointeur.Name="Pointeur";
            Pointeur.Size=new Size(52, 15);
            Pointeur.TabIndex=14;
            Pointeur.Text="Pointure";
            // 
            // sexeBox
            // 
            sexeBox.FormattingEnabled=true;
            sexeBox.Items.AddRange(new object[] { "Homme", "Femme" });
            sexeBox.Location=new Point(319, 223);
            sexeBox.Name="sexeBox";
            sexeBox.Size=new Size(121, 23);
            sexeBox.TabIndex=15;
            // 
            // sexelabel
            // 
            sexelabel.AutoSize=true;
            sexelabel.Location=new Point(271, 226);
            sexelabel.Name="sexelabel";
            sexelabel.Size=new Size(31, 15);
            sexelabel.TabIndex=16;
            sexelabel.Text="Sexe";
            // 
            // pointurBox
            // 
            pointurBox.FormattingEnabled=true;
            pointurBox.Items.AddRange(new object[] { "36", "37", "38", "39", "40", "41", "42", "43", "44", "45" });
            pointurBox.Location=new Point(319, 261);
            pointurBox.Name="pointurBox";
            pointurBox.Size=new Size(121, 23);
            pointurBox.TabIndex=17;
            // 
            // Prix
            // 
            Prix.AutoSize=true;
            Prix.Location=new Point(361, 437);
            Prix.Name="Prix";
            Prix.Size=new Size(27, 15);
            Prix.TabIndex=19;
            Prix.Text="Prix";
            // 
            // Euro_Label
            // 
            Euro_Label.AutoSize=true;
            Euro_Label.Location=new Point(427, 442);
            Euro_Label.Name="Euro_Label";
            Euro_Label.Size=new Size(13, 15);
            Euro_Label.TabIndex=20;
            Euro_Label.Text="€";
            // 
            // prixtextBox
            // 
            prixtextBox.Location=new Point(386, 434);
            prixtextBox.Name="prixtextBox";
            prixtextBox.Size=new Size(41, 23);
            prixtextBox.TabIndex=21;
            // 
            // modeleBox
            // 
            modeleBox.Enabled=false;
            modeleBox.FormattingEnabled=true;
            modeleBox.Location=new Point(319, 297);
            modeleBox.Name="modeleBox";
            modeleBox.Size=new Size(121, 23);
            modeleBox.TabIndex=22;
            // 
            // Modele
            // 
            Modele.AutoSize=true;
            Modele.Location=new Point(264, 305);
            Modele.Name="Modele";
            Modele.Size=new Size(41, 15);
            Modele.TabIndex=23;
            Modele.Text="Model";
            // 
            // longeurBox
            // 
            longeurBox.Enabled=false;
            longeurBox.FormattingEnabled=true;
            longeurBox.Location=new Point(319, 331);
            longeurBox.Name="longeurBox";
            longeurBox.Size=new Size(121, 23);
            longeurBox.TabIndex=22;
            // 
            // Longeur_label
            // 
            Longeur_label.AutoSize=true;
            Longeur_label.Location=new Point(251, 334);
            Longeur_label.Name="Longeur_label";
            Longeur_label.Size=new Size(51, 15);
            Longeur_label.TabIndex=24;
            Longeur_label.Text="Longeur";
            // 
            // NomL
            // 
            NomL.AutoSize=true;
            NomL.Location=new Point(267, 97);
            NomL.Name="NomL";
            NomL.Size=new Size(34, 15);
            NomL.TabIndex=25;
            NomL.Text="Nom";
            // 
            // Nom
            // 
            Nom.Location=new Point(319, 94);
            Nom.Name="Nom";
            Nom.Size=new Size(121, 23);
            Nom.TabIndex=26;
            // 
            // tailleBox
            // 
            tailleBox.Enabled=false;
            tailleBox.FormattingEnabled=true;
            tailleBox.Location=new Point(319, 360);
            tailleBox.Name="tailleBox";
            tailleBox.Size=new Size(121, 23);
            tailleBox.TabIndex=27;
            // 
            // tailleLabel
            // 
            tailleLabel.AutoSize=true;
            tailleLabel.Location=new Point(269, 363);
            tailleLabel.Name="tailleLabel";
            tailleLabel.Size=new Size(33, 15);
            tailleLabel.TabIndex=28;
            tailleLabel.Text="Taille";
            // 
            // ouicheckBox
            // 
            ouicheckBox.AutoSize=true;
            ouicheckBox.Location=new Point(324, 396);
            ouicheckBox.Name="ouicheckBox";
            ouicheckBox.Size=new Size(45, 19);
            ouicheckBox.TabIndex=29;
            ouicheckBox.Text="Oui";
            ouicheckBox.UseVisualStyleBackColor=true;
            ouicheckBox.Visible=false;
            ouicheckBox.CheckedChanged+=checkBox4_CheckedChanged;
            // 
            // nonCheckBox
            // 
            nonCheckBox.AutoSize=true;
            nonCheckBox.Location=new Point(386, 396);
            nonCheckBox.Name="nonCheckBox";
            nonCheckBox.Size=new Size(42, 19);
            nonCheckBox.TabIndex=30;
            nonCheckBox.Text="No";
            nonCheckBox.UseVisualStyleBackColor=true;
            nonCheckBox.Visible=false;
            nonCheckBox.CheckedChanged+=checkBox5_CheckedChanged;
            // 
            // capuche
            // 
            capuche.AutoSize=true;
            capuche.Location=new Point(221, 397);
            capuche.Name="capuche";
            capuche.Size=new Size(80, 15);
            capuche.TabIndex=31;
            capuche.Text="AvecCapuche";
            capuche.Visible=false;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location=new Point(304, 434);
            numericUpDown1.Name="numericUpDown1";
            numericUpDown1.Size=new Size(47, 23);
            numericUpDown1.TabIndex=32;
            // 
            // quantity
            // 
            quantity.AutoSize=true;
            quantity.Location=new Point(244, 437);
            quantity.Name="quantity";
            quantity.Size=new Size(53, 15);
            quantity.TabIndex=33;
            quantity.Text="Quantité";
            // 
            // AjouterArticle
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(473, 521);
            Controls.Add(quantity);
            Controls.Add(numericUpDown1);
            Controls.Add(capuche);
            Controls.Add(nonCheckBox);
            Controls.Add(ouicheckBox);
            Controls.Add(tailleLabel);
            Controls.Add(tailleBox);
            Controls.Add(Nom);
            Controls.Add(NomL);
            Controls.Add(Longeur_label);
            Controls.Add(Modele);
            Controls.Add(modeleBox);
            Controls.Add(prixtextBox);
            Controls.Add(Euro_Label);
            Controls.Add(Prix);
            Controls.Add(pointurBox);
            Controls.Add(sexelabel);
            Controls.Add(sexeBox);
            Controls.Add(Pointeur);
            Controls.Add(btnAnnuller);
            Controls.Add(textBox);
            Controls.Add(btnsave);
            Controls.Add(Sizelabel);
            Controls.Add(SmallcheckBox);
            Controls.Add(MediumcheckBox);
            Controls.Add(LargecheckBox);
            Controls.Add(ColeurLabel);
            Controls.Add(coleurBox);
            Controls.Add(Sortelabel);
            Controls.Add(comboBox1);
            Controls.Add(pictureBox1);
            Controls.Add(btnImporter);
            Controls.Add(longeurBox);
            FormBorderStyle=FormBorderStyle.FixedToolWindow;
            Name="AjouterArticle";
            StartPosition=FormStartPosition.CenterScreen;
            Text="Ajouter";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }





        #endregion

        private Button btnImporter;
        private PictureBox pictureBox1;
        private ComboBox comboBox1;
        private Label Sortelabel;
        private ComboBox coleurBox;
        private Label ColeurLabel;
        private CheckBox LargecheckBox;
        private CheckBox MediumcheckBox;
        private CheckBox SmallcheckBox;
        private Label Sizelabel;
        private Button btnsave;
        private Label textBox;
        private Button btnAnnuller;
        private Label Pointeur;
        private ComboBox sexeBox;
        private Label sexelabel;
        private ComboBox pointurBox;
        private Label Prix;
        private Label Euro_Label;
        private TextBox prixtextBox;
        private ComboBox modeleBox;
        private Label Modele;
        private ComboBox longeurBox;
        private Label Longeur_label;
        private Label NomL;
        private TextBox Nom;
        private ComboBox tailleBox;
        private Label tailleLabel;
        private CheckBox ouicheckBox;
        private CheckBox nonCheckBox;
        private Label capuche;
        private NumericUpDown numericUpDown1;
        private Label quantity;
    }
}