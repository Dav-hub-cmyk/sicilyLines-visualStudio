using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sicilylines
{
    [Serializable]
    class Liaison
    {
        private int id_liaison;
        private string duree;
        private int id_secteur;
        private string port_depart;
        private string port_arrivee;
        


        public Liaison(int id_li,string uneduree, int un_id_secteur,string port_dep,string port_ar)
        {
            this.id_liaison = id_li;
            this.duree = uneduree;
            this.id_secteur = un_id_secteur;
            this.port_depart = port_dep;
            this.port_arrivee = port_ar;
  
        }
        public Liaison()
        {

        }

        public int id_li
        {
            get { return id_li; }

        }

        public string uneduree
        {
            get { return uneduree; }
        }

        public int un_id_secteur
        {
            get { return un_id_secteur; }
        }

        public int port_dep
        {
            get { return port_dep; }
        }

        public int port_ar
        {
            get { return port_ar; }
        }


        public override string ToString()

        {

            return (this.id_li + "   " +this.id_secteur +" " + this.duree + " " + this.port_depart + " " + this.port_arrivee);
        }



    }
}
