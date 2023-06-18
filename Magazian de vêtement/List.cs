namespace Magazian_de_vêtement
{

    public class ListVêtements

    {

        public List<object> Supprimer = new List<object> { };
        public List<object> Vendu = new List<object> { };
        public List<string> VerfieDeActvicité = new List<string> { };
        public List<List<object>> _Listvêtmenets;
        public ListVêtements()
        {
            _Listvêtmenets = new List<List<object>> { };

            _Listvêtmenets.Add(new List<object>());
            _Listvêtmenets.Add(new List<object>());
            _Listvêtmenets.Add(new List<object>());
            _Listvêtmenets.Add(new List<object>());


        }

        private leMenuActual _leMenuActual;
        public void ListSupprimer(Object objec)
        {

            if (objec is Chaussures chaussure)
            {
                chaussure.Quantité--;
                this.Supprimer.Add(chaussure);
                _Listvêtmenets[1].Remove(chaussure);
                VerfieDeActvicité.Add(chaussure.Checkactivity("Supprimer", chaussure.Nom));
            }
            else if (objec is Pantalons pantalon)
            {
                pantalon.Quantité--;
                this.Supprimer.Add(pantalon);
                _Listvêtmenets[2].Remove(pantalon);
                VerfieDeActvicité.Add(pantalon.Checkactivity("Supprimer", pantalon.Nom));
            }

            else if (objec is Pull pull)
            {
                pull.Quantité--;
                this.Supprimer.Add(pull);
                _Listvêtmenets[3].Remove(pull);
                VerfieDeActvicité.Add(pull.Checkactivity("Supprimer", pull.Nom));
            }

            else if (objec is Tshirt tshirts)
            {
                tshirts.Quantité--;
                this.Supprimer.Add(tshirts);
                _Listvêtmenets[0].Remove(tshirts);
                VerfieDeActvicité.Add(tshirts.Checkactivity("Supprimer", tshirts.Nom));
            }
        }
        public void Vendre(Object vendu)
        {
        

            if (vendu is VêtEments vêtEments)
            {
               this.Vendu.Add(vêtEments);        
            }

            AjouterToMagazan(vendu, "", leMenuActual.Add_to_vendu);

        }
        private void AjouterToList(Object objec, string procédure)
        {
         
            if (objec is Chaussures chaussure)
            {   
                _Listvêtmenets[1].Add(chaussure); 
                VerfieDeActvicité.Add(chaussure.Checkactivity(procédure, chaussure.Nom));

            }
            else if (objec is Pantalons pantalon)
            {   
              
                _Listvêtmenets[2].Add(pantalon);
                VerfieDeActvicité.Add(pantalon.Checkactivity(procédure, pantalon.Nom));

            }

            else if (objec is Pull pull)
            {                _Listvêtmenets[3].Add(pull);
                VerfieDeActvicité.Add(pull.Checkactivity(procédure, pull.Nom));

            }

            else if (objec is Tshirt tshirts)
            {   
                _Listvêtmenets[0].Add(tshirts);     
                VerfieDeActvicité.Add(tshirts.Checkactivity(procédure, tshirts.Nom));

            }

        }
        public void AjouterToMagazan(Object _vetments, string procédure, leMenuActual _lemenuactual)
        {

            if (_lemenuactual == leMenuActual.Add_to_vendu)
            {
                if (_vetments is Chaussures chaussures)
                {
                    chaussures.Quantité--;
                    if (chaussures.Quantité == 0)
                    {
                        _Listvêtmenets[1].Remove(chaussures);
                        MessageBox.Show("La quantité de Chaussures <<"+ chaussures.Nom + ">> est fini ");

                    }
                }
                else if (_vetments is Pantalons pantalons)
                {
                    pantalons.Quantité--;
                    if (pantalons.Quantité == 0)
                    {
                        _Listvêtmenets[2].Remove(pantalons);
                        MessageBox.Show("La quantité de Pantalons <<" + pantalons.Nom + ">> est fini ");
                    }
                }
                else if (_vetments is Tshirt tshirt)
                {
                    tshirt.Quantité--;
                    if (tshirt.Quantité == 0)
                    {
                        _Listvêtmenets[0].Remove(tshirt);
                        MessageBox.Show("La quantité de T-Shirt <<" + tshirt.Nom + ">>est fini ");
                    }
                }
                else if (_vetments is Pull pull)
                {
                    pull.Quantité--;
                    if (pull.Quantité == 0)
                    {
                        _Listvêtmenets[3].Remove(pull);
                        MessageBox.Show("La quantité de Pull <<" + pull.Nom + ">>est fini ");
                    }
                }
            }
            else if (_lemenuactual == leMenuActual.list_rendre)
            {
                bool EstExist = isExist(_vetments);
                if (EstExist)
                {
                    if (_vetments is VêtEments _vêtEments)
                    {
                        _vêtEments.Quantité++;
                        if (_leMenuActual==leMenuActual.Vendu)
                        {
                            this.Vendu.Remove(_vêtEments);

                        }
                        else if (_leMenuActual==leMenuActual.Supprimer)
                        {
                            this.Supprimer.Remove(_vêtEments);
                        }
                        VerfieDeActvicité.Add(_vêtEments.Checkactivity(procédure, _vêtEments.Nom));
                    }
                    else { MessageBox.Show("Erreur"); }

                }
                else if (!EstExist)

                    if (_vetments is VêtEments vêtEments)
                    {
                        vêtEments.Quantité++;
                        if (_leMenuActual==leMenuActual.Supprimer)
                        {
                            this.Supprimer.Remove(vêtEments);
                        }
                        else if (_leMenuActual == leMenuActual.Vendu)
                        {
                            this.Vendu.Remove(vêtEments);
                        }
                        AjouterToList(_vetments, procédure);

                    }


            }
            else if (_lemenuactual == leMenuActual.Ajouter_au_magazin)
            {
                AjouterToList(_vetments, procédure);
            }

        }
        public bool isExist(object _vetments)
        {
      
            if (_vetments is Chaussures chaussures)
            {
                foreach (Chaussures item in _Listvêtmenets[1])
                {
                    if (item.Nom == chaussures.Nom &&
                        item.Couleur==chaussures.Couleur&&
                        item.pointur==chaussures.pointur&&
                        item.Prix==chaussures.Prix)
                    {
                        return true;
                    }
                }
            }
            else if (_vetments is Pantalons pantalons)
            {
                foreach (Pantalons item in _Listvêtmenets[2])
                {
                    if (item.Nom == pantalons.Nom &&
                        item.Couleur==pantalons.Couleur &&
                        item.Longeur==pantalons.Longeur &&
                        item.taille==pantalons.taille&&
                        item.Prix==pantalons.Prix)
                    {
                        return true;
                    }
                }
            }
            else if (_vetments is Pull pull)
            {
                foreach (Pull item in _Listvêtmenets[3])
                {
                    if (item.Nom == pull.Nom && 
                        item.Capuche==pull.Capuche&&
                        item.Couleur==pull.Couleur&&
                        item.Prix==pull.Prix)
                    {
                        return true;
                    }
                }
            }
            else if (_vetments is Tshirt tshirt)
            {
                foreach (Tshirt item in _Listvêtmenets[0])
                {
                    if (item.Nom == tshirt.Nom && 
                        item.Couleur==tshirt.Couleur&&
                        item.Modele==tshirt.Modele&& 
                        item.Size==tshirt.Size&&
                        item.Prix==tshirt.Prix)
                    {
                        return true;
                    }
                }
            }                       
            return false;         
        }   
       public void GetLeMenuActual(leMenuActual leMenuActual)
        {
            _leMenuActual = leMenuActual;
        }
    }


}














