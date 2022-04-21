using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sicilylines.DAL;

namespace sicilylines.Controller
{
    class Mrg
    {
        LiaisonDAO liD = new LiaisonDAO();


        public List<Liaison> chargementLIBD()
        {
            return (liD.getLiaisons());
        }

        public void deletLIBD(Liaison ls)
        {
            liD.deleteLiaison(ls);
        }

        public void updateLiaisonDureeBD(Liaison ls)
        {
            liD.updateLiaisonDuree(ls);
        }

        public void insertLBD(Liaison ls)
        {
            //liD.insertLiaison(ls);
        }


    }
}
