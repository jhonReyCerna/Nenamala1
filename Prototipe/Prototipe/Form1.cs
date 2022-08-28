using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bUSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bUSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sqlfenixDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sqlfenixDataSet.BUS' Puede moverla o quitarla según sea necesario.
            this.bUSTableAdapter.Fill(this.sqlfenixDataSet.BUS);

        }

        private void toolTip2_Popup(object sender, PopupEventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FrmPasajero frmPasajero = new FrmPasajero();

            frmPasajero.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            FrmViaje frmViaje = new FrmViaje();

            frmViaje.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            BoletaPasaje frmBoletaPasaje = new BoletaPasaje();

            frmBoletaPasaje.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            FrmPasajeDetalle frmPasajeDetalle = new FrmPasajeDetalle();

            frmPasajeDetalle.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            FrmGenerarBoleta frmGenerarBoleta = new FrmGenerarBoleta();
            frmGenerarBoleta.Show();
        }
    }
}
