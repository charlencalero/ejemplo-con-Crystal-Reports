using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo_con_Crystal_Reports
{
    public partial class WF_Test : Form
    {
        public WF_Test()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var repo = new frt_Ticket();
   

            List<DetalleEntity> detalle = new List<DetalleEntity>();

            detalle.Add(new DetalleEntity("1", "LAPTOP LENOVO 456", "40"));
            detalle.Add(new DetalleEntity("2", "LAPTOP HP 355", "50"));
            detalle.Add(new DetalleEntity("3", "PC DESKTOP 562", "44"));
            detalle.Add(new DetalleEntity("4", "MOUSE BLUETOOH", "100"));

            repo.SetDataSource(detalle);


            repo.SetParameterValue("dni_clie", textBox1.Text);
            repo.SetParameterValue("nomb_clie", textBox2.Text);
            repo.SetParameterValue("dire_clie", textBox3.Text);



            crystalReportViewer1.ReportSource = repo;

        }
    }
}
