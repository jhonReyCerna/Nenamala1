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
    public partial class FrmPasajero : Form
    {
        public FrmPasajero()
        {
            InitializeComponent();
        }

        private void pASAJEROBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pASAJEROBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sqlfenixDataSet);

        }

        private void FrmPasajero_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sqlfenixDataSet.PASAJERO' Puede moverla o quitarla según sea necesario.
            this.pASAJEROTableAdapter.Fill(this.sqlfenixDataSet.PASAJERO);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
