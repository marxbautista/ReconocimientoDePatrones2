using ReconocimientoDePatrones.Control;
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
    public partial class frmPrrincipal : Form
    {
        private Int32 cantidad;
        private Int32 dimension;
        private Int32 k;
        private Controles nuevo;
        private List<Punto> lista;
        private List<Clase> listaDeClases;
        
        public frmPrrincipal()
        {
            InitializeComponent();
            this.cargaControles();
        }

        private void cargaControles()
        {
            nuevo = new Controles();
            nuevo.MdiParent = this;
            nuevo.Show();
        }

        private void generarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void generaciónAutomaticaDeClasesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clasificador clasifica = new Clasificador(k,lista);
            clasifica.clasifica();
            this.listaDeClases = clasifica.creaClases();
            nuevo.guarda(listaDeClases );
            this.gráficaToolStripMenuItem.Enabled = true;
        }

        private void clasificarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void definirClasesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DefinirClases definiendoClases = new DefinirClases(this.dimension);
            //definiendoClases.MdiParent = this;
            definiendoClases.ShowDialog();

            Clasificador clasifica = new Clasificador(k, lista,definiendoClases.Lista);
            clasifica.clasifica();
            this.listaDeClases = clasifica.creaClases();
            nuevo.guarda(listaDeClases);
            this.gráficaToolStripMenuItem.Enabled = true;

        }

        private void gráficaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Grafica2D2 grafica = new Grafica2D2(lista,listaDeClases,k,dimension);
            grafica.MdiParent = this;
            grafica.Show();
        }

        private void generarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.nuevo.lee();
            cantidad = this.nuevo.Cantidad;
            dimension = this.nuevo.Dimension;
            k = this.nuevo.K;

            frmNube puntos = new frmNube(dimension, cantidad);
            lista = puntos.Nube.Lista;
            puntos.MdiParent = this;
            puntos.Show();
            this.clasificarToolStripMenuItem.Enabled = true;
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //este es un comentario
            //esta es un alinea nueva
        }

        private void cargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //este es otro cometario
        }
    }
}
