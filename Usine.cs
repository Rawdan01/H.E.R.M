using System;

namespace H.E.R.M
{
    public class Using
    {
        private int IdUsine_;
        private string Adresse_;
        private string Atelier_;

        public int IdUsine
        {
            get { return IdUsine_; }
            set { IdUsine_ = value; }
        }

        public string Adresse
        {
            get { return Adresse_; }
            set { Adresse_ = value; }
        }

        public string Atelier
        {
            get { return Atelier_; }
            set { Atelier_ = value; }
        }

        public Using(int id,string adresse, string atelier)
        {
            IdUsine = id;
            Adresse = adresse;
            Atelier = atelier;
        }
    }
}