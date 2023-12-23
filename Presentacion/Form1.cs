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
    public partial class Form1 : Form
    {
        Cl_Operaciones operaciones = new Cl_Operaciones();

        public Form1()
        {
            InitializeComponent();
            SqlServerTypes.Utilities.LoadNativeAssemblies(AppDomain.CurrentDomain.BaseDirectory);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void BTN_Insertar_Click(object sender, EventArgs e)
        {
            Frm_Insertar frm_Insertar = new Frm_Insertar();
            frm_Insertar.ShowDialog();
            CargarDatos();
        }

        public void CargarDatos()
        {
            dataGridView1.Rows.Clear();

            List<Entidades.Entidades> datos = operaciones.ObtenerDatos();

            foreach (Entidades.Entidades persona in datos)
            {
                listBox1.Items.Add(persona.Codigo);
                listBox1.Items.Add(persona.Nombre);
                listBox1.Items.Add(persona.Nivel);

                object[] obj = new object[3];
                obj[0] = persona.Codigo;
                obj[1] = persona.Nombre;
                obj[2] = persona.Nivel;

                dataGridView1.Rows.Add(obj);


            }
        }

        private void BTN_Eliminar_Click(object sender, EventArgs e)
        {
            Frm_Eliminar frm_Eliminar = new Frm_Eliminar();
            frm_Eliminar.ShowDialog();
            CargarDatos();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void insertarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BTN_Insertar_Click(sender, e);
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BTN_Eliminar_Click(sender, e);
        }

        private void abrirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_Reporte frm_Reporte = new Frm_Reporte();
            frm_Reporte.ShowDialog();
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Buscar frm_Buscar = new Frm_Buscar();
            frm_Buscar.ShowDialog();
        }
    }
}
