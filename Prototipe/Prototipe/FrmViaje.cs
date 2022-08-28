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
    public partial class FrmViaje : Form
    {
        public FrmViaje()
        {
            InitializeComponent();
        }

        private void vIAJEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vIAJEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sqlfenixDataSet);

        }

        private void FrmViaje_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sqlfenixDataSet.TERMINAL' Puede moverla o quitarla según sea necesario.
            this.tERMINALTableAdapter.Fill(this.sqlfenixDataSet.TERMINAL);
            // TODO: esta línea de código carga datos en la tabla 'sqlfenixDataSet.PILOTO' Puede moverla o quitarla según sea necesario.
            this.pILOTOTableAdapter.Fill(this.sqlfenixDataSet.PILOTO);
            // TODO: esta línea de código carga datos en la tabla 'sqlfenixDataSet.BUS' Puede moverla o quitarla según sea necesario.
            this.bUSTableAdapter.Fill(this.sqlfenixDataSet.BUS);
            // TODO: esta línea de código carga datos en la tabla 'sqlfenixDataSet.ITINERARIO' Puede moverla o quitarla según sea necesario.
            this.iTINERARIOTableAdapter.Fill(this.sqlfenixDataSet.ITINERARIO);
            // TODO: esta línea de código carga datos en la tabla 'sqlfenixDataSet.SERVICIO' Puede moverla o quitarla según sea necesario.
            this.sERVICIOTableAdapter.Fill(this.sqlfenixDataSet.SERVICIO);
            // TODO: esta línea de código carga datos en la tabla 'sqlfenixDataSet.VIAJE' Puede moverla o quitarla según sea necesario.
            this.vIAJETableAdapter.Fill(this.sqlfenixDataSet.VIAJE);

        }
    }
}
