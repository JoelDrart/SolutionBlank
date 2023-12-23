using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica;
using Entidades;

namespace Presentacion
{
    public partial class Frm_Insertar : Form
    {
        Cl_Operaciones objOperaciones = new Cl_Operaciones();
        Entidades.Entidades objEntidades = new Entidades.Entidades();

        string nombre = "";
        int nivel = 0;
        public Frm_Insertar()
        {
            InitializeComponent();

        }

        private void TXT_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                nombre = TXT_Nombre.Text;
                comboBox1.Focus();
            }
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            nivel = int.Parse(comboBox1.SelectedItem.ToString());
            
        }

        private void BTN_Aceptar_Click(object sender, EventArgs e)
        {
            nombre = TXT_Nombre.Text;
            if (string.IsNullOrEmpty(nombre))
            {
                TXT_Nombre.Focus();
            }
            else if(nivel == 0)
            {
                comboBox1.Focus();
            }
            else
            {
                //Insertar

                //objEntidades.Codigo = "Default";
                objEntidades.Nombre = nombre;
                objEntidades.Nivel = nivel;

                objOperaciones.RecibirInsertar(objEntidades);
                this.Close();

            }
        }

        private void BTN_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
