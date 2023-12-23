using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Frm_Reporte : Form
    {
        public Frm_Reporte()
        {
            InitializeComponent();
        }

        private void Frm_Reporte_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bD_Estudiantes_VSDataSetPCasita.Estudiante' Puede moverla o quitarla según sea necesario.
            this.estudianteTableAdapter.Fill(this.bD_Estudiantes_VSDataSetPCasita.Estudiante);
            // TODO: esta línea de código carga datos en la tabla 'bD_Estudiantes_VSDataSet.Estudiante' Puede moverla o quitarla según sea necesario.
            //this.estudianteTableAdapter.Fill(this.bD_Estudiantes_VSDataSet.Estudiante);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
