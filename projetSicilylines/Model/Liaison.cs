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
        private int id_liai;
        private string duree;
        private string secteur;
        private string port_depart;
        private string port_arrivee;
        


        public Liaison(int id_li,string uneduree, string unsecteur, string port_dep, string port_ar)
        {
            this.id_liai = id_li;
            this.duree = uneduree;
            this.secteur = unsecteur;
            this.port_depart = port_dep;
            this.port_arrivee = port_ar;
  
        }
        public Liaison()
        {

        }

        public int id_li
        {
            get { return this.id_liai; }

        }

        public string la_duree
        {
            get { return this.duree; }
        }

        public string le_secteur
        {
            get { return this.secteur; }
        }

        public string port_de_depart
        {
            get { return this.port_depart; }
        }

        public string port_d_arrivee
        {
            get { return this.port_arrivee; }
        }

        /*public override string ToString()

        {

            return (this.id_liai + "   " +this.duree +" "  +this.secteur+ " " + this.port_depart + " " + this.port_arrivee);
        }
        */


    }
}
