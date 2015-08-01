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
    public partial class Grafica2D : Form
    {
        private List<Punto> lista;
        private List<Clase> listaDeClases;
        private Int32 []y;
        private Int32[] x;
        private Int32[] yClase;
        private Int32[] xClase;
        private Int32 k;
        public Grafica2D(List<Punto> lista, int ejex, int ejey,List<Clase> listaDeClases, Int32 K)
        {
            InitializeComponent();
            this.graficaRadios();
            this.lista = lista;
            this.listaDeClases = listaDeClases;
            this.k = K;
            //this.inicializaEjes();
            this.graficaPuntos(ejex, ejey);
            this.graficaClases(0,1);
            
        }
        private void inicializaEjes()
        {
            x = new Int32[100];
            y = new Int32[100];
            for (int i = 0; i < 100; i++)
            {
                x[i] = 0;
                y[i] = 0;
            }
        }
        private void graficaPuntos(int ejeX,int ejeY)
        {
            x = new Int32[lista.Count];
            y = new Int32[lista.Count];
            for(int i=0; i<lista.Count;i++)
            {
                Punto leido= lista[i];
                y[i] = leido.get(ejeY);
                x[i] = leido.get(ejeX);
            }
            chart1.Series["y"].Points.DataBindXY(x,y);
        }
        private void graficaClases(int ejeX, int ejeY)
        {
            xClase = new Int32[listaDeClases.Count];
            yClase = new Int32[listaDeClases.Count];
            for (int i = 0; i < listaDeClases.Count; i++)
            {
                Punto leido = listaDeClases[i].PuntoFocal;
                yClase[i] = leido.get(ejeY);
                xClase[i] = leido.get(ejeX);
                chart1.Series[0].Points.AddXY(leido.get(ejeX), leido.get(ejeY));
                
            }
           
           
        }
        public void graficaRadios()
        {
            System.Drawing.SolidBrush brush1 =
     new System.Drawing.SolidBrush(System.Drawing.Color.Red);
            System.Drawing.Graphics formGraphics = this.CreateGraphics();
            formGraphics.FillRectangle(brush1, new System.Drawing.Rectangle(0, 0, 200, 300));
            brush1.Dispose();
            formGraphics.Dispose();
            
        }

        private void Grafica2D_Load(object sender, EventArgs e)
        {
           
        }
    }
}
