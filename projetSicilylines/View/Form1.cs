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
    }
}
