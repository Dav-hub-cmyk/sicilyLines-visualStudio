using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Windows.Forms;
using sicilylines.DAL;


namespace sicilylines.DAL
{
    class LiaisonDAO
    {
        private ConnexionSql maConnexionSql;
        private MySqlCommand Ocom;


        public Liaison getLiaison(int num)
        {

            try
            {
                Liaison li = new Liaison();



                maConnexionSql = ConnexionSql.getInstance(Fabrique.ProviderMysql, Fabrique.DataBaseMysql, Fabrique.UidMysql, Fabrique.MdpMysql);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("Select * from liaison where port_depart_id = " + num);


                MySqlDataReader reader1 = Ocom.ExecuteReader();


                while (reader1.Read())
                {

                    int num_li = (int)reader1.GetValue(0);
                    string uneduree = (string)reader1.GetValue(1);
                    string unsecteur = (string)reader1.GetValue(2);
                    string port_dep = (string)reader1.GetValue(3);
                    string port_ar = (string)reader1.GetValue(4);

                    li = new Liaison(num_li, uneduree, unsecteur, port_dep, port_ar);


                }



                reader1.Close();

                maConnexionSql.closeConnection();


                return (li);

            }

            catch (Exception emp)
            {

                throw (emp);
            }
        }



        public List<Liaison> getLiaisons()
        {

            List<Liaison> li = new List<Liaison>();

            try
            {

                maConnexionSql = ConnexionSql.getInstance(Fabrique.ProviderMysql, Fabrique.DataBaseMysql, Fabrique.UidMysql, Fabrique.MdpMysql);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("SELECT liaison.id,duree,libelle ,dep.nom,arriv.nom " +
                    "FROM liaison inner join port dep on liaison.port_depart_id = dep.id " +
                    "inner join secteur s on secteur_id = s.id " +
                    "inner join port arriv on port_arrive_id=arriv.id;");


                MySqlDataReader reader = Ocom.ExecuteReader();

                Liaison l;




                while (reader.Read())
                {

                    int id_li = (int)reader.GetValue(0);
                    string uneduree = (string)reader.GetValue(1);
                    string unesecteur = (string)reader.GetValue(2);
                    string port_dep = (string)reader.GetValue(3);
                    string port_ar = (string)reader.GetValue(4);

                    l = new Liaison(id_li,uneduree, unesecteur, port_dep, port_ar) ;

                    li.Add(l);


                }
                reader.Close();

                maConnexionSql.closeConnection();

            }

            catch (Exception emp)
            {

                MessageBox.Show(emp.Message);

            }

            return (li);
        }


        /*public void deleteLiaison()
        {
            try
            {
                maConnexionSql = ConnexionSql.getInstance(Fabrique.ProviderMysql, Fabrique.DataBaseMysql, Fabrique.UidMysql, Fabrique.MdpMysql);
                
                maConnexionSql.openConnection();
                
                Ocom = maConnexionSql.reqExec("delete from liaison where id '" + tb_id + "'");

                int i = Ocom.ExecuteNonQuery();

                maConnexionSql.closeConnection();
            }
        }*/


        /*public void insertLiaison()
        {
            try
            {
                maConnexionSql = ConnexionSql.getInstance(Fabrique.ProviderMysql, Fabrique.DataBaseMysql, Fabrique.UidMysql, Fabrique.MdpMysql);

                maConnexionSql.openConnection();

                Ocom = maConnexionSql.reqExec("insert into liaison(duree,secteur_id,port_depart_id,port_arrive_id)" +
                    " values('tb_duree','tb_sect','tb_portD',tb_portA)");

                int i = Ocom.ExecuteNonQuery();

                maConnexionSql.closeConnection();
            }
        }*/

        public void updateLiaisonDuree(Liaison ls)
        {
            try
            {


                maConnexionSql = ConnexionSql.getInstance(Fabrique.ProviderMysql, Fabrique.DataBaseMysql, Fabrique.UidMysql, Fabrique.MdpMysql);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("update liaison set duree = '" + ls.la_duree + "' where id = " + ls.id_li);


                int i = Ocom.ExecuteNonQuery();



                maConnexionSql.closeConnection();



            }

            catch (Exception emp)
            {

                throw (emp);
            }
        }



    }
}