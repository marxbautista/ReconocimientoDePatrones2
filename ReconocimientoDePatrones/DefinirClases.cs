using ReconocimientoDePatrones.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReconocimientoDePatrones
{
    public partial class DefinirClases : Form
    {
        private Int32 dimensiones;
        private Int32 numClases;
        private List<Punto> lista;

        public List<Punto> Lista
        {
            get { return lista; }
            set { lista = value; }
        }
        public DefinirClases(Int32 dimensiones)
        {
            InitializeComponent();
            this.dimensiones = dimensiones;
            lista = new List<Punto>();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.inicializndoDataGrid();

        }
        private void inicializndoDataGrid()
        {
             numClases = Convert.ToInt32(txbK.Text);
            datos.ColumnCount = this.dimensiones+1;
            datos.RowCount = numClases+1;
            datos.Columns[0].Name = "Clase";
            datos.Columns[0].Frozen = true;
            datos.ShowEditingIcon = true;
            
            for (int i = 0; i < numClases+1; i++)
            {
                this.datos.Rows[i].Cells[0].Value = "Clase" + (i + 1);
                this.datos.Rows[i].Cells[0].ReadOnly = true;
                
            }
            datos.AllowUserToAddRows = false;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Punto nuevo;
            for (int i = 0; i < numClases; i++)
            {
                nuevo = new Punto(this.dimensiones, 0);
                for (int j = 1; j <= dimensiones; j++)
                    nuevo.set(j - 1, Convert.ToInt32(this.datos.Rows[i].Cells[j].Value));
                this.lista.Add(nuevo);
            }
            this.Hide();
        }
    }
}
