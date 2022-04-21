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
    class TariferDAO
    {
        private ConnexionSql maConnexionSql;
        private MySqlCommand Ocom;
       /* public Liaison getTarifer(int num_id)
        {

            try
            {
                Tarifer tf = new Tarifer();



                maConnexionSql = ConnexionSql.getInstance(Fabrique.ProviderMysql, Fabrique.DataBaseMysql, Fabrique.UidMysql, Fabrique.MdpMysql);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("Select * from tarifer where id = " + num_id);


                MySqlDataReader reader1 = Ocom.ExecuteReader();


                while (reader1.Read())
                {

                    int id = (int)reader1.GetValue(0);
                    int id_liais = (int)reader1.GetValue(1);
                    int id_per = (int)reader1.GetValue(2);
                    int id_ty = (int)reader1.GetValue(3);
                    double tar = (double)reader1.GetValue(4);

                    tf = new Tarifer(id, id_liais, id_per, id_ty, tar);


                }



                reader1.Close();

                maConnexionSql.closeConnection();
                return (tf);

            }

            catch (Exception emp)
            {

                throw (emp);
            }
        }*/



    }
}
