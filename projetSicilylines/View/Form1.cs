using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sicilylines.Controller;

namespace sicilylines
{
    public partial class Form1 : Form
    {
        Mrg monManager;

        private List<Liaison> lstli = new List<Liaison>();
        public Form1()
        {
            InitializeComponent();
            monManager = new Mrg();
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


            lstli = monManager.chargementLIBD();

            if (lstli.Count != 0) { rafraichirGridView(0); }
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
        }
    }
}
