using Gma.QrCodeNet.Encoding;
using Gma.QrCodeNet.Encoding.Windows.Controls;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
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

            string hash = "20542471256|01|F001|00012356|18.00|118.00|2018-05-18|06|"+ textBox1.Text + "|DFFcw3MCjkXX9uilsEQ6noss8cw=";

            //Creando Ruta Temporal
            string ruta_temp = System.IO.Path.GetTempPath() + Guid.NewGuid().ToString() + ".bmp";


            List<DetalleEntity> detalle = new List<DetalleEntity>();

            detalle.Add(new DetalleEntity("1", "LAPTOP LENOVO 456", "40"));
            detalle.Add(new DetalleEntity("2", "LAPTOP HP 355", "50"));
            detalle.Add(new DetalleEntity("3", "PC DESKTOP 562", "44"));
            detalle.Add(new DetalleEntity("4", "MOUSE BLUETOOH", "100"));

            repo.SetDataSource(detalle);


            repo.SetParameterValue("dni_clie", textBox1.Text);
            repo.SetParameterValue("nomb_clie", textBox2.Text);
            repo.SetParameterValue("dire_clie", textBox3.Text);
            repo.SetParameterValue("ruta", ruta_temp);


            crystalReportViewer1.ReportSource = repo;

            generar_imagen_qr(hash,ruta_temp);

        }

        private void generar_imagen_qr(string texto,string ruta_temp)
        {
            QrEncoder qrEncoder = new QrEncoder(ErrorCorrectionLevel.H);
            QrCode qrCode = new QrCode();
            qrEncoder.TryEncode(texto, out qrCode);

            Renderer renderer = new Renderer(5, Brushes.Black, Brushes.White);
            renderer.CreateImageFile(qrCode.Matrix, ruta_temp, ImageFormat.Bmp);





        }
    }
}
