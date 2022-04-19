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
        private int id_secteur;
        private int port_depart;
        private int port_arrivee;
        


        public Liaison(int id_li,string uneduree, int un_id_secteur, int port_dep, int port_ar)
        {
            this.id_liai = id_li;
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
            get { return this.id_liai; }

        }

        public string uneduree
        {
            get { return this.duree; }
        }

        public int un_id_secteur
        {
            get { return this.id_secteur; }
        }

        public int port_dep
        {
            get { return this.port_depart; }
        }

        public int port_ar
        {
            get { return this.port_arrivee; }
        }

        public override string ToString()

        {

            return (this.id_liai + "   " +this.id_secteur +" " + this.duree + " " + this.port_depart + " " + this.port_arrivee);
        }



    }
}
