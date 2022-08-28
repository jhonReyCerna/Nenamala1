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
    public partial class BoletaPasaje : Form
    {
        public BoletaPasaje()
        {
            InitializeComponent();
        }

        private void bOLETA_PASAJEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bOLETA_PASAJEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sqlfenixDataSet);

        }

        private void BoletaPasaje_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sqlfenixDataSet.PASAJE_DETALLE' Puede moverla o quitarla según sea necesario.
            this.pASAJE_DETALLETableAdapter.Fill(this.sqlfenixDataSet.PASAJE_DETALLE);
            // TODO: esta línea de código carga datos en la tabla 'sqlfenixDataSet.BOLETA_PASAJE' Puede moverla o quitarla según sea necesario.
            this.bOLETA_PASAJETableAdapter.Fill(this.sqlfenixDataSet.BOLETA_PASAJE);

        }
    }
}
