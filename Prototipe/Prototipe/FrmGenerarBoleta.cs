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
    public partial class FrmGenerarBoleta : Form
    {
        public FrmGenerarBoleta()
        {
            InitializeComponent();
        }

        private void FrmGenerarBoleta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sqlfenixDataSet.SP_REPORTE_REGISTROS' Puede moverla o quitarla según sea necesario.
            this.sP_REPORTE_REGISTROSTableAdapter.Fill(this.sqlfenixDataSet.SP_REPORTE_REGISTROS);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.sP_GENERAR_BOLETA_PASAJE_DETALLESTableAdapter.Fill(this.sqlfenixDataSet.SP_GENERAR_BOLETA_PASAJE_DETALLES, new System.Nullable<int>(((int)(System.Convert.ChangeType(nroBoletaToolStripTextBox.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.sP_GENERAR_BOLETA_PASAJETableAdapter.Fill(this.sqlfenixDataSet.SP_GENERAR_BOLETA_PASAJE, new System.Nullable<int>(((int)(System.Convert.ChangeType(nroBoletaToolStripTextBox1.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.sP_GENERAR_BOLETA_PASAJE_DETALLESTableAdapter.Fill(this.sqlfenixDataSet.SP_GENERAR_BOLETA_PASAJE_DETALLES, new System.Nullable<int>(((int)(System.Convert.ChangeType(nroBoletaToolStripTextBox.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillToolStripButton_Click_2(object sender, EventArgs e)
        {
            try
            {
                this.sP_GENERAR_BOLETA_PASAJE_DETALLESTableAdapter.Fill(this.sqlfenixDataSet.SP_GENERAR_BOLETA_PASAJE_DETALLES, new System.Nullable<int>(((int)(System.Convert.ChangeType(nroBoletaToolStripTextBox.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillToolStripButton1_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.sP_GENERAR_BOLETA_PASAJETableAdapter.Fill(this.sqlfenixDataSet.SP_GENERAR_BOLETA_PASAJE, new System.Nullable<int>(((int)(System.Convert.ChangeType(nroBoletaToolStripTextBox1.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void direccionLabel1_Click(object sender, EventArgs e)
        {

        }

        private void direccionLabel_Click(object sender, EventArgs e)
        {

        }

        private void regionLabel_Click(object sender, EventArgs e)
        {

        }

        private void regionLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
