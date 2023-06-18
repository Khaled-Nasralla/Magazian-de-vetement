using DocumentFormat.OpenXml.Bibliography;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Magazian_de_vêtement
{
    public  class VêtEments 
    {
        public string Couleur { get; set; }
        public string Size { get; set; }
        public string Type { get; set; }
        public string PhotoPath { get; set; }
        public string Sexe { get; set; }
        public string Prix { get; set; }
        public string Nom { get; set; }
        public decimal Quantité { get; set; }
    
        public VêtEments(string color, string size, string type, string photo, string sexe, string prix, string nom,decimal quantite)
        {
            this.Couleur=color;
            this.Size=size;
            this.Type=type;
            this.PhotoPath=photo;
            this.Sexe=sexe;
            this.Prix = prix;
            this.Nom=nom;
            this.Quantité = quantite;
           
        }
        public virtual string Checkactivity(string procédure, string nom)

        {
            return $"{procédure} un Article Non definer";

        }

       
    }
    public class Tshirt : VêtEments
    {
        public string Modele { get; set; }

        public Tshirt(string color, string size, string type, string photo, string sexe, string prix, string nom,decimal _quantite,string col) : base(color, size, type, photo, sexe, prix, nom,_quantite)
        {
            this.Modele = col;
        }
      
        public override string Checkactivity(string procédure, string nom)
        {
            return $"{procédure} un Article T-shirt {nom} ";

        }
     


    }

    public class Chaussures : VêtEments
    {
        public string pointur { get; set; }
        public string Style { get; set; }
        public Chaussures(string color, string size, string type, string photo, string sexe, string prix, string nom,decimal _quantite, string pointur, string style) : base(color, size, type, photo, sexe, prix, nom,_quantite)
        {
            this.pointur = pointur;
            this.Style = style;

        }
        public override string Checkactivity(string procédure, string nom)
        {
            return $"{procédure} un Article Chaussure {nom}";

        }
     




    }
    public class Pantalons : Tshirt
    {
        public string Longeur { get; set; }
        public string taille { get; set; }

        public Pantalons(string color, string size, string type, string photo, string sexe, string prix, string nom,decimal _quantite, string modele, string longur, string taille) : base(color, size, type, photo, sexe, prix, nom,_quantite, modele)
        {
            this.Longeur = longur;
            this.taille = taille;

        }
        public override string Checkactivity(string procédure, string nom)
        {
            return $"{procédure} un Article Pantalons {nom} ";

        }
   
       
    }

    public class Pull : Tshirt
    {
       public string Capuche;
        public Pull(string color, string size, string type, string photo, string sexe, string prix, string nom, decimal _quantite, string modele, string _capuche) : base(color, size, type, photo, sexe, prix, nom, _quantite, modele)
        {
           this.Capuche=_capuche;
        }
        public override string Checkactivity(string procédure, string nom)
        {
            return $"{procédure} un Article Pull {nom} ";

        }
    
      

    }
}
   