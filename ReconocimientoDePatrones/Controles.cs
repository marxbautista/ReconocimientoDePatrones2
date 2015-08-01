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
    public partial class Controles : Form
    {
        private Int32 cantidad;

        public Int32 Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
        private Int32 dimension;

        public Int32 Dimension
        {
            get { return dimension; }
            set { dimension = value; }
        }
        private Int32 k;

        public Int32 K
        {
            get { return k; }
            set { k = value; }
        }
        public Controles()
        {
            InitializeComponent();
        }
        public void lee()
        {
            this.cantidad = Convert.ToInt32(this.txbCantidad.Text);
            this.dimension = Convert.ToInt32(this.txbDimension.Text);
            this.k = Convert.ToInt32(this.txbK.Text);
        }
        public void guarda(List<Clase> lista)
        {
            txbSalida.Clear();
            foreach(Clase x in lista){
                txbSalida.Text += x.imprime() + "\r\n\r\n";
            }
        }
    }
}
