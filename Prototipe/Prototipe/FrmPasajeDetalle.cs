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
    public partial class FrmPasajeDetalle : Form
    {
        public FrmPasajeDetalle()
        {
            InitializeComponent();
        }

        private void pASAJE_DETALLEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pASAJE_DETALLEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sqlfenixDataSet);

        }

        private void FrmPasajeDetalle_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sqlfenixDataSet.BOLETA_PASAJE' Puede moverla o quitarla según sea necesario.
            this.bOLETA_PASAJETableAdapter.Fill(this.sqlfenixDataSet.BOLETA_PASAJE);
            // TODO: esta línea de código carga datos en la tabla 'sqlfenixDataSet.VIAJE' Puede moverla o quitarla según sea necesario.
            this.vIAJETableAdapter.Fill(this.sqlfenixDataSet.VIAJE);
            // TODO: esta línea de código carga datos en la tabla 'sqlfenixDataSet.PASAJE_DETALLE' Puede moverla o quitarla según sea necesario.
            this.pASAJE_DETALLETableAdapter.Fill(this.sqlfenixDataSet.PASAJE_DETALLE);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
