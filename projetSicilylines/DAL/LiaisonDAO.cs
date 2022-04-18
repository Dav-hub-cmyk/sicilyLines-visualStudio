using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Windows.Forms;

namespace sicilylines.DAL
{
    class LiaisonDAO
    {
        private ConnexionSql maConnexionSql;
        private MySqlCommand Ocom;


        public Liaison getLiaison(int unId)
        {
            try
            {
                Liaison li = new Liaison();



                maConnexionSql = ConnexionSql.getInstance(Fabrique.ProviderMysql, Fabrique.DataBaseMysql, Fabrique.UidMysql, Fabrique.MdpMysql);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("Select * from liaison where id = " + unId);


                MySqlDataReader reader1 = Ocom.ExecuteReader();


                while (reader1.Read())
                {

                    int id_li = (int)reader1.GetValue(0);
                    string uneduree = (string)reader1.GetValue(1);
                    int un_id_secteur = (int)reader1.GetValue(2);
                    string port_dep = (string)reader1.GetValue(3);
                    string port_ar = (string)reader1.GetValue(3);

                    li = new Liaison(id_li, uneduree, un_id_secteur, port_dep, port_ar);


                }
                


                reader1.Close();

                maConnexionSql.closeConnection();

                return (li);

            }

            catch (Exception emp)
            {

                MessageBox.Show(emp.Message);

            }

        }

    }
}
