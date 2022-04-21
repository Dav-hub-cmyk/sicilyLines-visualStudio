using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using sicilylines.DAL;


namespace sicilylines
{
    public partial class Form1 : Form
    {
        

        private List<Liaison> lstli = new List<Liaison>();
        public Form1()
        {
            InitializeComponent();
            //monManager = new Mrg();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //rendre invisible les textbox
            tb_duree.Visible = false;
            tb_id.Visible = false;
            tb_portD.Visible = false;
            tb_portA.Visible = false;
            tb_sect.Visible = false;
            //rendre invisible les label
            lb_duree.Visible = false;
            lb_id.Visible = false;
            lb_sec.Visible = false;
            lb_portD.Visible = false;
            lb_portA.Visible = false;
            //rendre invisible les bouttons
            btn1.Visible = false;
            btn2.Visible = false;
            btn_modif.Visible = false;


            /*lstli = monManager.chargementLIBD();

            if (lstli.Count != 0) { rafraichirGridView(0); }*/

            //affichage des liaisons maniere brute

            //Connexion a la bdd
            affiche();

           

        }



        private void rafraichirGridView(int index)
        {

            dg1.DataSource = null;
            dg1.DataSource = lstli;
            dg1.Update();
            dg1.Refresh();

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void insererToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //affichage des tb
            tb_duree.Visible = true;
            tb_id.Visible = false;
            tb_portD.Visible = true;
            tb_portA.Visible = true;
            tb_sect.Visible = true;
            //affichage des lb
            lb_duree.Visible = true;
            lb_id.Visible = false;
            lb_sec.Visible = true;
            lb_portD.Visible = true;
            lb_portA.Visible = true;
            //affichage btn
            btn2.Visible = true;
            btn1.Visible = false;
            btn_modif.Visible = false;
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //rendre visible les textbox
            tb_duree.Visible = false;
            tb_id.Visible = true;
            tb_portD.Visible = false;
            tb_portA.Visible = false;
            tb_sect.Visible = false;
            //rendre visible les label
            lb_duree.Visible = false;
            lb_id.Visible = true;
            lb_sec.Visible = false;
            lb_portD.Visible = false;
            lb_portA.Visible = false;
            //rendre visible les bouttons
            btn1.Visible = true;
            btn2.Visible = false;
            btn_modif.Visible = false;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            ConnexionSql cnsql = ConnexionSql.getInstance("localhost", "adonet", "root", "");

            cnsql.openConnection();

            //requete
            MySqlCommand cmsql;
            String req = "DELETE FROM liaison WHERE id =" + Convert.ToInt32(tb_id.Text);
            cmsql = cnsql.reqExec(req);

            cmsql.ExecuteNonQuery();

            cnsql.closeConnection();
            affiche();


        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //rendre visible les textbox
            tb_duree.Visible = true;
            tb_id.Visible = true;
            tb_portD.Visible = false;
            tb_portA.Visible = false;
            tb_sect.Visible = false;
            //rendre visible les label
            lb_duree.Visible = true;
            lb_id.Visible = true;
            lb_sec.Visible = false;
            lb_portD.Visible = false;
            lb_portA.Visible = false;
            //rendre visible les bouttons
            btn1.Visible = false;
            btn2.Visible = false; ;
            btn_modif.Visible = true;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            //Connexion a la bdd
            ConnexionSql cnsql = ConnexionSql.getInstance("localhost", "sicilylines", "root", "");

            cnsql.openConnection();

            //requete
            MySqlCommand cmsql;
            cmsql = cnsql.reqExec("insert into liaison(duree,secteur_id, port_depart_id, port_arrive_id) values ('" + tb_duree.Text + "'," + Convert.ToInt32(tb_sect.Text) + "," + Convert.ToInt32(tb_portD.Text) + "," + Convert.ToInt32(tb_portA.Text )+ ")");
            cmsql.ExecuteNonQuery();
            cnsql.closeConnection();

            affiche();
        }

        public void affiche()
        {
            ConnexionSql cnsql = ConnexionSql.getInstance("localhost", "sicilylines", "root", "");

            cnsql.openConnection();

            //requete
            MySqlCommand cmsql;
            cmsql = cnsql.reqExec("SELECT liaison.id,duree,libelle ,dep.nom,arriv.nom " +
                    "FROM liaison inner join port dep on liaison.port_depart_id = dep.id " +
                    "inner join secteur s on secteur_id = s.id " +
                    "inner join port arriv on port_arrive_id=arriv.id;");
            //cmsql.ExecuteNonQuery();
            //cnsql.closeConnection();

            DataTable d = new DataTable();

            MySqlDataAdapter myDataAdapter = new MySqlDataAdapter(cmsql);

            myDataAdapter.Fill(d);

            dg1.DataSource = d;
        }

        private void btn_modif_Click(object sender, EventArgs e)
        {
            ConnexionSql cnsql = ConnexionSql.getInstance("localhost", "sicilylines", "root", "");

            cnsql.openConnection();
            MySqlCommand cmsql;
            String req = "UPDATE liaison SET duree = " +tb_duree.Text /*+ "WHERE id = " +Convert.ToInt32(tb_id.Text)*/;
            //MessageBox.Show(req);
            cmsql = cnsql.reqExec(req);

            cmsql.ExecuteNonQuery();

            cnsql.closeConnection();
            affiche();
        }
    }
}
