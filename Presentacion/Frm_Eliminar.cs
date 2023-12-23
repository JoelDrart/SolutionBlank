using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using CapaLogica;

namespace Presentacion
{
    public partial class Frm_Eliminar : Form
    {
        Cl_Operaciones objOperaciones = new Cl_Operaciones();
        public Frm_Eliminar()
        {
            InitializeComponent();
        }

        private void BTN_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int codEliminar = int.Parse(TXT_Codigo.Text);
                if (objOperaciones.RecibirEliminar(codEliminar))
                {
                    MessageBox.Show("Eliminado Correctamente");
                }
                else
                {
                    MessageBox.Show("No se encontró ese código");
                }

                this.Close();

            }
            catch
            {
                MessageBox.Show("Error Codigo Eliminar no válido.");
                Console.WriteLine("Error Codigo Eliminar no válido.");
            }
        }

        private void BTN_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
