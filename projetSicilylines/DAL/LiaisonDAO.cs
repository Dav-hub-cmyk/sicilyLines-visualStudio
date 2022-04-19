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


                Ocom = maConnexionSql.reqExec("Select * from client where numero = " + num);


                MySqlDataReader reader1 = Ocom.ExecuteReader();


                while (reader1.Read())
                {

                    int num_li = (int)reader1.GetValue(0);
                    string uneduree = (string)reader1.GetValue(1);
                    int un_id_secteur = (int)reader1.GetValue(2);
                    int port_dep = (int)reader1.GetValue(3);
                    int port_ar = (int)reader1.GetValue(3);

                    li = new Liaison(num_li, uneduree, un_id_secteur, port_dep, port_ar);


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


                Ocom = maConnexionSql.reqExec("Select * from liaison");


                MySqlDataReader reader = Ocom.ExecuteReader();

                Liaison l;




                while (reader.Read())
                {

                    int num_li = (int)reader.GetValue(0);
                    string uneduree = (string)reader.GetValue(1);
                    int un_id_secteur = (int)reader.GetValue(2);
                    int port_dep = (int)reader.GetValue(3);
                    int port_ar = (int)reader.GetValue(4);

                    l = new Liaison(num_li, uneduree, un_id_secteur, port_dep, port_ar);

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




    }
}