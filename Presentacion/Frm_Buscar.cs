using CapaLogica;
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
    public partial class Frm_Buscar : Form
    {
        Cl_Operaciones objOperaciones = new Cl_Operaciones();
        public Frm_Buscar()
        {
            InitializeComponent();
        }

        private void TXT_Codigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                BTN_Cancelar_Click(sender, e);
            }
        }

        private void BTN_Cancelar_Click(object sender, EventArgs e)
        {
            try
            {
                int codBuscar = int.Parse(TXT_Codigo.Text);

                Entidades.Entidades datoBuscado = objOperaciones.RecibirBuscar(codBuscar);


                if (datoBuscado != null)
                {
                    //Encontrado

                    LBL_Codigo.Text = datoBuscado.Codigo.ToString();
                    LBL_Nivel.Text = datoBuscado.Nivel.ToString();
                    LBL_Nombre.Text = datoBuscado.Nombre;


                    panel1.Visible = true;
                }
                else
                {
                    //No encontrado
                    MessageBox.Show("No se encontró ese código");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Código no válido." + ex.Message);
                Console.WriteLine("Error: Código no válido.");
            }
        }
    }
}
