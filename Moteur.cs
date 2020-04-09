using System;

namespace H.E.R.M
{
    public class Moteur
    {
        private int IdMoteur_;

        public int IdMoteur
        {
            get { return IdMoteur_; }
            set { IdMoteur_ = value; }
        }

        public Moteur(int id)
        {
            IdMoteur_ = id;
        }
    }
}